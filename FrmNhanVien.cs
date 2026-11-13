using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTau
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            cboVaiTro.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            LoadDanhSachNhanVien();
        }

        private void LoadDanhSachNhanVien(string keyword = "")
        {
            string sql = "SELECT MaNV AS [Mã NV], " +
                         "HoTen AS [Họ Và Tên], " +
                         "TenDangNhap AS [Tên Đăng Nhập], " +
                         "VaiTro AS [Vai Trò], " +
                         "ISNULL(SoDienThoai, '') AS [Số Điện Thoại], " +
                         "TrangThai AS [Trạng Thái], " +
                         "MatKhau " +
                         "FROM NhanVien ";

            SqlParameter[] p = null;
            if (!string.IsNullOrEmpty(keyword))
            {
                sql += "WHERE HoTen LIKE @kw OR TenDangNhap LIKE @kw OR SoDienThoai LIKE @kw ";
                p = new SqlParameter[] { new SqlParameter("@kw", "%" + keyword + "%") };
            }

            sql += "ORDER BY MaNV ASC";

            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql, p);
            dgvNhanVien.DataSource = dt;

            if (dgvNhanVien.Columns.Contains("MatKhau"))
            {
                dgvNhanVien.Columns["MatKhau"].Visible = false;
            }

            if (dgvNhanVien.Columns.Contains("Mã NV"))
            {
                dgvNhanVien.Columns["Mã NV"].Width = 80;
                dgvNhanVien.Columns["Tên Đăng Nhập"].Width = 140;
                dgvNhanVien.Columns["Vai Trò"].Width = 110;
                dgvNhanVien.Columns["Trạng Thái"].Width = 120;
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhanVien.Rows.Count)
            {
                DataGridViewRow r = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = r.Cells["Mã NV"].Value != null ? r.Cells["Mã NV"].Value.ToString() : "";
                txtHoTen.Text = r.Cells["Họ Và Tên"].Value != null ? r.Cells["Họ Và Tên"].Value.ToString() : "";
                txtTenDangNhap.Text = r.Cells["Tên Đăng Nhập"].Value != null ? r.Cells["Tên Đăng Nhập"].Value.ToString() : "";
                txtMatKhau.Text = r.Cells["MatKhau"].Value != null ? r.Cells["MatKhau"].Value.ToString() : "";
                txtSoDienThoai.Text = r.Cells["Số Điện Thoại"].Value != null ? r.Cells["Số Điện Thoại"].Value.ToString() : "";

                string vaiTro = r.Cells["Vai Trò"].Value != null ? r.Cells["Vai Trò"].Value.ToString() : "QuanLy";
                cboVaiTro.SelectedItem = vaiTro;

                string tt = r.Cells["Trạng Thái"].Value != null ? r.Cells["Trạng Thái"].Value.ToString() : "Hoạt động";
                cboTrangThai.SelectedItem = tt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();
            string vaiTro = cboVaiTro.SelectedItem != null ? cboVaiTro.SelectedItem.ToString() : "BanVe";
            string sdt = txtSoDienThoai.Text.Trim();
            string trangThai = cboTrangThai.SelectedItem != null ? cboTrangThai.SelectedItem.ToString() : "Hoạt động";

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên, Tên đăng nhập và Mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            // Kiểm tra trùng tên đăng nhập
            object check = Ketnoi_CSDL.ExecuteScalar("SELECT COUNT(*) FROM NhanVien WHERE TenDangNhap = @User",
                new SqlParameter[] { new SqlParameter("@User", username) });

            if (check != null && Convert.ToInt32(check) > 0)
            {
                MessageBox.Show("Tên đăng nhập '" + username + "' đã được sử dụng! Vui lòng chọn tên khác.",
                    "Trùng tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }

            string sql = "INSERT INTO NhanVien (HoTen, TenDangNhap, MatKhau, VaiTro, SoDienThoai, TrangThai) " +
                         "VALUES (@HoTen, @TenDangNhap, @MatKhau, @VaiTro, @SoDienThoai, @TrangThai)";

            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@TenDangNhap", username),
                new SqlParameter("@MatKhau", password),
                new SqlParameter("@VaiTro", vaiTro),
                new SqlParameter("@SoDienThoai", sdt),
                new SqlParameter("@TrangThai", trangThai)
            };

            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
            if (kq > 0)
            {
                MessageBox.Show("Thêm nhân viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();
                LoadDanhSachNhanVien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maNV = Convert.ToInt32(txtMaNV.Text);
            string hoTen = txtHoTen.Text.Trim();
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();
            string vaiTro = cboVaiTro.SelectedItem != null ? cboVaiTro.SelectedItem.ToString() : "BanVe";
            string sdt = txtSoDienThoai.Text.Trim();
            string trangThai = cboTrangThai.SelectedItem != null ? cboTrangThai.SelectedItem.ToString() : "Hoạt động";

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Tên đăng nhập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng username với người khác
            object check = Ketnoi_CSDL.ExecuteScalar("SELECT COUNT(*) FROM NhanVien WHERE TenDangNhap = @User AND MaNV <> @MaNV",
                new SqlParameter[] { new SqlParameter("@User", username), new SqlParameter("@MaNV", maNV) });

            if (check != null && Convert.ToInt32(check) > 0)
            {
                MessageBox.Show("Tên đăng nhập '" + username + "' đã được sử dụng bởi người khác!",
                    "Trùng tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "UPDATE NhanVien SET HoTen = @HoTen, TenDangNhap = @TenDangNhap, MatKhau = @MatKhau, " +
                         "VaiTro = @VaiTro, SoDienThoai = @SoDienThoai, TrangThai = @TrangThai WHERE MaNV = @MaNV";

            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@TenDangNhap", username),
                new SqlParameter("@MatKhau", password),
                new SqlParameter("@VaiTro", vaiTro),
                new SqlParameter("@SoDienThoai", sdt),
                new SqlParameter("@TrangThai", trangThai),
                new SqlParameter("@MaNV", maNV)
            };

            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachNhanVien();
            }
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần khóa/ngưng hoạt động!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maNV = Convert.ToInt32(txtMaNV.Text);
            if (maNV == Ketnoi_CSDL.NguoiDungHienTai.MaNV)
            {
                MessageBox.Show("Bạn không thể tự khóa tài khoản của chính mình!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult res = MessageBox.Show("Khóa hoặc chuyển trạng thái tài khoản này thành 'Ngưng hoạt động'?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                string sql = "UPDATE NhanVien SET TrangThai = N'Ngưng hoạt động' WHERE MaNV = @MaNV";
                int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, new SqlParameter[] { new SqlParameter("@MaNV", maNV) });
                if (kq > 0)
                {
                    MessageBox.Show("Đã khóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNhanVien();
                    LamMoi();
                }
            }
        }

        private void btnResetMatKhau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần đặt lại mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maNV = Convert.ToInt32(txtMaNV.Text);

            DialogResult res = MessageBox.Show("Đặt lại mật khẩu cho tài khoản '" + txtTenDangNhap.Text + "' về mặc định '123456'?",
                "Xác nhận đặt lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                string sql = "UPDATE NhanVien SET MatKhau = '123456' WHERE MaNV = @MaNV";
                int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, new SqlParameter[] { new SqlParameter("@MaNV", maNV) });
                if (kq > 0)
                {
                    txtMatKhau.Text = "123456";
                    MessageBox.Show("Đã đặt lại mật khẩu về '123456'!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNhanVien();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien(txtTimKiem.Text.Trim());
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDanhSachNhanVien();
        }

        private void LamMoi()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtSoDienThoai.Clear();
            cboVaiTro.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            txtTimKiem.Clear();
            txtHoTen.Focus();
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
