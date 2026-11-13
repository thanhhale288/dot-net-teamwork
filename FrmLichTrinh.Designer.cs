namespace QuanLyTau
{
    partial class FrmLichTrinh
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
            this.panelTopAction = new System.Windows.Forms.Panel();
            this.btnXemChuyenTau = new System.Windows.Forms.Button();
            this.btnSinhChuyen = new System.Windows.Forms.Button();
            this.dtpNgaySinhChuyen = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinhChuyen = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlNgayTrongTuan = new System.Windows.Forms.FlowLayoutPanel();
            this.chkT2 = new System.Windows.Forms.CheckBox();
            this.chkT3 = new System.Windows.Forms.CheckBox();
            this.chkT4 = new System.Windows.Forms.CheckBox();
            this.chkT5 = new System.Windows.Forms.CheckBox();
            this.chkT6 = new System.Windows.Forms.CheckBox();
            this.chkT7 = new System.Windows.Forms.CheckBox();
            this.chkCN = new System.Windows.Forms.CheckBox();
            this.lblNgayTrongTuan = new System.Windows.Forms.Label();
            this.dtpGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblGioKetThuc = new System.Windows.Forms.Label();
            this.dtpGioKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.lblGioKhoiHanh = new System.Windows.Forms.Label();
            this.cboTau = new System.Windows.Forms.ComboBox();
            this.lblTau = new System.Windows.Forms.Label();
            this.cboTuyen = new System.Windows.Forms.ComboBox();
            this.lblTuyen = new System.Windows.Forms.Label();
            this.txtMaLichTrinh = new System.Windows.Forms.TextBox();
            this.lblMaLichTrinh = new System.Windows.Forms.Label();
            this.dgvLichTrinh = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelTopAction.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.pnlNgayTrongTuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTrinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(964, 55);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(437, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CẤU HÌNH LỊCH TRÌNH CHẠY TÀU ĐỊNH KỲ";
            // 
            // panelTopAction
            // 
            this.panelTopAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panelTopAction.Controls.Add(this.btnXemChuyenTau);
            this.panelTopAction.Controls.Add(this.btnSinhChuyen);
            this.panelTopAction.Controls.Add(this.dtpNgaySinhChuyen);
            this.panelTopAction.Controls.Add(this.lblNgaySinhChuyen);
            this.panelTopAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopAction.Location = new System.Drawing.Point(0, 55);
            this.panelTopAction.Name = "panelTopAction";
            this.panelTopAction.Size = new System.Drawing.Size(964, 50);
            this.panelTopAction.TabIndex = 1;
            // 
            // btnXemChuyenTau
            // 
            this.btnXemChuyenTau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnXemChuyenTau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemChuyenTau.FlatAppearance.BorderSize = 0;
            this.btnXemChuyenTau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChuyenTau.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChuyenTau.ForeColor = System.Drawing.Color.White;
            this.btnXemChuyenTau.Location = new System.Drawing.Point(620, 11);
            this.btnXemChuyenTau.Name = "btnXemChuyenTau";
            this.btnXemChuyenTau.Size = new System.Drawing.Size(180, 28);
            this.btnXemChuyenTau.TabIndex = 3;
            this.btnXemChuyenTau.Text = "Xem Các Chuyến Tàu >>";
            this.btnXemChuyenTau.UseVisualStyleBackColor = false;
            this.btnXemChuyenTau.Click += new System.EventHandler(this.btnXemChuyenTau_Click);
            // 
            // btnSinhChuyen
            // 
            this.btnSinhChuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSinhChuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinhChuyen.FlatAppearance.BorderSize = 0;
            this.btnSinhChuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinhChuyen.Font = new System.Drawing.Font("Segoe UI Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhChuyen.ForeColor = System.Drawing.Color.White;
            this.btnSinhChuyen.Location = new System.Drawing.Point(380, 11);
            this.btnSinhChuyen.Name = "btnSinhChuyen";
            this.btnSinhChuyen.Size = new System.Drawing.Size(225, 28);
            this.btnSinhChuyen.TabIndex = 2;
            this.btnSinhChuyen.Text = "⚡ Tự Động Sinh Chuyến Ngày Này";
            this.btnSinhChuyen.UseVisualStyleBackColor = false;
            this.btnSinhChuyen.Click += new System.EventHandler(this.btnSinhChuyen_Click);
            // 
            // dtpNgaySinhChuyen
            // 
            this.dtpNgaySinhChuyen.CustomFormat = "dd/MM/yyyy (dddd)";
            this.dtpNgaySinhChuyen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinhChuyen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhChuyen.Location = new System.Drawing.Point(195, 12);
            this.dtpNgaySinhChuyen.Name = "dtpNgaySinhChuyen";
            this.dtpNgaySinhChuyen.Size = new System.Drawing.Size(175, 24);
            this.dtpNgaySinhChuyen.TabIndex = 1;
            // 
            // lblNgaySinhChuyen
            // 
            this.lblNgaySinhChuyen.AutoSize = true;
            this.lblNgaySinhChuyen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinhChuyen.Location = new System.Drawing.Point(15, 16);
            this.lblNgaySinhChuyen.Name = "lblNgaySinhChuyen";
            this.lblNgaySinhChuyen.Size = new System.Drawing.Size(173, 17);
            this.lblNgaySinhChuyen.TabIndex = 0;
            this.lblNgaySinhChuyen.Text = "Sinh chuyến chạy cho ngày:";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.btnLamMoi);
            this.grpInfo.Controls.Add(this.btnXoa);
            this.grpInfo.Controls.Add(this.btnSua);
            this.grpInfo.Controls.Add(this.btnThem);
            this.grpInfo.Controls.Add(this.pnlNgayTrongTuan);
            this.grpInfo.Controls.Add(this.lblNgayTrongTuan);
            this.grpInfo.Controls.Add(this.dtpGioKetThuc);
            this.grpInfo.Controls.Add(this.lblGioKetThuc);
            this.grpInfo.Controls.Add(this.dtpGioKhoiHanh);
            this.grpInfo.Controls.Add(this.lblGioKhoiHanh);
            this.grpInfo.Controls.Add(this.cboTau);
            this.grpInfo.Controls.Add(this.lblTau);
            this.grpInfo.Controls.Add(this.cboTuyen);
            this.grpInfo.Controls.Add(this.lblTuyen);
            this.grpInfo.Controls.Add(this.txtMaLichTrinh);
            this.grpInfo.Controls.Add(this.lblMaLichTrinh);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(0, 105);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(964, 185);
            this.grpInfo.TabIndex = 2;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông Tin Lịch Trình";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(425, 140);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(95, 33);
            this.btnLamMoi.TabIndex = 15;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(320, 140);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 33);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa Lịch";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(215, 140);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 33);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Cập Nhật";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(105, 140);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 33);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm Lịch";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnlNgayTrongTuan
            // 
            this.pnlNgayTrongTuan.Controls.Add(this.chkT2);
            this.pnlNgayTrongTuan.Controls.Add(this.chkT3);
            this.pnlNgayTrongTuan.Controls.Add(this.chkT4);
            this.pnlNgayTrongTuan.Controls.Add(this.chkT5);
            this.pnlNgayTrongTuan.Controls.Add(this.chkT6);
            this.pnlNgayTrongTuan.Controls.Add(this.chkT7);
            this.pnlNgayTrongTuan.Controls.Add(this.chkCN);
            this.pnlNgayTrongTuan.Location = new System.Drawing.Point(125, 98);
            this.pnlNgayTrongTuan.Name = "pnlNgayTrongTuan";
            this.pnlNgayTrongTuan.Size = new System.Drawing.Size(560, 32);
            this.pnlNgayTrongTuan.TabIndex = 11;
            // 
            // chkT2
            // 
            this.chkT2.AutoSize = true;
            this.chkT2.Checked = true;
            this.chkT2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkT2.Location = new System.Drawing.Point(3, 3);
            this.chkT2.Name = "chkT2";
            this.chkT2.Size = new System.Drawing.Size(42, 21);
            this.chkT2.TabIndex = 0;
            this.chkT2.Text = "T2";
            this.chkT2.UseVisualStyleBackColor = true;
            // 
            // chkT3
            // 
            this.chkT3.AutoSize = true;
            this.chkT3.Checked = true;
            this.chkT3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkT3.Location = new System.Drawing.Point(51, 3);
            this.chkT3.Name = "chkT3";
            this.chkT3.Size = new System.Drawing.Size(42, 21);
            this.chkT3.TabIndex = 1;
            this.chkT3.Text = "T3";
            this.chkT3.UseVisualStyleBackColor = true;
            // 
            // chkT4
            // 
            this.chkT4.AutoSize = true;
            this.chkT4.Checked = true;
            this.chkT4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkT4.Location = new System.Drawing.Point(99, 3);
            this.chkT4.Name = "chkT4";
            this.chkT4.Size = new System.Drawing.Size(42, 21);
            this.chkT4.TabIndex = 2;
            this.chkT4.Text = "T4";
            this.chkT4.UseVisualStyleBackColor = true;
            // 
            // chkT5
            // 
            this.chkT5.AutoSize = true;
            this.chkT5.Checked = true;
            this.chkT5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkT5.Location = new System.Drawing.Point(147, 3);
            this.chkT5.Name = "chkT5";
            this.chkT5.Size = new System.Drawing.Size(42, 21);
            this.chkT5.TabIndex = 3;
            this.chkT5.Text = "T5";
            this.chkT5.UseVisualStyleBackColor = true;
            // 
            // chkT6
            // 
            this.chkT6.AutoSize = true;
            this.chkT6.Checked = true;
            this.chkT6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkT6.Location = new System.Drawing.Point(195, 3);
            this.chkT6.Name = "chkT6";
            this.chkT6.Size = new System.Drawing.Size(42, 21);
            this.chkT6.TabIndex = 4;
            this.chkT6.Text = "T6";
            this.chkT6.UseVisualStyleBackColor = true;
            // 
            // chkT7
            // 
            this.chkT7.AutoSize = true;
            this.chkT7.Checked = true;
            this.chkT7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkT7.Location = new System.Drawing.Point(243, 3);
            this.chkT7.Name = "chkT7";
            this.chkT7.Size = new System.Drawing.Size(42, 21);
            this.chkT7.TabIndex = 5;
            this.chkT7.Text = "T7";
            this.chkT7.UseVisualStyleBackColor = true;
            // 
            // chkCN
            // 
            this.chkCN.AutoSize = true;
            this.chkCN.Checked = true;
            this.chkCN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCN.Location = new System.Drawing.Point(291, 3);
            this.chkCN.Name = "chkCN";
            this.chkCN.Size = new System.Drawing.Size(45, 21);
            this.chkCN.TabIndex = 6;
            this.chkCN.Text = "CN";
            this.chkCN.UseVisualStyleBackColor = true;
            // 
            // lblNgayTrongTuan
            // 
            this.lblNgayTrongTuan.AutoSize = true;
            this.lblNgayTrongTuan.Location = new System.Drawing.Point(20, 103);
            this.lblNgayTrongTuan.Name = "lblNgayTrongTuan";
            this.lblNgayTrongTuan.Size = new System.Drawing.Size(89, 17);
            this.lblNgayTrongTuan.TabIndex = 10;
            this.lblNgayTrongTuan.Text = "Ngày áp dụng:";
            // 
            // dtpGioKetThuc
            // 
            this.dtpGioKetThuc.CustomFormat = "HH:mm";
            this.dtpGioKetThuc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGioKetThuc.Location = new System.Drawing.Point(535, 63);
            this.dtpGioKetThuc.Name = "dtpGioKetThuc";
            this.dtpGioKetThuc.ShowUpDown = true;
            this.dtpGioKetThuc.Size = new System.Drawing.Size(100, 24);
            this.dtpGioKetThuc.TabIndex = 9;
            // 
            // lblGioKetThuc
            // 
            this.lblGioKetThuc.AutoSize = true;
            this.lblGioKetThuc.Location = new System.Drawing.Point(445, 67);
            this.lblGioKetThuc.Name = "lblGioKetThuc";
            this.lblGioKetThuc.Size = new System.Drawing.Size(84, 17);
            this.lblGioKetThuc.TabIndex = 8;
            this.lblGioKetThuc.Text = "Giờ đến/kết:";
            // 
            // dtpGioKhoiHanh
            // 
            this.dtpGioKhoiHanh.CustomFormat = "HH:mm";
            this.dtpGioKhoiHanh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGioKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGioKhoiHanh.Location = new System.Drawing.Point(325, 63);
            this.dtpGioKhoiHanh.Name = "dtpGioKhoiHanh";
            this.dtpGioKhoiHanh.ShowUpDown = true;
            this.dtpGioKhoiHanh.Size = new System.Drawing.Size(100, 24);
            this.dtpGioKhoiHanh.TabIndex = 7;
            // 
            // lblGioKhoiHanh
            // 
            this.lblGioKhoiHanh.AutoSize = true;
            this.lblGioKhoiHanh.Location = new System.Drawing.Point(235, 67);
            this.lblGioKhoiHanh.Name = "lblGioKhoiHanh";
            this.lblGioKhoiHanh.Size = new System.Drawing.Size(92, 17);
            this.lblGioKhoiHanh.TabIndex = 6;
            this.lblGioKhoiHanh.Text = "Giờ khởi hành:";
            // 
            // cboTau
            // 
            this.cboTau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTau.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTau.FormattingEnabled = true;
            this.cboTau.Location = new System.Drawing.Point(535, 26);
            this.cboTau.Name = "cboTau";
            this.cboTau.Size = new System.Drawing.Size(220, 25);
            this.cboTau.TabIndex = 5;
            // 
            // lblTau
            // 
            this.lblTau.AutoSize = true;
            this.lblTau.Location = new System.Drawing.Point(445, 30);
            this.lblTau.Name = "lblTau";
            this.lblTau.Size = new System.Drawing.Size(60, 17);
            this.lblTau.TabIndex = 4;
            this.lblTau.Text = "Đoàn tàu:";
            // 
            // cboTuyen
            // 
            this.cboTuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTuyen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTuyen.FormattingEnabled = true;
            this.cboTuyen.Location = new System.Drawing.Point(105, 26);
            this.cboTuyen.Name = "cboTuyen";
            this.cboTuyen.Size = new System.Drawing.Size(320, 25);
            this.cboTuyen.TabIndex = 3;
            this.cboTuyen.SelectedIndexChanged += new System.EventHandler(this.cboTuyen_SelectedIndexChanged);
            // 
            // lblTuyen
            // 
            this.lblTuyen.AutoSize = true;
            this.lblTuyen.Location = new System.Drawing.Point(20, 30);
            this.lblTuyen.Name = "lblTuyen";
            this.lblTuyen.Size = new System.Drawing.Size(70, 17);
            this.lblTuyen.TabIndex = 2;
            this.lblTuyen.Text = "Tuyến tàu:";
            // 
            // txtMaLichTrinh
            // 
            this.txtMaLichTrinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtMaLichTrinh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLichTrinh.Location = new System.Drawing.Point(105, 63);
            this.txtMaLichTrinh.Name = "txtMaLichTrinh";
            this.txtMaLichTrinh.ReadOnly = true;
            this.txtMaLichTrinh.Size = new System.Drawing.Size(100, 24);
            this.txtMaLichTrinh.TabIndex = 1;
            // 
            // lblMaLichTrinh
            // 
            this.lblMaLichTrinh.AutoSize = true;
            this.lblMaLichTrinh.Location = new System.Drawing.Point(20, 67);
            this.lblMaLichTrinh.Name = "lblMaLichTrinh";
            this.lblMaLichTrinh.Size = new System.Drawing.Size(84, 17);
            this.lblMaLichTrinh.TabIndex = 0;
            this.lblMaLichTrinh.Text = "Mã lịch trình:";
            // 
            // dgvLichTrinh
            // 
            this.dgvLichTrinh.AllowUserToAddRows = false;
            this.dgvLichTrinh.AllowUserToDeleteRows = false;
            this.dgvLichTrinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichTrinh.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichTrinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichTrinh.Location = new System.Drawing.Point(0, 290);
            this.dgvLichTrinh.MultiSelect = false;
            this.dgvLichTrinh.Name = "dgvLichTrinh";
            this.dgvLichTrinh.ReadOnly = true;
            this.dgvLichTrinh.RowHeadersWidth = 30;
            this.dgvLichTrinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichTrinh.Size = new System.Drawing.Size(964, 271);
            this.dgvLichTrinh.TabIndex = 3;
            this.dgvLichTrinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichTrinh_CellClick);
            // 
            // FrmLichTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 561);
            this.Controls.Add(this.dgvLichTrinh);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.panelTopAction);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmLichTrinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu Hình Lịch Trình Tàu - Subway";
            this.Load += new System.EventHandler(this.FrmLichTrinh_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelTopAction.ResumeLayout(false);
            this.panelTopAction.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.pnlNgayTrongTuan.ResumeLayout(false);
            this.pnlNgayTrongTuan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTrinh)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTopAction;
        private System.Windows.Forms.Label lblNgaySinhChuyen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhChuyen;
        private System.Windows.Forms.Button btnSinhChuyen;
        private System.Windows.Forms.Button btnXemChuyenTau;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblMaLichTrinh;
        private System.Windows.Forms.TextBox txtMaLichTrinh;
        private System.Windows.Forms.Label lblTuyen;
        private System.Windows.Forms.ComboBox cboTuyen;
        private System.Windows.Forms.Label lblTau;
        private System.Windows.Forms.ComboBox cboTau;
        private System.Windows.Forms.Label lblGioKhoiHanh;
        private System.Windows.Forms.DateTimePicker dtpGioKhoiHanh;
        private System.Windows.Forms.Label lblGioKetThuc;
        private System.Windows.Forms.DateTimePicker dtpGioKetThuc;
        private System.Windows.Forms.Label lblNgayTrongTuan;
        private System.Windows.Forms.FlowLayoutPanel pnlNgayTrongTuan;
        private System.Windows.Forms.CheckBox chkT2;
        private System.Windows.Forms.CheckBox chkT3;
        private System.Windows.Forms.CheckBox chkT4;
        private System.Windows.Forms.CheckBox chkT5;
        private System.Windows.Forms.CheckBox chkT6;
        private System.Windows.Forms.CheckBox chkT7;
        private System.Windows.Forms.CheckBox chkCN;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvLichTrinh;
    }
}
