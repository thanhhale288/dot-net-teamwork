using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTau
{
    public partial class FrmQuanLyTuyen : Form
    {
        public FrmQuanLyTuyen()
        {
            InitializeComponent();
        }

        private void FrmQuanLyTuyen_Load(object sender, EventArgs e)
        {
            cboTrangThai.SelectedIndex = 0;
            LoadDanhSachTuyen();
        }

        private void LoadDanhSachTuyen(string keyword = "")
        {
            string sql = "SELECT MaTuyen AS [Mã Tuyến], TenTuyen AS [Tên Tuyến Tàu], MoTa AS [Mô Tả Lộ Trình], TrangThai AS [Trạng Thái] " +
                         "FROM Tuyen ";
            SqlParameter[] p = null;
            if (!string.IsNullOrEmpty(keyword))
            {
                sql += "WHERE TenTuyen LIKE @kw OR MoTa LIKE @kw ";
                p = new SqlParameter[] { new SqlParameter("@kw", "%" + keyword + "%") };
            }
            sql += "ORDER BY MaTuyen ASC";

            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql, p);
            dgvTuyen.DataSource = dt;

            if (dgvTuyen.Columns.Contains("Mã Tuyến"))
            {
                dgvTuyen.Columns["Mã Tuyến"].Width = 90;
                dgvTuyen.Columns["Trạng Thái"].Width = 130;
            }
        }

        private void dgvTuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTuyen.Rows.Count)
            {
                DataGridViewRow r = dgvTuyen.Rows[e.RowIndex];
                txtMaTuyen.Text = r.Cells["Mã Tuyến"].Value != null ? r.Cells["Mã Tuyến"].Value.ToString() : "";
                txtTenTuyen.Text = r.Cells["Tên Tuyến Tàu"].Value != null ? r.Cells["Tên Tuyến Tàu"].Value.ToString() : "";
                txtMoTa.Text = r.Cells["Mô Tả Lộ Trình"].Value != null ? r.Cells["Mô Tả Lộ Trình"].Value.ToString() : "";
                string tt = r.Cells["Trạng Thái"].Value != null ? r.Cells["Trạng Thái"].Value.ToString() : "Hoạt động";
                cboTrangThai.SelectedItem = tt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenTuyen = txtTenTuyen.Text.Trim();
            string moTa = txtMoTa.Text.Trim();
            string trangThai = cboTrangThai.SelectedItem != null ? cboTrangThai.SelectedItem.ToString() : "Hoạt động";

            if (string.IsNullOrEmpty(tenTuyen))
            {
                MessageBox.Show("Vui lòng nhập tên tuyến tàu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTuyen.Focus();
                return;
            }

            string sql = "INSERT INTO Tuyen (TenTuyen, MoTa, TrangThai) VALUES (@TenTuyen, @MoTa, @TrangThai)";
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@TenTuyen", tenTuyen),
                new SqlParameter("@MoTa", moTa),
                new SqlParameter("@TrangThai", trangThai)
            };

            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
            if (kq > 0)
            {
                MessageBox.Show("Thêm tuyến tàu mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();
                LoadDanhSachTuyen();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTuyen.Text))
            {
                MessageBox.Show("Vui lòng chọn tuyến tàu cần cập nhật từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenTuyen = txtTenTuyen.Text.Trim();
            string moTa = txtMoTa.Text.Trim();
            string trangThai = cboTrangThai.SelectedItem != null ? cboTrangThai.SelectedItem.ToString() : "Hoạt động";

            if (string.IsNullOrEmpty(tenTuyen))
            {
                MessageBox.Show("Vui lòng nhập tên tuyến tàu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTuyen.Focus();
                return;
            }

            string sql = "UPDATE Tuyen SET TenTuyen = @TenTuyen, MoTa = @MoTa, TrangThai = @TrangThai WHERE MaTuyen = @MaTuyen";
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@TenTuyen", tenTuyen),
                new SqlParameter("@MoTa", moTa),
                new SqlParameter("@TrangThai", trangThai),
                new SqlParameter("@MaTuyen", Convert.ToInt32(txtMaTuyen.Text))
            };

            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật tuyến tàu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachTuyen();
            }
        }

        private void btnXoaNgung_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTuyen.Text))
            {
                MessageBox.Show("Vui lòng chọn tuyến tàu cần chuyển trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult res = MessageBox.Show("Bạn có muốn ngưng hoạt động tuyến tàu này (soft-delete) không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                string sql = "UPDATE Tuyen SET TrangThai = N'Ngưng hoạt động' WHERE MaTuyen = @MaTuyen";
                SqlParameter[] p = new SqlParameter[]
                {
                    new SqlParameter("@MaTuyen", Convert.ToInt32(txtMaTuyen.Text))
                };
                int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
                if (kq > 0)
                {
                    MessageBox.Show("Đã ngưng hoạt động tuyến tàu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachTuyen();
                    LamMoi();
                }
            }
        }

        private void btnChiTietGa_Click(object sender, EventArgs e)
        {
            int maTuyen = 0;
            if (!string.IsNullOrEmpty(txtMaTuyen.Text))
            {
                maTuyen = Convert.ToInt32(txtMaTuyen.Text);
            }

            FrmChiTietTuyen f = new FrmChiTietTuyen(maTuyen);
            f.ShowDialog();
            LoadDanhSachTuyen();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDanhSachTuyen(txtTimKiem.Text.Trim());
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDanhSachTuyen();
        }

        private void LamMoi()
        {
            txtMaTuyen.Clear();
            txtTenTuyen.Clear();
            txtMoTa.Clear();
            cboTrangThai.SelectedIndex = 0;
            txtTimKiem.Clear();
            txtTenTuyen.Focus();
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
