using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTau
{
    public partial class FrmBaoTri : Form
    {
        public FrmBaoTri()
        {
            InitializeComponent();
        }

        private void FrmBaoTri_Load(object sender, EventArgs e)
        {
            LoadDanhSachTau();
            LoadDanhSachNhanVien();
            cboLocTrangThai.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayHoanThanh.Checked = false;
            LoadDanhSachBaoTri();
        }

        private void LoadDanhSachTau()
        {
            string sql = "SELECT MaTau, TenTau FROM Tau ORDER BY MaTau ASC";
            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql);

            cboTau.DataSource = dt.Copy();
            cboTau.DisplayMember = "TenTau";
            cboTau.ValueMember = "MaTau";

            DataTable dtLoc = dt.Copy();
            DataRow rAll = dtLoc.NewRow();
            rAll["MaTau"] = 0;
            rAll["TenTau"] = "--- Tất cả các tàu ---";
            dtLoc.Rows.InsertAt(rAll, 0);

            cboLocTau.DataSource = dtLoc;
            cboLocTau.DisplayMember = "TenTau";
            cboLocTau.ValueMember = "MaTau";
            cboLocTau.SelectedIndex = 0;
        }

        private void LoadDanhSachNhanVien()
        {
            // Lấy kỹ thuật viên hoặc tất cả nhân viên
            string sql = "SELECT MaNV, HoTen + ' (' + VaiTro + ')' AS HoTenRole FROM NhanVien WHERE TrangThai = N'Hoạt động' ORDER BY HoTen ASC";
            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql);
            cboNhanVien.DataSource = dt;
            cboNhanVien.DisplayMember = "HoTenRole";
            cboNhanVien.ValueMember = "MaNV";
        }

        private void LoadDanhSachBaoTri()
        {
            string trangThaiLoc = cboLocTrangThai.SelectedItem != null ? cboLocTrangThai.SelectedItem.ToString() : "Tất cả trạng thái";
            int maTauLoc = 0;
            if (cboLocTau.SelectedValue != null && !(cboLocTau.SelectedValue is DataRowView))
            {
                maTauLoc = Convert.ToInt32(cboLocTau.SelectedValue);
            }

            string sql = "SELECT bt.MaBaoTri AS [Mã Lệnh], " +
                         "t.TenTau AS [Đoàn Tàu], " +
                         "ISNULL(nv.HoTen, N'Chưa phân công') AS [Kỹ Thuật Viên], " +
                         "bt.NgayBatDau AS [Ngày Bắt Đầu], " +
                         "bt.NgayHoanThanh AS [Ngày Hoàn Thành], " +
                         "bt.ChiPhi AS [Chi Phí (VNĐ)], " +
                         "bt.NoiDung AS [Nội Dung Bảo Trì], " +
                         "bt.TrangThai AS [Trạng Thái], " +
                         "bt.MaTau, bt.MaNV " +
                         "FROM BaoTri bt " +
                         "JOIN Tau t ON bt.MaTau = t.MaTau " +
                         "LEFT JOIN NhanVien nv ON bt.MaNV = nv.MaNV " +
                         "WHERE 1=1 ";

            List<SqlParameter> pList = new List<SqlParameter>();

            if (trangThaiLoc != "Tất cả trạng thái")
            {
                sql += "AND bt.TrangThai = @TrangThai ";
                pList.Add(new SqlParameter("@TrangThai", trangThaiLoc));
            }

            if (maTauLoc > 0)
            {
                sql += "AND bt.MaTau = @MaTau ";
                pList.Add(new SqlParameter("@MaTau", maTauLoc));
            }

            sql += "ORDER BY bt.MaBaoTri DESC";

            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql, pList.Count > 0 ? pList.ToArray() : null);
            dgvBaoTri.DataSource = dt;

            if (dgvBaoTri.Columns.Contains("MaTau")) dgvBaoTri.Columns["MaTau"].Visible = false;
            if (dgvBaoTri.Columns.Contains("MaNV")) dgvBaoTri.Columns["MaNV"].Visible = false;

            if (dgvBaoTri.Columns.Contains("Mã Lệnh"))
            {
                dgvBaoTri.Columns["Mã Lệnh"].Width = 80;
                dgvBaoTri.Columns["Trạng Thái"].Width = 110;
                dgvBaoTri.Columns["Chi Phí (VNĐ)"].DefaultCellStyle.Format = "N0";
            }
        }

        private void dgvBaoTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvBaoTri.Rows.Count)
            {
                DataGridViewRow r = dgvBaoTri.Rows[e.RowIndex];
                txtMaBaoTri.Text = r.Cells["Mã Lệnh"].Value != null ? r.Cells["Mã Lệnh"].Value.ToString() : "";

                if (r.Cells["MaTau"].Value != DBNull.Value && r.Cells["MaTau"].Value != null)
                {
                    cboTau.SelectedValue = Convert.ToInt32(r.Cells["MaTau"].Value);
                }

                if (r.Cells["MaNV"].Value != DBNull.Value && r.Cells["MaNV"].Value != null)
                {
                    cboNhanVien.SelectedValue = Convert.ToInt32(r.Cells["MaNV"].Value);
                }

                if (r.Cells["Ngày Bắt Đầu"].Value != DBNull.Value && r.Cells["Ngày Bắt Đầu"].Value != null)
                {
                    dtpNgayBatDau.Value = Convert.ToDateTime(r.Cells["Ngày Bắt Đầu"].Value);
                }

                if (r.Cells["Ngày Hoàn Thành"].Value != DBNull.Value && r.Cells["Ngày Hoàn Thành"].Value != null)
                {
                    dtpNgayHoanThanh.Checked = true;
                    dtpNgayHoanThanh.Value = Convert.ToDateTime(r.Cells["Ngày Hoàn Thành"].Value);
                }
                else
                {
                    dtpNgayHoanThanh.Checked = false;
                }

                decimal chiPhi = 0;
                if (r.Cells["Chi Phí (VNĐ)"].Value != DBNull.Value && r.Cells["Chi Phí (VNĐ)"].Value != null)
                {
                    chiPhi = Convert.ToDecimal(r.Cells["Chi Phí (VNĐ)"].Value);
                }
                numChiPhi.Value = chiPhi;

                txtNoiDung.Text = r.Cells["Nội Dung Bảo Trì"].Value != null ? r.Cells["Nội Dung Bảo Trì"].Value.ToString() : "";
                string tt = r.Cells["Trạng Thái"].Value != null ? r.Cells["Trạng Thái"].Value.ToString() : "Đang xử lý";
                cboTrangThai.SelectedItem = tt;
            }
        }

        private void btnTaoLenh_Click(object sender, EventArgs e)
        {
            if (cboTau.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đoàn tàu cần bảo trì!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maTau = Convert.ToInt32(cboTau.SelectedValue);
            int? maNV = null;
            if (cboNhanVien.SelectedValue != null)
            {
                maNV = Convert.ToInt32(cboNhanVien.SelectedValue);
            }

            DateTime ngayBD = dtpNgayBatDau.Value;
            string noiDung = txtNoiDung.Text.Trim();
            decimal chiPhi = numChiPhi.Value;

            if (string.IsNullOrEmpty(noiDung))
            {
                MessageBox.Show("Vui lòng nhập nội dung hoặc lý do bảo trì!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoiDung.Focus();
                return;
            }

            // Tạo lệnh bảo trì mới
            string sqlInsert = "INSERT INTO BaoTri (MaTau, MaNV, NgayBatDau, NgayHoanThanh, ChiPhi, NoiDung, TrangThai) " +
                               "VALUES (@MaTau, @MaNV, @NgayBatDau, NULL, @ChiPhi, @NoiDung, N'Đang xử lý')";
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@MaTau", maTau),
                new SqlParameter("@MaNV", (object)maNV ?? DBNull.Value),
                new SqlParameter("@NgayBatDau", ngayBD),
                new SqlParameter("@ChiPhi", chiPhi),
                new SqlParameter("@NoiDung", noiDung)
            };

            int kq = Ketnoi_CSDL.ExecuteNonQuery(sqlInsert, p);
            if (kq > 0)
            {
                // NGHIỆP VỤ: Tàu tự động chuyển trạng thái Bảo trì
                Ketnoi_CSDL.ExecuteNonQuery("UPDATE Tau SET TrangThai = N'Bảo trì' WHERE MaTau = @MaTau",
                    new SqlParameter[] { new SqlParameter("@MaTau", maTau) });

                MessageBox.Show("Tạo lệnh bảo trì thành công!\nTrạng thái tàu đã tự động chuyển sang: 'Bảo trì'.",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();
                LoadDanhSachBaoTri();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBaoTri.Text))
            {
                MessageBox.Show("Vui lòng chọn lệnh bảo trì cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maBaoTri = Convert.ToInt32(txtMaBaoTri.Text);
            int maTau = Convert.ToInt32(cboTau.SelectedValue);
            int? maNV = null;
            if (cboNhanVien.SelectedValue != null)
            {
                maNV = Convert.ToInt32(cboNhanVien.SelectedValue);
            }

            DateTime ngayBD = dtpNgayBatDau.Value;
            object ngayHT = dtpNgayHoanThanh.Checked ? (object)dtpNgayHoanThanh.Value : DBNull.Value;
            string noiDung = txtNoiDung.Text.Trim();
            decimal chiPhi = numChiPhi.Value;
            string trangThai = cboTrangThai.SelectedItem != null ? cboTrangThai.SelectedItem.ToString() : "Đang xử lý";

            string sql = "UPDATE BaoTri SET MaTau = @MaTau, MaNV = @MaNV, NgayBatDau = @NgayBatDau, " +
                         "NgayHoanThanh = @NgayHoanThanh, ChiPhi = @ChiPhi, NoiDung = @NoiDung, TrangThai = @TrangThai " +
                         "WHERE MaBaoTri = @MaBaoTri";

            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@MaTau", maTau),
                new SqlParameter("@MaNV", (object)maNV ?? DBNull.Value),
                new SqlParameter("@NgayBatDau", ngayBD),
                new SqlParameter("@NgayHoanThanh", ngayHT),
                new SqlParameter("@ChiPhi", chiPhi),
                new SqlParameter("@NoiDung", noiDung),
                new SqlParameter("@TrangThai", trangThai),
                new SqlParameter("@MaBaoTri", maBaoTri)
            };

            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
            if (kq > 0)
            {
                // Kiểm tra nếu lệnh chuyển thành Hoàn thành
                if (trangThai == "Hoàn thành")
                {
                    KiemTraVaCapNhatTrangThaiTau(maTau);
                }

                MessageBox.Show("Cập nhật lệnh bảo trì thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachBaoTri();
            }
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBaoTri.Text))
            {
                MessageBox.Show("Vui lòng chọn lệnh bảo trì cần đánh dấu hoàn thành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maBaoTri = Convert.ToInt32(txtMaBaoTri.Text);
            int maTau = Convert.ToInt32(cboTau.SelectedValue);
            decimal chiPhi = numChiPhi.Value;

            DialogResult res = MessageBox.Show("Đánh dấu hoàn thành lệnh bảo trì #" + maBaoTri + " với chi phí " + chiPhi.ToString("N0") + " đ?",
                "Xác nhận hoàn thành", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                string sql = "UPDATE BaoTri SET TrangThai = N'Hoàn thành', NgayHoanThanh = GETDATE(), ChiPhi = @ChiPhi " +
                             "WHERE MaBaoTri = @MaBaoTri";
                SqlParameter[] p = new SqlParameter[]
                {
                    new SqlParameter("@ChiPhi", chiPhi),
                    new SqlParameter("@MaBaoTri", maBaoTri)
                };

                int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
                if (kq > 0)
                {
                    // NGHIỆP VỤ: tàu tự động chuyển về Sẵn sàng nếu hết lệnh bảo trì mở
                    KiemTraVaCapNhatTrangThaiTau(maTau);

                    MessageBox.Show("Đã hoàn thành lệnh bảo trì!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachBaoTri();
                }
            }
        }

        private void KiemTraVaCapNhatTrangThaiTau(int maTau)
        {
            string sqlCheck = "SELECT COUNT(*) FROM BaoTri WHERE MaTau = @MaTau AND TrangThai = N'Đang xử lý'";
            object count = Ketnoi_CSDL.ExecuteScalar(sqlCheck, new SqlParameter[] { new SqlParameter("@MaTau", maTau) });

            if (count != null && Convert.ToInt32(count) == 0)
            {
                // Hết lệnh bảo trì mở -> tàu tự động chuyển về Sẵn sàng
                Ketnoi_CSDL.ExecuteNonQuery("UPDATE Tau SET TrangThai = N'Sẵn sàng' WHERE MaTau = @MaTau",
                    new SqlParameter[] { new SqlParameter("@MaTau", maTau) });
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadDanhSachBaoTri();
        }

        private void cboLocTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachBaoTri();
        }

        private void cboLocTau_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachBaoTri();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboLocTrangThai.SelectedIndex = 0;
            cboLocTau.SelectedIndex = 0;
            LamMoi();
            LoadDanhSachBaoTri();
        }

        private void LamMoi()
        {
            txtMaBaoTri.Clear();
            txtNoiDung.Clear();
            numChiPhi.Value = 0;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayHoanThanh.Checked = false;
            cboTrangThai.SelectedIndex = 0;
            txtNoiDung.Focus();
        }
    }
}
