namespace QuanLyTau
{
    partial class FrmChuyenTau
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
            this.btnNgayMai = new System.Windows.Forms.Button();
            this.btnHomNay = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cboLocTrangThai = new System.Windows.Forms.ComboBox();
            this.lblLocTrangThai = new System.Windows.Forms.Label();
            this.dtpLocNgay = new System.Windows.Forms.DateTimePicker();
            this.lblLocNgay = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.btnHuyChuyen = new System.Windows.Forms.Button();
            this.btnHoanThanhChuyen = new System.Windows.Forms.Button();
            this.btnBatDauChay = new System.Windows.Forms.Button();
            this.btnPhanCongLaiTau = new System.Windows.Forms.Button();
            this.cboLaiTau = new System.Windows.Forms.ComboBox();
            this.lblLaiTau = new System.Windows.Forms.Label();
            this.lblThongTinChuyen = new System.Windows.Forms.Label();
            this.txtMaChuyen = new System.Windows.Forms.TextBox();
            this.lblMaChuyen = new System.Windows.Forms.Label();
            this.dgvChuyenTau = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelTopAction.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenTau)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(378, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ CÁC CHUYẾN TÀU THEO NGÀY";
            // 
            // panelTopAction
            // 
            this.panelTopAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panelTopAction.Controls.Add(this.btnNgayMai);
            this.panelTopAction.Controls.Add(this.btnHomNay);
            this.panelTopAction.Controls.Add(this.btnLoc);
            this.panelTopAction.Controls.Add(this.cboLocTrangThai);
            this.panelTopAction.Controls.Add(this.lblLocTrangThai);
            this.panelTopAction.Controls.Add(this.dtpLocNgay);
            this.panelTopAction.Controls.Add(this.lblLocNgay);
            this.panelTopAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopAction.Location = new System.Drawing.Point(0, 55);
            this.panelTopAction.Name = "panelTopAction";
            this.panelTopAction.Size = new System.Drawing.Size(984, 50);
            this.panelTopAction.TabIndex = 1;
            // 
            // btnNgayMai
            // 
            this.btnNgayMai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnNgayMai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNgayMai.FlatAppearance.BorderSize = 0;
            this.btnNgayMai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNgayMai.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgayMai.ForeColor = System.Drawing.Color.White;
            this.btnNgayMai.Location = new System.Drawing.Point(755, 11);
            this.btnNgayMai.Name = "btnNgayMai";
            this.btnNgayMai.Size = new System.Drawing.Size(80, 28);
            this.btnNgayMai.TabIndex = 6;
            this.btnNgayMai.Text = "Ngày Mai";
            this.btnNgayMai.UseVisualStyleBackColor = false;
            this.btnNgayMai.Click += new System.EventHandler(this.btnNgayMai_Click);
            // 
            // btnHomNay
            // 
            this.btnHomNay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnHomNay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomNay.FlatAppearance.BorderSize = 0;
            this.btnHomNay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomNay.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomNay.ForeColor = System.Drawing.Color.White;
            this.btnHomNay.Location = new System.Drawing.Point(670, 11);
            this.btnHomNay.Name = "btnHomNay";
            this.btnHomNay.Size = new System.Drawing.Size(80, 28);
            this.btnHomNay.TabIndex = 5;
            this.btnHomNay.Text = "Hôm Nay";
            this.btnHomNay.UseVisualStyleBackColor = false;
            this.btnHomNay.Click += new System.EventHandler(this.btnHomNay_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(575, 11);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(85, 28);
            this.btnLoc.TabIndex = 4;
            this.btnLoc.Text = "Lọc Chuyến";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cboLocTrangThai
            // 
            this.cboLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocTrangThai.FormattingEnabled = true;
            this.cboLocTrangThai.Items.AddRange(new object[] {
            "Tất cả trạng thái",
            "Chờ chạy",
            "Đang chạy",
            "Hoàn thành",
            "Hủy"});
            this.cboLocTrangThai.Location = new System.Drawing.Point(395, 12);
            this.cboLocTrangThai.Name = "cboLocTrangThai";
            this.cboLocTrangThai.Size = new System.Drawing.Size(165, 25);
            this.cboLocTrangThai.TabIndex = 3;
            this.cboLocTrangThai.SelectedIndexChanged += new System.EventHandler(this.cboLocTrangThai_SelectedIndexChanged);
            // 
            // lblLocTrangThai
            // 
            this.lblLocTrangThai.AutoSize = true;
            this.lblLocTrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocTrangThai.Location = new System.Drawing.Point(315, 16);
            this.lblLocTrangThai.Name = "lblLocTrangThai";
            this.lblLocTrangThai.Size = new System.Drawing.Size(73, 17);
            this.lblLocTrangThai.TabIndex = 2;
            this.lblLocTrangThai.Text = "Trạng thái:";
            // 
            // dtpLocNgay
            // 
            this.dtpLocNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpLocNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLocNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLocNgay.Location = new System.Drawing.Point(135, 12);
            this.dtpLocNgay.Name = "dtpLocNgay";
            this.dtpLocNgay.Size = new System.Drawing.Size(155, 24);
            this.dtpLocNgay.TabIndex = 1;
            this.dtpLocNgay.ValueChanged += new System.EventHandler(this.dtpLocNgay_ValueChanged);
            // 
            // lblLocNgay
            // 
            this.lblLocNgay.AutoSize = true;
            this.lblLocNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocNgay.Location = new System.Drawing.Point(15, 16);
            this.lblLocNgay.Name = "lblLocNgay";
            this.lblLocNgay.Size = new System.Drawing.Size(107, 17);
            this.lblLocNgay.TabIndex = 0;
            this.lblLocNgay.Text = "Chọn ngày chạy:";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.btnHuyChuyen);
            this.grpInfo.Controls.Add(this.btnHoanThanhChuyen);
            this.grpInfo.Controls.Add(this.btnBatDauChay);
            this.grpInfo.Controls.Add(this.btnPhanCongLaiTau);
            this.grpInfo.Controls.Add(this.cboLaiTau);
            this.grpInfo.Controls.Add(this.lblLaiTau);
            this.grpInfo.Controls.Add(this.lblThongTinChuyen);
            this.grpInfo.Controls.Add(this.txtMaChuyen);
            this.grpInfo.Controls.Add(this.lblMaChuyen);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(0, 105);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(984, 125);
            this.grpInfo.TabIndex = 2;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Điều Hành Chuyến Tàu";
            // 
            // btnHuyChuyen
            // 
            this.btnHuyChuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnHuyChuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyChuyen.FlatAppearance.BorderSize = 0;
            this.btnHuyChuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyChuyen.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyChuyen.ForeColor = System.Drawing.Color.White;
            this.btnHuyChuyen.Location = new System.Drawing.Point(825, 75);
            this.btnHuyChuyen.Name = "btnHuyChuyen";
            this.btnHuyChuyen.Size = new System.Drawing.Size(120, 33);
            this.btnHuyChuyen.TabIndex = 8;
            this.btnHuyChuyen.Text = "✖ Hủy Chuyến";
            this.btnHuyChuyen.UseVisualStyleBackColor = false;
            this.btnHuyChuyen.Click += new System.EventHandler(this.btnHuyChuyen_Click);
            // 
            // btnHoanThanhChuyen
            // 
            this.btnHoanThanhChuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnHoanThanhChuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoanThanhChuyen.FlatAppearance.BorderSize = 0;
            this.btnHoanThanhChuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanThanhChuyen.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanThanhChuyen.ForeColor = System.Drawing.Color.White;
            this.btnHoanThanhChuyen.Location = new System.Drawing.Point(675, 75);
            this.btnHoanThanhChuyen.Name = "btnHoanThanhChuyen";
            this.btnHoanThanhChuyen.Size = new System.Drawing.Size(140, 33);
            this.btnHoanThanhChuyen.TabIndex = 7;
            this.btnHoanThanhChuyen.Text = "✔ Hoàn Thành";
            this.btnHoanThanhChuyen.UseVisualStyleBackColor = false;
            this.btnHoanThanhChuyen.Click += new System.EventHandler(this.btnHoanThanhChuyen_Click);
            // 
            // btnBatDauChay
            // 
            this.btnBatDauChay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnBatDauChay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatDauChay.FlatAppearance.BorderSize = 0;
            this.btnBatDauChay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatDauChay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDauChay.ForeColor = System.Drawing.Color.White;
            this.btnBatDauChay.Location = new System.Drawing.Point(525, 75);
            this.btnBatDauChay.Name = "btnBatDauChay";
            this.btnBatDauChay.Size = new System.Drawing.Size(140, 33);
            this.btnBatDauChay.TabIndex = 6;
            this.btnBatDauChay.Text = "▶ Bắt Đầu Chạy";
            this.btnBatDauChay.UseVisualStyleBackColor = false;
            this.btnBatDauChay.Click += new System.EventHandler(this.btnBatDauChay_Click);
            // 
            // btnPhanCongLaiTau
            // 
            this.btnPhanCongLaiTau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnPhanCongLaiTau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhanCongLaiTau.FlatAppearance.BorderSize = 0;
            this.btnPhanCongLaiTau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanCongLaiTau.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanCongLaiTau.ForeColor = System.Drawing.Color.White;
            this.btnPhanCongLaiTau.Location = new System.Drawing.Point(340, 75);
            this.btnPhanCongLaiTau.Name = "btnPhanCongLaiTau";
            this.btnPhanCongLaiTau.Size = new System.Drawing.Size(160, 33);
            this.btnPhanCongLaiTau.TabIndex = 5;
            this.btnPhanCongLaiTau.Text = "Phân Công Lái Tàu";
            this.btnPhanCongLaiTau.UseVisualStyleBackColor = false;
            this.btnPhanCongLaiTau.Click += new System.EventHandler(this.btnPhanCongLaiTau_Click);
            // 
            // cboLaiTau
            // 
            this.cboLaiTau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLaiTau.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLaiTau.FormattingEnabled = true;
            this.cboLaiTau.Location = new System.Drawing.Point(105, 78);
            this.cboLaiTau.Name = "cboLaiTau";
            this.cboLaiTau.Size = new System.Drawing.Size(220, 25);
            this.cboLaiTau.TabIndex = 4;
            // 
            // lblLaiTau
            // 
            this.lblLaiTau.AutoSize = true;
            this.lblLaiTau.Location = new System.Drawing.Point(20, 81);
            this.lblLaiTau.Name = "lblLaiTau";
            this.lblLaiTau.Size = new System.Drawing.Size(53, 17);
            this.lblLaiTau.TabIndex = 3;
            this.lblLaiTau.Text = "Lái tàu:";
            // 
            // lblThongTinChuyen
            // 
            this.lblThongTinChuyen.AutoSize = true;
            this.lblThongTinChuyen.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinChuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblThongTinChuyen.Location = new System.Drawing.Point(230, 31);
            this.lblThongTinChuyen.Name = "lblThongTinChuyen";
            this.lblThongTinChuyen.Size = new System.Drawing.Size(271, 19);
            this.lblThongTinChuyen.TabIndex = 2;
            this.lblThongTinChuyen.Text = "Chọn một chuyến tàu từ bảng dưới để xử lý";
            // 
            // txtMaChuyen
            // 
            this.txtMaChuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtMaChuyen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChuyen.Location = new System.Drawing.Point(105, 29);
            this.txtMaChuyen.Name = "txtMaChuyen";
            this.txtMaChuyen.ReadOnly = true;
            this.txtMaChuyen.Size = new System.Drawing.Size(100, 24);
            this.txtMaChuyen.TabIndex = 1;
            // 
            // lblMaChuyen
            // 
            this.lblMaChuyen.AutoSize = true;
            this.lblMaChuyen.Location = new System.Drawing.Point(20, 32);
            this.lblMaChuyen.Name = "lblMaChuyen";
            this.lblMaChuyen.Size = new System.Drawing.Size(79, 17);
            this.lblMaChuyen.TabIndex = 0;
            this.lblMaChuyen.Text = "Mã chuyến:";
            // 
            // dgvChuyenTau
            // 
            this.dgvChuyenTau.AllowUserToAddRows = false;
            this.dgvChuyenTau.AllowUserToDeleteRows = false;
            this.dgvChuyenTau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuyenTau.BackgroundColor = System.Drawing.Color.White;
            this.dgvChuyenTau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenTau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChuyenTau.Location = new System.Drawing.Point(0, 230);
            this.dgvChuyenTau.MultiSelect = false;
            this.dgvChuyenTau.Name = "dgvChuyenTau";
            this.dgvChuyenTau.ReadOnly = true;
            this.dgvChuyenTau.RowHeadersWidth = 30;
            this.dgvChuyenTau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuyenTau.Size = new System.Drawing.Size(984, 331);
            this.dgvChuyenTau.TabIndex = 3;
            this.dgvChuyenTau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyenTau_CellClick);
            // 
            // FrmChuyenTau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dgvChuyenTau);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.panelTopAction);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmChuyenTau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Chuyến Tàu - Subway";
            this.Load += new System.EventHandler(this.FrmChuyenTau_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelTopAction.ResumeLayout(false);
            this.panelTopAction.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenTau)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTopAction;
        private System.Windows.Forms.Label lblLocNgay;
        private System.Windows.Forms.DateTimePicker dtpLocNgay;
        private System.Windows.Forms.Label lblLocTrangThai;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnHomNay;
        private System.Windows.Forms.Button btnNgayMai;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblMaChuyen;
        private System.Windows.Forms.TextBox txtMaChuyen;
        private System.Windows.Forms.Label lblThongTinChuyen;
        private System.Windows.Forms.Label lblLaiTau;
        private System.Windows.Forms.ComboBox cboLaiTau;
        private System.Windows.Forms.Button btnPhanCongLaiTau;
        private System.Windows.Forms.Button btnBatDauChay;
        private System.Windows.Forms.Button btnHoanThanhChuyen;
        private System.Windows.Forms.Button btnHuyChuyen;
        private System.Windows.Forms.DataGridView dgvChuyenTau;
    }
}
