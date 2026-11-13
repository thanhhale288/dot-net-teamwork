namespace QuanLyTau
{
    partial class FrmBaoCao
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
            this.tabBaoCao = new System.Windows.Forms.TabControl();
            this.tabDoanhThuNgay = new System.Windows.Forms.TabPage();
            this.dgvDoanhThuNgay = new System.Windows.Forms.DataGridView();
            this.pnlCardsNgay = new System.Windows.Forms.Panel();
            this.pnlCardDoanhThu = new System.Windows.Forms.Panel();
            this.lblTongDoanhThuVal = new System.Windows.Forms.Label();
            this.lblTongDoanhThuTitle = new System.Windows.Forms.Label();
            this.pnlCardVeHuy = new System.Windows.Forms.Panel();
            this.lblTongVeHuyVal = new System.Windows.Forms.Label();
            this.lblTongVeHuyTitle = new System.Windows.Forms.Label();
            this.pnlCardVeBan = new System.Windows.Forms.Panel();
            this.lblTongVeBanVal = new System.Windows.Forms.Label();
            this.lblTongVeBanTitle = new System.Windows.Forms.Label();
            this.pnlFilterNgay = new System.Windows.Forms.Panel();
            this.btnThongKeNgay = new System.Windows.Forms.Button();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.tabDoanhThuTuyen = new System.Windows.Forms.TabPage();
            this.dgvDoanhThuTuyen = new System.Windows.Forms.DataGridView();
            this.pnlFilterTuyen = new System.Windows.Forms.Panel();
            this.btnThongKeTuyen = new System.Windows.Forms.Button();
            this.dtpTuyenKT = new System.Windows.Forms.DateTimePicker();
            this.lblTuyenKT = new System.Windows.Forms.Label();
            this.dtpTuyenBD = new System.Windows.Forms.DateTimePicker();
            this.lblTuyenBD = new System.Windows.Forms.Label();
            this.tabBaoTri = new System.Windows.Forms.TabPage();
            this.dgvBaoTriThongKe = new System.Windows.Forms.DataGridView();
            this.pnlCardsBaoTri = new System.Windows.Forms.Panel();
            this.pnlCardChiPhiBT = new System.Windows.Forms.Panel();
            this.lblTongChiPhiBTVal = new System.Windows.Forms.Label();
            this.lblTongChiPhiBTTitle = new System.Windows.Forms.Label();
            this.pnlCardLuotBT = new System.Windows.Forms.Panel();
            this.lblTongLuotBTVal = new System.Windows.Forms.Label();
            this.lblTongLuotBTTitle = new System.Windows.Forms.Label();
            this.pnlFilterBaoTri = new System.Windows.Forms.Panel();
            this.btnThongKeBaoTri = new System.Windows.Forms.Button();
            this.cboLocTauBT = new System.Windows.Forms.ComboBox();
            this.lblLocTauBT = new System.Windows.Forms.Label();
            this.dtpBTKT = new System.Windows.Forms.DateTimePicker();
            this.lblBTKT = new System.Windows.Forms.Label();
            this.dtpBTBD = new System.Windows.Forms.DateTimePicker();
            this.lblBTBD = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.tabBaoCao.SuspendLayout();
            this.tabDoanhThuNgay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuNgay)).BeginInit();
            this.pnlCardsNgay.SuspendLayout();
            this.pnlCardDoanhThu.SuspendLayout();
            this.pnlCardVeHuy.SuspendLayout();
            this.pnlCardVeBan.SuspendLayout();
            this.pnlFilterNgay.SuspendLayout();
            this.tabDoanhThuTuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuTuyen)).BeginInit();
            this.pnlFilterTuyen.SuspendLayout();
            this.tabBaoTri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoTriThongKe)).BeginInit();
            this.pnlCardsBaoTri.SuspendLayout();
            this.pnlCardChiPhiBT.SuspendLayout();
            this.pnlCardLuotBT.SuspendLayout();
            this.pnlFilterBaoTri.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(469, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁO CÁO THỐNG KÊ DOANH THU && BẢO TRÌ SUBWAY";
            // 
            // tabBaoCao
            // 
            this.tabBaoCao.Controls.Add(this.tabDoanhThuNgay);
            this.tabBaoCao.Controls.Add(this.tabDoanhThuTuyen);
            this.tabBaoCao.Controls.Add(this.tabBaoTri);
            this.tabBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBaoCao.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBaoCao.Location = new System.Drawing.Point(0, 55);
            this.tabBaoCao.Name = "tabBaoCao";
            this.tabBaoCao.SelectedIndex = 0;
            this.tabBaoCao.Size = new System.Drawing.Size(984, 556);
            this.tabBaoCao.TabIndex = 1;
            // 
            // tabDoanhThuNgay
            // 
            this.tabDoanhThuNgay.Controls.Add(this.dgvDoanhThuNgay);
            this.tabDoanhThuNgay.Controls.Add(this.pnlCardsNgay);
            this.tabDoanhThuNgay.Controls.Add(this.pnlFilterNgay);
            this.tabDoanhThuNgay.Location = new System.Drawing.Point(4, 26);
            this.tabDoanhThuNgay.Name = "tabDoanhThuNgay";
            this.tabDoanhThuNgay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoanhThuNgay.Size = new System.Drawing.Size(976, 526);
            this.tabDoanhThuNgay.TabIndex = 0;
            this.tabDoanhThuNgay.Text = "1. Doanh Thu Theo Khoảng Ngày";
            this.tabDoanhThuNgay.UseVisualStyleBackColor = true;
            // 
            // dgvDoanhThuNgay
            // 
            this.dgvDoanhThuNgay.AllowUserToAddRows = false;
            this.dgvDoanhThuNgay.AllowUserToDeleteRows = false;
            this.dgvDoanhThuNgay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThuNgay.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoanhThuNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThuNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThuNgay.Location = new System.Drawing.Point(3, 153);
            this.dgvDoanhThuNgay.MultiSelect = false;
            this.dgvDoanhThuNgay.Name = "dgvDoanhThuNgay";
            this.dgvDoanhThuNgay.ReadOnly = true;
            this.dgvDoanhThuNgay.RowHeadersWidth = 30;
            this.dgvDoanhThuNgay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhThuNgay.Size = new System.Drawing.Size(970, 370);
            this.dgvDoanhThuNgay.TabIndex = 2;
            // 
            // pnlCardsNgay
            // 
            this.pnlCardsNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlCardsNgay.Controls.Add(this.pnlCardDoanhThu);
            this.pnlCardsNgay.Controls.Add(this.pnlCardVeHuy);
            this.pnlCardsNgay.Controls.Add(this.pnlCardVeBan);
            this.pnlCardsNgay.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardsNgay.Location = new System.Drawing.Point(3, 53);
            this.pnlCardsNgay.Name = "pnlCardsNgay";
            this.pnlCardsNgay.Size = new System.Drawing.Size(970, 100);
            this.pnlCardsNgay.TabIndex = 1;
            // 
            // pnlCardDoanhThu
            // 
            this.pnlCardDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.pnlCardDoanhThu.Controls.Add(this.lblTongDoanhThuVal);
            this.pnlCardDoanhThu.Controls.Add(this.lblTongDoanhThuTitle);
            this.pnlCardDoanhThu.Location = new System.Drawing.Point(580, 12);
            this.pnlCardDoanhThu.Name = "pnlCardDoanhThu";
            this.pnlCardDoanhThu.Size = new System.Drawing.Size(320, 75);
            this.pnlCardDoanhThu.TabIndex = 2;
            // 
            // lblTongDoanhThuVal
            // 
            this.lblTongDoanhThuVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThuVal.ForeColor = System.Drawing.Color.White;
            this.lblTongDoanhThuVal.Location = new System.Drawing.Point(10, 35);
            this.lblTongDoanhThuVal.Name = "lblTongDoanhThuVal";
            this.lblTongDoanhThuVal.Size = new System.Drawing.Size(300, 30);
            this.lblTongDoanhThuVal.TabIndex = 1;
            this.lblTongDoanhThuVal.Text = "0 VNĐ";
            this.lblTongDoanhThuVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongDoanhThuTitle
            // 
            this.lblTongDoanhThuTitle.AutoSize = true;
            this.lblTongDoanhThuTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThuTitle.ForeColor = System.Drawing.Color.White;
            this.lblTongDoanhThuTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTongDoanhThuTitle.Name = "lblTongDoanhThuTitle";
            this.lblTongDoanhThuTitle.Size = new System.Drawing.Size(178, 17);
            this.lblTongDoanhThuTitle.TabIndex = 0;
            this.lblTongDoanhThuTitle.Text = "TỔNG DOANH THU THỰC TẾ";
            // 
            // pnlCardVeHuy
            // 
            this.pnlCardVeHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pnlCardVeHuy.Controls.Add(this.lblTongVeHuyVal);
            this.pnlCardVeHuy.Controls.Add(this.lblTongVeHuyTitle);
            this.pnlCardVeHuy.Location = new System.Drawing.Point(300, 12);
            this.pnlCardVeHuy.Name = "pnlCardVeHuy";
            this.pnlCardVeHuy.Size = new System.Drawing.Size(260, 75);
            this.pnlCardVeHuy.TabIndex = 1;
            // 
            // lblTongVeHuyVal
            // 
            this.lblTongVeHuyVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongVeHuyVal.ForeColor = System.Drawing.Color.White;
            this.lblTongVeHuyVal.Location = new System.Drawing.Point(10, 32);
            this.lblTongVeHuyVal.Name = "lblTongVeHuyVal";
            this.lblTongVeHuyVal.Size = new System.Drawing.Size(240, 32);
            this.lblTongVeHuyVal.TabIndex = 1;
            this.lblTongVeHuyVal.Text = "0";
            this.lblTongVeHuyVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongVeHuyTitle
            // 
            this.lblTongVeHuyTitle.AutoSize = true;
            this.lblTongVeHuyTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongVeHuyTitle.ForeColor = System.Drawing.Color.White;
            this.lblTongVeHuyTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTongVeHuyTitle.Name = "lblTongVeHuyTitle";
            this.lblTongVeHuyTitle.Size = new System.Drawing.Size(124, 17);
            this.lblTongVeHuyTitle.TabIndex = 0;
            this.lblTongVeHuyTitle.Text = "TỔNG SỐ VÉ BỊ HỦY";
            // 
            // pnlCardVeBan
            // 
            this.pnlCardVeBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.pnlCardVeBan.Controls.Add(this.lblTongVeBanVal);
            this.pnlCardVeBan.Controls.Add(this.lblTongVeBanTitle);
            this.pnlCardVeBan.Location = new System.Drawing.Point(20, 12);
            this.pnlCardVeBan.Name = "pnlCardVeBan";
            this.pnlCardVeBan.Size = new System.Drawing.Size(260, 75);
            this.pnlCardVeBan.TabIndex = 0;
            // 
            // lblTongVeBanVal
            // 
            this.lblTongVeBanVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongVeBanVal.ForeColor = System.Drawing.Color.White;
            this.lblTongVeBanVal.Location = new System.Drawing.Point(10, 32);
            this.lblTongVeBanVal.Name = "lblTongVeBanVal";
            this.lblTongVeBanVal.Size = new System.Drawing.Size(240, 32);
            this.lblTongVeBanVal.TabIndex = 1;
            this.lblTongVeBanVal.Text = "0";
            this.lblTongVeBanVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongVeBanTitle
            // 
            this.lblTongVeBanTitle.AutoSize = true;
            this.lblTongVeBanTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongVeBanTitle.ForeColor = System.Drawing.Color.White;
            this.lblTongVeBanTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTongVeBanTitle.Name = "lblTongVeBanTitle";
            this.lblTongVeBanTitle.Size = new System.Drawing.Size(133, 17);
            this.lblTongVeBanTitle.TabIndex = 0;
            this.lblTongVeBanTitle.Text = "TỔNG SỐ VÉ ĐÃ BÁN";
            // 
            // pnlFilterNgay
            // 
            this.pnlFilterNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.pnlFilterNgay.Controls.Add(this.btnThongKeNgay);
            this.pnlFilterNgay.Controls.Add(this.dtpNgayKT);
            this.pnlFilterNgay.Controls.Add(this.lblNgayKT);
            this.pnlFilterNgay.Controls.Add(this.dtpNgayBD);
            this.pnlFilterNgay.Controls.Add(this.lblNgayBD);
            this.pnlFilterNgay.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterNgay.Location = new System.Drawing.Point(3, 3);
            this.pnlFilterNgay.Name = "pnlFilterNgay";
            this.pnlFilterNgay.Size = new System.Drawing.Size(970, 50);
            this.pnlFilterNgay.TabIndex = 0;
            // 
            // btnThongKeNgay
            // 
            this.btnThongKeNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnThongKeNgay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKeNgay.FlatAppearance.BorderSize = 0;
            this.btnThongKeNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeNgay.ForeColor = System.Drawing.Color.White;
            this.btnThongKeNgay.Location = new System.Drawing.Point(540, 10);
            this.btnThongKeNgay.Name = "btnThongKeNgay";
            this.btnThongKeNgay.Size = new System.Drawing.Size(140, 30);
            this.btnThongKeNgay.TabIndex = 4;
            this.btnThongKeNgay.Text = "Xem Thống Kê";
            this.btnThongKeNgay.UseVisualStyleBackColor = false;
            this.btnThongKeNgay.Click += new System.EventHandler(this.btnThongKeNgay_Click);
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(365, 13);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(140, 24);
            this.dtpNgayKT.TabIndex = 3;
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.AutoSize = true;
            this.lblNgayKT.Location = new System.Drawing.Point(290, 16);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(71, 19);
            this.lblNgayKT.TabIndex = 2;
            this.lblNgayKT.Text = "Đến ngày:";
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(125, 13);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(140, 24);
            this.dtpNgayBD.TabIndex = 1;
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Location = new System.Drawing.Point(20, 16);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(63, 19);
            this.lblNgayBD.TabIndex = 0;
            this.lblNgayBD.Text = "Từ ngày:";
            // 
            // tabDoanhThuTuyen
            // 
            this.tabDoanhThuTuyen.Controls.Add(this.dgvDoanhThuTuyen);
            this.tabDoanhThuTuyen.Controls.Add(this.pnlFilterTuyen);
            this.tabDoanhThuTuyen.Location = new System.Drawing.Point(4, 26);
            this.tabDoanhThuTuyen.Name = "tabDoanhThuTuyen";
            this.tabDoanhThuTuyen.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoanhThuTuyen.Size = new System.Drawing.Size(976, 526);
            this.tabDoanhThuTuyen.TabIndex = 1;
            this.tabDoanhThuTuyen.Text = "2. Doanh Thu Theo Tuyến Tàu";
            this.tabDoanhThuTuyen.UseVisualStyleBackColor = true;
            // 
            // dgvDoanhThuTuyen
            // 
            this.dgvDoanhThuTuyen.AllowUserToAddRows = false;
            this.dgvDoanhThuTuyen.AllowUserToDeleteRows = false;
            this.dgvDoanhThuTuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThuTuyen.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoanhThuTuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThuTuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThuTuyen.Location = new System.Drawing.Point(3, 53);
            this.dgvDoanhThuTuyen.MultiSelect = false;
            this.dgvDoanhThuTuyen.Name = "dgvDoanhThuTuyen";
            this.dgvDoanhThuTuyen.ReadOnly = true;
            this.dgvDoanhThuTuyen.RowHeadersWidth = 30;
            this.dgvDoanhThuTuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhThuTuyen.Size = new System.Drawing.Size(970, 470);
            this.dgvDoanhThuTuyen.TabIndex = 1;
            // 
            // pnlFilterTuyen
            // 
            this.pnlFilterTuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.pnlFilterTuyen.Controls.Add(this.btnThongKeTuyen);
            this.pnlFilterTuyen.Controls.Add(this.dtpTuyenKT);
            this.pnlFilterTuyen.Controls.Add(this.lblTuyenKT);
            this.pnlFilterTuyen.Controls.Add(this.dtpTuyenBD);
            this.pnlFilterTuyen.Controls.Add(this.lblTuyenBD);
            this.pnlFilterTuyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterTuyen.Location = new System.Drawing.Point(3, 3);
            this.pnlFilterTuyen.Name = "pnlFilterTuyen";
            this.pnlFilterTuyen.Size = new System.Drawing.Size(970, 50);
            this.pnlFilterTuyen.TabIndex = 0;
            // 
            // btnThongKeTuyen
            // 
            this.btnThongKeTuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnThongKeTuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKeTuyen.FlatAppearance.BorderSize = 0;
            this.btnThongKeTuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeTuyen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeTuyen.ForeColor = System.Drawing.Color.White;
            this.btnThongKeTuyen.Location = new System.Drawing.Point(540, 10);
            this.btnThongKeTuyen.Name = "btnThongKeTuyen";
            this.btnThongKeTuyen.Size = new System.Drawing.Size(140, 30);
            this.btnThongKeTuyen.TabIndex = 4;
            this.btnThongKeTuyen.Text = "Xem Thống Kê";
            this.btnThongKeTuyen.UseVisualStyleBackColor = false;
            this.btnThongKeTuyen.Click += new System.EventHandler(this.btnThongKeTuyen_Click);
            // 
            // dtpTuyenKT
            // 
            this.dtpTuyenKT.CustomFormat = "dd/MM/yyyy";
            this.dtpTuyenKT.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuyenKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuyenKT.Location = new System.Drawing.Point(365, 13);
            this.dtpTuyenKT.Name = "dtpTuyenKT";
            this.dtpTuyenKT.Size = new System.Drawing.Size(140, 24);
            this.dtpTuyenKT.TabIndex = 3;
            // 
            // lblTuyenKT
            // 
            this.lblTuyenKT.AutoSize = true;
            this.lblTuyenKT.Location = new System.Drawing.Point(290, 16);
            this.lblTuyenKT.Name = "lblTuyenKT";
            this.lblTuyenKT.Size = new System.Drawing.Size(71, 19);
            this.lblTuyenKT.TabIndex = 2;
            this.lblTuyenKT.Text = "Đến ngày:";
            // 
            // dtpTuyenBD
            // 
            this.dtpTuyenBD.CustomFormat = "dd/MM/yyyy";
            this.dtpTuyenBD.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuyenBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuyenBD.Location = new System.Drawing.Point(125, 13);
            this.dtpTuyenBD.Name = "dtpTuyenBD";
            this.dtpTuyenBD.Size = new System.Drawing.Size(140, 24);
            this.dtpTuyenBD.TabIndex = 1;
            // 
            // lblTuyenBD
            // 
            this.lblTuyenBD.AutoSize = true;
            this.lblTuyenBD.Location = new System.Drawing.Point(20, 16);
            this.lblTuyenBD.Name = "lblTuyenBD";
            this.lblTuyenBD.Size = new System.Drawing.Size(63, 19);
            this.lblTuyenBD.TabIndex = 0;
            this.lblTuyenBD.Text = "Từ ngày:";
            // 
            // tabBaoTri
            // 
            this.tabBaoTri.Controls.Add(this.dgvBaoTriThongKe);
            this.tabBaoTri.Controls.Add(this.pnlCardsBaoTri);
            this.tabBaoTri.Controls.Add(this.pnlFilterBaoTri);
            this.tabBaoTri.Location = new System.Drawing.Point(4, 26);
            this.tabBaoTri.Name = "tabBaoTri";
            this.tabBaoTri.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaoTri.Size = new System.Drawing.Size(976, 526);
            this.tabBaoTri.TabIndex = 2;
            this.tabBaoTri.Text = "3. Chi Phí & Lịch Sử Bảo Trì";
            this.tabBaoTri.UseVisualStyleBackColor = true;
            // 
            // dgvBaoTriThongKe
            // 
            this.dgvBaoTriThongKe.AllowUserToAddRows = false;
            this.dgvBaoTriThongKe.AllowUserToDeleteRows = false;
            this.dgvBaoTriThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoTriThongKe.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoTriThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoTriThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoTriThongKe.Location = new System.Drawing.Point(3, 153);
            this.dgvBaoTriThongKe.MultiSelect = false;
            this.dgvBaoTriThongKe.Name = "dgvBaoTriThongKe";
            this.dgvBaoTriThongKe.ReadOnly = true;
            this.dgvBaoTriThongKe.RowHeadersWidth = 30;
            this.dgvBaoTriThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoTriThongKe.Size = new System.Drawing.Size(970, 370);
            this.dgvBaoTriThongKe.TabIndex = 2;
            // 
            // pnlCardsBaoTri
            // 
            this.pnlCardsBaoTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlCardsBaoTri.Controls.Add(this.pnlCardChiPhiBT);
            this.pnlCardsBaoTri.Controls.Add(this.pnlCardLuotBT);
            this.pnlCardsBaoTri.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardsBaoTri.Location = new System.Drawing.Point(3, 53);
            this.pnlCardsBaoTri.Name = "pnlCardsBaoTri";
            this.pnlCardsBaoTri.Size = new System.Drawing.Size(970, 100);
            this.pnlCardsBaoTri.TabIndex = 1;
            // 
            // pnlCardChiPhiBT
            // 
            this.pnlCardChiPhiBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.pnlCardChiPhiBT.Controls.Add(this.lblTongChiPhiBTVal);
            this.pnlCardChiPhiBT.Controls.Add(this.lblTongChiPhiBTTitle);
            this.pnlCardChiPhiBT.Location = new System.Drawing.Point(400, 12);
            this.pnlCardChiPhiBT.Name = "pnlCardChiPhiBT";
            this.pnlCardChiPhiBT.Size = new System.Drawing.Size(350, 75);
            this.pnlCardChiPhiBT.TabIndex = 1;
            // 
            // lblTongChiPhiBTVal
            // 
            this.lblTongChiPhiBTVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongChiPhiBTVal.ForeColor = System.Drawing.Color.White;
            this.lblTongChiPhiBTVal.Location = new System.Drawing.Point(10, 35);
            this.lblTongChiPhiBTVal.Name = "lblTongChiPhiBTVal";
            this.lblTongChiPhiBTVal.Size = new System.Drawing.Size(330, 30);
            this.lblTongChiPhiBTVal.TabIndex = 1;
            this.lblTongChiPhiBTVal.Text = "0 VNĐ";
            this.lblTongChiPhiBTVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongChiPhiBTTitle
            // 
            this.lblTongChiPhiBTTitle.AutoSize = true;
            this.lblTongChiPhiBTTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongChiPhiBTTitle.ForeColor = System.Drawing.Color.White;
            this.lblTongChiPhiBTTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTongChiPhiBTTitle.Name = "lblTongChiPhiBTTitle";
            this.lblTongChiPhiBTTitle.Size = new System.Drawing.Size(183, 17);
            this.lblTongChiPhiBTTitle.TabIndex = 0;
            this.lblTongChiPhiBTTitle.Text = "TỔNG CHI PHÍ BẢO TRÌ (VNĐ)";
            // 
            // pnlCardLuotBT
            // 
            this.pnlCardLuotBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.pnlCardLuotBT.Controls.Add(this.lblTongLuotBTVal);
            this.pnlCardLuotBT.Controls.Add(this.lblTongLuotBTTitle);
            this.pnlCardLuotBT.Location = new System.Drawing.Point(20, 12);
            this.pnlCardLuotBT.Name = "pnlCardLuotBT";
            this.pnlCardLuotBT.Size = new System.Drawing.Size(350, 75);
            this.pnlCardLuotBT.TabIndex = 0;
            // 
            // lblTongLuotBTVal
            // 
            this.lblTongLuotBTVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongLuotBTVal.ForeColor = System.Drawing.Color.White;
            this.lblTongLuotBTVal.Location = new System.Drawing.Point(10, 32);
            this.lblTongLuotBTVal.Name = "lblTongLuotBTVal";
            this.lblTongLuotBTVal.Size = new System.Drawing.Size(330, 32);
            this.lblTongLuotBTVal.TabIndex = 1;
            this.lblTongLuotBTVal.Text = "0 lượt";
            this.lblTongLuotBTVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongLuotBTTitle
            // 
            this.lblTongLuotBTTitle.AutoSize = true;
            this.lblTongLuotBTTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongLuotBTTitle.ForeColor = System.Drawing.Color.White;
            this.lblTongLuotBTTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTongLuotBTTitle.Name = "lblTongLuotBTTitle";
            this.lblTongLuotBTTitle.Size = new System.Drawing.Size(193, 17);
            this.lblTongLuotBTTitle.TabIndex = 0;
            this.lblTongLuotBTTitle.Text = "TỔNG SỐ LƯỢT BẢO TRÌ TÀU";
            // 
            // pnlFilterBaoTri
            // 
            this.pnlFilterBaoTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.pnlFilterBaoTri.Controls.Add(this.btnThongKeBaoTri);
            this.pnlFilterBaoTri.Controls.Add(this.cboLocTauBT);
            this.pnlFilterBaoTri.Controls.Add(this.lblLocTauBT);
            this.pnlFilterBaoTri.Controls.Add(this.dtpBTKT);
            this.pnlFilterBaoTri.Controls.Add(this.lblBTKT);
            this.pnlFilterBaoTri.Controls.Add(this.dtpBTBD);
            this.pnlFilterBaoTri.Controls.Add(this.lblBTBD);
            this.pnlFilterBaoTri.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterBaoTri.Location = new System.Drawing.Point(3, 3);
            this.pnlFilterBaoTri.Name = "pnlFilterBaoTri";
            this.pnlFilterBaoTri.Size = new System.Drawing.Size(970, 50);
            this.pnlFilterBaoTri.TabIndex = 0;
            // 
            // btnThongKeBaoTri
            // 
            this.btnThongKeBaoTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnThongKeBaoTri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKeBaoTri.FlatAppearance.BorderSize = 0;
            this.btnThongKeBaoTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeBaoTri.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeBaoTri.ForeColor = System.Drawing.Color.White;
            this.btnThongKeBaoTri.Location = new System.Drawing.Point(760, 10);
            this.btnThongKeBaoTri.Name = "btnThongKeBaoTri";
            this.btnThongKeBaoTri.Size = new System.Drawing.Size(140, 30);
            this.btnThongKeBaoTri.TabIndex = 6;
            this.btnThongKeBaoTri.Text = "Xem Thống Kê";
            this.btnThongKeBaoTri.UseVisualStyleBackColor = false;
            this.btnThongKeBaoTri.Click += new System.EventHandler(this.btnThongKeBaoTri_Click);
            // 
            // cboLocTauBT
            // 
            this.cboLocTauBT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTauBT.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocTauBT.FormattingEnabled = true;
            this.cboLocTauBT.Location = new System.Drawing.Point(545, 12);
            this.cboLocTauBT.Name = "cboLocTauBT";
            this.cboLocTauBT.Size = new System.Drawing.Size(195, 25);
            this.cboLocTauBT.TabIndex = 5;
            // 
            // lblLocTauBT
            // 
            this.lblLocTauBT.AutoSize = true;
            this.lblLocTauBT.Location = new System.Drawing.Point(475, 16);
            this.lblLocTauBT.Name = "lblLocTauBT";
            this.lblLocTauBT.Size = new System.Drawing.Size(68, 19);
            this.lblLocTauBT.TabIndex = 4;
            this.lblLocTauBT.Text = "Chọn tàu:";
            // 
            // dtpBTKT
            // 
            this.dtpBTKT.CustomFormat = "dd/MM/yyyy";
            this.dtpBTKT.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBTKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBTKT.Location = new System.Drawing.Point(325, 13);
            this.dtpBTKT.Name = "dtpBTKT";
            this.dtpBTKT.Size = new System.Drawing.Size(130, 24);
            this.dtpBTKT.TabIndex = 3;
            // 
            // lblBTKT
            // 
            this.lblBTKT.AutoSize = true;
            this.lblBTKT.Location = new System.Drawing.Point(250, 16);
            this.lblBTKT.Name = "lblBTKT";
            this.lblBTKT.Size = new System.Drawing.Size(71, 19);
            this.lblBTKT.TabIndex = 2;
            this.lblBTKT.Text = "Đến ngày:";
            // 
            // dtpBTBD
            // 
            this.dtpBTBD.CustomFormat = "dd/MM/yyyy";
            this.dtpBTBD.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBTBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBTBD.Location = new System.Drawing.Point(105, 13);
            this.dtpBTBD.Name = "dtpBTBD";
            this.dtpBTBD.Size = new System.Drawing.Size(130, 24);
            this.dtpBTBD.TabIndex = 1;
            // 
            // lblBTBD
            // 
            this.lblBTBD.AutoSize = true;
            this.lblBTBD.Location = new System.Drawing.Point(20, 16);
            this.lblBTBD.Name = "lblBTBD";
            this.lblBTBD.Size = new System.Drawing.Size(63, 19);
            this.lblBTBD.TabIndex = 0;
            this.lblBTBD.Text = "Từ ngày:";
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.tabBaoCao);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Thống Kê - Subway";
            this.Load += new System.EventHandler(this.FrmBaoCao_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabBaoCao.ResumeLayout(false);
            this.tabDoanhThuNgay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuNgay)).EndInit();
            this.pnlCardsNgay.ResumeLayout(false);
            this.pnlCardDoanhThu.ResumeLayout(false);
            this.pnlCardDoanhThu.PerformLayout();
            this.pnlCardVeHuy.ResumeLayout(false);
            this.pnlCardVeHuy.PerformLayout();
            this.pnlCardVeBan.ResumeLayout(false);
            this.pnlCardVeBan.PerformLayout();
            this.pnlFilterNgay.ResumeLayout(false);
            this.pnlFilterNgay.PerformLayout();
            this.tabDoanhThuTuyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuTuyen)).EndInit();
            this.pnlFilterTuyen.ResumeLayout(false);
            this.pnlFilterTuyen.PerformLayout();
            this.tabBaoTri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoTriThongKe)).EndInit();
            this.pnlCardsBaoTri.ResumeLayout(false);
            this.pnlCardChiPhiBT.ResumeLayout(false);
            this.pnlCardChiPhiBT.PerformLayout();
            this.pnlCardLuotBT.ResumeLayout(false);
            this.pnlCardLuotBT.PerformLayout();
            this.pnlFilterBaoTri.ResumeLayout(false);
            this.pnlFilterBaoTri.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabBaoCao;
        private System.Windows.Forms.TabPage tabDoanhThuNgay;
        private System.Windows.Forms.TabPage tabDoanhThuTuyen;
        private System.Windows.Forms.TabPage tabBaoTri;
        private System.Windows.Forms.Panel pnlFilterNgay;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label lblNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.Button btnThongKeNgay;
        private System.Windows.Forms.Panel pnlCardsNgay;
        private System.Windows.Forms.Panel pnlCardVeBan;
        private System.Windows.Forms.Label lblTongVeBanTitle;
        private System.Windows.Forms.Label lblTongVeBanVal;
        private System.Windows.Forms.Panel pnlCardVeHuy;
        private System.Windows.Forms.Label lblTongVeHuyTitle;
        private System.Windows.Forms.Label lblTongVeHuyVal;
        private System.Windows.Forms.Panel pnlCardDoanhThu;
        private System.Windows.Forms.Label lblTongDoanhThuTitle;
        private System.Windows.Forms.Label lblTongDoanhThuVal;
        private System.Windows.Forms.DataGridView dgvDoanhThuNgay;
        private System.Windows.Forms.Panel pnlFilterTuyen;
        private System.Windows.Forms.Label lblTuyenBD;
        private System.Windows.Forms.DateTimePicker dtpTuyenBD;
        private System.Windows.Forms.Label lblTuyenKT;
        private System.Windows.Forms.DateTimePicker dtpTuyenKT;
        private System.Windows.Forms.Button btnThongKeTuyen;
        private System.Windows.Forms.DataGridView dgvDoanhThuTuyen;
        private System.Windows.Forms.Panel pnlFilterBaoTri;
        private System.Windows.Forms.Label lblBTBD;
        private System.Windows.Forms.DateTimePicker dtpBTBD;
        private System.Windows.Forms.Label lblBTKT;
        private System.Windows.Forms.DateTimePicker dtpBTKT;
        private System.Windows.Forms.Label lblLocTauBT;
        private System.Windows.Forms.ComboBox cboLocTauBT;
        private System.Windows.Forms.Button btnThongKeBaoTri;
        private System.Windows.Forms.Panel pnlCardsBaoTri;
        private System.Windows.Forms.Panel pnlCardLuotBT;
        private System.Windows.Forms.Label lblTongLuotBTTitle;
        private System.Windows.Forms.Label lblTongLuotBTVal;
        private System.Windows.Forms.Panel pnlCardChiPhiBT;
        private System.Windows.Forms.Label lblTongChiPhiBTTitle;
        private System.Windows.Forms.Label lblTongChiPhiBTVal;
        private System.Windows.Forms.DataGridView dgvBaoTriThongKe;
    }
}
