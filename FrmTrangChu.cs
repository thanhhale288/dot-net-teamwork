using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyTau
{
    public partial class FrmTrangChu : Form
    {
        public FrmTrangChu()
        {
            InitializeComponent();
        }

        private void FrmTrangChu_Load(object sender, EventArgs e)
        {
            HienThiThongTinNguoiDung();
            PhanQuyenTheoVaiTro();
            LoadThongKeDashboard();
        }

        private void HienThiThongTinNguoiDung()
        {
            if (Ketnoi_CSDL.NguoiDungHienTai.DaDangNhap())
            {
                lblUserInfo.Text = string.Format("Xin chào: {0} ({1})",
                    Ketnoi_CSDL.NguoiDungHienTai.HoTen,
                    Ketnoi_CSDL.NguoiDungHienTai.VaiTro);
            }
            else
            {
                lblUserInfo.Text = "Chưa đăng nhập";
            }
        }

        private void PhanQuyenTheoVaiTro()
        {
            string role = Ketnoi_CSDL.NguoiDungHienTai.VaiTro;

            if (role == "QuanLy")
            {
                // Toàn quyền
                return;
            }

            // Mặc định vô hiệu hóa tất cả các nút chức năng quản trị & hạ tầng
            btnQuanLyTuyen.Enabled = false;
            btnChiTietTuyen.Enabled = false;
            btnQuanLyGa.Enabled = false;
            btnQuanLyTau.Enabled = false;
            btnChiTietTau.Enabled = false;
            btnBaoTri.Enabled = false;
            btnLichTrinh.Enabled = false;
            btnChuyenTau.Enabled = false;
            btnBanVe.Enabled = false;
            btnTraCuuVe.Enabled = false;
            btnHanhKhach.Enabled = false;
            btnNhanVien.Enabled = false;
            btnBaoCao.Enabled = false;

            // Đổi màu các nút bị vô hiệu hóa
            Color disabledBg = Color.FromArgb(209, 213, 219);
            Color disabledFg = Color.FromArgb(107, 114, 128);

            SetButtonDisabled(btnQuanLyTuyen, disabledBg, disabledFg);
            SetButtonDisabled(btnChiTietTuyen, disabledBg, disabledFg);
            SetButtonDisabled(btnQuanLyGa, disabledBg, disabledFg);
            SetButtonDisabled(btnQuanLyTau, disabledBg, disabledFg);
            SetButtonDisabled(btnChiTietTau, disabledBg, disabledFg);
            SetButtonDisabled(btnBaoTri, disabledBg, disabledFg);
            SetButtonDisabled(btnLichTrinh, disabledBg, disabledFg);
            SetButtonDisabled(btnChuyenTau, disabledBg, disabledFg);
            SetButtonDisabled(btnBanVe, disabledBg, disabledFg);
            SetButtonDisabled(btnTraCuuVe, disabledBg, disabledFg);
            SetButtonDisabled(btnHanhKhach, disabledBg, disabledFg);
            SetButtonDisabled(btnNhanVien, disabledBg, disabledFg);
            SetButtonDisabled(btnBaoCao, disabledBg, disabledFg);

            if (role == "BanVe")
            {
                // Bán vé: Sử dụng Chuyến tàu, Bán vé, Tra cứu vé, Hành khách
                EnableButton(btnChuyenTau, Color.FromArgb(217, 119, 6));
                EnableButton(btnBanVe, Color.FromArgb(16, 185, 129));
                EnableButton(btnTraCuuVe, Color.FromArgb(217, 119, 6));
                EnableButton(btnHanhKhach, Color.FromArgb(217, 119, 6));
            }
            else if (role == "KyThuat")
            {
                // Kỹ thuật: Quản lý tàu, Chi tiết tàu, Bảo trì
                EnableButton(btnQuanLyTau, Color.FromArgb(13, 148, 136));
                EnableButton(btnChiTietTau, Color.FromArgb(13, 148, 136));
                EnableButton(btnBaoTri, Color.FromArgb(13, 148, 136));
            }
            else if (role == "LaiTau")
            {
                // Lái tàu: Xem danh sách chuyến tàu được phân công
                EnableButton(btnChuyenTau, Color.FromArgb(217, 119, 6));
            }
        }

        private void SetButtonDisabled(Button btn, Color bg, Color fg)
        {
            btn.Enabled = false;
            btn.BackColor = bg;
            btn.ForeColor = fg;
        }

        private void EnableButton(Button btn, Color bg)
        {
            btn.Enabled = true;
            btn.BackColor = bg;
            btn.ForeColor = Color.White;
        }

        public void LoadThongKeDashboard()
        {
            try
            {
                // Thử gọi Stored Procedure sp_ThongKeTrangChu nếu có
                DataTable dt = null;
                try
                {
                    dt = Ketnoi_CSDL.ExecuteProcedure("sp_ThongKeTrangChu");
                }
                catch { dt = null; }

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];

                    // 1. Số tàu sẵn sàng / tổng số tàu
                    if (dt.Columns.Contains("SoTauSanSang"))
                        lblSoTauVal.Text = r["SoTauSanSang"].ToString();
                    else if (dt.Columns.Contains("TongTau"))
                        lblSoTauVal.Text = r["TongTau"].ToString();
                    else
                    {
                        object soTau = Ketnoi_CSDL.ExecuteScalar("SELECT COUNT(*) FROM Tau WHERE TrangThai LIKE N'%S%n s%ng%'");
                        lblSoTauVal.Text = soTau != null ? soTau.ToString() : "0";
                    }

                    // 2. Chuyến tàu hôm nay
                    if (dt.Columns.Contains("SoChuyenHomNay"))
                        lblSoChuyenVal.Text = r["SoChuyenHomNay"].ToString();
                    else if (dt.Columns.Contains("ChuyenHomNay"))
                        lblSoChuyenVal.Text = r["ChuyenHomNay"].ToString();
                    else
                    {
                        object soChuyen = Ketnoi_CSDL.ExecuteScalar("SELECT COUNT(*) FROM ChuyenTau WHERE CAST(NgayChay AS DATE) = CAST(GETDATE() AS DATE)");
                        lblSoChuyenVal.Text = soChuyen != null ? soChuyen.ToString() : "0";
                    }

                    // 3. Số vé bán hôm nay
                    if (dt.Columns.Contains("SoVeBanHomNay"))
                        lblSoVeVal.Text = r["SoVeBanHomNay"].ToString();
                    else
                    {
                        object soVe = Ketnoi_CSDL.ExecuteScalar("SELECT COUNT(*) FROM Ve WHERE CAST(NgayMua AS DATE) = CAST(GETDATE() AS DATE) AND TrangThai LIKE N'%thanh to%n%'");
                        lblSoVeVal.Text = soVe != null ? soVe.ToString() : "0";
                    }

                    // 4. Doanh thu hôm nay
                    if (dt.Columns.Contains("DoanhThuHomNay"))
                    {
                        decimal dtHomNay = r["DoanhThuHomNay"] != DBNull.Value ? Convert.ToDecimal(r["DoanhThuHomNay"]) : 0;
                        lblDoanhThuVal.Text = string.Format("{0:N0} VNĐ", dtHomNay);
                    }
                }
                else
                {
                    // Fallback SQL query thống kê trực tiếp toàn diện
                    string sql = @"
                        SELECT 
                            (SELECT COUNT(*) FROM Tau WHERE TrangThai LIKE N'%S%n s%ng%') AS SoTauSanSang,
                            (SELECT COUNT(*) FROM ChuyenTau WHERE CAST(NgayChay AS DATE) = CAST(GETDATE() AS DATE)) AS SoChuyenHomNay,
                            (SELECT COUNT(*) FROM Ve WHERE CAST(NgayMua AS DATE) = CAST(GETDATE() AS DATE) AND TrangThai LIKE N'%thanh to%n%') AS SoVeBanHomNay,
                            (SELECT ISNULL(SUM(GiaVe), 0) FROM Ve WHERE CAST(NgayMua AS DATE) = CAST(GETDATE() AS DATE) AND TrangThai LIKE N'%thanh to%n%') AS DoanhThuHomNay";

                    DataTable dtDirect = Ketnoi_CSDL.ExecuteQuery(sql);
                    if (dtDirect != null && dtDirect.Rows.Count > 0)
                    {
                        DataRow r = dtDirect.Rows[0];
                        lblSoTauVal.Text = r["SoTauSanSang"].ToString();
                        lblSoChuyenVal.Text = r["SoChuyenHomNay"].ToString();
                        lblSoVeVal.Text = r["SoVeBanHomNay"].ToString();
                        decimal dtVal = r["DoanhThuHomNay"] != DBNull.Value ? Convert.ToDecimal(r["DoanhThuHomNay"]) : 0;
                        lblDoanhThuVal.Text = string.Format("{0:N0} VNĐ", dtVal);
                    }
                }
            }
            catch (Exception ex)
            {
                // Giữ nguyên giao diện không crash nếu chưa có dữ liệu
                Console.WriteLine("Lỗi load thống kê: " + ex.Message);
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Ketnoi_CSDL.NguoiDungHienTai.DangXuat();
                this.Close();
            }
        }

        // ================= 1. HẠ TẦNG =================
        private void btnQuanLyTuyen_Click(object sender, EventArgs e)
        {
            FrmQuanLyTuyen f = new FrmQuanLyTuyen();
            f.ShowDialog();
            LoadThongKeDashboard();
        }

        private void btnChiTietTuyen_Click(object sender, EventArgs e)
        {
            FrmChiTietTuyen f = new FrmChiTietTuyen();
            f.ShowDialog();
            LoadThongKeDashboard();
        }

        private void btnQuanLyGa_Click(object sender, EventArgs e)
        {
            FrmQuanLyGa f = new FrmQuanLyGa();
            f.ShowDialog();
            LoadThongKeDashboard();
        }

        // ================= 2. PHƯƠNG TIỆN =================
        private void btnQuanLyTau_Click(object sender, EventArgs e)
        {
            FrmQuanLyTau f = new FrmQuanLyTau();
            f.ShowDialog();
            LoadThongKeDashboard();
        }

        private void btnChiTietTau_Click(object sender, EventArgs e)
        {
            FrmChiTietTau f = new FrmChiTietTau();
            f.ShowDialog();
            LoadThongKeDashboard();
        }

        private void btnBaoTri_Click(object sender, EventArgs e)
        {
            FrmBaoTri f = new FrmBaoTri();
            f.ShowDialog();
            LoadThongKeDashboard();
        }

        // ================= 3. VẬN HÀNH & BÁN VÉ =================
        private void btnLichTrinh_Click(object sender, EventArgs e)
        {
            FrmLichTrinh f = new FrmLichTrinh();
            f.ShowDialog();
            LoadThongKeDashboard();
        }

        private void btnChuyenTau_Click(object sender, EventArgs e)
        {
            FrmChuyenTau f = new FrmChuyenTau();
            f.ShowDialog();
            LoadThongKeDashboard();
        }

        private void btnBanVe_Click(object sender, EventArgs e)
        {
            FrmBanVe f = new FrmBanVe();
            f.ShowDialog();
            LoadThongKeDashboard();
        }

        private void btnTraCuuVe_Click(object sender, EventArgs e)
        {
            FrmTraCuuVe f = new FrmTraCuuVe();
            f.ShowDialog();
            LoadThongKeDashboard();
        }

        private void btnHanhKhach_Click(object sender, EventArgs e)
        {
            FrmHanhKhach f = new FrmHanhKhach();
            f.ShowDialog();
            LoadThongKeDashboard();
        }

        // ================= 4. QUẢN TRỊ & BÁO CÁO =================
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien f = new FrmNhanVien();
            f.ShowDialog();
            LoadThongKeDashboard();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            FrmBaoCao f = new FrmBaoCao();
            f.ShowDialog();
            LoadThongKeDashboard();
        }
    }
}
