using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTau
{
    public partial class FrmChiTietTau : Form
    {
        private int _maTauMacDinh = 0;

        public FrmChiTietTau()
        {
            InitializeComponent();
        }

        public FrmChiTietTau(int maTauMacDinh)
        {
            InitializeComponent();
            _maTauMacDinh = maTauMacDinh;
        }

        private void FrmChiTietTau_Load(object sender, EventArgs e)
        {
            cboLoaiToa.SelectedIndex = 0;
            LoadDanhSachTau();

            if (_maTauMacDinh > 0)
            {
                cboTau.SelectedValue = _maTauMacDinh;
            }
            else if (cboTau.Items.Count > 0)
            {
                cboTau.SelectedIndex = 0;
            }
        }

        private void LoadDanhSachTau()
        {
            string sql = "SELECT MaTau, TenTau FROM Tau ORDER BY MaTau ASC";
            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql);
            cboTau.DataSource = dt;
            cboTau.DisplayMember = "TenTau";
            cboTau.ValueMember = "MaTau";
        }

        private void cboTau_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachToa();
        }

        private void LoadDanhSachToa()
        {
            if (cboTau.SelectedValue == null || cboTau.SelectedValue is DataRowView)
                return;

            int maTau = Convert.ToInt32(cboTau.SelectedValue);

            // Lấy trạng thái của tàu
            DataTable dtTau = Ketnoi_CSDL.ExecuteQuery("SELECT TrangThai FROM Tau WHERE MaTau = @MaTau",
                new SqlParameter[] { new SqlParameter("@MaTau", maTau) });
            if (dtTau != null && dtTau.Rows.Count > 0)
            {
                lblTrangThaiTau.Text = "Trạng thái: " + dtTau.Rows[0]["TrangThai"].ToString();
            }

            // Lấy danh sách toa
            string sql = "SELECT MaToa AS [Mã Toa], SoToa AS [Số Thứ Tự Toa], " +
                         "LoaiToa AS [Loại Toa], SucChua AS [Sức Chứa (Chỗ)] " +
                         "FROM ToaTau " +
                         "WHERE MaTau = @MaTau " +
                         "ORDER BY SoToa ASC";

            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql, new SqlParameter[] { new SqlParameter("@MaTau", maTau) });
            dgvToaTau.DataSource = dt;

            int soToa = dt.Rows.Count;
            int tongSucChua = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tongSucChua += Convert.ToInt32(dt.Rows[i]["Sức Chứa (Chỗ)"]);
            }

            lblTongSoToa.Text = string.Format("Tổng số toa: {0} toa", soToa);
            lblTongSucChua.Text = string.Format("Tổng sức chứa: {0} chỗ ngồi", tongSucChua);

            numSoToa.Value = soToa + 1; // Gợi ý số toa tiếp theo
            txtMaToa.Clear();
        }

        private void dgvToaTau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvToaTau.Rows.Count)
            {
                DataGridViewRow r = dgvToaTau.Rows[e.RowIndex];
                txtMaToa.Text = r.Cells["Mã Toa"].Value != null ? r.Cells["Mã Toa"].Value.ToString() : "";
                numSoToa.Value = Convert.ToDecimal(r.Cells["Số Thứ Tự Toa"].Value);
                string loaiToa = r.Cells["Loại Toa"].Value != null ? r.Cells["Loại Toa"].Value.ToString() : "Thường";
                cboLoaiToa.SelectedItem = loaiToa;
                numSucChua.Value = Convert.ToDecimal(r.Cells["Sức Chứa (Chỗ)"].Value);
            }
        }

        private void btnThemToa_Click(object sender, EventArgs e)
        {
            if (cboTau.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đoàn tàu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maTau = Convert.ToInt32(cboTau.SelectedValue);
            int soToa = Convert.ToInt32(numSoToa.Value);
            string loaiToa = cboLoaiToa.SelectedItem != null ? cboLoaiToa.SelectedItem.ToString() : "Thường";
            int sucChua = Convert.ToInt32(numSucChua.Value);

            // Kiểm tra trùng số toa trên cùng đoàn tàu
            object check = Ketnoi_CSDL.ExecuteScalar("SELECT COUNT(*) FROM ToaTau WHERE MaTau = @MaTau AND SoToa = @SoToa",
                new SqlParameter[] { new SqlParameter("@MaTau", maTau), new SqlParameter("@SoToa", soToa) });

            if (check != null && Convert.ToInt32(check) > 0)
            {
                MessageBox.Show("Số toa số " + soToa + " đã tồn tại trên đoàn tàu này! Vui lòng chọn số toa khác.",
                    "Trùng lặp số toa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "INSERT INTO ToaTau (MaTau, SoToa, LoaiToa, SucChua) VALUES (@MaTau, @SoToa, @LoaiToa, @SucChua)";
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@MaTau", maTau),
                new SqlParameter("@SoToa", soToa),
                new SqlParameter("@LoaiToa", loaiToa),
                new SqlParameter("@SucChua", sucChua)
            };

            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
            if (kq > 0)
            {
                MessageBox.Show("Thêm toa tàu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachToa();
            }
        }

        private void btnSuaToa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaToa.Text))
            {
                MessageBox.Show("Vui lòng chọn toa tàu cần cập nhật từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maToa = Convert.ToInt32(txtMaToa.Text);
            int maTau = Convert.ToInt32(cboTau.SelectedValue);
            int soToa = Convert.ToInt32(numSoToa.Value);
            string loaiToa = cboLoaiToa.SelectedItem != null ? cboLoaiToa.SelectedItem.ToString() : "Thường";
            int sucChua = Convert.ToInt32(numSucChua.Value);

            // Kiểm tra trùng số toa với toa khác của cùng tàu
            object check = Ketnoi_CSDL.ExecuteScalar("SELECT COUNT(*) FROM ToaTau WHERE MaTau = @MaTau AND SoToa = @SoToa AND MaToa <> @MaToa",
                new SqlParameter[] { new SqlParameter("@MaTau", maTau), new SqlParameter("@SoToa", soToa), new SqlParameter("@MaToa", maToa) });

            if (check != null && Convert.ToInt32(check) > 0)
            {
                MessageBox.Show("Số toa số " + soToa + " đã tồn tại trên đoàn tàu này! Vui lòng chọn số toa khác.",
                    "Trùng lặp số toa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "UPDATE ToaTau SET SoToa = @SoToa, LoaiToa = @LoaiToa, SucChua = @SucChua WHERE MaToa = @MaToa";
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@SoToa", soToa),
                new SqlParameter("@LoaiToa", loaiToa),
                new SqlParameter("@SucChua", sucChua),
                new SqlParameter("@MaToa", maToa)
            };

            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật thông tin toa tàu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachToa();
            }
        }

        private void btnXoaToa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaToa.Text))
            {
                MessageBox.Show("Vui lòng chọn toa tàu cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maToa = Convert.ToInt32(txtMaToa.Text);

            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa toa tàu này không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                string sql = "DELETE FROM ToaTau WHERE MaToa = @MaToa";
                SqlParameter[] p = new SqlParameter[] { new SqlParameter("@MaToa", maToa) };

                int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
                if (kq > 0)
                {
                    MessageBox.Show("Đã xóa toa tàu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachToa();
                }
            }
        }
    }
}
