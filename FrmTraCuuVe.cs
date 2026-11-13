using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTau
{
    public partial class FrmTraCuuVe : Form
    {
        private int _maVeDangChon = 0;
        private string _trangThaiDangChon = "";

        public FrmTraCuuVe()
        {
            InitializeComponent();
        }

        private void FrmTraCuuVe_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Today.AddDays(-7);
            dtpDenNgay.Value = DateTime.Today;
            LoadDanhSachVe();
        }

        private void LoadDanhSachVe()
        {
            string sql = "SELECT v.MaVe AS [Mã Vé], " +
                         "v.MaChuyen AS [Mã Chuyến], " +
                         "ISNULL(ty.TenTuyen, N'---') AS [Tuyến Tàu], " +
                         "t.TenTau AS [Đoàn Tàu], " +
                         "hk.CCCD AS [Số CCCD], " +
                         "hk.HoTen AS [Hành Khách], " +
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
                         "JOIN HanhKhach hk ON v.MaHK = hk.MaHK " +
                         "JOIN Ga gDi ON v.MaGaDi = gDi.MaGa " +
                         "JOIN Ga gDen ON v.MaGaDen = gDen.MaGa " +
                         "WHERE 1=1 ";

            List<SqlParameter> pList = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(txtTimMaVe.Text.Trim()))
            {
                int maVe = 0;
                if (int.TryParse(txtTimMaVe.Text.Trim(), out maVe))
                {
                    sql += "AND v.MaVe = @MaVe ";
                    pList.Add(new SqlParameter("@MaVe", maVe));
                }
            }

            if (!string.IsNullOrEmpty(txtTimCCCD.Text.Trim()))
            {
                sql += "AND hk.CCCD LIKE @CCCD ";
                pList.Add(new SqlParameter("@CCCD", "%" + txtTimCCCD.Text.Trim() + "%"));
            }

            if (dtpTuNgay.Checked)
            {
                sql += "AND CAST(v.NgayMua AS DATE) >= @TuNgay ";
                pList.Add(new SqlParameter("@TuNgay", dtpTuNgay.Value.Date));
            }

            if (dtpDenNgay.Checked)
            {
                sql += "AND CAST(v.NgayMua AS DATE) <= @DenNgay ";
                pList.Add(new SqlParameter("@DenNgay", dtpDenNgay.Value.Date));
            }

            sql += "ORDER BY v.MaVe DESC";

            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql, pList.Count > 0 ? pList.ToArray() : null);
            dgvVe.DataSource = dt;

            if (dgvVe.Columns.Contains("Mã Vé"))
            {
                dgvVe.Columns["Mã Vé"].Width = 80;
                dgvVe.Columns["Mã Chuyến"].Width = 85;
                dgvVe.Columns["Giá Vé (VNĐ)"].DefaultCellStyle.Format = "N0";
                dgvVe.Columns["Thời Gian Mua"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
        }

        private void dgvVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvVe.Rows.Count)
            {
                DataGridViewRow r = dgvVe.Rows[e.RowIndex];
                _maVeDangChon = Convert.ToInt32(r.Cells["Mã Vé"].Value);
                _trangThaiDangChon = r.Cells["Trạng Thái"].Value != null ? r.Cells["Trạng Thái"].Value.ToString() : "";

                lblMaVeVal.Text = "MÃ VÉ: #" + _maVeDangChon;
                lblHanhKhachVal.Text = string.Format("Hành khách: {0} (CCCD: {1})", r.Cells["Hành Khách"].Value, r.Cells["Số CCCD"].Value);
                lblTuyenTauVal.Text = string.Format("Tuyến: {0} | {1} | Chuyến #{2}", r.Cells["Tuyến Tàu"].Value, r.Cells["Đoàn Tàu"].Value, r.Cells["Mã Chuyến"].Value);
                lblGaDiVal.Text = "Ga đi: " + r.Cells["Ga Đi"].Value;
                lblGaDenVal.Text = "Ga đến: " + r.Cells["Ga Đến"].Value;

                decimal giaVe = Convert.ToDecimal(r.Cells["Giá Vé (VNĐ)"].Value);
                lblGiaVeVal.Text = string.Format("Giá vé: {0:N0} đ ({1})", giaVe, r.Cells["Loại Vé"].Value);

                lblTrangThaiVal.Text = "Trạng thái: " + _trangThaiDangChon.ToUpper();
                if (_trangThaiDangChon == "Đã thanh toán")
                {
                    lblTrangThaiVal.ForeColor = System.Drawing.Color.FromArgb(5, 150, 105);
                    btnHuyVe.Enabled = true;
                }
                else
                {
                    lblTrangThaiVal.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
                    btnHuyVe.Enabled = false;
                }
            }
        }

        private void btnHuyVe_Click(object sender, EventArgs e)
        {
            if (_maVeDangChon <= 0)
            {
                MessageBox.Show("Vui lòng chọn vé tàu cần hủy từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_trangThaiDangChon == "Đã hủy")
            {
                MessageBox.Show("Vé tàu này đã bị hủy trước đó rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn HỦY vé tàu #" + _maVeDangChon + " không?\nSau khi hủy, trạng thái vé sẽ chuyển sang 'Đã hủy'.",
                "Xác nhận hủy vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                // Thử gọi sp_HuyVe nếu có
                try
                {
                    SqlParameter[] spP = new SqlParameter[] { new SqlParameter("@MaVe", _maVeDangChon) };
                    DataTable dtSP = Ketnoi_CSDL.ExecuteProcedure("sp_HuyVe", spP);
                    if (dtSP != null)
                    {
                        MessageBox.Show("Hủy vé thành công qua thủ tục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachVe();
                        return;
                    }
                }
                catch { }

                // Fallback SQL
                string sql = "UPDATE Ve SET TrangThai = N'Đã hủy' WHERE MaVe = @MaVe";
                SqlParameter[] p = new SqlParameter[] { new SqlParameter("@MaVe", _maVeDangChon) };

                int kq = Ketnoi_CSDL.ExecuteNonQuery(sql, p);
                if (kq > 0)
                {
                    MessageBox.Show("Đã hủy vé #" + _maVeDangChon + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachVe();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDanhSachVe();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimMaVe.Clear();
            txtTimCCCD.Clear();
            dtpTuNgay.Checked = false;
            dtpDenNgay.Checked = false;
            LoadDanhSachVe();
        }

        private void txtTimMaVe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoadDanhSachVe();
        }

        private void txtTimCCCD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoadDanhSachVe();
        }
    }
}
