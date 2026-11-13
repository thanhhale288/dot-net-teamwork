using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTau
{
    public partial class FrmChiTietTuyen : Form
    {
        private int _maTuyenMacDinh = 0;

        public FrmChiTietTuyen()
        {
            InitializeComponent();
        }

        public FrmChiTietTuyen(int maTuyenMacDinh)
        {
            InitializeComponent();
            _maTuyenMacDinh = maTuyenMacDinh;
        }

        private void FrmChiTietTuyen_Load(object sender, EventArgs e)
        {
            LoadDanhSachTuyen();
            LoadDanhSachGa();

            if (_maTuyenMacDinh > 0)
            {
                cboTuyen.SelectedValue = _maTuyenMacDinh;
            }
            else if (cboTuyen.Items.Count > 0)
            {
                cboTuyen.SelectedIndex = 0;
            }
        }

        private void LoadDanhSachTuyen()
        {
            string sql = "SELECT MaTuyen, TenTuyen FROM Tuyen WHERE TrangThai = N'Hoạt động' ORDER BY MaTuyen ASC";
            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql);
            cboTuyen.DataSource = dt;
            cboTuyen.DisplayMember = "TenTuyen";
            cboTuyen.ValueMember = "MaTuyen";
        }

        private void LoadDanhSachGa()
        {
            string sql = "SELECT MaGa, TenGa FROM Ga WHERE TrangThai = N'Hoạt động' ORDER BY TenGa ASC";
            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql);
            cboGa.DataSource = dt;
            cboGa.DisplayMember = "TenGa";
            cboGa.ValueMember = "MaGa";
        }

        private void cboTuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGaDungCuaTuyen();
        }

        private void LoadGaDungCuaTuyen()
        {
            if (cboTuyen.SelectedValue == null || cboTuyen.SelectedValue is DataRowView)
                return;

            int maTuyen = Convert.ToInt32(cboTuyen.SelectedValue);

            string sql = "SELECT tg.ThuTu AS [Thứ Tự Dừng], g.MaGa AS [Mã Ga], g.TenGa AS [Tên Ga Tàu], " +
                         "g.DiaChi AS [Địa Chỉ Ga], tg.PhutDung AS [Phút Dừng] " +
                         "FROM Tuyen_Ga tg " +
                         "JOIN Ga g ON tg.MaGa = g.MaGa " +
                         "WHERE tg.MaTuyen = @MaTuyen " +
                         "ORDER BY tg.ThuTu ASC";

            SqlParameter[] p = new SqlParameter[] { new SqlParameter("@MaTuyen", maTuyen) };
            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql, p);
            dgvGaDung.DataSource = dt;

            // Cập nhật thẻ tóm tắt ga đầu/ga cuối
            int tongGa = dt.Rows.Count;
            lblTongSoGa.Text = string.Format("Tổng số ga: {0}", tongGa);

            if (tongGa > 0)
            {
                lblGaDau.Text = string.Format("Ga đầu: {0}", dt.Rows[0]["Tên Ga Tàu"]);
                lblGaCuoi.Text = string.Format("Ga cuối: {0}", dt.Rows[tongGa - 1]["Tên Ga Tàu"]);
                numThuTu.Value = tongGa + 1; // Gợi ý thứ tự tiếp theo
            }
            else
            {
                lblGaDau.Text = "Ga đầu: [Chưa có]";
                lblGaCuoi.Text = "Ga cuối: [Chưa có]";
                numThuTu.Value = 1;
            }
        }

        private void dgvGaDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvGaDung.Rows.Count)
            {
                DataGridViewRow r = dgvGaDung.Rows[e.RowIndex];
                int maGa = Convert.ToInt32(r.Cells["Mã Ga"].Value);
                cboGa.SelectedValue = maGa;
                numThuTu.Value = Convert.ToDecimal(r.Cells["Thứ Tự Dừng"].Value);
                numPhutDung.Value = Convert.ToDecimal(r.Cells["Phút Dừng"].Value);
            }
        }

        private void btnThemGa_Click(object sender, EventArgs e)
        {
            if (cboTuyen.SelectedValue == null || cboGa.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tuyến tàu và ga cần thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maTuyen = Convert.ToInt32(cboTuyen.SelectedValue);
            int maGa = Convert.ToInt32(cboGa.SelectedValue);
            int thuTu = Convert.ToInt32(numThuTu.Value);
            int phutDung = Convert.ToInt32(numPhutDung.Value);

            // Kiểm tra xem ga đã có trên tuyến chưa
            object check = Ketnoi_CSDL.ExecuteScalar("SELECT COUNT(*) FROM Tuyen_Ga WHERE MaTuyen = @MaTuyen AND MaGa = @MaGa",
                new SqlParameter[] { new SqlParameter("@MaTuyen", maTuyen), new SqlParameter("@MaGa", maGa) });

            if (check != null && Convert.ToInt32(check) > 0)
            {
                MessageBox.Show("Ga này đã có trong lộ trình của tuyến! Bạn có thể chọn ga khác hoặc cập nhật thứ tự ga.",
                    "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "INSERT INTO Tuyen_Ga (MaTuyen, MaGa, ThuTu, PhutDung) VALUES (@MaTuyen, @MaGa, @ThuTu, @PhutDung)";
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@MaTuyen", maTuyen),
                new SqlParameter("@MaGa", maGa),
                new SqlParameter("@ThuTu", thuTu),
                new SqlParameter("@PhutDung", phutDung)
            };

            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
            if (kq > 0)
            {
                MessageBox.Show("Thêm ga dừng vào tuyến thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGaDungCuaTuyen();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (cboTuyen.SelectedValue == null || cboGa.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn ga cần cập nhật thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maTuyen = Convert.ToInt32(cboTuyen.SelectedValue);
            int maGa = Convert.ToInt32(cboGa.SelectedValue);
            int thuTu = Convert.ToInt32(numThuTu.Value);
            int phutDung = Convert.ToInt32(numPhutDung.Value);

            string sql = "UPDATE Tuyen_Ga SET ThuTu = @ThuTu, PhutDung = @PhutDung WHERE MaTuyen = @MaTuyen AND MaGa = @MaGa";
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@ThuTu", thuTu),
                new SqlParameter("@PhutDung", phutDung),
                new SqlParameter("@MaTuyen", maTuyen),
                new SqlParameter("@MaGa", maGa)
            };

            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật thứ tự / phút dừng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGaDungCuaTuyen();
            }
        }

        private void btnXoaGa_Click(object sender, EventArgs e)
        {
            if (cboTuyen.SelectedValue == null || cboGa.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn ga cần xóa khỏi tuyến!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maTuyen = Convert.ToInt32(cboTuyen.SelectedValue);
            int maGa = Convert.ToInt32(cboGa.SelectedValue);

            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa ga này khỏi tuyến không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                string sql = "DELETE FROM Tuyen_Ga WHERE MaTuyen = @MaTuyen AND MaGa = @MaGa";
                SqlParameter[] p = new SqlParameter[]
                {
                    new SqlParameter("@MaTuyen", maTuyen),
                    new SqlParameter("@MaGa", maGa)
                };

                int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
                if (kq > 0)
                {
                    MessageBox.Show("Đã xóa ga khỏi tuyến!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGaDungCuaTuyen();
                }
            }
        }

        private void btnTuDongDanhSo_Click(object sender, EventArgs e)
        {
            if (cboTuyen.SelectedValue == null) return;
            int maTuyen = Convert.ToInt32(cboTuyen.SelectedValue);

            string sql = "SELECT MaGa FROM Tuyen_Ga WHERE MaTuyen = @MaTuyen ORDER BY ThuTu ASC";
            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql, new SqlParameter[] { new SqlParameter("@MaTuyen", maTuyen) });

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int maGa = Convert.ToInt32(dt.Rows[i]["MaGa"]);
                    int thuTuMoi = i + 1;
                    Ketnoi_CSDL.ExecuteNonQuery("UPDATE Tuyen_Ga SET ThuTu = @ThuTu WHERE MaTuyen = @MaTuyen AND MaGa = @MaGa",
                        new SqlParameter[]
                        {
                            new SqlParameter("@ThuTu", thuTuMoi),
                            new SqlParameter("@MaTuyen", maTuyen),
                            new SqlParameter("@MaGa", maGa)
                        });
                }
                MessageBox.Show("Đã tự động đánh lại số thứ tự từ 1 đến " + dt.Rows.Count + "!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGaDungCuaTuyen();
            }
        }

        private void btnMoQuanLyGa_Click(object sender, EventArgs e)
        {
            FrmQuanLyGa f = new FrmQuanLyGa();
            f.ShowDialog();
            LoadDanhSachGa();
            LoadGaDungCuaTuyen();
        }
    }
}
