namespace QuanLyTau
{
    partial class FrmQuanLyTau
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
            this.cboLocTuyen = new System.Windows.Forms.ComboBox();
            this.lblLocTuyen = new System.Windows.Forms.Label();
            this.cboLocTrangThai = new System.Windows.Forms.ComboBox();
            this.lblLocTrangThai = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.btnChiTietToaTau = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTuyen = new System.Windows.Forms.ComboBox();
            this.lblTuyen = new System.Windows.Forms.Label();
            this.txtTenTau = new System.Windows.Forms.TextBox();
            this.lblTenTau = new System.Windows.Forms.Label();
            this.txtMaTau = new System.Windows.Forms.TextBox();
            this.lblMaTau = new System.Windows.Forms.Label();
            this.dgvTau = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelTopAction.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTau)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(934, 55);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(347, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ DANH SÁCH TÀU SUBWAY";
            // 
            // panelTopAction
            // 
            this.panelTopAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panelTopAction.Controls.Add(this.btnLamMoi);
            this.panelTopAction.Controls.Add(this.btnLoc);
            this.panelTopAction.Controls.Add(this.cboLocTuyen);
            this.panelTopAction.Controls.Add(this.lblLocTuyen);
            this.panelTopAction.Controls.Add(this.cboLocTrangThai);
            this.panelTopAction.Controls.Add(this.lblLocTrangThai);
            this.panelTopAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopAction.Location = new System.Drawing.Point(0, 55);
            this.panelTopAction.Name = "panelTopAction";
            this.panelTopAction.Size = new System.Drawing.Size(934, 50);
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
            this.btnLamMoi.Location = new System.Drawing.Point(745, 11);
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
            this.btnLoc.Location = new System.Drawing.Point(645, 11);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(90, 28);
            this.btnLoc.TabIndex = 4;
            this.btnLoc.Text = "Lọc Dữ Liệu";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cboLocTuyen
            // 
            this.cboLocTuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTuyen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocTuyen.FormattingEnabled = true;
            this.cboLocTuyen.Location = new System.Drawing.Point(375, 12);
            this.cboLocTuyen.Name = "cboLocTuyen";
            this.cboLocTuyen.Size = new System.Drawing.Size(250, 25);
            this.cboLocTuyen.TabIndex = 3;
            this.cboLocTuyen.SelectedIndexChanged += new System.EventHandler(this.cboLocTuyen_SelectedIndexChanged);
            // 
            // lblLocTuyen
            // 
            this.lblLocTuyen.AutoSize = true;
            this.lblLocTuyen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocTuyen.Location = new System.Drawing.Point(295, 16);
            this.lblLocTuyen.Name = "lblLocTuyen";
            this.lblLocTuyen.Size = new System.Drawing.Size(75, 17);
            this.lblLocTuyen.TabIndex = 2;
            this.lblLocTuyen.Text = "Theo tuyến:";
            // 
            // cboLocTrangThai
            // 
            this.cboLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocTrangThai.FormattingEnabled = true;
            this.cboLocTrangThai.Items.AddRange(new object[] {
            "Tất cả trạng thái",
            "Sẵn sàng",
            "Đang chạy",
            "Bảo trì",
            "Hỏng"});
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
            this.grpInfo.Controls.Add(this.btnChiTietToaTau);
            this.grpInfo.Controls.Add(this.btnXoa);
            this.grpInfo.Controls.Add(this.btnSua);
            this.grpInfo.Controls.Add(this.btnThem);
            this.grpInfo.Controls.Add(this.cboTrangThai);
            this.grpInfo.Controls.Add(this.lblTrangThai);
            this.grpInfo.Controls.Add(this.cboTuyen);
            this.grpInfo.Controls.Add(this.lblTuyen);
            this.grpInfo.Controls.Add(this.txtTenTau);
            this.grpInfo.Controls.Add(this.lblTenTau);
            this.grpInfo.Controls.Add(this.txtMaTau);
            this.grpInfo.Controls.Add(this.lblMaTau);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(0, 105);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(934, 160);
            this.grpInfo.TabIndex = 2;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông Tin Đoàn Tàu";
            // 
            // btnChiTietToaTau
            // 
            this.btnChiTietToaTau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.btnChiTietToaTau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChiTietToaTau.FlatAppearance.BorderSize = 0;
            this.btnChiTietToaTau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietToaTau.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietToaTau.ForeColor = System.Drawing.Color.White;
            this.btnChiTietToaTau.Location = new System.Drawing.Point(425, 110);
            this.btnChiTietToaTau.Name = "btnChiTietToaTau";
            this.btnChiTietToaTau.Size = new System.Drawing.Size(210, 35);
            this.btnChiTietToaTau.TabIndex = 11;
            this.btnChiTietToaTau.Text = "Chi Tiết Tàu & Toa Tàu >>";
            this.btnChiTietToaTau.UseVisualStyleBackColor = false;
            this.btnChiTietToaTau.Click += new System.EventHandler(this.btnChiTietToaTau_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(315, 110);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 35);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa Tàu";
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
            this.btnSua.Location = new System.Drawing.Point(210, 110);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 35);
            this.btnSua.TabIndex = 9;
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
            this.btnThem.Location = new System.Drawing.Point(105, 110);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 35);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm Tàu";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Sẵn sàng",
            "Đang chạy",
            "Bảo trì",
            "Hỏng"});
            this.cboTrangThai.Location = new System.Drawing.Point(545, 68);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(260, 25);
            this.cboTrangThai.TabIndex = 7;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(465, 72);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(73, 17);
            this.lblTrangThai.TabIndex = 6;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTuyen
            // 
            this.cboTuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTuyen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTuyen.FormattingEnabled = true;
            this.cboTuyen.Location = new System.Drawing.Point(545, 28);
            this.cboTuyen.Name = "cboTuyen";
            this.cboTuyen.Size = new System.Drawing.Size(260, 25);
            this.cboTuyen.TabIndex = 5;
            // 
            // lblTuyen
            // 
            this.lblTuyen.AutoSize = true;
            this.lblTuyen.Location = new System.Drawing.Point(465, 32);
            this.lblTuyen.Name = "lblTuyen";
            this.lblTuyen.Size = new System.Drawing.Size(69, 17);
            this.lblTuyen.TabIndex = 4;
            this.lblTuyen.Text = "Thuộc tuyến:";
            // 
            // txtTenTau
            // 
            this.txtTenTau.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTau.Location = new System.Drawing.Point(105, 68);
            this.txtTenTau.Name = "txtTenTau";
            this.txtTenTau.Size = new System.Drawing.Size(305, 24);
            this.txtTenTau.TabIndex = 3;
            // 
            // lblTenTau
            // 
            this.lblTenTau.AutoSize = true;
            this.lblTenTau.Location = new System.Drawing.Point(20, 72);
            this.lblTenTau.Name = "lblTenTau";
            this.lblTenTau.Size = new System.Drawing.Size(56, 17);
            this.lblTenTau.TabIndex = 2;
            this.lblTenTau.Text = "Tên tàu:";
            // 
            // txtMaTau
            // 
            this.txtMaTau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtMaTau.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTau.Location = new System.Drawing.Point(105, 28);
            this.txtMaTau.Name = "txtMaTau";
            this.txtMaTau.ReadOnly = true;
            this.txtMaTau.Size = new System.Drawing.Size(120, 24);
            this.txtMaTau.TabIndex = 1;
            // 
            // lblMaTau
            // 
            this.lblMaTau.AutoSize = true;
            this.lblMaTau.Location = new System.Drawing.Point(20, 32);
            this.lblMaTau.Name = "lblMaTau";
            this.lblMaTau.Size = new System.Drawing.Size(54, 17);
            this.lblMaTau.TabIndex = 0;
            this.lblMaTau.Text = "Mã tàu:";
            // 
            // dgvTau
            // 
            this.dgvTau.AllowUserToAddRows = false;
            this.dgvTau.AllowUserToDeleteRows = false;
            this.dgvTau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTau.BackgroundColor = System.Drawing.Color.White;
            this.dgvTau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTau.Location = new System.Drawing.Point(0, 265);
            this.dgvTau.MultiSelect = false;
            this.dgvTau.Name = "dgvTau";
            this.dgvTau.ReadOnly = true;
            this.dgvTau.RowHeadersWidth = 30;
            this.dgvTau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTau.Size = new System.Drawing.Size(934, 296);
            this.dgvTau.TabIndex = 3;
            this.dgvTau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTau_CellClick);
            // 
            // FrmQuanLyTau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.dgvTau);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.panelTopAction);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmQuanLyTau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tàu Điện - Subway";
            this.Load += new System.EventHandler(this.FrmQuanLyTau_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelTopAction.ResumeLayout(false);
            this.panelTopAction.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTau)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTopAction;
        private System.Windows.Forms.Label lblLocTrangThai;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Label lblLocTuyen;
        private System.Windows.Forms.ComboBox cboLocTuyen;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblMaTau;
        private System.Windows.Forms.TextBox txtMaTau;
        private System.Windows.Forms.Label lblTenTau;
        private System.Windows.Forms.TextBox txtTenTau;
        private System.Windows.Forms.Label lblTuyen;
        private System.Windows.Forms.ComboBox cboTuyen;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChiTietToaTau;
        private System.Windows.Forms.DataGridView dgvTau;
    }
}
