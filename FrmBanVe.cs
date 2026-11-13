using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTau
{
    public partial class FrmBanVe : Form
    {
        private int _maTuyenHienTai = 0;
        private decimal _giaVeHienTai = 0;
        private int _thuTuGaDi = 0;
        private int _thuTuGaDen = 0;

        public FrmBanVe()
        {
            InitializeComponent();
        }

        private void FrmBanVe_Load(object sender, EventArgs e)
        {
            dtpNgayChay.Value = DateTime.Today;
            cboLoaiVe.SelectedIndex = 0;
            LoadChuyenTauTheoNgay();
        }

        private void dtpNgayChay_ValueChanged(object sender, EventArgs e)
        {
            LoadChuyenTauTheoNgay();
        }

        private void LoadChuyenTauTheoNgay()
        {
            DateTime ngay = dtpNgayChay.Value.Date;
            string sql = "SELECT ct.MaChuyen, " +
                         "'#' + CAST(ct.MaChuyen AS VARCHAR) + ' - ' + ty.TenTuyen + ' (' + t.TenTau + ' | ' + CONVERT(VARCHAR(5), ct.GioKhoiHanh, 108) + ')' AS ThongTinChuyen, " +
                         "t.MaTuyen, ty.TenTuyen " +
                         "FROM ChuyenTau ct " +
                         "JOIN Tau t ON ct.MaTau = t.MaTau " +
                         "JOIN Tuyen ty ON t.MaTuyen = ty.MaTuyen " +
                         "WHERE ct.NgayChay = @Ngay AND ct.TrangThai <> N'Hủy' " +
                         "ORDER BY ct.GioKhoiHanh ASC";

            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql, new SqlParameter[] { new SqlParameter("@Ngay", ngay) });

            if (dt != null && dt.Rows.Count > 0)
            {
                cboChuyenTau.DataSource = dt;
                cboChuyenTau.DisplayMember = "ThongTinChuyen";
                cboChuyenTau.ValueMember = "MaChuyen";
                cboChuyenTau.SelectedIndex = 0;
            }
            else
            {
                cboChuyenTau.DataSource = null;
                cboGaDi.DataSource = null;
                cboGaDen.DataSource = null;
                lblThongTinTuyen.Text = "Không có chuyến tàu nào hoạt động trong ngày này.";
                lblGiaTien.Text = "0 VNĐ";
                _giaVeHienTai = 0;
            }
        }

        private void cboChuyenTau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChuyenTau.SelectedValue == null || cboChuyenTau.SelectedValue is DataRowView)
                return;

            DataRowView drv = cboChuyenTau.SelectedItem as DataRowView;
            if (drv != null)
            {
                _maTuyenHienTai = Convert.ToInt32(drv["MaTuyen"]);
                string tenTuyen = drv["TenTuyen"].ToString();
                lblThongTinTuyen.Text = "Lộ trình tuyến: " + tenTuyen;
                LoadGaCuaTuyen(_maTuyenHienTai);
            }
        }

        private void LoadGaCuaTuyen(int maTuyen)
        {
            string sql = "SELECT tg.MaGa, CAST(tg.ThuTu AS VARCHAR) + '. ' + g.TenGa AS TenGaThuTu, tg.ThuTu, g.TenGa " +
                         "FROM Tuyen_Ga tg " +
                         "JOIN Ga g ON tg.MaGa = g.MaGa " +
                         "WHERE tg.MaTuyen = @MaTuyen AND g.TrangThai = N'Hoạt động' " +
                         "ORDER BY tg.ThuTu ASC";

            DataTable dtGaDi = Ketnoi_CSDL.ExecuteQuery(sql, new SqlParameter[] { new SqlParameter("@MaTuyen", maTuyen) });
            DataTable dtGaDen = dtGaDi.Copy();

            cboGaDi.DataSource = dtGaDi;
            cboGaDi.DisplayMember = "TenGaThuTu";
            cboGaDi.ValueMember = "MaGa";

            cboGaDen.DataSource = dtGaDen;
            cboGaDen.DisplayMember = "TenGaThuTu";
            cboGaDen.ValueMember = "MaGa";

            if (cboGaDi.Items.Count > 0) cboGaDi.SelectedIndex = 0;
            if (cboGaDen.Items.Count > 1) cboGaDen.SelectedIndex = cboGaDen.Items.Count - 1;

            TinhToanGiaVe();
        }

        private void cboGaDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = cboGaDi.SelectedItem as DataRowView;
            if (drv != null)
            {
                _thuTuGaDi = Convert.ToInt32(drv["ThuTu"]);
            }
            TinhToanGiaVe();
        }

        private void cboGaDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = cboGaDen.SelectedItem as DataRowView;
            if (drv != null)
            {
                _thuTuGaDen = Convert.ToInt32(drv["ThuTu"]);
            }
            TinhToanGiaVe();
        }

        private void cboLoaiVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhToanGiaVe();
        }

        private void TinhToanGiaVe()
        {
            if (cboGaDi.SelectedValue == null || cboGaDen.SelectedValue == null ||
                cboGaDi.SelectedValue is DataRowView || cboGaDen.SelectedValue is DataRowView)
            {
                lblGiaTien.Text = "0 VNĐ";
                _giaVeHienTai = 0;
                return;
            }

            int cuLy = _thuTuGaDen - _thuTuGaDi;
            if (cuLy <= 0)
            {
                lblKhoangCachGa.Text = "Cự ly: Không hợp lệ (Ga đến phải sau ga đi!)";
                lblKhoangCachGa.ForeColor = System.Drawing.Color.Red;
                lblGiaTien.Text = "0 VNĐ";
                _giaVeHienTai = 0;
                return;
            }

            lblKhoangCachGa.ForeColor = System.Drawing.Color.FromArgb(217, 119, 6);
            lblKhoangCachGa.Text = string.Format("Cự ly di chuyển: {0} chặng ga dừng", cuLy);

            // Bảng giá vé mẫu theo cự ly metro
            decimal giaCoBan = 10000;
            if (cuLy <= 2) giaCoBan = 12000;
            else if (cuLy <= 4) giaCoBan = 15000;
            else if (cuLy <= 6) giaCoBan = 18000;
            else giaCoBan = 20000;

            // Loại vé
            string loaiVe = cboLoaiVe.SelectedItem != null ? cboLoaiVe.SelectedItem.ToString() : "Thường";
            if (loaiVe.Contains("Ưu tiên"))
            {
                // Giảm 30% cho đối tượng ưu tiên
                _giaVeHienTai = Math.Round(giaCoBan * 0.7m, 0);
            }
            else
            {
                _giaVeHienTai = giaCoBan;
            }

            lblGiaTien.Text = string.Format("{0:N0} VNĐ", _giaVeHienTai);
        }

        private void btnKiemTraCCCD_Click(object sender, EventArgs e)
        {
            KiemTraThongTinHanhKhach();
        }

        private void txtCCCD_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCCCD.Text.Trim()))
            {
                KiemTraThongTinHanhKhach();
            }
        }

        private void txtCCCD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KiemTraThongTinHanhKhach();
            }
        }

        private void KiemTraThongTinHanhKhach()
        {
            string cccd = txtCCCD.Text.Trim();
            if (string.IsNullOrEmpty(cccd)) return;

            string sql = "SELECT MaHK, HoTen, SoDienThoai FROM HanhKhach WHERE CCCD = @CCCD";
            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql, new SqlParameter[] { new SqlParameter("@CCCD", cccd) });

            if (dt != null && dt.Rows.Count > 0)
            {
                txtHoTen.Text = dt.Rows[0]["HoTen"].ToString();
                txtSoDienThoai.Text = dt.Rows[0]["SoDienThoai"] != DBNull.Value ? dt.Rows[0]["SoDienThoai"].ToString() : "";
            }
            else
            {
                // Khách mới
                txtHoTen.Clear();
                txtSoDienThoai.Clear();
                txtHoTen.Focus();
            }
        }

        private void btnInVe_Click(object sender, EventArgs e)
        {
            if (cboChuyenTau.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn chuyến tàu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cccd = txtCCCD.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();

            if (string.IsNullOrEmpty(cccd))
            {
                MessageBox.Show("Vui lòng nhập số CCCD/CMND của hành khách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCCCD.Focus();
                return;
            }

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên của hành khách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            if (_thuTuGaDen <= _thuTuGaDi)
            {
                MessageBox.Show("Ga đến phải nằm sau ga đi trên hành trình tuyến tàu!", "Lỗi chọn ga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int maChuyen = Convert.ToInt32(cboChuyenTau.SelectedValue);
            int maGaDi = Convert.ToInt32(cboGaDi.SelectedValue);
            int maGaDen = Convert.ToInt32(cboGaDen.SelectedValue);
            string loaiVe = cboLoaiVe.SelectedItem.ToString().Contains("Ưu tiên") ? "Ưu tiên" : "Thường";
            decimal giaVe = _giaVeHienTai;

            // Thử gọi sp_BanVe nếu có
            try
            {
                SqlParameter[] spP = new SqlParameter[]
                {
                    new SqlParameter("@MaChuyen", maChuyen),
                    new SqlParameter("@CCCD", cccd),
                    new SqlParameter("@HoTen", hoTen),
                    new SqlParameter("@SoDienThoai", sdt),
                    new SqlParameter("@MaGaDi", maGaDi),
                    new SqlParameter("@MaGaDen", maGaDen),
                    new SqlParameter("@LoaiVe", loaiVe),
                    new SqlParameter("@GiaVe", giaVe)
                };
                DataTable dtSP = Ketnoi_CSDL.ExecuteProcedure("sp_BanVe", spP);
                if (dtSP != null && dtSP.Rows.Count > 0)
                {
                    int maVeMoi = Convert.ToInt32(dtSP.Rows[0][0]);
                    InVeXacNhan(maVeMoi, hoTen, cccd, loaiVe, giaVe);
                    LamMoiGiaoDich();
                    return;
                }
            }
            catch { }

            // Giao dịch Transaction an toàn bằng ADO.NET
            using (SqlConnection conn = Ketnoi_CSDL.GetConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // 1. Kiểm tra hoặc thêm hành khách
                    int maHK = 0;
                    SqlCommand cmdCheckHK = new SqlCommand("SELECT MaHK FROM HanhKhach WHERE CCCD = @CCCD", conn, trans);
                    cmdCheckHK.Parameters.AddWithValue("@CCCD", cccd);
                    object hkObj = cmdCheckHK.ExecuteScalar();

                    if (hkObj != null && hkObj != DBNull.Value)
                    {
                        maHK = Convert.ToInt32(hkObj);
                        // Cập nhật lại số điện thoại hoặc họ tên nếu có sửa
                        SqlCommand cmdUpdHK = new SqlCommand("UPDATE HanhKhach SET HoTen = @HoTen, SoDienThoai = @SDT WHERE MaHK = @MaHK", conn, trans);
                        cmdUpdHK.Parameters.AddWithValue("@HoTen", hoTen);
                        cmdUpdHK.Parameters.AddWithValue("@SDT", sdt);
                        cmdUpdHK.Parameters.AddWithValue("@MaHK", maHK);
                        cmdUpdHK.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlCommand cmdInsHK = new SqlCommand("INSERT INTO HanhKhach (CCCD, HoTen, SoDienThoai) VALUES (@CCCD, @HoTen, @SDT); SELECT SCOPE_IDENTITY();", conn, trans);
                        cmdInsHK.Parameters.AddWithValue("@CCCD", cccd);
                        cmdInsHK.Parameters.AddWithValue("@HoTen", hoTen);
                        cmdInsHK.Parameters.AddWithValue("@SDT", sdt);
                        maHK = Convert.ToInt32(cmdInsHK.ExecuteScalar());
                    }

                    // 2. Thêm vé tàu mới
                    string sqlVe = "INSERT INTO Ve (MaChuyen, MaHK, MaGaDi, MaGaDen, LoaiVe, GiaVe, NgayMua, TrangThai) " +
                                   "VALUES (@MaChuyen, @MaHK, @MaGaDi, @MaGaDen, @LoaiVe, @GiaVe, GETDATE(), N'Đã thanh toán'); " +
                                   "SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdVe = new SqlCommand(sqlVe, conn, trans);
                    cmdVe.Parameters.AddWithValue("@MaChuyen", maChuyen);
                    cmdVe.Parameters.AddWithValue("@MaHK", maHK);
                    cmdVe.Parameters.AddWithValue("@MaGaDi", maGaDi);
                    cmdVe.Parameters.AddWithValue("@MaGaDen", maGaDen);
                    cmdVe.Parameters.AddWithValue("@LoaiVe", loaiVe);
                    cmdVe.Parameters.AddWithValue("@GiaVe", giaVe);

                    int maVeMoi = Convert.ToInt32(cmdVe.ExecuteScalar());

                    trans.Commit();

                    InVeXacNhan(maVeMoi, hoTen, cccd, loaiVe, giaVe);
                    LamMoiGiaoDich();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Giao dịch bán vé thất bại: " + ex.Message, "Lỗi giao dịch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InVeXacNhan(int maVe, string hoTen, string cccd, string loaiVe, decimal giaVe)
        {
            string gaDiText = cboGaDi.Text;
            string gaDenText = cboGaDen.Text;
            string chuyenText = cboChuyenTau.Text;

            string bill = "========================================\n" +
                          "       VÉ TÀU ĐIỆN SUBWAY METRO         \n" +
                          "========================================\n" +
                          "MÃ VÉ: #" + maVe + "\n" +
                          "Hành khách: " + hoTen + "\n" +
                          "CCCD: " + cccd + "\n" +
                          "Chuyến: " + chuyenText + "\n" +
                          "Ga lên: " + gaDiText + "\n" +
                          "Ga xuống: " + gaDenText + "\n" +
                          "Loại vé: " + loaiVe + "\n" +
                          "Giá vé: " + giaVe.ToString("N0") + " VNĐ\n" +
                          "Thời gian in: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\n" +
                          "Trạng thái: ĐÃ THANH TOÁN (Hợp lệ)\n" +
                          "========================================\n" +
                          "   Chúc quý khách có một chuyến đi vui vẻ!  ";

            MessageBox.Show(bill, "XUẤT VÉ THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiGiaoDich();
        }

        private void LamMoiGiaoDich()
        {
            txtCCCD.Clear();
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            cboLoaiVe.SelectedIndex = 0;
            txtCCCD.Focus();
        }
    }
}
