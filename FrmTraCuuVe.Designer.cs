namespace QuanLyTau
{
    partial class FrmTraCuuVe
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
            this.panelTimKiem = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.txtTimCCCD = new System.Windows.Forms.TextBox();
            this.lblTimCCCD = new System.Windows.Forms.Label();
            this.txtTimMaVe = new System.Windows.Forms.TextBox();
            this.lblTimMaVe = new System.Windows.Forms.Label();
            this.grpChiTietVe = new System.Windows.Forms.GroupBox();
            this.btnHuyVe = new System.Windows.Forms.Button();
            this.lblTrangThaiVal = new System.Windows.Forms.Label();
            this.lblGiaVeVal = new System.Windows.Forms.Label();
            this.lblGaDenVal = new System.Windows.Forms.Label();
            this.lblGaDiVal = new System.Windows.Forms.Label();
            this.lblTuyenTauVal = new System.Windows.Forms.Label();
            this.lblHanhKhachVal = new System.Windows.Forms.Label();
            this.lblMaVeVal = new System.Windows.Forms.Label();
            this.dgvVe = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelTimKiem.SuspendLayout();
            this.grpChiTietVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(406, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TRA CỨU VÉ TÀU && QUẢN LÝ HỦY VÉ ĐÃ BÁN";
            // 
            // panelTimKiem
            // 
            this.panelTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panelTimKiem.Controls.Add(this.btnLamMoi);
            this.panelTimKiem.Controls.Add(this.btnTimKiem);
            this.panelTimKiem.Controls.Add(this.dtpDenNgay);
            this.panelTimKiem.Controls.Add(this.lblDenNgay);
            this.panelTimKiem.Controls.Add(this.dtpTuNgay);
            this.panelTimKiem.Controls.Add(this.lblTuNgay);
            this.panelTimKiem.Controls.Add(this.txtTimCCCD);
            this.panelTimKiem.Controls.Add(this.lblTimCCCD);
            this.panelTimKiem.Controls.Add(this.txtTimMaVe);
            this.panelTimKiem.Controls.Add(this.lblTimMaVe);
            this.panelTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimKiem.Location = new System.Drawing.Point(0, 55);
            this.panelTimKiem.Name = "panelTimKiem";
            this.panelTimKiem.Size = new System.Drawing.Size(984, 65);
            this.panelTimKiem.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(885, 17);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(85, 30);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Tất Cả";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(790, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 30);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Checked = false;
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(670, 20);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.ShowCheckBox = true;
            this.dtpDenNgay.Size = new System.Drawing.Size(110, 24);
            this.dtpDenNgay.TabIndex = 7;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.Location = new System.Drawing.Point(605, 24);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(60, 15);
            this.lblDenNgay.TabIndex = 6;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Checked = false;
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(485, 20);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.ShowCheckBox = true;
            this.dtpTuNgay.Size = new System.Drawing.Size(110, 24);
            this.dtpTuNgay.TabIndex = 5;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuNgay.Location = new System.Drawing.Point(425, 24);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(53, 15);
            this.lblTuNgay.TabIndex = 4;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // txtTimCCCD
            // 
            this.txtTimCCCD.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimCCCD.Location = new System.Drawing.Point(265, 20);
            this.txtTimCCCD.Name = "txtTimCCCD";
            this.txtTimCCCD.Size = new System.Drawing.Size(145, 24);
            this.txtTimCCCD.TabIndex = 3;
            this.txtTimCCCD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimCCCD_KeyDown);
            // 
            // lblTimCCCD
            // 
            this.lblTimCCCD.AutoSize = true;
            this.lblTimCCCD.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimCCCD.Location = new System.Drawing.Point(185, 24);
            this.lblTimCCCD.Name = "lblTimCCCD";
            this.lblTimCCCD.Size = new System.Drawing.Size(74, 15);
            this.lblTimCCCD.TabIndex = 2;
            this.lblTimCCCD.Text = "CCCD khách:";
            // 
            // txtTimMaVe
            // 
            this.txtTimMaVe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMaVe.Location = new System.Drawing.Point(70, 20);
            this.txtTimMaVe.Name = "txtTimMaVe";
            this.txtTimMaVe.Size = new System.Drawing.Size(100, 24);
            this.txtTimMaVe.TabIndex = 1;
            this.txtTimMaVe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimMaVe_KeyDown);
            // 
            // lblTimMaVe
            // 
            this.lblTimMaVe.AutoSize = true;
            this.lblTimMaVe.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimMaVe.Location = new System.Drawing.Point(15, 24);
            this.lblTimMaVe.Name = "lblTimMaVe";
            this.lblTimMaVe.Size = new System.Drawing.Size(46, 15);
            this.lblTimMaVe.TabIndex = 0;
            this.lblTimMaVe.Text = "Mã vé:";
            // 
            // grpChiTietVe
            // 
            this.grpChiTietVe.BackColor = System.Drawing.Color.White;
            this.grpChiTietVe.Controls.Add(this.btnHuyVe);
            this.grpChiTietVe.Controls.Add(this.lblTrangThaiVal);
            this.grpChiTietVe.Controls.Add(this.lblGiaVeVal);
            this.grpChiTietVe.Controls.Add(this.lblGaDenVal);
            this.grpChiTietVe.Controls.Add(this.lblGaDiVal);
            this.grpChiTietVe.Controls.Add(this.lblTuyenTauVal);
            this.grpChiTietVe.Controls.Add(this.lblHanhKhachVal);
            this.grpChiTietVe.Controls.Add(this.lblMaVeVal);
            this.grpChiTietVe.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpChiTietVe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChiTietVe.Location = new System.Drawing.Point(0, 120);
            this.grpChiTietVe.Name = "grpChiTietVe";
            this.grpChiTietVe.Size = new System.Drawing.Size(984, 115);
            this.grpChiTietVe.TabIndex = 2;
            this.grpChiTietVe.TabStop = false;
            this.grpChiTietVe.Text = "Chi Tiết Vé Đang Chọn";
            // 
            // btnHuyVe
            // 
            this.btnHuyVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnHuyVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyVe.FlatAppearance.BorderSize = 0;
            this.btnHuyVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyVe.Font = new System.Drawing.Font("Segoe UI Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyVe.ForeColor = System.Drawing.Color.White;
            this.btnHuyVe.Location = new System.Drawing.Point(790, 45);
            this.btnHuyVe.Name = "btnHuyVe";
            this.btnHuyVe.Size = new System.Drawing.Size(180, 42);
            this.btnHuyVe.TabIndex = 7;
            this.btnHuyVe.Text = "✖ HỦY VÉ TÀU NÀY";
            this.btnHuyVe.UseVisualStyleBackColor = false;
            this.btnHuyVe.Click += new System.EventHandler(this.btnHuyVe_Click);
            // 
            // lblTrangThaiVal
            // 
            this.lblTrangThaiVal.AutoSize = true;
            this.lblTrangThaiVal.Font = new System.Drawing.Font("Segoe UI Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThaiVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.lblTrangThaiVal.Location = new System.Drawing.Point(525, 75);
            this.lblTrangThaiVal.Name = "lblTrangThaiVal";
            this.lblTrangThaiVal.Size = new System.Drawing.Size(176, 19);
            this.lblTrangThaiVal.TabIndex = 6;
            this.lblTrangThaiVal.Text = "Trạng thái: ĐÃ THANH TOÁN";
            // 
            // lblGiaVeVal
            // 
            this.lblGiaVeVal.AutoSize = true;
            this.lblGiaVeVal.Font = new System.Drawing.Font("Segoe UI Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaVeVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblGiaVeVal.Location = new System.Drawing.Point(525, 30);
            this.lblGiaVeVal.Name = "lblGiaVeVal";
            this.lblGiaVeVal.Size = new System.Drawing.Size(130, 20);
            this.lblGiaVeVal.TabIndex = 5;
            this.lblGiaVeVal.Text = "Giá vé: 20,000 đ";
            // 
            // lblGaDenVal
            // 
            this.lblGaDenVal.AutoSize = true;
            this.lblGaDenVal.Location = new System.Drawing.Point(280, 75);
            this.lblGaDenVal.Name = "lblGaDenVal";
            this.lblGaDenVal.Size = new System.Drawing.Size(117, 17);
            this.lblGaDenVal.TabIndex = 4;
            this.lblGaDenVal.Text = "Ga đến: Ga Suối Tiên";
            // 
            // lblGaDiVal
            // 
            this.lblGaDiVal.AutoSize = true;
            this.lblGaDiVal.Location = new System.Drawing.Point(280, 30);
            this.lblGaDiVal.Name = "lblGaDiVal";
            this.lblGaDiVal.Size = new System.Drawing.Size(117, 17);
            this.lblGaDiVal.TabIndex = 3;
            this.lblGaDiVal.Text = "Ga đi: Ga Bến Thành";
            // 
            // lblTuyenTauVal
            // 
            this.lblTuyenTauVal.AutoSize = true;
            this.lblTuyenTauVal.Location = new System.Drawing.Point(20, 80);
            this.lblTuyenTauVal.Name = "lblTuyenTauVal";
            this.lblTuyenTauVal.Size = new System.Drawing.Size(149, 17);
            this.lblTuyenTauVal.TabIndex = 2;
            this.lblTuyenTauVal.Text = "Tuyến: Tuyến 01 | Tàu: 01";
            // 
            // lblHanhKhachVal
            // 
            this.lblHanhKhachVal.AutoSize = true;
            this.lblHanhKhachVal.Location = new System.Drawing.Point(20, 55);
            this.lblHanhKhachVal.Name = "lblHanhKhachVal";
            this.lblHanhKhachVal.Size = new System.Drawing.Size(183, 17);
            this.lblHanhKhachVal.TabIndex = 1;
            this.lblHanhKhachVal.Text = "Hành khách: [Chưa chọn vé]";
            // 
            // lblMaVeVal
            // 
            this.lblMaVeVal.AutoSize = true;
            this.lblMaVeVal.Font = new System.Drawing.Font("Segoe UI Bold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaVeVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblMaVeVal.Location = new System.Drawing.Point(20, 28);
            this.lblMaVeVal.Name = "lblMaVeVal";
            this.lblMaVeVal.Size = new System.Drawing.Size(107, 19);
            this.lblMaVeVal.TabIndex = 0;
            this.lblMaVeVal.Text = "MÃ VÉ: [---]";
            // 
            // dgvVe
            // 
            this.dgvVe.AllowUserToAddRows = false;
            this.dgvVe.AllowUserToDeleteRows = false;
            this.dgvVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVe.BackgroundColor = System.Drawing.Color.White;
            this.dgvVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVe.Location = new System.Drawing.Point(0, 235);
            this.dgvVe.MultiSelect = false;
            this.dgvVe.Name = "dgvVe";
            this.dgvVe.ReadOnly = true;
            this.dgvVe.RowHeadersWidth = 30;
            this.dgvVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVe.Size = new System.Drawing.Size(984, 326);
            this.dgvVe.TabIndex = 3;
            this.dgvVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVe_CellClick);
            // 
            // FrmTraCuuVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dgvVe);
            this.Controls.Add(this.grpChiTietVe);
            this.Controls.Add(this.panelTimKiem);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmTraCuuVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra Cứu & Hủy Vé Tàu - Subway";
            this.Load += new System.EventHandler(this.FrmTraCuuVe_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelTimKiem.ResumeLayout(false);
            this.panelTimKiem.PerformLayout();
            this.grpChiTietVe.ResumeLayout(false);
            this.grpChiTietVe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTimKiem;
        private System.Windows.Forms.Label lblTimMaVe;
        private System.Windows.Forms.TextBox txtTimMaVe;
        private System.Windows.Forms.Label lblTimCCCD;
        private System.Windows.Forms.TextBox txtTimCCCD;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpChiTietVe;
        private System.Windows.Forms.Label lblMaVeVal;
        private System.Windows.Forms.Label lblHanhKhachVal;
        private System.Windows.Forms.Label lblTuyenTauVal;
        private System.Windows.Forms.Label lblGaDiVal;
        private System.Windows.Forms.Label lblGaDenVal;
        private System.Windows.Forms.Label lblGiaVeVal;
        private System.Windows.Forms.Label lblTrangThaiVal;
        private System.Windows.Forms.Button btnHuyVe;
        private System.Windows.Forms.DataGridView dgvVe;
    }
}
