namespace QuanLyTau
{
    partial class FrmChiTietTuyen
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
            this.panelChonTuyen = new System.Windows.Forms.Panel();
            this.lblTongSoGa = new System.Windows.Forms.Label();
            this.lblGaCuoi = new System.Windows.Forms.Label();
            this.lblGaDau = new System.Windows.Forms.Label();
            this.cboTuyen = new System.Windows.Forms.ComboBox();
            this.lblChonTuyen = new System.Windows.Forms.Label();
            this.grpThaoTacGa = new System.Windows.Forms.GroupBox();
            this.btnMoQuanLyGa = new System.Windows.Forms.Button();
            this.btnTuDongDanhSo = new System.Windows.Forms.Button();
            this.btnXoaGa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThemGa = new System.Windows.Forms.Button();
            this.numPhutDung = new System.Windows.Forms.NumericUpDown();
            this.lblPhutDung = new System.Windows.Forms.Label();
            this.numThuTu = new System.Windows.Forms.NumericUpDown();
            this.lblThuTu = new System.Windows.Forms.Label();
            this.cboGa = new System.Windows.Forms.ComboBox();
            this.lblGa = new System.Windows.Forms.Label();
            this.dgvGaDung = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelChonTuyen.SuspendLayout();
            this.grpThaoTacGa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhutDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThuTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGaDung)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(437, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CHI TIẾT TUYẾN - QUẢN LÝ CÁC GA TRÊN TUYẾN";
            // 
            // panelChonTuyen
            // 
            this.panelChonTuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panelChonTuyen.Controls.Add(this.lblTongSoGa);
            this.panelChonTuyen.Controls.Add(this.lblGaCuoi);
            this.panelChonTuyen.Controls.Add(this.lblGaDau);
            this.panelChonTuyen.Controls.Add(this.cboTuyen);
            this.panelChonTuyen.Controls.Add(this.lblChonTuyen);
            this.panelChonTuyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChonTuyen.Location = new System.Drawing.Point(0, 55);
            this.panelChonTuyen.Name = "panelChonTuyen";
            this.panelChonTuyen.Size = new System.Drawing.Size(934, 60);
            this.panelChonTuyen.TabIndex = 1;
            // 
            // lblTongSoGa
            // 
            this.lblTongSoGa.AutoSize = true;
            this.lblTongSoGa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSoGa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblTongSoGa.Location = new System.Drawing.Point(760, 21);
            this.lblTongSoGa.Name = "lblTongSoGa";
            this.lblTongSoGa.Size = new System.Drawing.Size(89, 17);
            this.lblTongSoGa.TabIndex = 4;
            this.lblTongSoGa.Text = "Tổng số ga: 0";
            // 
            // lblGaCuoi
            // 
            this.lblGaCuoi.AutoSize = true;
            this.lblGaCuoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGaCuoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblGaCuoi.Location = new System.Drawing.Point(580, 21);
            this.lblGaCuoi.Name = "lblGaCuoi";
            this.lblGaCuoi.Size = new System.Drawing.Size(87, 17);
            this.lblGaCuoi.TabIndex = 3;
            this.lblGaCuoi.Text = "Ga cuối: [---]";
            // 
            // lblGaDau
            // 
            this.lblGaDau.AutoSize = true;
            this.lblGaDau.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGaDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.lblGaDau.Location = new System.Drawing.Point(420, 21);
            this.lblGaDau.Name = "lblGaDau";
            this.lblGaDau.Size = new System.Drawing.Size(85, 17);
            this.lblGaDau.TabIndex = 2;
            this.lblGaDau.Text = "Ga đầu: [---]";
            // 
            // cboTuyen
            // 
            this.cboTuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTuyen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTuyen.FormattingEnabled = true;
            this.cboTuyen.Location = new System.Drawing.Point(125, 17);
            this.cboTuyen.Name = "cboTuyen";
            this.cboTuyen.Size = new System.Drawing.Size(270, 25);
            this.cboTuyen.TabIndex = 1;
            this.cboTuyen.SelectedIndexChanged += new System.EventHandler(this.cboTuyen_SelectedIndexChanged);
            // 
            // lblChonTuyen
            // 
            this.lblChonTuyen.AutoSize = true;
            this.lblChonTuyen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonTuyen.Location = new System.Drawing.Point(15, 21);
            this.lblChonTuyen.Name = "lblChonTuyen";
            this.lblChonTuyen.Size = new System.Drawing.Size(104, 17);
            this.lblChonTuyen.TabIndex = 0;
            this.lblChonTuyen.Text = "Chọn tuyến tàu:";
            // 
            // grpThaoTacGa
            // 
            this.grpThaoTacGa.Controls.Add(this.btnMoQuanLyGa);
            this.grpThaoTacGa.Controls.Add(this.btnTuDongDanhSo);
            this.grpThaoTacGa.Controls.Add(this.btnXoaGa);
            this.grpThaoTacGa.Controls.Add(this.btnCapNhat);
            this.grpThaoTacGa.Controls.Add(this.btnThemGa);
            this.grpThaoTacGa.Controls.Add(this.numPhutDung);
            this.grpThaoTacGa.Controls.Add(this.lblPhutDung);
            this.grpThaoTacGa.Controls.Add(this.numThuTu);
            this.grpThaoTacGa.Controls.Add(this.lblThuTu);
            this.grpThaoTacGa.Controls.Add(this.cboGa);
            this.grpThaoTacGa.Controls.Add(this.lblGa);
            this.grpThaoTacGa.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThaoTacGa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThaoTacGa.Location = new System.Drawing.Point(0, 115);
            this.grpThaoTacGa.Name = "grpThaoTacGa";
            this.grpThaoTacGa.Size = new System.Drawing.Size(934, 125);
            this.grpThaoTacGa.TabIndex = 2;
            this.grpThaoTacGa.TabStop = false;
            this.grpThaoTacGa.Text = "Quản Lý Thứ Tự Và Thời Gian Dừng Ga";
            // 
            // btnMoQuanLyGa
            // 
            this.btnMoQuanLyGa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnMoQuanLyGa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoQuanLyGa.FlatAppearance.BorderSize = 0;
            this.btnMoQuanLyGa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoQuanLyGa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoQuanLyGa.ForeColor = System.Drawing.Color.White;
            this.btnMoQuanLyGa.Location = new System.Drawing.Point(635, 75);
            this.btnMoQuanLyGa.Name = "btnMoQuanLyGa";
            this.btnMoQuanLyGa.Size = new System.Drawing.Size(145, 32);
            this.btnMoQuanLyGa.TabIndex = 10;
            this.btnMoQuanLyGa.Text = "Danh Mục Ga Tàu >>";
            this.btnMoQuanLyGa.UseVisualStyleBackColor = false;
            this.btnMoQuanLyGa.Click += new System.EventHandler(this.btnMoQuanLyGa_Click);
            // 
            // btnTuDongDanhSo
            // 
            this.btnTuDongDanhSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnTuDongDanhSo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTuDongDanhSo.FlatAppearance.BorderSize = 0;
            this.btnTuDongDanhSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuDongDanhSo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuDongDanhSo.ForeColor = System.Drawing.Color.White;
            this.btnTuDongDanhSo.Location = new System.Drawing.Point(440, 75);
            this.btnTuDongDanhSo.Name = "btnTuDongDanhSo";
            this.btnTuDongDanhSo.Size = new System.Drawing.Size(180, 32);
            this.btnTuDongDanhSo.TabIndex = 9;
            this.btnTuDongDanhSo.Text = "Đánh Lại Thứ Tự 1..N";
            this.btnTuDongDanhSo.UseVisualStyleBackColor = false;
            this.btnTuDongDanhSo.Click += new System.EventHandler(this.btnTuDongDanhSo_Click);
            // 
            // btnXoaGa
            // 
            this.btnXoaGa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnXoaGa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaGa.FlatAppearance.BorderSize = 0;
            this.btnXoaGa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaGa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaGa.ForeColor = System.Drawing.Color.White;
            this.btnXoaGa.Location = new System.Drawing.Point(315, 75);
            this.btnXoaGa.Name = "btnXoaGa";
            this.btnXoaGa.Size = new System.Drawing.Size(110, 32);
            this.btnXoaGa.TabIndex = 8;
            this.btnXoaGa.Text = "Xóa Khỏi Tuyến";
            this.btnXoaGa.UseVisualStyleBackColor = false;
            this.btnXoaGa.Click += new System.EventHandler(this.btnXoaGa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(200, 75);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 32);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThemGa
            // 
            this.btnThemGa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnThemGa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemGa.FlatAppearance.BorderSize = 0;
            this.btnThemGa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemGa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGa.ForeColor = System.Drawing.Color.White;
            this.btnThemGa.Location = new System.Drawing.Point(85, 75);
            this.btnThemGa.Name = "btnThemGa";
            this.btnThemGa.Size = new System.Drawing.Size(100, 32);
            this.btnThemGa.TabIndex = 6;
            this.btnThemGa.Text = "Thêm Vào Tuyến";
            this.btnThemGa.UseVisualStyleBackColor = false;
            this.btnThemGa.Click += new System.EventHandler(this.btnThemGa_Click);
            // 
            // numPhutDung
            // 
            this.numPhutDung.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPhutDung.Location = new System.Drawing.Point(695, 30);
            this.numPhutDung.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numPhutDung.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPhutDung.Name = "numPhutDung";
            this.numPhutDung.Size = new System.Drawing.Size(85, 24);
            this.numPhutDung.TabIndex = 5;
            this.numPhutDung.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblPhutDung
            // 
            this.lblPhutDung.AutoSize = true;
            this.lblPhutDung.Location = new System.Drawing.Point(595, 33);
            this.lblPhutDung.Name = "lblPhutDung";
            this.lblPhutDung.Size = new System.Drawing.Size(95, 17);
            this.lblPhutDung.TabIndex = 4;
            this.lblPhutDung.Text = "Phút dừng ga:";
            // 
            // numThuTu
            // 
            this.numThuTu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numThuTu.Location = new System.Drawing.Point(475, 30);
            this.numThuTu.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numThuTu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThuTu.Name = "numThuTu";
            this.numThuTu.Size = new System.Drawing.Size(85, 24);
            this.numThuTu.TabIndex = 3;
            this.numThuTu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblThuTu
            // 
            this.lblThuTu.AutoSize = true;
            this.lblThuTu.Location = new System.Drawing.Point(385, 33);
            this.lblThuTu.Name = "lblThuTu";
            this.lblThuTu.Size = new System.Drawing.Size(84, 17);
            this.lblThuTu.TabIndex = 2;
            this.lblThuTu.Text = "Thứ tự dừng:";
            // 
            // cboGa
            // 
            this.cboGa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGa.FormattingEnabled = true;
            this.cboGa.Location = new System.Drawing.Point(85, 30);
            this.cboGa.Name = "cboGa";
            this.cboGa.Size = new System.Drawing.Size(270, 25);
            this.cboGa.TabIndex = 1;
            // 
            // lblGa
            // 
            this.lblGa.AutoSize = true;
            this.lblGa.Location = new System.Drawing.Point(20, 33);
            this.lblGa.Name = "lblGa";
            this.lblGa.Size = new System.Drawing.Size(61, 17);
            this.lblGa.TabIndex = 0;
            this.lblGa.Text = "Chọn Ga:";
            // 
            // dgvGaDung
            // 
            this.dgvGaDung.AllowUserToAddRows = false;
            this.dgvGaDung.AllowUserToDeleteRows = false;
            this.dgvGaDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGaDung.BackgroundColor = System.Drawing.Color.White;
            this.dgvGaDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGaDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGaDung.Location = new System.Drawing.Point(0, 240);
            this.dgvGaDung.MultiSelect = false;
            this.dgvGaDung.Name = "dgvGaDung";
            this.dgvGaDung.ReadOnly = true;
            this.dgvGaDung.RowHeadersWidth = 30;
            this.dgvGaDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGaDung.Size = new System.Drawing.Size(934, 321);
            this.dgvGaDung.TabIndex = 3;
            this.dgvGaDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGaDung_CellClick);
            // 
            // FrmChiTietTuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.dgvGaDung);
            this.Controls.Add(this.grpThaoTacGa);
            this.Controls.Add(this.panelChonTuyen);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmChiTietTuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Tuyến & Ga Dừng - Subway";
            this.Load += new System.EventHandler(this.FrmChiTietTuyen_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelChonTuyen.ResumeLayout(false);
            this.panelChonTuyen.PerformLayout();
            this.grpThaoTacGa.ResumeLayout(false);
            this.grpThaoTacGa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhutDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThuTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGaDung)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelChonTuyen;
        private System.Windows.Forms.Label lblChonTuyen;
        private System.Windows.Forms.ComboBox cboTuyen;
        private System.Windows.Forms.Label lblGaDau;
        private System.Windows.Forms.Label lblGaCuoi;
        private System.Windows.Forms.Label lblTongSoGa;
        private System.Windows.Forms.GroupBox grpThaoTacGa;
        private System.Windows.Forms.Label lblGa;
        private System.Windows.Forms.ComboBox cboGa;
        private System.Windows.Forms.Label lblThuTu;
        private System.Windows.Forms.NumericUpDown numThuTu;
        private System.Windows.Forms.Label lblPhutDung;
        private System.Windows.Forms.NumericUpDown numPhutDung;
        private System.Windows.Forms.Button btnThemGa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoaGa;
        private System.Windows.Forms.Button btnTuDongDanhSo;
        private System.Windows.Forms.Button btnMoQuanLyGa;
        private System.Windows.Forms.DataGridView dgvGaDung;
    }
}
