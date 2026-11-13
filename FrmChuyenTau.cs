using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTau
{
    public partial class FrmChuyenTau : Form
    {
        private int _maTauHienTai = 0;

        public FrmChuyenTau()
        {
            InitializeComponent();
        }

        private void FrmChuyenTau_Load(object sender, EventArgs e)
        {
            dtpLocNgay.Value = DateTime.Today;
            cboLocTrangThai.SelectedIndex = 0;
            LoadDanhSachLaiTau();
            KiemTraPhanQuyenLaiTau();
            LoadDanhSachChuyenTau();
        }

        private void KiemTraPhanQuyenLaiTau()
        {
            if (Ketnoi_CSDL.NguoiDungHienTai.VaiTro == "LaiTau")
            {
                btnPhanCongLaiTau.Enabled = false;
                btnHuyChuyen.Enabled = false;
                cboLaiTau.Enabled = false;
                this.Text = "Lịch Trình Chuyến Tàu Phân Công Cho Lái Tàu";
            }
        }

        private void LoadDanhSachLaiTau()
        {
            string sql = "SELECT MaNV, HoTen + ' (' + SoDienThoai + ')' AS HoTenPhone " +
                         "FROM NhanVien " +
                         "WHERE VaiTro = 'LaiTau' AND TrangThai = N'Hoạt động' " +
                         "ORDER BY HoTen ASC";
            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql);
            cboLaiTau.DataSource = dt;
            cboLaiTau.DisplayMember = "HoTenPhone";
            cboLaiTau.ValueMember = "MaNV";
        }

        private void LoadDanhSachChuyenTau()
        {
            DateTime ngayChon = dtpLocNgay.Value.Date;
            string trangThaiLoc = cboLocTrangThai.SelectedItem != null ? cboLocTrangThai.SelectedItem.ToString() : "Tất cả trạng thái";

            string sql = "SELECT ct.MaChuyen AS [Mã Chuyến], " +
                         "ty.TenTuyen AS [Tuyến Tàu], " +
                         "t.TenTau AS [Đoàn Tàu], " +
                         "ISNULL(nv.HoTen, N'-- Chưa phân công --') AS [Lái Tàu], " +
                         "CONVERT(VARCHAR(10), ct.NgayChay, 103) AS [Ngày Chạy], " +
                         "CONVERT(VARCHAR(5), ct.GioKhoiHanh, 108) AS [Giờ Khởi Hành], " +
                         "CONVERT(VARCHAR(5), ct.GioDen, 108) AS [Giờ Đến], " +
                         "ct.TrangThai AS [Trạng Thái], " +
                         "(SELECT COUNT(*) FROM Ve v WHERE v.MaChuyen = ct.MaChuyen AND v.TrangThai = N'Đã thanh toán') AS [Vé Đã Bán], " +
                         "ct.MaTau, ct.MaLaiTau, ct.MaLichTrinh " +
                         "FROM ChuyenTau ct " +
                         "JOIN Tau t ON ct.MaTau = t.MaTau " +
                         "LEFT JOIN Tuyen ty ON t.MaTuyen = ty.MaTuyen " +
                         "LEFT JOIN NhanVien nv ON ct.MaLaiTau = nv.MaNV " +
                         "WHERE ct.NgayChay = @NgayChay ";

            List<SqlParameter> pList = new List<SqlParameter>();
            pList.Add(new SqlParameter("@NgayChay", ngayChon));

            // Nếu người dùng là Lái tàu thì chỉ lọc các chuyến của lái tàu này
            if (Ketnoi_CSDL.NguoiDungHienTai.VaiTro == "LaiTau")
            {
                sql += "AND ct.MaLaiTau = @MaLaiTau ";
                pList.Add(new SqlParameter("@MaLaiTau", Ketnoi_CSDL.NguoiDungHienTai.MaNV));
            }

            if (trangThaiLoc != "Tất cả trạng thái")
            {
                sql += "AND ct.TrangThai = @TrangThai ";
                pList.Add(new SqlParameter("@TrangThai", trangThaiLoc));
            }

            sql += "ORDER BY ct.GioKhoiHanh ASC";

            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql, pList.ToArray());
            dgvChuyenTau.DataSource = dt;

            if (dgvChuyenTau.Columns.Contains("MaTau")) dgvChuyenTau.Columns["MaTau"].Visible = false;
            if (dgvChuyenTau.Columns.Contains("MaLaiTau")) dgvChuyenTau.Columns["MaLaiTau"].Visible = false;
            if (dgvChuyenTau.Columns.Contains("MaLichTrinh")) dgvChuyenTau.Columns["MaLichTrinh"].Visible = false;

            if (dgvChuyenTau.Columns.Contains("Mã Chuyến"))
            {
                dgvChuyenTau.Columns["Mã Chuyến"].Width = 85;
                dgvChuyenTau.Columns["Trạng Thái"].Width = 110;
                dgvChuyenTau.Columns["Vé Đã Bán"].Width = 90;
            }
        }

        private void dgvChuyenTau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvChuyenTau.Rows.Count)
            {
                DataGridViewRow r = dgvChuyenTau.Rows[e.RowIndex];
                txtMaChuyen.Text = r.Cells["Mã Chuyến"].Value != null ? r.Cells["Mã Chuyến"].Value.ToString() : "";

                string tenTuyen = r.Cells["Tuyến Tàu"].Value != null ? r.Cells["Tuyến Tàu"].Value.ToString() : "";
                string tenTau = r.Cells["Đoàn Tàu"].Value != null ? r.Cells["Đoàn Tàu"].Value.ToString() : "";
                string gioDi = r.Cells["Giờ Khởi Hành"].Value != null ? r.Cells["Giờ Khởi Hành"].Value.ToString() : "";
                string gioDen = r.Cells["Giờ Đến"].Value != null ? r.Cells["Giờ Đến"].Value.ToString() : "";
                string tt = r.Cells["Trạng Thái"].Value != null ? r.Cells["Trạng Thái"].Value.ToString() : "";

                lblThongTinChuyen.Text = string.Format("Chuyến #{0}: {1} | Tàu: {2} | Giờ: {3} - {4} | TT: {5}",
                    txtMaChuyen.Text, tenTuyen, tenTau, gioDi, gioDen, tt);

                if (r.Cells["MaTau"].Value != DBNull.Value && r.Cells["MaTau"].Value != null)
                {
                    _maTauHienTai = Convert.ToInt32(r.Cells["MaTau"].Value);
                }

                if (r.Cells["MaLaiTau"].Value != DBNull.Value && r.Cells["MaLaiTau"].Value != null)
                {
                    cboLaiTau.SelectedValue = Convert.ToInt32(r.Cells["MaLaiTau"].Value);
                }
            }
        }

        private void btnPhanCongLaiTau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaChuyen.Text))
            {
                MessageBox.Show("Vui lòng chọn chuyến tàu cần phân công lái tàu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboLaiTau.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên lái tàu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maChuyen = Convert.ToInt32(txtMaChuyen.Text);
            int maLaiTau = Convert.ToInt32(cboLaiTau.SelectedValue);

            string sql = "UPDATE ChuyenTau SET MaLaiTau = @MaLaiTau WHERE MaChuyen = @MaChuyen";
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@MaLaiTau", maLaiTau),
                new SqlParameter("@MaChuyen", maChuyen)
            };

            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
            if (kq > 0)
            {
                MessageBox.Show("Phân công lái tàu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachChuyenTau();
            }
        }

        private void btnBatDauChay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaChuyen.Text))
            {
                MessageBox.Show("Vui lòng chọn chuyến tàu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maChuyen = Convert.ToInt32(txtMaChuyen.Text);

            string sql = "UPDATE ChuyenTau SET TrangThai = N'Đang chạy' WHERE MaChuyen = @MaChuyen";
            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, new SqlParameter[] { new SqlParameter("@MaChuyen", maChuyen) });

            if (kq > 0)
            {
                if (_maTauHienTai > 0)
                {
                    Ketnoi_CSDL.ExecuteNonQuery("UPDATE Tau SET TrangThai = N'Đang chạy' WHERE MaTau = @MaTau",
                        new SqlParameter[] { new SqlParameter("@MaTau", _maTauHienTai) });
                }
                MessageBox.Show("Đã cập nhật chuyến tàu sang trạng thái: 'Đang chạy'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachChuyenTau();
            }
        }

        private void btnHoanThanhChuyen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaChuyen.Text))
            {
                MessageBox.Show("Vui lòng chọn chuyến tàu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maChuyen = Convert.ToInt32(txtMaChuyen.Text);

            string sql = "UPDATE ChuyenTau SET TrangThai = N'Hoàn thành' WHERE MaChuyen = @MaChuyen";
            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, new SqlParameter[] { new SqlParameter("@MaChuyen", maChuyen) });

            if (kq > 0)
            {
                if (_maTauHienTai > 0)
                {
                    Ketnoi_CSDL.ExecuteNonQuery("UPDATE Tau SET TrangThai = N'Sẵn sàng' WHERE MaTau = @MaTau",
                        new SqlParameter[] { new SqlParameter("@MaTau", _maTauHienTai) });
                }
                MessageBox.Show("Chuyến tàu đã hoàn thành lộ trình!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachChuyenTau();
            }
        }

        private void btnHuyChuyen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaChuyen.Text))
            {
                MessageBox.Show("Vui lòng chọn chuyến tàu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maChuyen = Convert.ToInt32(txtMaChuyen.Text);

            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn hủy chuyến tàu này không?",
                "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                string sql = "UPDATE ChuyenTau SET TrangThai = N'Hủy' WHERE MaChuyen = @MaChuyen";
                int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, new SqlParameter[] { new SqlParameter("@MaChuyen", maChuyen) });

                if (kq > 0)
                {
                    if (_maTauHienTai > 0)
                    {
                        Ketnoi_CSDL.ExecuteNonQuery("UPDATE Tau SET TrangThai = N'Sẵn sàng' WHERE MaTau = @MaTau",
                            new SqlParameter[] { new SqlParameter("@MaTau", _maTauHienTai) });
                    }
                    MessageBox.Show("Đã hủy chuyến tàu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachChuyenTau();
                }
            }
        }

        private void dtpLocNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSachChuyenTau();
        }

        private void cboLocTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachChuyenTau();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadDanhSachChuyenTau();
        }

        private void btnHomNay_Click(object sender, EventArgs e)
        {
            dtpLocNgay.Value = DateTime.Today;
        }

        private void btnNgayMai_Click(object sender, EventArgs e)
        {
            dtpLocNgay.Value = DateTime.Today.AddDays(1);
        }
    }
}
