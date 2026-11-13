using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTau
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "admin";
            txtMatKhau.Text = "123456";
            txtTenDangNhap.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ThucHienDangNhap();
        }

        private void ThucHienDangNhap()
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            try
            {
                // Thử gọi qua Stored Procedure sp_DangNhap trước, nếu chưa có thì fallback sang câu lệnh SQL
                DataTable dt = null;
                try
                {
                    SqlParameter[] spParams = new SqlParameter[]
                    {
                        new SqlParameter("@TenDangNhap", username),
                        new SqlParameter("@MatKhau", password)
                    };
                    dt = Ketnoi_CSDL.ExecuteProcedure("sp_DangNhap", spParams);
                }
                catch
                {
                    dt = null;
                }

                if (dt == null || dt.Rows.Count == 0)
                {
                    string sql = "SELECT MaNV, HoTen, TenDangNhap, VaiTro, SoDienThoai, TrangThai " +
                                 "FROM NhanVien " +
                                 "WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                    SqlParameter[] p = new SqlParameter[]
                    {
                        new SqlParameter("@TenDangNhap", username),
                        new SqlParameter("@MatKhau", password)
                    };
                    dt = Ketnoi_CSDL.ExecuteQuery(sql, p);
                }

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    string trangThai = r["TrangThai"].ToString();
                    if (trangThai != "Hoạt động")
                    {
                        MessageBox.Show("Tài khoản này đã bị khóa hoặc ngưng hoạt động!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Lưu session
                    Ketnoi_CSDL.NguoiDungHienTai.MaNV = Convert.ToInt32(r["MaNV"]);
                    Ketnoi_CSDL.NguoiDungHienTai.HoTen = r["HoTen"].ToString();
                    Ketnoi_CSDL.NguoiDungHienTai.TenDangNhap = r["TenDangNhap"].ToString();
                    Ketnoi_CSDL.NguoiDungHienTai.VaiTro = r["VaiTro"].ToString();
                    Ketnoi_CSDL.NguoiDungHienTai.SoDienThoai = r["SoDienThoai"] != DBNull.Value ? r["SoDienThoai"].ToString() : "";

                    MessageBox.Show("Đăng nhập thành công!\nXin chào: " + Ketnoi_CSDL.NguoiDungHienTai.HoTen + " (" + Ketnoi_CSDL.NguoiDungHienTai.VaiTro + ")",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    FrmTrangChu fMain = new FrmTrangChu();
                    fMain.FormClosed += (s, args) =>
                    {
                        txtMatKhau.Clear();
                        this.Show();
                        txtTenDangNhap.Focus();
                    };
                    fMain.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.SelectAll();
                    txtMatKhau.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThucHienDangNhap();
            }
        }
    }
}
