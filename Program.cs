using System;
using System.Windows.Forms;

namespace QuanLyTau
{
    static class Program
    {
        /// <summary>
        /// Điểm khởi động chính của ứng dụng Quản lý Tàu.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmDangNhap());
        }
    }
}
