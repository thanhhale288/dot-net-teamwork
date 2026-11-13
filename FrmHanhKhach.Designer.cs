namespace QuanLyTau
{
    partial class FrmHanhKhach
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblSdt = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.txtMaHK = new System.Windows.Forms.TextBox();
            this.lblMaHK = new System.Windows.Forms.Label();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.grpDanhSachHK = new System.Windows.Forms.GroupBox();
            this.dgvHanhKhach = new System.Windows.Forms.DataGridView();
            this.grpLichSuVe = new System.Windows.Forms.GroupBox();
            this.dgvLichSuVe = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelTopAction.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.grpDanhSachHK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhKhach)).BeginInit();
            this.grpLichSuVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuVe)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(519, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ HÀNH KHÁCH && LỊCH SỬ CÁC VÉ TÀU ĐÃ MUA";
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
            this.btnLamMoi.Location = new System.Drawing.Point(545, 11);
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
            this.btnTimKiem.Location = new System.Drawing.Point(445, 11);
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
            this.txtTimKiem.Size = new System.Drawing.Size(290, 24);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(15, 16);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(126, 17);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm theo tên/CCCD:";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.btnXoa);
            this.grpInfo.Controls.Add(this.btnSua);
            this.grpInfo.Controls.Add(this.btnThem);
            this.grpInfo.Controls.Add(this.txtSoDienThoai);
            this.grpInfo.Controls.Add(this.lblSdt);
            this.grpInfo.Controls.Add(this.txtHoTen);
            this.grpInfo.Controls.Add(this.lblHoTen);
            this.grpInfo.Controls.Add(this.txtCCCD);
            this.grpInfo.Controls.Add(this.lblCCCD);
            this.grpInfo.Controls.Add(this.txtMaHK);
            this.grpInfo.Controls.Add(this.lblMaHK);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(0, 105);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(984, 120);
            this.grpInfo.TabIndex = 2;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông Tin Hành Khách";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(315, 75);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 32);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa Khách";
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
            this.btnSua.Location = new System.Drawing.Point(210, 75);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 32);
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
            this.btnThem.Location = new System.Drawing.Point(105, 75);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 32);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(745, 28);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(200, 24);
            this.txtSoDienThoai.TabIndex = 7;
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Location = new System.Drawing.Point(650, 32);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(91, 17);
            this.lblSdt.TabIndex = 6;
            this.lblSdt.Text = "Số điện thoại:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(435, 28);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 24);
            this.txtHoTen.TabIndex = 5;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(365, 32);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(70, 17);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(215, 28);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(140, 24);
            this.txtCCCD.TabIndex = 3;
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(165, 32);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(46, 17);
            this.lblCCCD.TabIndex = 2;
            this.lblCCCD.Text = "CCCD:";
            // 
            // txtMaHK
            // 
            this.txtMaHK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtMaHK.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHK.Location = new System.Drawing.Point(85, 28);
            this.txtMaHK.Name = "txtMaHK";
            this.txtMaHK.ReadOnly = true;
            this.txtMaHK.Size = new System.Drawing.Size(70, 24);
            this.txtMaHK.TabIndex = 1;
            // 
            // lblMaHK
            // 
            this.lblMaHK.AutoSize = true;
            this.lblMaHK.Location = new System.Drawing.Point(20, 32);
            this.lblMaHK.Name = "lblMaHK";
            this.lblMaHK.Size = new System.Drawing.Size(53, 17);
            this.lblMaHK.TabIndex = 0;
            this.lblMaHK.Text = "Mã HK:";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 225);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.grpDanhSachHK);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.grpLichSuVe);
            this.splitContainerMain.Size = new System.Drawing.Size(984, 386);
            this.splitContainerMain.SplitterDistance = 190;
            this.splitContainerMain.TabIndex = 3;
            // 
            // grpDanhSachHK
            // 
            this.grpDanhSachHK.Controls.Add(this.dgvHanhKhach);
            this.grpDanhSachHK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSachHK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSachHK.Location = new System.Drawing.Point(0, 0);
            this.grpDanhSachHK.Name = "grpDanhSachHK";
            this.grpDanhSachHK.Size = new System.Drawing.Size(984, 190);
            this.grpDanhSachHK.TabIndex = 0;
            this.grpDanhSachHK.TabStop = false;
            this.grpDanhSachHK.Text = "Danh Sách Hành Khách (Click chọn để xem lịch sử vé)";
            // 
            // dgvHanhKhach
            // 
            this.dgvHanhKhach.AllowUserToAddRows = false;
            this.dgvHanhKhach.AllowUserToDeleteRows = false;
            this.dgvHanhKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHanhKhach.BackgroundColor = System.Drawing.Color.White;
            this.dgvHanhKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanhKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHanhKhach.Location = new System.Drawing.Point(3, 19);
            this.dgvHanhKhach.MultiSelect = false;
            this.dgvHanhKhach.Name = "dgvHanhKhach";
            this.dgvHanhKhach.ReadOnly = true;
            this.dgvHanhKhach.RowHeadersWidth = 30;
            this.dgvHanhKhach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHanhKhach.Size = new System.Drawing.Size(978, 168);
            this.dgvHanhKhach.TabIndex = 0;
            this.dgvHanhKhach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHanhKhach_CellClick);
            // 
            // grpLichSuVe
            // 
            this.grpLichSuVe.Controls.Add(this.dgvLichSuVe);
            this.grpLichSuVe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLichSuVe.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLichSuVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.grpLichSuVe.Location = new System.Drawing.Point(0, 0);
            this.grpLichSuVe.Name = "grpLichSuVe";
            this.grpLichSuVe.Size = new System.Drawing.Size(984, 192);
            this.grpLichSuVe.TabIndex = 0;
            this.grpLichSuVe.TabStop = false;
            this.grpLichSuVe.Text = "Lịch Sử Toàn Bộ Các Vé Đã Mua Của Hành Khách Đang Chọn";
            // 
            // dgvLichSuVe
            // 
            this.dgvLichSuVe.AllowUserToAddRows = false;
            this.dgvLichSuVe.AllowUserToDeleteRows = false;
            this.dgvLichSuVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSuVe.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSuVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuVe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichSuVe.Location = new System.Drawing.Point(3, 19);
            this.dgvLichSuVe.MultiSelect = false;
            this.dgvLichSuVe.Name = "dgvLichSuVe";
            this.dgvLichSuVe.ReadOnly = true;
            this.dgvLichSuVe.RowHeadersWidth = 30;
            this.dgvLichSuVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSuVe.Size = new System.Drawing.Size(978, 170);
            this.dgvLichSuVe.TabIndex = 0;
            // 
            // FrmHanhKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.panelTopAction);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmHanhKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hành Khách & Lịch Sử Mua Vé - Subway";
            this.Load += new System.EventHandler(this.FrmHanhKhach_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelTopAction.ResumeLayout(false);
            this.panelTopAction.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.grpDanhSachHK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhKhach)).EndInit();
            this.grpLichSuVe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuVe)).EndInit();
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
        private System.Windows.Forms.Label lblMaHK;
        private System.Windows.Forms.TextBox txtMaHK;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.GroupBox grpDanhSachHK;
        private System.Windows.Forms.DataGridView dgvHanhKhach;
        private System.Windows.Forms.GroupBox grpLichSuVe;
        private System.Windows.Forms.DataGridView dgvLichSuVe;
    }
}
