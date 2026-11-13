using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTau
{
    public partial class FrmHanhKhach : Form
    {
        private int _maHKDangChon = 0;

        public FrmHanhKhach()
        {
            InitializeComponent();
        }

        private void FrmHanhKhach_Load(object sender, EventArgs e)
        {
            LoadDanhSachHanhKhach();
        }

        private void LoadDanhSachHanhKhach(string keyword = "")
        {
            string sql = "SELECT hk.MaHK AS [Mã HK], " +
                         "hk.CCCD AS [Số CCCD/CMND], " +
                         "hk.HoTen AS [Họ Và Tên], " +
                         "ISNULL(hk.SoDienThoai, '') AS [Số Điện Thoại], " +
                         "(SELECT COUNT(*) FROM Ve v WHERE v.MaHK = hk.MaHK) AS [Tổng Số Vé Đã Mua], " +
                         "(SELECT ISNULL(SUM(v.GiaVe), 0) FROM Ve v WHERE v.MaHK = hk.MaHK AND v.TrangThai = N'Đã thanh toán') AS [Tổng Chi Tiêu (VNĐ)] " +
                         "FROM HanhKhach hk ";

            SqlParameter[] p = null;
            if (!string.IsNullOrEmpty(keyword))
            {
                sql += "WHERE hk.HoTen LIKE @kw OR hk.CCCD LIKE @kw OR hk.SoDienThoai LIKE @kw ";
                p = new SqlParameter[] { new SqlParameter("@kw", "%" + keyword + "%") };
            }

            sql += "ORDER BY hk.MaHK ASC";

            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql, p);
            dgvHanhKhach.DataSource = dt;

            if (dgvHanhKhach.Columns.Contains("Mã HK"))
            {
                dgvHanhKhach.Columns["Mã HK"].Width = 80;
                dgvHanhKhach.Columns["Số CCCD/CMND"].Width = 140;
                dgvHanhKhach.Columns["Họ Và Tên"].Width = 180;
                dgvHanhKhach.Columns["Tổng Số Vé Đã Mua"].Width = 140;
                dgvHanhKhach.Columns["Tổng Chi Tiêu (VNĐ)"].DefaultCellStyle.Format = "N0";
            }
        }

        private void dgvHanhKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvHanhKhach.Rows.Count)
            {
                DataGridViewRow r = dgvHanhKhach.Rows[e.RowIndex];
                _maHKDangChon = Convert.ToInt32(r.Cells["Mã HK"].Value);
                txtMaHK.Text = _maHKDangChon.ToString();
                txtCCCD.Text = r.Cells["Số CCCD/CMND"].Value != null ? r.Cells["Số CCCD/CMND"].Value.ToString() : "";
                txtHoTen.Text = r.Cells["Họ Và Tên"].Value != null ? r.Cells["Họ Và Tên"].Value.ToString() : "";
                txtSoDienThoai.Text = r.Cells["Số Điện Thoại"].Value != null ? r.Cells["Số Điện Thoại"].Value.ToString() : "";

                grpLichSuVe.Text = string.Format("Lịch Sử Vé Của Hành Khách: {0} (CCCD: {1})", txtHoTen.Text, txtCCCD.Text);
                LoadLichSuVeCuaKhach(_maHKDangChon);
            }
        }

        private void LoadLichSuVeCuaKhach(int maHK)
        {
            string sql = "SELECT v.MaVe AS [Mã Vé], " +
                         "v.MaChuyen AS [Chuyến #], " +
                         "ISNULL(ty.TenTuyen, N'---') AS [Tuyến Tàu], " +
                         "gDi.TenGa AS [Ga Đi], " +
                         "gDen.TenGa AS [Ga Đến], " +
                         "v.LoaiVe AS [Loại Vé], " +
                         "v.GiaVe AS [Giá Vé (VNĐ)], " +
                         "v.NgayMua AS [Thời Gian Mua], " +
                         "v.TrangThai AS [Trạng Thái] " +
                         "FROM Ve v " +
                         "JOIN ChuyenTau ct ON v.MaChuyen = ct.MaChuyen " +
                         "JOIN Tau t ON ct.MaTau = t.MaTau " +
                         "LEFT JOIN Tuyen ty ON t.MaTuyen = ty.MaTuyen " +
                         "JOIN Ga gDi ON v.MaGaDi = gDi.MaGa " +
                         "JOIN Ga gDen ON v.MaGaDen = gDen.MaGa " +
                         "WHERE v.MaHK = @MaHK " +
                         "ORDER BY v.MaVe DESC";

            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql, new SqlParameter[] { new SqlParameter("@MaHK", maHK) });
            dgvLichSuVe.DataSource = dt;

            if (dgvLichSuVe.Columns.Contains("Mã Vé"))
            {
                dgvLichSuVe.Columns["Mã Vé"].Width = 80;
                dgvLichSuVe.Columns["Giá Vé (VNĐ)"].DefaultCellStyle.Format = "N0";
                dgvLichSuVe.Columns["Thời Gian Mua"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string cccd = txtCCCD.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();

            if (string.IsNullOrEmpty(cccd) || string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số CCCD và họ tên hành khách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCCCD.Focus();
                return;
            }

            object check = Ketnoi_CSDL.ExecuteScalar("SELECT COUNT(*) FROM HanhKhach WHERE CCCD = @CCCD",
                new SqlParameter[] { new SqlParameter("@CCCD", cccd) });

            if (check != null && Convert.ToInt32(check) > 0)
            {
                MessageBox.Show("Số CCCD này đã tồn tại trong hệ thống!", "Trùng CCCD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "INSERT INTO HanhKhach (CCCD, HoTen, SoDienThoai) VALUES (@CCCD, @HoTen, @SDT)";
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@CCCD", cccd),
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@SDT", sdt)
            };

            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
            if (kq > 0)
            {
                MessageBox.Show("Thêm hành khách mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();
                LoadDanhSachHanhKhach();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHK.Text))
            {
                MessageBox.Show("Vui lòng chọn hành khách cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maHK = Convert.ToInt32(txtMaHK.Text);
            string cccd = txtCCCD.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();

            if (string.IsNullOrEmpty(cccd) || string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số CCCD và họ tên hành khách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng CCCD với người khác
            object check = Ketnoi_CSDL.ExecuteScalar("SELECT COUNT(*) FROM HanhKhach WHERE CCCD = @CCCD AND MaHK <> @MaHK",
                new SqlParameter[] { new SqlParameter("@CCCD", cccd), new SqlParameter("@MaHK", maHK) });

            if (check != null && Convert.ToInt32(check) > 0)
            {
                MessageBox.Show("Số CCCD này đã thuộc về hành khách khác!", "Trùng CCCD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "UPDATE HanhKhach SET CCCD = @CCCD, HoTen = @HoTen, SoDienThoai = @SDT WHERE MaHK = @MaHK";
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@CCCD", cccd),
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@SDT", sdt),
                new SqlParameter("@MaHK", maHK)
            };

            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật thông tin hành khách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachHanhKhach();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHK.Text))
            {
                MessageBox.Show("Vui lòng chọn hành khách cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maHK = Convert.ToInt32(txtMaHK.Text);

            // Kiểm tra xem hành khách đã từng mua vé chưa
            object checkVe = Ketnoi_CSDL.ExecuteScalar("SELECT COUNT(*) FROM Ve WHERE MaHK = @MaHK",
                new SqlParameter[] { new SqlParameter("@MaHK", maHK) });

            if (checkVe != null && Convert.ToInt32(checkVe) > 0)
            {
                MessageBox.Show("Không thể xóa hành khách này vì đã có dữ liệu vé tàu trong lịch sử bán vé!",
                    "Chặn xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa hành khách này không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                int kq = Ketnoi_CSDL.ExecuteNonQuery("DELETE FROM HanhKhach WHERE MaHK = @MaHK",
                    new SqlParameter[] { new SqlParameter("@MaHK", maHK) });
                if (kq > 0)
                {
                    MessageBox.Show("Đã xóa hành khách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoi();
                    LoadDanhSachHanhKhach();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDanhSachHanhKhach(txtTimKiem.Text.Trim());
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDanhSachHanhKhach();
        }

        private void LamMoi()
        {
            txtMaHK.Clear();
            txtCCCD.Clear();
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtTimKiem.Clear();
            _maHKDangChon = 0;
            dgvLichSuVe.DataSource = null;
            grpLichSuVe.Text = "Lịch Sử Toàn Bộ Các Vé Đã Mua Của Hành Khách Đang Chọn";
            txtCCCD.Focus();
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
