namespace QuanLyTau
{
    partial class FrmChiTietTau
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
            this.panelChonTau = new System.Windows.Forms.Panel();
            this.lblTrangThaiTau = new System.Windows.Forms.Label();
            this.lblTongSucChua = new System.Windows.Forms.Label();
            this.lblTongSoToa = new System.Windows.Forms.Label();
            this.cboTau = new System.Windows.Forms.ComboBox();
            this.lblChonTau = new System.Windows.Forms.Label();
            this.grpToaTau = new System.Windows.Forms.GroupBox();
            this.btnXoaToa = new System.Windows.Forms.Button();
            this.btnSuaToa = new System.Windows.Forms.Button();
            this.btnThemToa = new System.Windows.Forms.Button();
            this.numSucChua = new System.Windows.Forms.NumericUpDown();
            this.lblSucChua = new System.Windows.Forms.Label();
            this.cboLoaiToa = new System.Windows.Forms.ComboBox();
            this.lblLoaiToa = new System.Windows.Forms.Label();
            this.numSoToa = new System.Windows.Forms.NumericUpDown();
            this.lblSoToa = new System.Windows.Forms.Label();
            this.txtMaToa = new System.Windows.Forms.TextBox();
            this.lblMaToa = new System.Windows.Forms.Label();
            this.dgvToaTau = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelChonTau.SuspendLayout();
            this.grpToaTau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSucChua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoToa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaTau)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(434, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CHI TIẾT ĐOÀN TÀU VÀ QUẢN LÝ CÁC TOA TÀU";
            // 
            // panelChonTau
            // 
            this.panelChonTau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panelChonTau.Controls.Add(this.lblTrangThaiTau);
            this.panelChonTau.Controls.Add(this.lblTongSucChua);
            this.panelChonTau.Controls.Add(this.lblTongSoToa);
            this.panelChonTau.Controls.Add(this.cboTau);
            this.panelChonTau.Controls.Add(this.lblChonTau);
            this.panelChonTau.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChonTau.Location = new System.Drawing.Point(0, 55);
            this.panelChonTau.Name = "panelChonTau";
            this.panelChonTau.Size = new System.Drawing.Size(934, 60);
            this.panelChonTau.TabIndex = 1;
            // 
            // lblTrangThaiTau
            // 
            this.lblTrangThaiTau.AutoSize = true;
            this.lblTrangThaiTau.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThaiTau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.lblTrangThaiTau.Location = new System.Drawing.Point(740, 21);
            this.lblTrangThaiTau.Name = "lblTrangThaiTau";
            this.lblTrangThaiTau.Size = new System.Drawing.Size(127, 17);
            this.lblTrangThaiTau.TabIndex = 4;
            this.lblTrangThaiTau.Text = "Trạng thái: Sẵn sàng";
            // 
            // lblTongSucChua
            // 
            this.lblTongSucChua.AutoSize = true;
            this.lblTongSucChua.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSucChua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblTongSucChua.Location = new System.Drawing.Point(540, 21);
            this.lblTongSucChua.Name = "lblTongSucChua";
            this.lblTongSucChua.Size = new System.Drawing.Size(152, 17);
            this.lblTongSucChua.TabIndex = 3;
            this.lblTongSucChua.Text = "Tổng sức chứa: 0 chỗ ngồi";
            // 
            // lblTongSoToa
            // 
            this.lblTongSoToa.AutoSize = true;
            this.lblTongSoToa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSoToa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblTongSoToa.Location = new System.Drawing.Point(390, 21);
            this.lblTongSoToa.Name = "lblTongSoToa";
            this.lblTongSoToa.Size = new System.Drawing.Size(107, 17);
            this.lblTongSoToa.TabIndex = 2;
            this.lblTongSoToa.Text = "Tổng số toa: 0 toa";
            // 
            // cboTau
            // 
            this.cboTau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTau.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTau.FormattingEnabled = true;
            this.cboTau.Location = new System.Drawing.Point(125, 17);
            this.cboTau.Name = "cboTau";
            this.cboTau.Size = new System.Drawing.Size(240, 25);
            this.cboTau.TabIndex = 1;
            this.cboTau.SelectedIndexChanged += new System.EventHandler(this.cboTau_SelectedIndexChanged);
            // 
            // lblChonTau
            // 
            this.lblChonTau.AutoSize = true;
            this.lblChonTau.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonTau.Location = new System.Drawing.Point(15, 21);
            this.lblChonTau.Name = "lblChonTau";
            this.lblChonTau.Size = new System.Drawing.Size(98, 17);
            this.lblChonTau.TabIndex = 0;
            this.lblChonTau.Text = "Chọn đoàn tàu:";
            // 
            // grpToaTau
            // 
            this.grpToaTau.Controls.Add(this.btnXoaToa);
            this.grpToaTau.Controls.Add(this.btnSuaToa);
            this.grpToaTau.Controls.Add(this.btnThemToa);
            this.grpToaTau.Controls.Add(this.numSucChua);
            this.grpToaTau.Controls.Add(this.lblSucChua);
            this.grpToaTau.Controls.Add(this.cboLoaiToa);
            this.grpToaTau.Controls.Add(this.lblLoaiToa);
            this.grpToaTau.Controls.Add(this.numSoToa);
            this.grpToaTau.Controls.Add(this.lblSoToa);
            this.grpToaTau.Controls.Add(this.txtMaToa);
            this.grpToaTau.Controls.Add(this.lblMaToa);
            this.grpToaTau.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpToaTau.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToaTau.Location = new System.Drawing.Point(0, 115);
            this.grpToaTau.Name = "grpToaTau";
            this.grpToaTau.Size = new System.Drawing.Size(934, 125);
            this.grpToaTau.TabIndex = 2;
            this.grpToaTau.TabStop = false;
            this.grpToaTau.Text = "Thông Tin Toa Tàu";
            // 
            // btnXoaToa
            // 
            this.btnXoaToa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnXoaToa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaToa.FlatAppearance.BorderSize = 0;
            this.btnXoaToa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaToa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaToa.ForeColor = System.Drawing.Color.White;
            this.btnXoaToa.Location = new System.Drawing.Point(315, 75);
            this.btnXoaToa.Name = "btnXoaToa";
            this.btnXoaToa.Size = new System.Drawing.Size(100, 32);
            this.btnXoaToa.TabIndex = 10;
            this.btnXoaToa.Text = "Xóa Toa";
            this.btnXoaToa.UseVisualStyleBackColor = false;
            this.btnXoaToa.Click += new System.EventHandler(this.btnXoaToa_Click);
            // 
            // btnSuaToa
            // 
            this.btnSuaToa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnSuaToa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaToa.FlatAppearance.BorderSize = 0;
            this.btnSuaToa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaToa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaToa.ForeColor = System.Drawing.Color.White;
            this.btnSuaToa.Location = new System.Drawing.Point(200, 75);
            this.btnSuaToa.Name = "btnSuaToa";
            this.btnSuaToa.Size = new System.Drawing.Size(100, 32);
            this.btnSuaToa.TabIndex = 9;
            this.btnSuaToa.Text = "Cập Nhật";
            this.btnSuaToa.UseVisualStyleBackColor = false;
            this.btnSuaToa.Click += new System.EventHandler(this.btnSuaToa_Click);
            // 
            // btnThemToa
            // 
            this.btnThemToa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnThemToa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemToa.FlatAppearance.BorderSize = 0;
            this.btnThemToa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemToa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemToa.ForeColor = System.Drawing.Color.White;
            this.btnThemToa.Location = new System.Drawing.Point(85, 75);
            this.btnThemToa.Name = "btnThemToa";
            this.btnThemToa.Size = new System.Drawing.Size(100, 32);
            this.btnThemToa.TabIndex = 8;
            this.btnThemToa.Text = "Thêm Toa";
            this.btnThemToa.UseVisualStyleBackColor = false;
            this.btnThemToa.Click += new System.EventHandler(this.btnThemToa_Click);
            // 
            // numSucChua
            // 
            this.numSucChua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSucChua.Location = new System.Drawing.Point(745, 29);
            this.numSucChua.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numSucChua.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSucChua.Name = "numSucChua";
            this.numSucChua.Size = new System.Drawing.Size(100, 24);
            this.numSucChua.TabIndex = 7;
            this.numSucChua.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblSucChua
            // 
            this.lblSucChua.AutoSize = true;
            this.lblSucChua.Location = new System.Drawing.Point(675, 32);
            this.lblSucChua.Name = "lblSucChua";
            this.lblSucChua.Size = new System.Drawing.Size(65, 17);
            this.lblSucChua.TabIndex = 6;
            this.lblSucChua.Text = "Sức chứa:";
            // 
            // cboLoaiToa
            // 
            this.cboLoaiToa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiToa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiToa.FormattingEnabled = true;
            this.cboLoaiToa.Items.AddRange(new object[] {
            "Thường",
            "Ưu tiên"});
            this.cboLoaiToa.Location = new System.Drawing.Point(495, 28);
            this.cboLoaiToa.Name = "cboLoaiToa";
            this.cboLoaiToa.Size = new System.Drawing.Size(145, 25);
            this.cboLoaiToa.TabIndex = 5;
            // 
            // lblLoaiToa
            // 
            this.lblLoaiToa.AutoSize = true;
            this.lblLoaiToa.Location = new System.Drawing.Point(430, 32);
            this.lblLoaiToa.Name = "lblLoaiToa";
            this.lblLoaiToa.Size = new System.Drawing.Size(59, 17);
            this.lblLoaiToa.TabIndex = 4;
            this.lblLoaiToa.Text = "Loại toa:";
            // 
            // numSoToa
            // 
            this.numSoToa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoToa.Location = new System.Drawing.Point(305, 29);
            this.numSoToa.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numSoToa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoToa.Name = "numSoToa";
            this.numSoToa.Size = new System.Drawing.Size(95, 24);
            this.numSoToa.TabIndex = 3;
            this.numSoToa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSoToa
            // 
            this.lblSoToa.AutoSize = true;
            this.lblSoToa.Location = new System.Drawing.Point(235, 32);
            this.lblSoToa.Name = "lblSoToa";
            this.lblSoToa.Size = new System.Drawing.Size(65, 17);
            this.lblSoToa.TabIndex = 2;
            this.lblSoToa.Text = "Số thứ tự:";
            // 
            // txtMaToa
            // 
            this.txtMaToa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtMaToa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaToa.Location = new System.Drawing.Point(85, 29);
            this.txtMaToa.Name = "txtMaToa";
            this.txtMaToa.ReadOnly = true;
            this.txtMaToa.Size = new System.Drawing.Size(120, 24);
            this.txtMaToa.TabIndex = 1;
            // 
            // lblMaToa
            // 
            this.lblMaToa.AutoSize = true;
            this.lblMaToa.Location = new System.Drawing.Point(20, 32);
            this.lblMaToa.Name = "lblMaToa";
            this.lblMaToa.Size = new System.Drawing.Size(53, 17);
            this.lblMaToa.TabIndex = 0;
            this.lblMaToa.Text = "Mã toa:";
            // 
            // dgvToaTau
            // 
            this.dgvToaTau.AllowUserToAddRows = false;
            this.dgvToaTau.AllowUserToDeleteRows = false;
            this.dgvToaTau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToaTau.BackgroundColor = System.Drawing.Color.White;
            this.dgvToaTau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToaTau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvToaTau.Location = new System.Drawing.Point(0, 240);
            this.dgvToaTau.MultiSelect = false;
            this.dgvToaTau.Name = "dgvToaTau";
            this.dgvToaTau.ReadOnly = true;
            this.dgvToaTau.RowHeadersWidth = 30;
            this.dgvToaTau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToaTau.Size = new System.Drawing.Size(934, 321);
            this.dgvToaTau.TabIndex = 3;
            this.dgvToaTau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToaTau_CellClick);
            // 
            // FrmChiTietTau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.dgvToaTau);
            this.Controls.Add(this.grpToaTau);
            this.Controls.Add(this.panelChonTau);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmChiTietTau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Đoàn Tàu & Toa Tàu - Subway";
            this.Load += new System.EventHandler(this.FrmChiTietTau_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelChonTau.ResumeLayout(false);
            this.panelChonTau.PerformLayout();
            this.grpToaTau.ResumeLayout(false);
            this.grpToaTau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSucChua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoToa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaTau)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelChonTau;
        private System.Windows.Forms.Label lblChonTau;
        private System.Windows.Forms.ComboBox cboTau;
        private System.Windows.Forms.Label lblTongSoToa;
        private System.Windows.Forms.Label lblTongSucChua;
        private System.Windows.Forms.Label lblTrangThaiTau;
        private System.Windows.Forms.GroupBox grpToaTau;
        private System.Windows.Forms.Label lblMaToa;
        private System.Windows.Forms.TextBox txtMaToa;
        private System.Windows.Forms.Label lblSoToa;
        private System.Windows.Forms.NumericUpDown numSoToa;
        private System.Windows.Forms.Label lblLoaiToa;
        private System.Windows.Forms.ComboBox cboLoaiToa;
        private System.Windows.Forms.Label lblSucChua;
        private System.Windows.Forms.NumericUpDown numSucChua;
        private System.Windows.Forms.Button btnThemToa;
        private System.Windows.Forms.Button btnSuaToa;
        private System.Windows.Forms.Button btnXoaToa;
        private System.Windows.Forms.DataGridView dgvToaTau;
    }
}
