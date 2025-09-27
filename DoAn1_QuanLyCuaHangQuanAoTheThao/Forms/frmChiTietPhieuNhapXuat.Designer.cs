namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Forms
{
    partial class frmChiTietPhieuNhapXuat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietPhieuNhapXuat));
            panel3 = new Panel();
            ptbTroVe = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            groupBox4 = new GroupBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            groupBox1 = new GroupBox();
            lblLoaiPhieu = new Label();
            lblMaPhieu = new Label();
            cbbSanPham = new ComboBox();
            txtSoLuong = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            dgvChiTietPhieu = new DataGridView();
            MaSP = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbTroVe).BeginInit();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieu).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(ptbTroVe);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1370, 50);
            panel3.TabIndex = 51;
            // 
            // ptbTroVe
            // 
            ptbTroVe.Image = (Image)resources.GetObject("ptbTroVe.Image");
            ptbTroVe.Location = new Point(12, 12);
            ptbTroVe.Name = "ptbTroVe";
            ptbTroVe.Size = new Size(38, 34);
            ptbTroVe.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbTroVe.TabIndex = 30;
            ptbTroVe.TabStop = false;
            ptbTroVe.Click += btnTroVe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(391, 9);
            label1.Name = "label1";
            label1.Size = new Size(445, 37);
            label1.TabIndex = 1;
            label1.Text = "CHI TIẾT PHIẾU NHẬP XUẤT KHO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 631);
            panel1.TabIndex = 53;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnThem);
            groupBox4.Controls.Add(btnSua);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(btnLamMoi);
            groupBox4.Location = new Point(178, 296);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(371, 132);
            groupBox4.TabIndex = 50;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thao tác";
            // 
            // btnThem
            // 
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(39, 16);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(144, 37);
            btnThem.TabIndex = 55;
            btnThem.Text = "Nhập thêm SP mới";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(204, 16);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(161, 37);
            btnSua.TabIndex = 56;
            btnSua.Text = "Sửa thông tin SP nhập";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(39, 59);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(144, 37);
            btnXoa.TabIndex = 57;
            btnXoa.Text = "Xóa SP trong phiếu";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Image = (Image)resources.GetObject("btnLamMoi.Image");
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.Location = new Point(204, 59);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(161, 37);
            btnLamMoi.TabIndex = 59;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.TextAlign = ContentAlignment.MiddleRight;
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblLoaiPhieu);
            groupBox1.Controls.Add(lblMaPhieu);
            groupBox1.Controls.Add(cbbSanPham);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(178, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(371, 210);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN CHI TIẾT PHIẾU";
            // 
            // lblLoaiPhieu
            // 
            lblLoaiPhieu.AutoSize = true;
            lblLoaiPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoaiPhieu.Location = new Point(124, 73);
            lblLoaiPhieu.Name = "lblLoaiPhieu";
            lblLoaiPhieu.Size = new Size(63, 15);
            lblLoaiPhieu.TabIndex = 47;
            lblLoaiPhieu.Text = "Loại phiếu";
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.AutoSize = true;
            lblMaPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaPhieu.Location = new Point(124, 51);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(58, 15);
            lblMaPhieu.TabIndex = 46;
            lblMaPhieu.Text = "Mã phiếu";
            // 
            // cbbSanPham
            // 
            cbbSanPham.FormattingEnabled = true;
            cbbSanPham.Location = new Point(124, 104);
            cbbSanPham.Name = "cbbSanPham";
            cbbSanPham.Size = new Size(183, 23);
            cbbSanPham.TabIndex = 45;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(124, 133);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(183, 23);
            txtSoLuong.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 136);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 41;
            label4.Text = "Số lượng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 107);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 40;
            label3.Text = "Sản phẩm:";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(585, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(785, 631);
            panel2.TabIndex = 54;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvChiTietPhieu);
            groupBox2.Location = new Point(31, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(601, 348);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "CHI TIẾT PHIẾU";
            // 
            // dgvChiTietPhieu
            // 
            dgvChiTietPhieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietPhieu.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, SoLuong });
            dgvChiTietPhieu.Location = new Point(28, 51);
            dgvChiTietPhieu.Name = "dgvChiTietPhieu";
            dgvChiTietPhieu.Size = new Size(540, 261);
            dgvChiTietPhieu.TabIndex = 9;
            dgvChiTietPhieu.CellContentClick += dgvChiTietPhieu_CellContentClick;
            // 
            // MaSP
            // 
            MaSP.HeaderText = "Mã SP";
            MaSP.Name = "MaSP";
            MaSP.Width = 70;
            // 
            // TenSP
            // 
            TenSP.HeaderText = "Tên sản phẩm";
            TenSP.Name = "TenSP";
            TenSP.Width = 150;
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số lượng";
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 80;
            // 
            // frmChiTietPhieuNhapXuat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "frmChiTietPhieuNhapXuat";
            Text = "frmChiTietPhieuNhapXuat";
            Load += frmChiTietPhieuNhapXuat_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbTroVe).EndInit();
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private PictureBox ptbTroVe;
        private Label label1;
        private Panel panel1;
        private GroupBox groupBox4;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private GroupBox groupBox1;
        private Label lblMaPhieu;
        private ComboBox cbbSanPham;
        private TextBox txtSoLuong;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private GroupBox groupBox2;
        private DataGridView dgvChiTietPhieu;
        private Label lblLoaiPhieu;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn SoLuong;
    }
}