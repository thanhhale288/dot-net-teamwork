using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTau
{
    public partial class FrmBaoCao : Form
    {
        public FrmBaoCao()
        {
            InitializeComponent();
        }

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            // Mặc định khoảng ngày: từ đầu tháng đến hiện tại
            DateTime dauThang = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpNgayBD.Value = dauThang.AddMonths(-1); // Lấy từ tháng trước để xem được nhiều dữ liệu mẫu
            dtpNgayKT.Value = DateTime.Today.AddDays(1);

            dtpTuyenBD.Value = dtpNgayBD.Value;
            dtpTuyenKT.Value = dtpNgayKT.Value;

            dtpBTBD.Value = dtpNgayBD.Value;
            dtpBTKT.Value = dtpNgayKT.Value;

            LoadDanhSachTauBaoTri();

            ThongKeDoanhThuNgay();
            ThongKeDoanhThuTuyen();
            ThongKeBaoTri();
        }

        private void LoadDanhSachTauBaoTri()
        {
            string sql = "SELECT MaTau, TenTau FROM Tau ORDER BY MaTau ASC";
            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql);

            DataRow r = dt.NewRow();
            r["MaTau"] = 0;
            r["TenTau"] = "--- Tất cả các tàu ---";
            dt.Rows.InsertAt(r, 0);

            cboLocTauBT.DataSource = dt;
            cboLocTauBT.DisplayMember = "TenTau";
            cboLocTauBT.ValueMember = "MaTau";
            cboLocTauBT.SelectedIndex = 0;
        }

        // ================= TAB 1: DOANH THU THEO NGÀY =================
        private void btnThongKeNgay_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThuNgay();
        }

        private void ThongKeDoanhThuNgay()
        {
            DateTime bd = dtpNgayBD.Value.Date;
            DateTime kt = dtpNgayKT.Value.Date;

            // 1. Tính thẻ tóm tắt
            string sqlCards = "SELECT " +
                              "SUM(CASE WHEN TrangThai = N'Đã thanh toán' THEN 1 ELSE 0 END) AS VeBan, " +
                              "SUM(CASE WHEN TrangThai = N'Đã hủy' THEN 1 ELSE 0 END) AS VeHuy, " +
                              "ISNULL(SUM(CASE WHEN TrangThai = N'Đã thanh toán' THEN GiaVe ELSE 0 END), 0) AS DoanhThu " +
                              "FROM Ve " +
                              "WHERE CAST(NgayMua AS DATE) >= @BD AND CAST(NgayMua AS DATE) <= @KT";

            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@BD", bd),
                new SqlParameter("@KT", kt)
            };

            DataTable dtCards = Ketnoi_CSDL.ExecuteQuery(sqlCards, p);
            if (dtCards != null && dtCards.Rows.Count > 0)
            {
                DataRow r = dtCards.Rows[0];
                int veBan = r["VeBan"] != DBNull.Value ? Convert.ToInt32(r["VeBan"]) : 0;
                int veHuy = r["VeHuy"] != DBNull.Value ? Convert.ToInt32(r["VeHuy"]) : 0;
                decimal doanhThu = r["DoanhThu"] != DBNull.Value ? Convert.ToDecimal(r["DoanhThu"]) : 0;

                lblTongVeBanVal.Text = string.Format("{0:N0} vé", veBan);
                lblTongVeHuyVal.Text = string.Format("{0:N0} vé", veHuy);
                lblTongDoanhThuVal.Text = string.Format("{0:N0} VNĐ", doanhThu);
            }

            // 2. DataGridView chi tiết theo từng ngày
            string sqlGrid = "SELECT CONVERT(VARCHAR(10), NgayMua, 103) AS [Ngày Giao Dịch], " +
                             "SUM(CASE WHEN TrangThai = N'Đã thanh toán' THEN 1 ELSE 0 END) AS [Số Vé Bán Thành Công], " +
                             "SUM(CASE WHEN TrangThai = N'Đã hủy' THEN 1 ELSE 0 END) AS [Số Vé Bị Hủy], " +
                             "ISNULL(SUM(CASE WHEN TrangThai = N'Đã thanh toán' THEN GiaVe ELSE 0 END), 0) AS [Doanh Thu Thực Tế (VNĐ)] " +
                             "FROM Ve " +
                             "WHERE CAST(NgayMua AS DATE) >= @BD AND CAST(NgayMua AS DATE) <= @KT " +
                             "GROUP BY CONVERT(VARCHAR(10), NgayMua, 103), CAST(NgayMua AS DATE) " +
                             "ORDER BY CAST(NgayMua AS DATE) DESC";

            SqlParameter[] pGrid = new SqlParameter[]
            {
                new SqlParameter("@BD", bd),
                new SqlParameter("@KT", kt)
            };

            DataTable dtGrid = Ketnoi_CSDL.ExecuteQuery(sqlGrid, pGrid);
            dgvDoanhThuNgay.DataSource = dtGrid;

            if (dgvDoanhThuNgay.Columns.Contains("Doanh Thu Thực Tế (VNĐ)"))
            {
                dgvDoanhThuNgay.Columns["Doanh Thu Thực Tế (VNĐ)"].DefaultCellStyle.Format = "N0";
            }
        }

        // ================= TAB 2: DOANH THU THEO TUYẾN =================
        private void btnThongKeTuyen_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThuTuyen();
        }

        private void ThongKeDoanhThuTuyen()
        {
            DateTime bd = dtpTuyenBD.Value.Date;
            DateTime kt = dtpTuyenKT.Value.Date;

            string sql = "SELECT ty.MaTuyen AS [Mã Tuyến], " +
                         "ty.TenTuyen AS [Tên Tuyến Tàu Đô Thị], " +
                         "COUNT(DISTINCT ct.MaChuyen) AS [Số Chuyến Tàu], " +
                         "COUNT(v.MaVe) AS [Số Vé Đã Bán], " +
                         "ISNULL(SUM(v.GiaVe), 0) AS [Tổng Doanh Thu (VNĐ)] " +
                         "FROM Tuyen ty " +
                         "LEFT JOIN Tau t ON ty.MaTuyen = t.MaTuyen " +
                         "LEFT JOIN ChuyenTau ct ON t.MaTau = ct.MaTau " +
                         "LEFT JOIN Ve v ON ct.MaChuyen = v.MaChuyen AND v.TrangThai = N'Đã thanh toán' " +
                         "     AND CAST(v.NgayMua AS DATE) >= @BD AND CAST(v.NgayMua AS DATE) <= @KT " +
                         "GROUP BY ty.MaTuyen, ty.TenTuyen " +
                         "ORDER BY [Tổng Doanh Thu (VNĐ)] DESC";

            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@BD", bd),
                new SqlParameter("@KT", kt)
            };

            DataTable dt = Ketnoi_CSDL.ExecuteQuery(sql, p);
            dgvDoanhThuTuyen.DataSource = dt;

            if (dgvDoanhThuTuyen.Columns.Contains("Mã Tuyến"))
            {
                dgvDoanhThuTuyen.Columns["Mã Tuyến"].Width = 90;
                dgvDoanhThuTuyen.Columns["Tổng Doanh Thu (VNĐ)"].DefaultCellStyle.Format = "N0";
            }
        }

        // ================= TAB 3: THỐNG KÊ BẢO TRÌ =================
        private void btnThongKeBaoTri_Click(object sender, EventArgs e)
        {
            ThongKeBaoTri();
        }

        private void ThongKeBaoTri()
        {
            DateTime bd = dtpBTBD.Value.Date;
            DateTime kt = dtpBTKT.Value.Date;
            int maTau = 0;
            if (cboLocTauBT.SelectedValue != null && !(cboLocTauBT.SelectedValue is DataRowView))
            {
                maTau = Convert.ToInt32(cboLocTauBT.SelectedValue);
            }

            string sqlCards = "SELECT COUNT(*) AS TongLuot, ISNULL(SUM(ChiPhi), 0) AS TongChiPhi " +
                              "FROM BaoTri " +
                              "WHERE CAST(NgayBatDau AS DATE) >= @BD AND CAST(NgayBatDau AS DATE) <= @KT ";

            List<SqlParameter> pList = new List<SqlParameter>();
            pList.Add(new SqlParameter("@BD", bd));
            pList.Add(new SqlParameter("@KT", kt));

            if (maTau > 0)
            {
                sqlCards += "AND MaTau = @MaTau ";
                pList.Add(new SqlParameter("@MaTau", maTau));
            }

            DataTable dtCards = Ketnoi_CSDL.ExecuteQuery(sqlCards, pList.ToArray());
            if (dtCards != null && dtCards.Rows.Count > 0)
            {
                DataRow r = dtCards.Rows[0];
                int luot = Convert.ToInt32(r["TongLuot"]);
                decimal chiPhi = Convert.ToDecimal(r["TongChiPhi"]);

                lblTongLuotBTVal.Text = string.Format("{0:N0} lượt", luot);
                lblTongChiPhiBTVal.Text = string.Format("{0:N0} VNĐ", chiPhi);
            }

            string sqlGrid = "SELECT bt.MaBaoTri AS [Mã Lệnh], " +
                             "t.TenTau AS [Đoàn Tàu], " +
                             "bt.NoiDung AS [Hạng Mục / Nội Dung Sửa Chữa], " +
                             "bt.NgayBatDau AS [Ngày Bắt Đầu], " +
                             "bt.NgayHoanThanh AS [Ngày Hoàn Thành], " +
                             "bt.ChiPhi AS [Chi Phí (VNĐ)], " +
                             "bt.TrangThai AS [Trạng Thái], " +
                             "ISNULL(nv.HoTen, N'Chưa phân công') AS [Kỹ Thuật Viên Phụ Trách] " +
                             "FROM BaoTri bt " +
                             "JOIN Tau t ON bt.MaTau = t.MaTau " +
                             "LEFT JOIN NhanVien nv ON bt.MaNV = nv.MaNV " +
                             "WHERE CAST(bt.NgayBatDau AS DATE) >= @BD AND CAST(bt.NgayBatDau AS DATE) <= @KT ";

            List<SqlParameter> pGridList = new List<SqlParameter>();
            pGridList.Add(new SqlParameter("@BD", bd));
            pGridList.Add(new SqlParameter("@KT", kt));

            if (maTau > 0)
            {
                sqlGrid += "AND bt.MaTau = @MaTau ";
                pGridList.Add(new SqlParameter("@MaTau", maTau));
            }

            sqlGrid += "ORDER BY bt.MaBaoTri DESC";

            DataTable dtGrid = Ketnoi_CSDL.ExecuteQuery(sqlGrid, pGridList.ToArray());
            dgvBaoTriThongKe.DataSource = dtGrid;

            if (dgvBaoTriThongKe.Columns.Contains("Mã Lệnh"))
            {
                dgvBaoTriThongKe.Columns["Mã Lệnh"].Width = 80;
                dgvBaoTriThongKe.Columns["Chi Phí (VNĐ)"].DefaultCellStyle.Format = "N0";
            }
        }
    }
}
