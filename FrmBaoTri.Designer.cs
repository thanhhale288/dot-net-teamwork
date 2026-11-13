namespace QuanLyTau
{
    partial class FrmBaoTri
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
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cboLocTau = new System.Windows.Forms.ComboBox();
            this.lblLocTau = new System.Windows.Forms.Label();
            this.cboLocTrangThai = new System.Windows.Forms.ComboBox();
            this.lblLocTrangThai = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnTaoLenh = new System.Windows.Forms.Button();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.numChiPhi = new System.Windows.Forms.NumericUpDown();
            this.lblChiPhi = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.dtpNgayHoanThanh = new System.Windows.Forms.DateTimePicker();
            this.lblNgayHoanThanh = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.cboTau = new System.Windows.Forms.ComboBox();
            this.lblTau = new System.Windows.Forms.Label();
            this.txtMaBaoTri = new System.Windows.Forms.TextBox();
            this.lblMaBaoTri = new System.Windows.Forms.Label();
            this.dgvBaoTri = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelTopAction.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChiPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoTri)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(984, 55);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(395, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ BẢO TRÌ & SỬA CHỮA ĐOÀN TÀU";
            // 
            // panelTopAction
            // 
            this.panelTopAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panelTopAction.Controls.Add(this.btnLamMoi);
            this.panelTopAction.Controls.Add(this.btnLoc);
            this.panelTopAction.Controls.Add(this.cboLocTau);
            this.panelTopAction.Controls.Add(this.lblLocTau);
            this.panelTopAction.Controls.Add(this.cboLocTrangThai);
            this.panelTopAction.Controls.Add(this.lblLocTrangThai);
            this.panelTopAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopAction.Location = new System.Drawing.Point(0, 55);
            this.panelTopAction.Name = "panelTopAction";
            this.panelTopAction.Size = new System.Drawing.Size(984, 50);
            this.panelTopAction.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(695, 11);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 28);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(595, 11);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(90, 28);
            this.btnLoc.TabIndex = 4;
            this.btnLoc.Text = "Lọc Dữ Liệu";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cboLocTau
            // 
            this.cboLocTau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTau.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocTau.FormattingEnabled = true;
            this.cboLocTau.Location = new System.Drawing.Point(365, 12);
            this.cboLocTau.Name = "cboLocTau";
            this.cboLocTau.Size = new System.Drawing.Size(210, 25);
            this.cboLocTau.TabIndex = 3;
            this.cboLocTau.SelectedIndexChanged += new System.EventHandler(this.cboLocTau_SelectedIndexChanged);
            // 
            // lblLocTau
            // 
            this.lblLocTau.AutoSize = true;
            this.lblLocTau.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocTau.Location = new System.Drawing.Point(295, 16);
            this.lblLocTau.Name = "lblLocTau";
            this.lblLocTau.Size = new System.Drawing.Size(65, 17);
            this.lblLocTau.TabIndex = 2;
            this.lblLocTau.Text = "Theo tàu:";
            // 
            // cboLocTrangThai
            // 
            this.cboLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocTrangThai.FormattingEnabled = true;
            this.cboLocTrangThai.Items.AddRange(new object[] {
            "Tất cả trạng thái",
            "Đang xử lý",
            "Hoàn thành"});
            this.cboLocTrangThai.Location = new System.Drawing.Point(125, 12);
            this.cboLocTrangThai.Name = "cboLocTrangThai";
            this.cboLocTrangThai.Size = new System.Drawing.Size(150, 25);
            this.cboLocTrangThai.TabIndex = 1;
            this.cboLocTrangThai.SelectedIndexChanged += new System.EventHandler(this.cboLocTrangThai_SelectedIndexChanged);
            // 
            // lblLocTrangThai
            // 
            this.lblLocTrangThai.AutoSize = true;
            this.lblLocTrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocTrangThai.Location = new System.Drawing.Point(15, 16);
            this.lblLocTrangThai.Name = "lblLocTrangThai";
            this.lblLocTrangThai.Size = new System.Drawing.Size(103, 17);
            this.lblLocTrangThai.TabIndex = 0;
            this.lblLocTrangThai.Text = "Theo trạng thái:";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.btnHoanThanh);
            this.grpInfo.Controls.Add(this.btnCapNhat);
            this.grpInfo.Controls.Add(this.btnTaoLenh);
            this.grpInfo.Controls.Add(this.cboTrangThai);
            this.grpInfo.Controls.Add(this.lblTrangThai);
            this.grpInfo.Controls.Add(this.numChiPhi);
            this.grpInfo.Controls.Add(this.lblChiPhi);
            this.grpInfo.Controls.Add(this.txtNoiDung);
            this.grpInfo.Controls.Add(this.lblNoiDung);
            this.grpInfo.Controls.Add(this.dtpNgayHoanThanh);
            this.grpInfo.Controls.Add(this.lblNgayHoanThanh);
            this.grpInfo.Controls.Add(this.dtpNgayBatDau);
            this.grpInfo.Controls.Add(this.lblNgayBatDau);
            this.grpInfo.Controls.Add(this.cboNhanVien);
            this.grpInfo.Controls.Add(this.lblNhanVien);
            this.grpInfo.Controls.Add(this.cboTau);
            this.grpInfo.Controls.Add(this.lblTau);
            this.grpInfo.Controls.Add(this.txtMaBaoTri);
            this.grpInfo.Controls.Add(this.lblMaBaoTri);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(0, 105);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(984, 185);
            this.grpInfo.TabIndex = 2;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông Tin Lệnh Bảo Trì";
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnHoanThanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoanThanh.FlatAppearance.BorderSize = 0;
            this.btnHoanThanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanThanh.Font = new System.Drawing.Font("Segoe UI Bold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanThanh.ForeColor = System.Drawing.Color.White;
            this.btnHoanThanh.Location = new System.Drawing.Point(620, 140);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(210, 35);
            this.btnHoanThanh.TabIndex = 18;
            this.btnHoanThanh.Text = "✔ Đánh Dấu Hoàn Thành";
            this.btnHoanThanh.UseVisualStyleBackColor = false;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(475, 140);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(130, 35);
            this.btnCapNhat.TabIndex = 17;
            this.btnCapNhat.Text = "Cập Nhật Lệnh";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnTaoLenh
            // 
            this.btnTaoLenh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnTaoLenh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoLenh.FlatAppearance.BorderSize = 0;
            this.btnTaoLenh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoLenh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoLenh.ForeColor = System.Drawing.Color.White;
            this.btnTaoLenh.Location = new System.Drawing.Point(280, 140);
            this.btnTaoLenh.Name = "btnTaoLenh";
            this.btnTaoLenh.Size = new System.Drawing.Size(180, 35);
            this.btnTaoLenh.TabIndex = 16;
            this.btnTaoLenh.Text = "+ Tạo Lệnh Bảo Trì Mới";
            this.btnTaoLenh.UseVisualStyleBackColor = false;
            this.btnTaoLenh.Click += new System.EventHandler(this.btnTaoLenh_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Đang xử lý",
            "Hoàn thành"});
            this.cboTrangThai.Location = new System.Drawing.Point(795, 63);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(165, 25);
            this.cboTrangThai.TabIndex = 15;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(715, 67);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(73, 17);
            this.lblTrangThai.TabIndex = 14;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // numChiPhi
            // 
            this.numChiPhi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numChiPhi.Increment = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numChiPhi.Location = new System.Drawing.Point(525, 63);
            this.numChiPhi.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numChiPhi.Name = "numChiPhi";
            this.numChiPhi.Size = new System.Drawing.Size(165, 24);
            this.numChiPhi.TabIndex = 13;
            this.numChiPhi.ThousandsSeparator = true;
            // 
            // lblChiPhi
            // 
            this.lblChiPhi.AutoSize = true;
            this.lblChiPhi.Location = new System.Drawing.Point(425, 67);
            this.lblChiPhi.Name = "lblChiPhi";
            this.lblChiPhi.Size = new System.Drawing.Size(91, 17);
            this.lblChiPhi.TabIndex = 12;
            this.lblChiPhi.Text = "Chi phí (VNĐ):";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(105, 102);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(855, 24);
            this.txtNoiDung.TabIndex = 11;
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Location = new System.Drawing.Point(20, 105);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(68, 17);
            this.lblNoiDung.TabIndex = 10;
            this.lblNoiDung.Text = "Nội dung:";
            // 
            // dtpNgayHoanThanh
            // 
            this.dtpNgayHoanThanh.Checked = false;
            this.dtpNgayHoanThanh.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNgayHoanThanh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayHoanThanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHoanThanh.Location = new System.Drawing.Point(235, 63);
            this.dtpNgayHoanThanh.Name = "dtpNgayHoanThanh";
            this.dtpNgayHoanThanh.ShowCheckBox = true;
            this.dtpNgayHoanThanh.Size = new System.Drawing.Size(175, 24);
            this.dtpNgayHoanThanh.TabIndex = 9;
            // 
            // lblNgayHoanThanh
            // 
            this.lblNgayHoanThanh.AutoSize = true;
            this.lblNgayHoanThanh.Location = new System.Drawing.Point(20, 67);
            this.lblNgayHoanThanh.Name = "lblNgayHoanThanh";
            this.lblNgayHoanThanh.Size = new System.Drawing.Size(117, 17);
            this.lblNgayHoanThanh.TabIndex = 8;
            this.lblNgayHoanThanh.Text = "Ngày hoàn thành:";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(795, 26);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(165, 24);
            this.dtpNgayBatDau.TabIndex = 7;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Location = new System.Drawing.Point(715, 30);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(76, 17);
            this.lblNgayBatDau.TabIndex = 6;
            this.lblNgayBatDau.Text = "Ngày b.đầu:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(525, 26);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(165, 25);
            this.cboNhanVien.TabIndex = 5;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(425, 30);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(94, 17);
            this.lblNhanVien.TabIndex = 4;
            this.lblNhanVien.Text = "Kỹ thuật viên:";
            // 
            // cboTau
            // 
            this.cboTau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTau.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTau.FormattingEnabled = true;
            this.cboTau.Location = new System.Drawing.Point(235, 26);
            this.cboTau.Name = "cboTau";
            this.cboTau.Size = new System.Drawing.Size(175, 25);
            this.cboTau.TabIndex = 3;
            // 
            // lblTau
            // 
            this.lblTau.AutoSize = true;
            this.lblTau.Location = new System.Drawing.Point(170, 30);
            this.lblTau.Name = "lblTau";
            this.lblTau.Size = new System.Drawing.Size(60, 17);
            this.lblTau.TabIndex = 2;
            this.lblTau.Text = "Đoàn tàu:";
            // 
            // txtMaBaoTri
            // 
            this.txtMaBaoTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtMaBaoTri.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBaoTri.Location = new System.Drawing.Point(85, 26);
            this.txtMaBaoTri.Name = "txtMaBaoTri";
            this.txtMaBaoTri.ReadOnly = true;
            this.txtMaBaoTri.Size = new System.Drawing.Size(75, 24);
            this.txtMaBaoTri.TabIndex = 1;
            // 
            // lblMaBaoTri
            // 
            this.lblMaBaoTri.AutoSize = true;
            this.lblMaBaoTri.Location = new System.Drawing.Point(20, 30);
            this.lblMaBaoTri.Name = "lblMaBaoTri";
            this.lblMaBaoTri.Size = new System.Drawing.Size(59, 17);
            this.lblMaBaoTri.TabIndex = 0;
            this.lblMaBaoTri.Text = "Mã lệnh:";
            // 
            // dgvBaoTri
            // 
            this.dgvBaoTri.AllowUserToAddRows = false;
            this.dgvBaoTri.AllowUserToDeleteRows = false;
            this.dgvBaoTri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoTri.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoTri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoTri.Location = new System.Drawing.Point(0, 290);
            this.dgvBaoTri.MultiSelect = false;
            this.dgvBaoTri.Name = "dgvBaoTri";
            this.dgvBaoTri.ReadOnly = true;
            this.dgvBaoTri.RowHeadersWidth = 30;
            this.dgvBaoTri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoTri.Size = new System.Drawing.Size(984, 271);
            this.dgvBaoTri.TabIndex = 3;
            this.dgvBaoTri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaoTri_CellClick);
            // 
            // FrmBaoTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dgvBaoTri);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.panelTopAction);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmBaoTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bảo Trì Đoàn Tàu - Subway";
            this.Load += new System.EventHandler(this.FrmBaoTri_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelTopAction.ResumeLayout(false);
            this.panelTopAction.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChiPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoTri)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTopAction;
        private System.Windows.Forms.Label lblLocTrangThai;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Label lblLocTau;
        private System.Windows.Forms.ComboBox cboLocTau;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblMaBaoTri;
        private System.Windows.Forms.TextBox txtMaBaoTri;
        private System.Windows.Forms.Label lblTau;
        private System.Windows.Forms.ComboBox cboTau;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label lblNgayHoanThanh;
        private System.Windows.Forms.DateTimePicker dtpNgayHoanThanh;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label lblChiPhi;
        private System.Windows.Forms.NumericUpDown numChiPhi;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnTaoLenh;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.DataGridView dgvBaoTri;
    }
}
