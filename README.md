# HỆ THỐNG QUẢN LÝ TÀU ĐIỆN ĐÔ THỊ (SUBWAY MANAGEMENT SYSTEM)

Dự án phần mềm quản lý hệ thống đường sắt đô thị / tàu điện ngầm (Metro / Subway) viết bằng **C# Windows Forms (.NET Framework 4.7.2)** kết nối cơ sở dữ liệu **Microsoft SQL Server**.

---

## 📌 1. YÊU CẦU HỆ THỐNG
* **Hệ điều hành**: Windows 10/11
* **Công cụ phát triển**: Visual Studio 2019 / 2022 (cài đặt workload *.NET Desktop Development*)
* **Cơ sở dữ liệu**: Microsoft SQL Server (SQL Server Express, Developer hoặc Enterprise)
* **Công cụ quản lý DB**: SQL Server Management Studio (SSMS)

---

## 🚀 2. HƯỚNG DẪN CÀI ĐẶT VÀ CHẠY DỰ ÁN TRÊN MÁY TÍNH

### Bước 1: Khởi tạo Cơ sở dữ liệu (Database)
1. Mở công cụ **SQL Server Management Studio (SSMS)** và kết nối tới máy chủ SQL Server của bạn (ví dụ: `.\SQLEXPRESS` hoặc `localhost`).
2. Mở file [`QuanLyTau.sql`](QuanLyTau.sql) trong thư mục dự án và nhấn **Execute (F5)** để tự động tạo database `QuanLyTau`, cấu trúc bảng và nạp dữ liệu mẫu ban đầu.
3. *(Khuyên dùng)* Mở tiếp file [`BoSung_StoredProcedures.sql`](BoSung_StoredProcedures.sql) và nhấn **Execute (F5)** để nạp các Stored Procedures tối ưu hóa.

---

### Bước 2: Cấu hình chuỗi kết nối trong `App.config`
Mở file `App.config` trong thư mục dự án và kiểm tra chuỗi kết nối:
```xml
<connectionStrings>
    <add name="QuanLyTauConn" 
         connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTau;Integrated Security=True;Encrypt=False" 
         providerName="System.Data.SqlClient" />
</connectionStrings>
```
* **Lưu ý**: Nếu SQL Server trên máy bạn dùng tên khác (ví dụ: `localhost`, `.` hoặc tên máy `DESKTOP-ABC\SQLEXPRESS`), hãy đổi `Data Source=.\SQLEXPRESS` thành tên server của máy bạn.

---

### Bước 3: Mở và chạy chương trình trong Visual Studio
1. Nhấp đúp chuột vào file **`QuanLyTau.sln`** để mở dự án trong Visual Studio.
2. Kiểm tra chế độ chạy là **Debug** hoặc **Release**, nền tảng **Any CPU**.
3. Nhấn **F5** hoặc bấm vào nút **Start** trên thanh công cụ để biên dịch và khởi chạy ứng dụng.

---

## 🔑 3. TÀI KHOẢN ĐĂNG NHẬP THỬ NGHIỆM

Hệ thống đã có sẵn 4 tài khoản phân quyền đại diện cho các phòng ban:

| Tên Đăng Nhập | Mật Khẩu | Vai Trò | Quyền Hạn |
| :--- | :---: | :---: | :--- |
| **admin** | `123456` | **Quản Lý** (`QuanLy`) | Toàn quyền sử dụng tất cả 15 màn hình chức năng |
| **banve** | `123456` | **Bán Vé** (`BanVe`) | Bán vé tại quầy (POS), tra cứu & hủy vé, quản lý khách hàng |
| **kythuat** | `123456` | **Kỹ Thuật** (`KyThuat`) | Quản lý tàu điện, toa tàu, lập & hoàn thành phiếu bảo trì |
| **laixe** | `123456` | **Lái Tàu** (`LaiTau`) | Xem danh sách chuyến tàu được phân công, cập nhật trạng thái |

---

## 📂 4. CẤU TRÚC THƯ MỤC DỰ ÁN

* `QuanLyTau.sln`: File giải pháp Visual Studio Solution.
* `QuanLyTau.csproj`: File cấu hình dự án Windows Forms .NET Framework 4.7.2.
* `App.config`: Cấu hình chuỗi kết nối CSDL SQL Server.
* `Program.cs`: Điểm khởi chạy chương trình (mở `FrmDangNhap`).
* `Ketnoi_CSDL.cs`: Lớp kết nối CSDL, gọi hàm/thủ tục và quản lý thông tin phiên đăng nhập.
* `QuanLyTau.sql`: Script khởi tạo cơ sở dữ liệu và dữ liệu mẫu.
* `BoSung_StoredProcedures.sql`: 5 Stored Procedures mở rộng.
* `report.md`: Báo cáo chi tiết về kiến trúc, chức năng và các sơ đồ luồng (Workflows).
* **15 Windows Forms** (mỗi Form có đủ 3 file `.cs`, `.Designer.cs`, `.resx`):
  1. `FrmDangNhap`: Xác thực tài khoản & phân quyền người dùng.
  2. `FrmTrangChu`: Bảng điều khiển (Dashboard) thống kê thời gian thực & menu chính.
  3. `FrmQuanLyTuyen`: Quản lý danh sách các tuyến tàu đô thị (CRUD, xóa mềm).
  4. `FrmChiTietTuyen`: Cấu hình thứ tự ga dừng và thời gian dừng đỗ trên tuyến.
  5. `FrmQuanLyGa`: Quản lý danh mục các nhà ga (chặn ngưng hoạt động ga đang có tuyến chạy).
  6. `FrmQuanLyTau`: Quản lý đoàn tàu điện, trạng thái và tổng sức chứa.
  7. `FrmChiTietTau`: Quản lý danh sách toa tàu của đoàn tàu.
  8. `FrmBaoTri`: Lập và hoàn thành phiếu bảo trì (tự động cập nhật trạng thái đoàn tàu).
  9. `FrmLichTrinh`: Cấu hình lịch vận hành định kỳ & công cụ sinh chuyến tự động.
  10. `FrmChuyenTau`: Quản lý chuyến tàu thực tế theo ngày, gán lái tàu, đổi trạng thái.
  11. `FrmBanVe`: Điểm bán vé tại quầy (POS), tính cước tự động theo cự ly ga, tra cứu CCCD.
  12. `FrmTraCuuVe`: Tra cứu vé phát hành và thực hiện hủy vé.
  13. `FrmHanhKhach`: Quản lý khách hàng và xem lịch sử các vé đã mua (Master-Detail).
  14. `FrmNhanVien`: Quản lý danh sách nhân sự, tài khoản và đặt lại mật khẩu.
  15. `FrmBaoCao`: Báo cáo thống kê chuyên sâu 3 tab (Doanh thu ngày, Doanh thu tuyến, Chi phí bảo trì).
