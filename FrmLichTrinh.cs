using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTau
{
    public partial class FrmLichTrinh : Form
    {
        public FrmLichTrinh()
        {
            InitializeComponent();
        }

        private void FrmLichTrinh_Load(object sender, EventArgs e)
        {
            LoadDanhSachTuyen();
            LoadDanhSachTau();
            dtpNgaySinhChuyen.Value = DateTime.Today;
            dtpGioKhoiHanh.Value = DateTime.Today.AddHours(7);
            dtpGioKetThuc.Value = DateTime.Today.AddHours(7).AddMinutes(45);
            LoadDanhSachLichTrinh();
        }

        private void LoadDanhSachTuyen()
        {
            string sql = "SELECT MaTuyen, TenTuyen FROM Tuyen WHERE TrangThai = N'Hoạt động' ORDER BY MaTuyen ASC";
            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql);
            cboTuyen.DataSource = dt;
            cboTuyen.DisplayMember = "TenTuyen";
            cboTuyen.ValueMember = "MaTuyen";
        }

        private void LoadDanhSachTau()
        {
            int maTuyen = 0;
            if (cboTuyen.SelectedValue != null && !(cboTuyen.SelectedValue is DataRowView))
            {
                maTuyen = Convert.ToInt32(cboTuyen.SelectedValue);
            }

            string sql = "SELECT MaTau, TenTau FROM Tau ";
            SqlParameter[] p = null;
            if (maTuyen > 0)
            {
                sql += "WHERE MaTuyen = @MaTuyen ";
                p = new SqlParameter[] { new SqlParameter("@MaTuyen", maTuyen) };
            }
            sql += "ORDER BY MaTau ASC";

            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql, p);
            cboTau.DataSource = dt;
            cboTau.DisplayMember = "TenTau";
            cboTau.ValueMember = "MaTau";
        }

        private void cboTuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachTau();
        }

        private void LoadDanhSachLichTrinh()
        {
            string sql = "SELECT lt.MaLichTrinh AS [Mã Lịch Trình], " +
                         "ty.TenTuyen AS [Tuyến Tàu], " +
                         "t.TenTau AS [Đoàn Tàu], " +
                         "CONVERT(VARCHAR(5), lt.GioKhoiHanh, 108) AS [Giờ Khởi Hành], " +
                         "CONVERT(VARCHAR(5), lt.GioKetThuc, 108) AS [Giờ Kết Thúc], " +
                         "lt.NgayTrongTuan AS [Ngày Chạy Trong Tuần], " +
                         "lt.MaTuyen, lt.MaTau, " +
                         "lt.GioKhoiHanh, lt.GioKetThuc " +
                         "FROM LichTrinh lt " +
                         "JOIN Tuyen ty ON lt.MaTuyen = ty.MaTuyen " +
                         "JOIN Tau t ON lt.MaTau = t.MaTau " +
                         "ORDER BY lt.MaLichTrinh ASC";

            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql);
            dgvLichTrinh.DataSource = dt;

            if (dgvLichTrinh.Columns.Contains("MaTuyen")) dgvLichTrinh.Columns["MaTuyen"].Visible = false;
            if (dgvLichTrinh.Columns.Contains("MaTau")) dgvLichTrinh.Columns["MaTau"].Visible = false;
            if (dgvLichTrinh.Columns.Contains("GioKhoiHanh")) dgvLichTrinh.Columns["GioKhoiHanh"].Visible = false;
            if (dgvLichTrinh.Columns.Contains("GioKetThuc")) dgvLichTrinh.Columns["GioKetThuc"].Visible = false;

            if (dgvLichTrinh.Columns.Contains("Mã Lịch Trình"))
            {
                dgvLichTrinh.Columns["Mã Lịch Trình"].Width = 90;
                dgvLichTrinh.Columns["Giờ Khởi Hành"].Width = 110;
                dgvLichTrinh.Columns["Giờ Kết Thúc"].Width = 110;
            }
        }

        private void dgvLichTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLichTrinh.Rows.Count)
            {
                DataGridViewRow r = dgvLichTrinh.Rows[e.RowIndex];
                txtMaLichTrinh.Text = r.Cells["Mã Lịch Trình"].Value != null ? r.Cells["Mã Lịch Trình"].Value.ToString() : "";

                if (r.Cells["MaTuyen"].Value != DBNull.Value && r.Cells["MaTuyen"].Value != null)
                {
                    cboTuyen.SelectedValue = Convert.ToInt32(r.Cells["MaTuyen"].Value);
                }

                if (r.Cells["MaTau"].Value != DBNull.Value && r.Cells["MaTau"].Value != null)
                {
                    cboTau.SelectedValue = Convert.ToInt32(r.Cells["MaTau"].Value);
                }

                if (r.Cells["GioKhoiHanh"].Value != DBNull.Value && r.Cells["GioKhoiHanh"].Value != null)
                {
                    TimeSpan ts = (TimeSpan)r.Cells["GioKhoiHanh"].Value;
                    dtpGioKhoiHanh.Value = DateTime.Today.Add(ts);
                }

                if (r.Cells["GioKetThuc"].Value != DBNull.Value && r.Cells["GioKetThuc"].Value != null)
                {
                    TimeSpan ts = (TimeSpan)r.Cells["GioKetThuc"].Value;
                    dtpGioKetThuc.Value = DateTime.Today.Add(ts);
                }

                string ngayTuan = r.Cells["Ngày Chạy Trong Tuần"].Value != null ? r.Cells["Ngày Chạy Trong Tuần"].Value.ToString() : "";
                chkT2.Checked = ngayTuan.Contains("T2");
                chkT3.Checked = ngayTuan.Contains("T3");
                chkT4.Checked = ngayTuan.Contains("T4");
                chkT5.Checked = ngayTuan.Contains("T5");
                chkT6.Checked = ngayTuan.Contains("T6");
                chkT7.Checked = ngayTuan.Contains("T7");
                chkCN.Checked = ngayTuan.Contains("CN");
            }
        }

        private string LayChuoiNgayTrongTuan()
        {
            List<string> days = new List<string>();
            if (chkT2.Checked) days.Add("T2");
            if (chkT3.Checked) days.Add("T3");
            if (chkT4.Checked) days.Add("T4");
            if (chkT5.Checked) days.Add("T5");
            if (chkT6.Checked) days.Add("T6");
            if (chkT7.Checked) days.Add("T7");
            if (chkCN.Checked) days.Add("CN");
            return string.Join(",", days.ToArray());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboTuyen.SelectedValue == null || cboTau.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tuyến tàu và đoàn tàu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ngayTuan = LayChuoiNgayTrongTuan();
            if (string.IsNullOrEmpty(ngayTuan))
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ngày chạy trong tuần!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maTuyen = Convert.ToInt32(cboTuyen.SelectedValue);
            int maTau = Convert.ToInt32(cboTau.SelectedValue);
            TimeSpan gioDi = dtpGioKhoiHanh.Value.TimeOfDay;
            TimeSpan gioDen = dtpGioKetThuc.Value.TimeOfDay;

            string sql = "INSERT INTO LichTrinh (MaTuyen, MaTau, GioKhoiHanh, GioKetThuc, NgayTrongTuan) " +
                         "VALUES (@MaTuyen, @MaTau, @GioKhoiHanh, @GioKetThuc, @NgayTrongTuan)";

            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@MaTuyen", maTuyen),
                new SqlParameter("@MaTau", maTau),
                new SqlParameter("@GioKhoiHanh", gioDi),
                new SqlParameter("@GioKetThuc", gioDen),
                new SqlParameter("@NgayTrongTuan", ngayTuan)
            };

            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
            if (kq > 0)
            {
                MessageBox.Show("Thêm lịch trình định kỳ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();
                LoadDanhSachLichTrinh();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLichTrinh.Text))
            {
                MessageBox.Show("Vui lòng chọn lịch trình cần cập nhật từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ngayTuan = LayChuoiNgayTrongTuan();
            if (string.IsNullOrEmpty(ngayTuan))
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ngày chạy trong tuần!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maLT = Convert.ToInt32(txtMaLichTrinh.Text);
            int maTuyen = Convert.ToInt32(cboTuyen.SelectedValue);
            int maTau = Convert.ToInt32(cboTau.SelectedValue);
            TimeSpan gioDi = dtpGioKhoiHanh.Value.TimeOfDay;
            TimeSpan gioDen = dtpGioKetThuc.Value.TimeOfDay;

            string sql = "UPDATE LichTrinh SET MaTuyen = @MaTuyen, MaTau = @MaTau, GioKhoiHanh = @GioKhoiHanh, " +
                         "GioKetThuc = @GioKetThuc, NgayTrongTuan = @NgayTrongTuan WHERE MaLichTrinh = @MaLichTrinh";

            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@MaTuyen", maTuyen),
                new SqlParameter("@MaTau", maTau),
                new SqlParameter("@GioKhoiHanh", gioDi),
                new SqlParameter("@GioKetThuc", gioDen),
                new SqlParameter("@NgayTrongTuan", ngayTuan),
                new SqlParameter("@MaLichTrinh", maLT)
            };

            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật lịch trình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachLichTrinh();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLichTrinh.Text))
            {
                MessageBox.Show("Vui lòng chọn lịch trình cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maLT = Convert.ToInt32(txtMaLichTrinh.Text);

            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa cấu hình lịch trình #" + maLT + " không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                string sql = "DELETE FROM LichTrinh WHERE MaLichTrinh = @MaLichTrinh";
                SqlParameter[] p = new SqlParameter[] { new SqlParameter("@MaLichTrinh", maLT) };

                int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
                if (kq > 0)
                {
                    MessageBox.Show("Đã xóa lịch trình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoi();
                    LoadDanhSachLichTrinh();
                }
            }
        }

        private void btnSinhChuyen_Click(object sender, EventArgs e)
        {
            DateTime ngayChon = dtpNgaySinhChuyen.Value.Date;

            DialogResult res = MessageBox.Show("Hệ thống sẽ tự động sinh các chuyến tàu cho ngày: " + ngayChon.ToString("dd/MM/yyyy") +
                " dựa trên các lịch trình định kỳ tương ứng. Bạn có muốn tiếp tục?", "Xác nhận sinh chuyến", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res != DialogResult.Yes) return;

            // Thử gọi sp_SinhChuyen nếu có
            try
            {
                SqlParameter[] spP = new SqlParameter[] { new SqlParameter("@NgayChay", ngayChon) };
                DataTable dtSP = Ketnoi_CSDL.ExecuteProcedure("sp_SinhChuyen", spP);
                if (dtSP != null)
                {
                    MessageBox.Show("Đã sinh chuyến thành công qua thủ tục sp_SinhChuyen!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch { }

            // Fallback C# logic sinh chuyến tự động
            // Xác định mã thứ
            string maThu = "";
            switch (ngayChon.DayOfWeek)
            {
                case DayOfWeek.Monday: maThu = "T2"; break;
                case DayOfWeek.Tuesday: maThu = "T3"; break;
                case DayOfWeek.Wednesday: maThu = "T4"; break;
                case DayOfWeek.Thursday: maThu = "T5"; break;
                case DayOfWeek.Friday: maThu = "T6"; break;
                case DayOfWeek.Saturday: maThu = "T7"; break;
                case DayOfWeek.Sunday: maThu = "CN"; break;
            }

            string sqlLT = "SELECT MaLichTrinh, MaTau, GioKhoiHanh, GioKetThuc FROM LichTrinh WHERE NgayTrongTuan LIKE @Thu";
            DataTable dtLT = Ketnoi_CSDL.ExecuteQuery(sqlLT, new SqlParameter[] { new SqlParameter("@Thu", "%" + maThu + "%") });

            if (dtLT == null || dtLT.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy lịch trình định kỳ nào áp dụng cho ngày " + maThu + " (" + ngayChon.ToString("dd/MM/yyyy") + ")!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int soChuyenTaoMoi = 0;
            int soChuyenDaCo = 0;

            foreach (DataRow r in dtLT.Rows)
            {
                int maLT = Convert.ToInt32(r["MaLichTrinh"]);
                int maTau = Convert.ToInt32(r["MaTau"]);
                TimeSpan gioDi = (TimeSpan)r["GioKhoiHanh"];
                TimeSpan gioDen = (TimeSpan)r["GioKetThuc"];

                // Kiểm tra xem chuyến tàu của lịch trình này ngày hôm đó đã tạo chưa
                object check = Ketnoi_CSDL.ExecuteScalar("SELECT COUNT(*) FROM ChuyenTau WHERE MaLichTrinh = @MaLT AND NgayChay = @NgayChay",
                    new SqlParameter[] { new SqlParameter("@MaLT", maLT), new SqlParameter("@NgayChay", ngayChon) });

                if (check != null && Convert.ToInt32(check) > 0)
                {
                    soChuyenDaCo++;
                }
                else
                {
                    string sqlInsert = "INSERT INTO ChuyenTau (MaLichTrinh, MaTau, MaLaiTau, NgayChay, GioKhoiHanh, GioDen, TrangThai) " +
                                       "VALUES (@MaLT, @MaTau, NULL, @NgayChay, @GioKhoiHanh, @GioDen, N'Chờ chạy')";
                    SqlParameter[] pIns = new SqlParameter[]
                    {
                        new SqlParameter("@MaLT", maLT),
                        new SqlParameter("@MaTau", maTau),
                        new SqlParameter("@NgayChay", ngayChon),
                        new SqlParameter("@GioKhoiHanh", gioDi),
                        new SqlParameter("@GioDen", gioDen)
                    };
                    int kq = Ketnoi_CSDL.ExecuteNonQuery(sqlInsert, pIns);
                    if (kq > 0) soChuyenTaoMoi++;
                }
            }

            MessageBox.Show(string.Format("Hoàn tất sinh chuyến cho ngày {0} ({1}):\n- Số chuyến tạo mới: {2}\n- Số chuyến đã tồn tại trước đó: {3}",
                ngayChon.ToString("dd/MM/yyyy"), maThu, soChuyenTaoMoi, soChuyenDaCo),
                "Kết quả sinh chuyến", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXemChuyenTau_Click(object sender, EventArgs e)
        {
            FrmChuyenTau f = new FrmChuyenTau();
            f.ShowDialog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDanhSachLichTrinh();
        }

        private void LamMoi()
        {
            txtMaLichTrinh.Clear();
            chkT2.Checked = true;
            chkT3.Checked = true;
            chkT4.Checked = true;
            chkT5.Checked = true;
            chkT6.Checked = true;
            chkT7.Checked = true;
            chkCN.Checked = true;
        }
    }
}
