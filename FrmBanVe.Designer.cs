namespace QuanLyTau
{
    partial class FrmBanVe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpChonChuyen = new System.Windows.Forms.GroupBox();
            this.lblThongTinTuyen = new System.Windows.Forms.Label();
            this.cboChuyenTau = new System.Windows.Forms.ComboBox();
            this.lblChuyen = new System.Windows.Forms.Label();
            this.dtpNgayChay = new System.Windows.Forms.DateTimePicker();
            this.lblNgay = new System.Windows.Forms.Label();
            this.grpHanhKhach = new System.Windows.Forms.GroupBox();
            this.btnKiemTraCCCD = new System.Windows.Forms.Button();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblSdt = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.grpHanhTrinh = new System.Windows.Forms.GroupBox();
            this.lblKhoangCachGa = new System.Windows.Forms.Label();
            this.cboLoaiVe = new System.Windows.Forms.ComboBox();
            this.lblLoaiVe = new System.Windows.Forms.Label();
            this.cboGaDen = new System.Windows.Forms.ComboBox();
            this.lblGaDen = new System.Windows.Forms.Label();
            this.cboGaDi = new System.Windows.Forms.ComboBox();
            this.lblGaDi = new System.Windows.Forms.Label();
            this.pnlThanhTien = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnInVe = new System.Windows.Forms.Button();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblTongTienTitle = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.grpChonChuyen.SuspendLayout();
            this.grpHanhKhach.SuspendLayout();
            this.grpHanhTrinh.SuspendLayout();
            this.pnlThanhTien.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(834, 55);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(397, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẦY BÁN VÉ TÀU SUBWAY (POS TICKET)";
            // 
            // grpChonChuyen
            // 
            this.grpChonChuyen.Controls.Add(this.lblThongTinTuyen);
            this.grpChonChuyen.Controls.Add(this.cboChuyenTau);
            this.grpChonChuyen.Controls.Add(this.lblChuyen);
            this.grpChonChuyen.Controls.Add(this.dtpNgayChay);
            this.grpChonChuyen.Controls.Add(this.lblNgay);
            this.grpChonChuyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpChonChuyen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChonChuyen.Location = new System.Drawing.Point(0, 55);
            this.grpChonChuyen.Name = "grpChonChuyen";
            this.grpChonChuyen.Size = new System.Drawing.Size(834, 105);
            this.grpChonChuyen.TabIndex = 1;
            this.grpChonChuyen.TabStop = false;
            this.grpChonChuyen.Text = "Bước 1: Chọn Chuyến Tàu";
            // 
            // lblThongTinTuyen
            // 
            this.lblThongTinTuyen.AutoSize = true;
            this.lblThongTinTuyen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinTuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblThongTinTuyen.Location = new System.Drawing.Point(145, 68);
            this.lblThongTinTuyen.Name = "lblThongTinTuyen";
            this.lblThongTinTuyen.Size = new System.Drawing.Size(200, 17);
            this.lblThongTinTuyen.TabIndex = 4;
            this.lblThongTinTuyen.Text = "Lộ trình tuyến: Đang tải thông tin...";
            // 
            // cboChuyenTau
            // 
            this.cboChuyenTau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyenTau.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChuyenTau.FormattingEnabled = true;
            this.cboChuyenTau.Location = new System.Drawing.Point(405, 28);
            this.cboChuyenTau.Name = "cboChuyenTau";
            this.cboChuyenTau.Size = new System.Drawing.Size(400, 25);
            this.cboChuyenTau.TabIndex = 3;
            this.cboChuyenTau.SelectedIndexChanged += new System.EventHandler(this.cboChuyenTau_SelectedIndexChanged);
            // 
            // lblChuyen
            // 
            this.lblChuyen.AutoSize = true;
            this.lblChuyen.Location = new System.Drawing.Point(315, 32);
            this.lblChuyen.Name = "lblChuyen";
            this.lblChuyen.Size = new System.Drawing.Size(88, 17);
            this.lblChuyen.TabIndex = 2;
            this.lblChuyen.Text = "Chọn chuyến:";
            // 
            // dtpNgayChay
            // 
            this.dtpNgayChay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayChay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayChay.Location = new System.Drawing.Point(145, 28);
            this.dtpNgayChay.Name = "dtpNgayChay";
            this.dtpNgayChay.Size = new System.Drawing.Size(145, 24);
            this.dtpNgayChay.TabIndex = 1;
            this.dtpNgayChay.ValueChanged += new System.EventHandler(this.dtpNgayChay_ValueChanged);
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(20, 32);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(117, 17);
            this.lblNgay.TabIndex = 0;
            this.lblNgay.Text = "Ngày khởi hành:";
            // 
            // grpHanhKhach
            // 
            this.grpHanhKhach.Controls.Add(this.btnKiemTraCCCD);
            this.grpHanhKhach.Controls.Add(this.txtSoDienThoai);
            this.grpHanhKhach.Controls.Add(this.lblSdt);
            this.grpHanhKhach.Controls.Add(this.txtHoTen);
            this.grpHanhKhach.Controls.Add(this.lblHoTen);
            this.grpHanhKhach.Controls.Add(this.txtCCCD);
            this.grpHanhKhach.Controls.Add(this.lblCCCD);
            this.grpHanhKhach.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpHanhKhach.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHanhKhach.Location = new System.Drawing.Point(0, 160);
            this.grpHanhKhach.Name = "grpHanhKhach";
            this.grpHanhKhach.Size = new System.Drawing.Size(834, 115);
            this.grpHanhKhach.TabIndex = 2;
            this.grpHanhKhach.TabStop = false;
            this.grpHanhKhach.Text = "Bước 2: Thông Tin Hành Khách (Tự động nhận diện / Lưu mới)";
            // 
            // btnKiemTraCCCD
            // 
            this.btnKiemTraCCCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnKiemTraCCCD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKiemTraCCCD.FlatAppearance.BorderSize = 0;
            this.btnKiemTraCCCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiemTraCCCD.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemTraCCCD.ForeColor = System.Drawing.Color.White;
            this.btnKiemTraCCCD.Location = new System.Drawing.Point(340, 27);
            this.btnKiemTraCCCD.Name = "btnKiemTraCCCD";
            this.btnKiemTraCCCD.Size = new System.Drawing.Size(100, 26);
            this.btnKiemTraCCCD.TabIndex = 2;
            this.btnKiemTraCCCD.Text = "Kiểm Tra";
            this.btnKiemTraCCCD.UseVisualStyleBackColor = false;
            this.btnKiemTraCCCD.Click += new System.EventHandler(this.btnKiemTraCCCD_Click);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(545, 68);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(260, 24);
            this.txtSoDienThoai.TabIndex = 6;
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Location = new System.Drawing.Point(450, 72);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(91, 17);
            this.lblSdt.TabIndex = 5;
            this.lblSdt.Text = "Số điện thoại:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(145, 68);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(280, 24);
            this.txtHoTen.TabIndex = 4;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(20, 72);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(123, 17);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Họ tên hành khách:";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(145, 28);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(185, 24);
            this.txtCCCD.TabIndex = 1;
            this.txtCCCD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCCCD_KeyDown);
            this.txtCCCD.Leave += new System.EventHandler(this.txtCCCD_Leave);
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(20, 32);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(94, 17);
            this.lblCCCD.TabIndex = 0;
            this.lblCCCD.Text = "CCCD/CMND:";
            // 
            // grpHanhTrinh
            // 
            this.grpHanhTrinh.Controls.Add(this.lblKhoangCachGa);
            this.grpHanhTrinh.Controls.Add(this.cboLoaiVe);
            this.grpHanhTrinh.Controls.Add(this.lblLoaiVe);
            this.grpHanhTrinh.Controls.Add(this.cboGaDen);
            this.grpHanhTrinh.Controls.Add(this.lblGaDen);
            this.grpHanhTrinh.Controls.Add(this.cboGaDi);
            this.grpHanhTrinh.Controls.Add(this.lblGaDi);
            this.grpHanhTrinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpHanhTrinh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHanhTrinh.Location = new System.Drawing.Point(0, 275);
            this.grpHanhTrinh.Name = "grpHanhTrinh";
            this.grpHanhTrinh.Size = new System.Drawing.Size(834, 115);
            this.grpHanhTrinh.TabIndex = 3;
            this.grpHanhTrinh.TabStop = false;
            this.grpHanhTrinh.Text = "Bước 3: Chọn Ga Đi - Ga Đến & Loại Vé";
            // 
            // lblKhoangCachGa
            // 
            this.lblKhoangCachGa.AutoSize = true;
            this.lblKhoangCachGa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoangCachGa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.lblKhoangCachGa.Location = new System.Drawing.Point(450, 72);
            this.lblKhoangCachGa.Name = "lblKhoangCachGa";
            this.lblKhoangCachGa.Size = new System.Drawing.Size(126, 17);
            this.lblKhoangCachGa.TabIndex = 6;
            this.lblKhoangCachGa.Text = "Cự ly: 0 chặng dừng";
            // 
            // cboLoaiVe
            // 
            this.cboLoaiVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiVe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiVe.FormattingEnabled = true;
            this.cboLoaiVe.Items.AddRange(new object[] {
            "Thường",
            "Ưu tiên (HSSV / Người cao tuổi)"});
            this.cboLoaiVe.Location = new System.Drawing.Point(145, 68);
            this.cboLoaiVe.Name = "cboLoaiVe";
            this.cboLoaiVe.Size = new System.Drawing.Size(260, 25);
            this.cboLoaiVe.TabIndex = 5;
            this.cboLoaiVe.SelectedIndexChanged += new System.EventHandler(this.cboLoaiVe_SelectedIndexChanged);
            // 
            // lblLoaiVe
            // 
            this.lblLoaiVe.AutoSize = true;
            this.lblLoaiVe.Location = new System.Drawing.Point(20, 72);
            this.lblLoaiVe.Name = "lblLoaiVe";
            this.lblLoaiVe.Size = new System.Drawing.Size(55, 17);
            this.lblLoaiVe.TabIndex = 4;
            this.lblLoaiVe.Text = "Loại vé:";
            // 
            // cboGaDen
            // 
            this.cboGaDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGaDen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGaDen.FormattingEnabled = true;
            this.cboGaDen.Location = new System.Drawing.Point(545, 28);
            this.cboGaDen.Name = "cboGaDen";
            this.cboGaDen.Size = new System.Drawing.Size(260, 25);
            this.cboGaDen.TabIndex = 3;
            this.cboGaDen.SelectedIndexChanged += new System.EventHandler(this.cboGaDen_SelectedIndexChanged);
            // 
            // lblGaDen
            // 
            this.lblGaDen.AutoSize = true;
            this.lblGaDen.Location = new System.Drawing.Point(450, 32);
            this.lblGaDen.Name = "lblGaDen";
            this.lblGaDen.Size = new System.Drawing.Size(86, 17);
            this.lblGaDen.TabIndex = 2;
            this.lblGaDen.Text = "Ga đến (trả):";
            // 
            // cboGaDi
            // 
            this.cboGaDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGaDi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGaDi.FormattingEnabled = true;
            this.cboGaDi.Location = new System.Drawing.Point(145, 28);
            this.cboGaDi.Name = "cboGaDi";
            this.cboGaDi.Size = new System.Drawing.Size(260, 25);
            this.cboGaDi.TabIndex = 1;
            this.cboGaDi.SelectedIndexChanged += new System.EventHandler(this.cboGaDi_SelectedIndexChanged);
            // 
            // lblGaDi
            // 
            this.lblGaDi.AutoSize = true;
            this.lblGaDi.Location = new System.Drawing.Point(20, 32);
            this.lblGaDi.Name = "lblGaDi";
            this.lblGaDi.Size = new System.Drawing.Size(81, 17);
            this.lblGaDi.TabIndex = 0;
            this.lblGaDi.Text = "Ga đi (lên):";
            // 
            // pnlThanhTien
            // 
            this.pnlThanhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThanhTien.Controls.Add(this.btnLamMoi);
            this.pnlThanhTien.Controls.Add(this.btnInVe);
            this.pnlThanhTien.Controls.Add(this.lblGiaTien);
            this.pnlThanhTien.Controls.Add(this.lblTongTienTitle);
            this.pnlThanhTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThanhTien.Location = new System.Drawing.Point(0, 390);
            this.pnlThanhTien.Name = "pnlThanhTien";
            this.pnlThanhTien.Size = new System.Drawing.Size(834, 161);
            this.pnlThanhTien.TabIndex = 4;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(620, 85);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(185, 45);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Giao Dịch Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnInVe
            // 
            this.btnInVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnInVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInVe.FlatAppearance.BorderSize = 0;
            this.btnInVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInVe.Font = new System.Drawing.Font("Segoe UI Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInVe.ForeColor = System.Drawing.Color.White;
            this.btnInVe.Location = new System.Drawing.Point(620, 20);
            this.btnInVe.Name = "btnInVe";
            this.btnInVe.Size = new System.Drawing.Size(185, 55);
            this.btnInVe.TabIndex = 2;
            this.btnInVe.Text = "💳 BÁN VÉ && IN VÉ";
            this.btnInVe.UseVisualStyleBackColor = false;
            this.btnInVe.Click += new System.EventHandler(this.btnInVe_Click);
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblGiaTien.Location = new System.Drawing.Point(20, 60);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(450, 60);
            this.lblGiaTien.TabIndex = 1;
            this.lblGiaTien.Text = "0 VNĐ";
            // 
            // lblTongTienTitle
            // 
            this.lblTongTienTitle.AutoSize = true;
            this.lblTongTienTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblTongTienTitle.Location = new System.Drawing.Point(25, 25);
            this.lblTongTienTitle.Name = "lblTongTienTitle";
            this.lblTongTienTitle.Size = new System.Drawing.Size(207, 21);
            this.lblTongTienTitle.TabIndex = 0;
            this.lblTongTienTitle.Text = "TỔNG TIỀN THANH TOÁN:";
            // 
            // FrmBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 551);
            this.Controls.Add(this.pnlThanhTien);
            this.Controls.Add(this.grpHanhTrinh);
            this.Controls.Add(this.grpHanhKhach);
            this.Controls.Add(this.grpChonChuyen);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmBanVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán Vé Tại Quầy - Subway";
            this.Load += new System.EventHandler(this.FrmBanVe_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.grpChonChuyen.ResumeLayout(false);
            this.grpChonChuyen.PerformLayout();
            this.grpHanhKhach.ResumeLayout(false);
            this.grpHanhKhach.PerformLayout();
            this.grpHanhTrinh.ResumeLayout(false);
            this.grpHanhTrinh.PerformLayout();
            this.pnlThanhTien.ResumeLayout(false);
            this.pnlThanhTien.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpChonChuyen;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayChay;
        private System.Windows.Forms.Label lblChuyen;
        private System.Windows.Forms.ComboBox cboChuyenTau;
        private System.Windows.Forms.Label lblThongTinTuyen;
        private System.Windows.Forms.GroupBox grpHanhKhach;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Button btnKiemTraCCCD;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.GroupBox grpHanhTrinh;
        private System.Windows.Forms.Label lblGaDi;
        private System.Windows.Forms.ComboBox cboGaDi;
        private System.Windows.Forms.Label lblGaDen;
        private System.Windows.Forms.ComboBox cboGaDen;
        private System.Windows.Forms.Label lblLoaiVe;
        private System.Windows.Forms.ComboBox cboLoaiVe;
        private System.Windows.Forms.Label lblKhoangCachGa;
        private System.Windows.Forms.Panel pnlThanhTien;
        private System.Windows.Forms.Label lblTongTienTitle;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Button btnInVe;
        private System.Windows.Forms.Button btnLamMoi;
    }
}
