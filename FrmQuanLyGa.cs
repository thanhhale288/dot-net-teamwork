using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTau
{
    public partial class FrmQuanLyGa : Form
    {
        public FrmQuanLyGa()
        {
            InitializeComponent();
        }

        private void FrmQuanLyGa_Load(object sender, EventArgs e)
        {
            cboTrangThai.SelectedIndex = 0;
            LoadDanhSachGa();
        }

        private void LoadDanhSachGa(string keyword = "")
        {
            string sql = "SELECT g.MaGa AS [Mã Ga], g.TenGa AS [Tên Ga Tàu], g.DiaChi AS [Địa Chỉ], " +
                         "g.TrangThai AS [Trạng Thái], " +
                         "(SELECT COUNT(*) FROM Tuyen_Ga tg WHERE tg.MaGa = g.MaGa) AS [Số Tuyến Đi Qua] " +
                         "FROM Ga g ";
            SqlParameter[] p = null;
            if (!string.IsNullOrEmpty(keyword))
            {
                sql += "WHERE g.TenGa LIKE @kw OR g.DiaChi LIKE @kw ";
                p = new SqlParameter[] { new SqlParameter("@kw", "%" + keyword + "%") };
            }
            sql += "ORDER BY g.MaGa ASC";

            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql, p);
            dgvGa.DataSource = dt;

            if (dgvGa.Columns.Contains("Mã Ga"))
            {
                dgvGa.Columns["Mã Ga"].Width = 80;
                dgvGa.Columns["Trạng Thái"].Width = 120;
                dgvGa.Columns["Số Tuyến Đi Qua"].Width = 130;
            }
        }

        private void dgvGa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvGa.Rows.Count)
            {
                DataGridViewRow r = dgvGa.Rows[e.RowIndex];
                txtMaGa.Text = r.Cells["Mã Ga"].Value != null ? r.Cells["Mã Ga"].Value.ToString() : "";
                txtTenGa.Text = r.Cells["Tên Ga Tàu"].Value != null ? r.Cells["Tên Ga Tàu"].Value.ToString() : "";
                txtDiaChi.Text = r.Cells["Địa Chỉ"].Value != null ? r.Cells["Địa Chỉ"].Value.ToString() : "";
                string tt = r.Cells["Trạng Thái"].Value != null ? r.Cells["Trạng Thái"].Value.ToString() : "Hoạt động";
                cboTrangThai.SelectedItem = tt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenGa = txtTenGa.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string trangThai = cboTrangThai.SelectedItem != null ? cboTrangThai.SelectedItem.ToString() : "Hoạt động";

            if (string.IsNullOrEmpty(tenGa))
            {
                MessageBox.Show("Vui lòng nhập tên ga tàu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenGa.Focus();
                return;
            }

            string sql = "INSERT INTO Ga (TenGa, DiaChi, TrangThai) VALUES (@TenGa, @DiaChi, @TrangThai)";
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@TenGa", tenGa),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@TrangThai", trangThai)
            };

            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
            if (kq > 0)
            {
                MessageBox.Show("Thêm ga tàu mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();
                LoadDanhSachGa();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaGa.Text))
            {
                MessageBox.Show("Vui lòng chọn ga tàu cần cập nhật từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenGa = txtTenGa.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string trangThai = cboTrangThai.SelectedItem != null ? cboTrangThai.SelectedItem.ToString() : "Hoạt động";
            int maGa = Convert.ToInt32(txtMaGa.Text);

            if (string.IsNullOrEmpty(tenGa))
            {
                MessageBox.Show("Vui lòng nhập tên ga tàu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenGa.Focus();
                return;
            }

            // Nếu đổi sang Ngưng hoạt động, cần kiểm tra ràng buộc tuyến
            if (trangThai == "Ngưng hoạt động")
            {
                if (KiemTraGaDangThuocTuyenHoatDong(maGa))
                {
                    MessageBox.Show("Không thể ngưng hoạt động ga này vì ga đang thuộc tuyến tàu đang hoạt động!\n" +
                                    "Vui lòng gỡ ga này khỏi các tuyến liên quan trước khi ngưng hoạt động.",
                                    "Chặn ngưng hoạt động", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string sql = "UPDATE Ga SET TenGa = @TenGa, DiaChi = @DiaChi, TrangThai = @TrangThai WHERE MaGa = @MaGa";
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@TenGa", tenGa),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@TrangThai", trangThai),
                new SqlParameter("@MaGa", maGa)
            };

            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật thông tin ga tàu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachGa();
            }
        }

        private void btnNgungHoatDong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaGa.Text))
            {
                MessageBox.Show("Vui lòng chọn ga tàu cần ngưng hoạt động!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maGa = Convert.ToInt32(txtMaGa.Text);

            // Kiểm tra ràng buộc nghiệp vụ: chặn nếu ga đang thuộc tuyến đang hoạt động
            if (KiemTraGaDangThuocTuyenHoatDong(maGa))
            {
                MessageBox.Show("Không thể ngưng hoạt động ga này vì ga đang thuộc tuyến tàu đang hoạt động!\n" +
                                "Vui lòng gỡ ga này khỏi các tuyến hoặc ngưng hoạt động tuyến tàu trước.",
                                "Chặn nghiệp vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn ngưng hoạt động ga tàu này không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                string sql = "UPDATE Ga SET TrangThai = N'Ngưng hoạt động' WHERE MaGa = @MaGa";
                SqlParameter[] p = new SqlParameter[] { new SqlParameter("@MaGa", maGa) };
                int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
                if (kq > 0)
                {
                    MessageBox.Show("Đã ngưng hoạt động ga tàu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachGa();
                    LamMoi();
                }
            }
        }

        private bool KiemTraGaDangThuocTuyenHoatDong(int maGa)
        {
            string sqlCheck = "SELECT COUNT(*) FROM Tuyen_Ga tg " +
                              "JOIN Tuyen t ON tg.MaTuyen = t.MaTuyen " +
                              "WHERE tg.MaGa = @MaGa AND t.TrangThai = N'Hoạt động'";
            object kq = Ketnoi_CSDL.ExecuteScalar(sqlCheck, new SqlParameter[] { new SqlParameter("@MaGa", maGa) });
            return kq != null && Convert.ToInt32(kq) > 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDanhSachGa(txtTimKiem.Text.Trim());
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDanhSachGa();
        }

        private void LamMoi()
        {
            txtMaGa.Clear();
            txtTenGa.Clear();
            txtDiaChi.Clear();
            cboTrangThai.SelectedIndex = 0;
            txtTimKiem.Clear();
            txtTenGa.Focus();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }
    }
}
