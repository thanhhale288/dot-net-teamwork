namespace QuanLyTau
{
    partial class FrmQuanLyTuyen
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.btnChiTietGa = new System.Windows.Forms.Button();
            this.btnXoaNgung = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtTenTuyen = new System.Windows.Forms.TextBox();
            this.lblTenTuyen = new System.Windows.Forms.Label();
            this.txtMaTuyen = new System.Windows.Forms.TextBox();
            this.lblMaTuyen = new System.Windows.Forms.Label();
            this.dgvTuyen = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelTopAction.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyen)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(315, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ DANH SÁCH TUYẾN TÀU";
            // 
            // panelTopAction
            // 
            this.panelTopAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panelTopAction.Controls.Add(this.btnLamMoi);
            this.panelTopAction.Controls.Add(this.btnTimKiem);
            this.panelTopAction.Controls.Add(this.txtTimKiem);
            this.panelTopAction.Controls.Add(this.lblTimKiem);
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
            this.btnLamMoi.Location = new System.Drawing.Point(535, 11);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 28);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
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
            this.btnTimKiem.Location = new System.Drawing.Point(435, 11);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 28);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(145, 13);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(280, 24);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(15, 16);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(124, 17);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm theo tên tuyến:";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.btnChiTietGa);
            this.grpInfo.Controls.Add(this.btnXoaNgung);
            this.grpInfo.Controls.Add(this.btnSua);
            this.grpInfo.Controls.Add(this.btnThem);
            this.grpInfo.Controls.Add(this.cboTrangThai);
            this.grpInfo.Controls.Add(this.lblTrangThai);
            this.grpInfo.Controls.Add(this.txtMoTa);
            this.grpInfo.Controls.Add(this.lblMoTa);
            this.grpInfo.Controls.Add(this.txtTenTuyen);
            this.grpInfo.Controls.Add(this.lblTenTuyen);
            this.grpInfo.Controls.Add(this.txtMaTuyen);
            this.grpInfo.Controls.Add(this.lblMaTuyen);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(0, 105);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(934, 165);
            this.grpInfo.TabIndex = 2;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông Tin Tuyến Tàu";
            // 
            // btnChiTietGa
            // 
            this.btnChiTietGa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.btnChiTietGa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChiTietGa.FlatAppearance.BorderSize = 0;
            this.btnChiTietGa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietGa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietGa.ForeColor = System.Drawing.Color.White;
            this.btnChiTietGa.Location = new System.Drawing.Point(445, 115);
            this.btnChiTietGa.Name = "btnChiTietGa";
            this.btnChiTietGa.Size = new System.Drawing.Size(200, 35);
            this.btnChiTietGa.TabIndex = 11;
            this.btnChiTietGa.Text = "Chi Tiết Các Ga Dừng >>";
            this.btnChiTietGa.UseVisualStyleBackColor = false;
            this.btnChiTietGa.Click += new System.EventHandler(this.btnChiTietGa_Click);
            // 
            // btnXoaNgung
            // 
            this.btnXoaNgung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnXoaNgung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNgung.FlatAppearance.BorderSize = 0;
            this.btnXoaNgung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNgung.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNgung.ForeColor = System.Drawing.Color.White;
            this.btnXoaNgung.Location = new System.Drawing.Point(315, 115);
            this.btnXoaNgung.Name = "btnXoaNgung";
            this.btnXoaNgung.Size = new System.Drawing.Size(120, 35);
            this.btnXoaNgung.TabIndex = 10;
            this.btnXoaNgung.Text = "Ngưng HĐ";
            this.btnXoaNgung.UseVisualStyleBackColor = false;
            this.btnXoaNgung.Click += new System.EventHandler(this.btnXoaNgung_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(210, 115);
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
            this.btnThem.Location = new System.Drawing.Point(105, 115);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 35);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Hoạt động",
            "Ngưng hoạt động"});
            this.cboTrangThai.Location = new System.Drawing.Point(545, 68);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(250, 25);
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
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(545, 28);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(360, 24);
            this.txtMoTa.TabIndex = 5;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(465, 32);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(46, 17);
            this.lblMoTa.TabIndex = 4;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // txtTenTuyen
            // 
            this.txtTenTuyen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTuyen.Location = new System.Drawing.Point(105, 68);
            this.txtTenTuyen.Name = "txtTenTuyen";
            this.txtTenTuyen.Size = new System.Drawing.Size(330, 24);
            this.txtTenTuyen.TabIndex = 3;
            // 
            // lblTenTuyen
            // 
            this.lblTenTuyen.AutoSize = true;
            this.lblTenTuyen.Location = new System.Drawing.Point(20, 72);
            this.lblTenTuyen.Name = "lblTenTuyen";
            this.lblTenTuyen.Size = new System.Drawing.Size(70, 17);
            this.lblTenTuyen.TabIndex = 2;
            this.lblTenTuyen.Text = "Tên tuyến:";
            // 
            // txtMaTuyen
            // 
            this.txtMaTuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtMaTuyen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTuyen.Location = new System.Drawing.Point(105, 28);
            this.txtMaTuyen.Name = "txtMaTuyen";
            this.txtMaTuyen.ReadOnly = true;
            this.txtMaTuyen.Size = new System.Drawing.Size(120, 24);
            this.txtMaTuyen.TabIndex = 1;
            // 
            // lblMaTuyen
            // 
            this.lblMaTuyen.AutoSize = true;
            this.lblMaTuyen.Location = new System.Drawing.Point(20, 32);
            this.lblMaTuyen.Name = "lblMaTuyen";
            this.lblMaTuyen.Size = new System.Drawing.Size(68, 17);
            this.lblMaTuyen.TabIndex = 0;
            this.lblMaTuyen.Text = "Mã tuyến:";
            // 
            // dgvTuyen
            // 
            this.dgvTuyen.AllowUserToAddRows = false;
            this.dgvTuyen.AllowUserToDeleteRows = false;
            this.dgvTuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTuyen.BackgroundColor = System.Drawing.Color.White;
            this.dgvTuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTuyen.Location = new System.Drawing.Point(0, 270);
            this.dgvTuyen.MultiSelect = false;
            this.dgvTuyen.Name = "dgvTuyen";
            this.dgvTuyen.ReadOnly = true;
            this.dgvTuyen.RowHeadersWidth = 30;
            this.dgvTuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTuyen.Size = new System.Drawing.Size(934, 291);
            this.dgvTuyen.TabIndex = 3;
            this.dgvTuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuyen_CellClick);
            // 
            // FrmQuanLyTuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.dgvTuyen);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.panelTopAction);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmQuanLyTuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tuyến Tàu - Subway";
            this.Load += new System.EventHandler(this.FrmQuanLyTuyen_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelTopAction.ResumeLayout(false);
            this.panelTopAction.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyen)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTopAction;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblMaTuyen;
        private System.Windows.Forms.TextBox txtMaTuyen;
        private System.Windows.Forms.Label lblTenTuyen;
        private System.Windows.Forms.TextBox txtTenTuyen;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoaNgung;
        private System.Windows.Forms.Button btnChiTietGa;
        private System.Windows.Forms.DataGridView dgvTuyen;
    }
}
