using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTau
{
    /// <summary>
    /// Lớp kết nối và thao tác với cơ sở dữ liệu SQL Server QuanLyTau
    /// </summary>
    public static class Ketnoi_CSDL
    {
        private static string _connectionString;

        // Lưu thông tin người dùng đăng nhập hiện tại
        public static class NguoiDungHienTai
        {
            public static int MaNV { get; set; }
            public static string HoTen { get; set; }
            public static string TenDangNhap { get; set; }
            public static string VaiTro { get; set; } // QuanLy, BanVe, KyThuat, LaiTau
            public static string SoDienThoai { get; set; }

            public static void DangXuat()
            {
                MaNV = 0;
                HoTen = string.Empty;
                TenDangNhap = string.Empty;
                VaiTro = string.Empty;
                SoDienThoai = string.Empty;
            }

            public static bool DaDangNhap()
            {
                return MaNV > 0;
            }
        }

        static Ketnoi_CSDL()
        {
            try
            {
                if (ConfigurationManager.ConnectionStrings["QuanLyTauConn"] != null)
                {
                    _connectionString = ConfigurationManager.ConnectionStrings["QuanLyTauConn"].ConnectionString;
                }
            }
            catch
            {
                // Fallback nếu không đọc được App.config
            }

            if (string.IsNullOrEmpty(_connectionString))
            {
                // Mặc định kết nối SQLEXPRESS hoặc Local
                _connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTau;Integrated Security=True;TrustServerCertificate=True";
            }
        }

        public static string ChuoiKetNoi
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        /// <summary>
        /// Kiểm tra xem kết nối đến CSDL có thành công không
        /// </summary>
        public static bool KiemTraKetNoi(out string thongBaoLoi)
        {
            thongBaoLoi = string.Empty;
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                thongBaoLoi = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Thực thi câu lệnh SELECT trả về DataTable
        /// </summary>
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        /// <summary>
        /// Thực thi câu lệnh INSERT, UPDATE, DELETE trả về số dòng ảnh hưởng
        /// </summary>
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi dữ liệu: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            return rowsAffected;
        }

        /// <summary>
        /// Thực thi câu lệnh SELECT trả về 1 giá trị ô đầu tiên (COUNT, MAX, ID...)
        /// </summary>
        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object result = null;
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        result = cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính toán dữ liệu: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        /// <summary>
        /// Thực thi Stored Procedure trả về DataTable
        /// </summary>
        public static DataTable ExecuteProcedure(string procName, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}
