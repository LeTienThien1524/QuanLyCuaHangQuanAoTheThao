namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Forms
{
    partial class frmChiTietDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietDonHang));
            dgvChiTietDonHang = new DataGridView();
            MaSP = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
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
            lblTrangThai = new Label();
            lblMaDH = new Label();
            cbbSanPham = new ComboBox();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietDonHang).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbTroVe).BeginInit();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvChiTietDonHang
            // 
            dgvChiTietDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietDonHang.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, SoLuong, DonGia, ThanhTien });
            dgvChiTietDonHang.Location = new Point(29, 38);
            dgvChiTietDonHang.Name = "dgvChiTietDonHang";
            dgvChiTietDonHang.Size = new Size(540, 218);
            dgvChiTietDonHang.TabIndex = 9;
            dgvChiTietDonHang.CellContentClick += dgvChiTietDonHang_CellContentClick;
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
            // DonGia
            // 
            DonGia.HeaderText = "Đơn giá";
            DonGia.Name = "DonGia";
            DonGia.Width = 90;
            // 
            // ThanhTien
            // 
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.Name = "ThanhTien";
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
            ptbTroVe.Click += ptbTroVe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(364, 9);
            label1.Name = "label1";
            label1.Size = new Size(426, 37);
            label1.TabIndex = 1;
            label1.Text = "CẬP NHẬT CHI TIẾT ĐƠN HÀNG";
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
            panel1.TabIndex = 52;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnThem);
            groupBox4.Controls.Add(btnSua);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(btnLamMoi);
            groupBox4.Location = new Point(178, 296);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(371, 114);
            groupBox4.TabIndex = 50;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thao tác";
            // 
            // btnThem
            // 
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(40, 16);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(137, 37);
            btnThem.TabIndex = 55;
            btnThem.Text = "Thêm SP vào ĐH";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThemSP_Click;
            // 
            // btnSua
            // 
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(201, 16);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(134, 37);
            btnSua.TabIndex = 56;
            btnSua.Text = "Sửa SP trong ĐH";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSuaSP_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(40, 59);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(137, 37);
            btnXoa.TabIndex = 57;
            btnXoa.Text = "Xóa SP khỏi ĐH";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoaSP_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Image = (Image)resources.GetObject("btnLamMoi.Image");
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.Location = new Point(201, 59);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(134, 37);
            btnLamMoi.TabIndex = 59;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.TextAlign = ContentAlignment.MiddleRight;
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTrangThai);
            groupBox1.Controls.Add(lblMaDH);
            groupBox1.Controls.Add(cbbSanPham);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(178, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(371, 210);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN CHI TIẾT ĐƠN HÀNG";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrangThai.Location = new Point(159, 64);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(62, 15);
            lblTrangThai.TabIndex = 47;
            lblTrangThai.Text = "Trạng thái";
            // 
            // lblMaDH
            // 
            lblMaDH.AutoSize = true;
            lblMaDH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaDH.Location = new Point(159, 38);
            lblMaDH.Name = "lblMaDH";
            lblMaDH.Size = new Size(80, 15);
            lblMaDH.TabIndex = 46;
            lblMaDH.Text = "Mã đơn hàng";
            // 
            // cbbSanPham
            // 
            cbbSanPham.FormattingEnabled = true;
            cbbSanPham.Location = new Point(124, 96);
            cbbSanPham.Name = "cbbSanPham";
            cbbSanPham.Size = new Size(183, 23);
            cbbSanPham.TabIndex = 45;
            cbbSanPham.SelectedIndexChanged += cbbSanPham_SelectedIndexChanged;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(124, 154);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(183, 23);
            txtDonGia.TabIndex = 44;
            txtDonGia.Text = "Tự động cập nhật";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(124, 125);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(183, 23);
            txtSoLuong.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 157);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 42;
            label5.Text = "Đơn giá:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 128);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 41;
            label4.Text = "Số lượng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 99);
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
            panel2.TabIndex = 53;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvChiTietDonHang);
            groupBox2.Location = new Point(31, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(601, 330);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "CHI TIẾT ĐƠN HÀNG";
            // 
            // frmChiTietDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "frmChiTietDonHang";
            Text = "Chi tiết đơn hàng";
            Load += frmChiTietDonHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChiTietDonHang).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbTroVe).EndInit();
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private DataGridView dgvChiTietDonHang;
        private Panel panel3;
        private PictureBox ptbTroVe;
        private Label label1;
        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
        private GroupBox groupBox2;
        private Label lblMaDH;
        private ComboBox cbbSanPham;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox4;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
        private Label lblTrangThai;
    }
}