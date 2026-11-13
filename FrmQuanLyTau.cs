using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTau
{
    public partial class FrmQuanLyTau : Form
    {
        public FrmQuanLyTau()
        {
            InitializeComponent();
        }

        private void FrmQuanLyTau_Load(object sender, EventArgs e)
        {
            LoadDanhSachTuyen();
            cboLocTrangThai.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            LoadDanhSachTau();
        }

        private void LoadDanhSachTuyen()
        {
            string sql = "SELECT MaTuyen, TenTuyen FROM Tuyen WHERE TrangThai = N'Hoạt động' ORDER BY MaTuyen ASC";
            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql);

            // Cho cboTuyen trong form nhập
            cboTuyen.DataSource = dt.Copy();
            cboTuyen.DisplayMember = "TenTuyen";
            cboTuyen.ValueMember = "MaTuyen";

            // Cho cboLocTuyen
            DataTable dtLoc = dt.Copy();
            DataRow rAll = dtLoc.NewRow();
            rAll["MaTuyen"] = 0;
            rAll["TenTuyen"] = "--- Tất cả các tuyến ---";
            dtLoc.Rows.InsertAt(rAll, 0);

            cboLocTuyen.DataSource = dtLoc;
            cboLocTuyen.DisplayMember = "TenTuyen";
            cboLocTuyen.ValueMember = "MaTuyen";
            cboLocTuyen.SelectedIndex = 0;
        }

        private void LoadDanhSachTau()
        {
            string trangThaiLoc = cboLocTrangThai.SelectedItem != null ? cboLocTrangThai.SelectedItem.ToString() : "Tất cả trạng thái";
            int maTuyenLoc = 0;
            if (cboLocTuyen.SelectedValue != null && !(cboLocTuyen.SelectedValue is DataRowView))
            {
                maTuyenLoc = Convert.ToInt32(cboLocTuyen.SelectedValue);
            }

            string sql = "SELECT t.MaTau AS [Mã Tàu], t.TenTau AS [Tên Tàu], " +
                         "ISNULL(ty.TenTuyen, N'Chưa phân tuyến') AS [Tuyến Hoạt Động], " +
                         "t.TrangThai AS [Trạng Thái], " +
                         "COUNT(tt.MaToa) AS [Số Toa], " +
                         "ISNULL(SUM(tt.SucChua), 0) AS [Tổng Sức Chứa (Chỗ)], " +
                         "t.MaTuyen " +
                         "FROM Tau t " +
                         "LEFT JOIN Tuyen ty ON t.MaTuyen = ty.MaTuyen " +
                         "LEFT JOIN ToaTau tt ON t.MaTau = tt.MaTau " +
                         "WHERE 1=1 ";

            List<SqlParameter> pList = new List<SqlParameter>();

            if (trangThaiLoc != "Tất cả trạng thái")
            {
                sql += "AND t.TrangThai = @TrangThai ";
                pList.Add(new SqlParameter("@TrangThai", trangThaiLoc));
            }

            if (maTuyenLoc > 0)
            {
                sql += "AND t.MaTuyen = @MaTuyen ";
                pList.Add(new SqlParameter("@MaTuyen", maTuyenLoc));
            }

            sql += "GROUP BY t.MaTau, t.TenTau, ty.TenTuyen, t.TrangThai, t.MaTuyen " +
                   "ORDER BY t.MaTau ASC";

            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql, pList.Count > 0 ? pList.ToArray() : null);
            dgvTau.DataSource = dt;

            if (dgvTau.Columns.Contains("MaTuyen"))
            {
                dgvTau.Columns["MaTuyen"].Visible = false;
            }

            if (dgvTau.Columns.Contains("Mã Tàu"))
            {
                dgvTau.Columns["Mã Tàu"].Width = 80;
                dgvTau.Columns["Trạng Thái"].Width = 110;
                dgvTau.Columns["Số Toa"].Width = 80;
                dgvTau.Columns["Tổng Sức Chứa (Chỗ)"].Width = 150;
            }
        }

        private void dgvTau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTau.Rows.Count)
            {
                DataGridViewRow r = dgvTau.Rows[e.RowIndex];
                txtMaTau.Text = r.Cells["Mã Tàu"].Value != null ? r.Cells["Mã Tàu"].Value.ToString() : "";
                txtTenTau.Text = r.Cells["Tên Tàu"].Value != null ? r.Cells["Tên Tàu"].Value.ToString() : "";

                if (r.Cells["MaTuyen"].Value != DBNull.Value && r.Cells["MaTuyen"].Value != null)
                {
                    cboTuyen.SelectedValue = Convert.ToInt32(r.Cells["MaTuyen"].Value);
                }

                string tt = r.Cells["Trạng Thái"].Value != null ? r.Cells["Trạng Thái"].Value.ToString() : "Sẵn sàng";
                cboTrangThai.SelectedItem = tt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenTau = txtTenTau.Text.Trim();
            if (string.IsNullOrEmpty(tenTau))
            {
                MessageBox.Show("Vui lòng nhập tên đoàn tàu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTau.Focus();
                return;
            }

            int? maTuyen = null;
            if (cboTuyen.SelectedValue != null)
            {
                maTuyen = Convert.ToInt32(cboTuyen.SelectedValue);
            }

            string trangThai = cboTrangThai.SelectedItem != null ? cboTrangThai.SelectedItem.ToString() : "Sẵn sàng";

            string sql = "INSERT INTO Tau (TenTau, MaTuyen, TrangThai) VALUES (@TenTau, @MaTuyen, @TrangThai)";
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@TenTau", tenTau),
                new SqlParameter("@MaTuyen", (object)maTuyen ?? DBNull.Value),
                new SqlParameter("@TrangThai", trangThai)
            };

            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
            if (kq > 0)
            {
                MessageBox.Show("Thêm đoàn tàu mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();
                LoadDanhSachTau();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTau.Text))
            {
                MessageBox.Show("Vui lòng chọn tàu cần cập nhật từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenTau = txtTenTau.Text.Trim();
            if (string.IsNullOrEmpty(tenTau))
            {
                MessageBox.Show("Vui lòng nhập tên đoàn tàu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTau.Focus();
                return;
            }

            int? maTuyen = null;
            if (cboTuyen.SelectedValue != null)
            {
                maTuyen = Convert.ToInt32(cboTuyen.SelectedValue);
            }

            string trangThai = cboTrangThai.SelectedItem != null ? cboTrangThai.SelectedItem.ToString() : "Sẵn sàng";
            int maTau = Convert.ToInt32(txtMaTau.Text);

            string sql = "UPDATE Tau SET TenTau = @TenTau, MaTuyen = @MaTuyen, TrangThai = @TrangThai WHERE MaTau = @MaTau";
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@TenTau", tenTau),
                new SqlParameter("@MaTuyen", (object)maTuyen ?? DBNull.Value),
                new SqlParameter("@TrangThai", trangThai),
                new SqlParameter("@MaTau", maTau)
            };

            int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật thông tin tàu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachTau();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTau.Text))
            {
                MessageBox.Show("Vui lòng chọn tàu cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maTau = Convert.ToInt32(txtMaTau.Text);

            // Kiểm tra xem tàu có chuyến tàu hoặc bảo trì không
            object checkChuyen = Ketnoi_CSDL.ExecuteScalar("SELECT COUNT(*) FROM ChuyenTau WHERE MaTau = @MaTau",
                new SqlParameter[] { new SqlParameter("@MaTau", maTau) });

            if (checkChuyen != null && Convert.ToInt32(checkChuyen) > 0)
            {
                MessageBox.Show("Không thể xóa tàu này vì đã có lịch sử chuyến tàu được lập! Bạn có thể chuyển trạng thái sang 'Hỏng' hoặc 'Bảo trì'.",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa đoàn tàu này không? Các toa tàu liên quan cũng sẽ bị xóa.",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Ketnoi_CSDL.ExecuteNonQuery("DELETE FROM ToaTau WHERE MaTau = @MaTau", new SqlParameter[] { new SqlParameter("@MaTau", maTau) });
                int kq = Ketnoi_CSDL.ExecuteNonQuery("DELETE FROM Tau WHERE MaTau = @MaTau", new SqlParameter[] { new SqlParameter("@MaTau", maTau) });
                if (kq > 0)
                {
                    MessageBox.Show("Đã xóa tàu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachTau();
                    LamMoi();
                }
            }
        }

        private void btnChiTietToaTau_Click(object sender, EventArgs e)
        {
            int maTau = 0;
            if (!string.IsNullOrEmpty(txtMaTau.Text))
            {
                maTau = Convert.ToInt32(txtMaTau.Text);
            }

            FrmChiTietTau f = new FrmChiTietTau(maTau);
            f.ShowDialog();
            LoadDanhSachTau();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadDanhSachTau();
        }

        private void cboLocTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachTau();
        }

        private void cboLocTuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachTau();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboLocTrangThai.SelectedIndex = 0;
            cboLocTuyen.SelectedIndex = 0;
            LamMoi();
            LoadDanhSachTau();
        }

        private void LamMoi()
        {
            txtMaTau.Clear();
            txtTenTau.Clear();
            cboTrangThai.SelectedIndex = 0;
            txtTenTau.Focus();
        }
    }
}
