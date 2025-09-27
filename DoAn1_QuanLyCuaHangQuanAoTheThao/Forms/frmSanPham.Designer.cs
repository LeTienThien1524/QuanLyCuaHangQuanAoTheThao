namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Forms
{
    partial class frmSanPham
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            label1 = new Label();
            dgvSanPham = new DataGridView();
            MaSP = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            MaDM = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            Anh = new DataGridViewImageColumn();
            ptbTroVe = new PictureBox();
            panel1 = new Panel();
            groupBox4 = new GroupBox();
            btnThem = new Button();
            label10 = new Label();
            txtTimKiem = new TextBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnTimKiem = new Button();
            groupBox1 = new GroupBox();
            cbbMaDM = new ComboBox();
            ptbAnh = new PictureBox();
            btnAnh = new Button();
            txtSoLuong = new TextBox();
            cbbSize = new ComboBox();
            txtGiaBan = new TextBox();
            txtTenSP = new TextBox();
            txtMaSP = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnQLDanhMuc = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbTroVe).BeginInit();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).BeginInit();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(280, 9);
            label1.Name = "label1";
            label1.Size = new Size(463, 37);
            label1.TabIndex = 1;
            label1.Text = "CẬP NHẬT THÔNG TIN SẢN PHẨM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvSanPham
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, MaDM, GiaBan, Size, SoLuong, Anh });
            dgvSanPham.Location = new Point(6, 37);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.Size = new Size(788, 487);
            dgvSanPham.TabIndex = 18;
            dgvSanPham.CellContentClick += dgvSanPham_CellContentClick;
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
            TenSP.Width = 170;
            // 
            // MaDM
            // 
            MaDM.HeaderText = "Danh mục";
            MaDM.Name = "MaDM";
            MaDM.Width = 110;
            // 
            // GiaBan
            // 
            GiaBan.HeaderText = "Giá bán";
            GiaBan.Name = "GiaBan";
            // 
            // Size
            // 
            Size.HeaderText = "Size";
            Size.Name = "Size";
            Size.Width = 60;
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số lượng";
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 80;
            // 
            // Anh
            // 
            Anh.HeaderText = "Ảnh";
            Anh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Anh.Name = "Anh";
            Anh.Width = 150;
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
            // panel1
            // 
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 631);
            panel1.TabIndex = 32;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnThem);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(txtTimKiem);
            groupBox4.Controls.Add(btnSua);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(btnLamMoi);
            groupBox4.Controls.Add(btnTimKiem);
            groupBox4.Location = new Point(79, 334);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(375, 150);
            groupBox4.TabIndex = 48;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thao tác";
            // 
            // btnThem
            // 
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(19, 16);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 37);
            btnThem.TabIndex = 60;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 79);
            label10.Name = "label10";
            label10.Size = new Size(167, 15);
            label10.TabIndex = 53;
            label10.Text = "Tìm kiếm SP theo tên, mã DM:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(192, 76);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(163, 23);
            txtTimKiem.TabIndex = 54;
            // 
            // btnSua
            // 
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(107, 16);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(64, 37);
            btnSua.TabIndex = 56;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(186, 16);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(62, 37);
            btnXoa.TabIndex = 57;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Image = (Image)resources.GetObject("btnLamMoi.Image");
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.Location = new Point(264, 16);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(91, 37);
            btnLamMoi.TabIndex = 59;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.TextAlign = ContentAlignment.MiddleRight;
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(192, 105);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(91, 37);
            btnTimKiem.TabIndex = 58;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbbMaDM);
            groupBox1.Controls.Add(ptbAnh);
            groupBox1.Controls.Add(btnAnh);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(cbbSize);
            groupBox1.Controls.Add(txtGiaBan);
            groupBox1.Controls.Add(txtTenSP);
            groupBox1.Controls.Add(txtMaSP);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(79, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 263);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // cbbMaDM
            // 
            cbbMaDM.FormattingEnabled = true;
            cbbMaDM.Items.AddRange(new object[] { "qabd", "qacl", "qlbc", "qabr" });
            cbbMaDM.Location = new Point(108, 96);
            cbbMaDM.Name = "cbbMaDM";
            cbbMaDM.Size = new Size(247, 23);
            cbbMaDM.TabIndex = 45;
            // 
            // ptbAnh
            // 
            ptbAnh.Location = new Point(255, 159);
            ptbAnh.Name = "ptbAnh";
            ptbAnh.Size = new Size(100, 75);
            ptbAnh.TabIndex = 42;
            ptbAnh.TabStop = false;
            // 
            // btnAnh
            // 
            btnAnh.Location = new Point(107, 211);
            btnAnh.Name = "btnAnh";
            btnAnh.Size = new Size(121, 23);
            btnAnh.TabIndex = 41;
            btnAnh.Text = "File ảnh";
            btnAnh.UseVisualStyleBackColor = true;
            btnAnh.Click += btnAnh_Click;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(107, 182);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.ReadOnly = true;
            txtSoLuong.Size = new Size(121, 23);
            txtSoLuong.TabIndex = 40;
            txtSoLuong.Text = "Tự động cập nhật";
            // 
            // cbbSize
            // 
            cbbSize.FormattingEnabled = true;
            cbbSize.Items.AddRange(new object[] { "S", "M", "L", "XL", "XXL" });
            cbbSize.Location = new Point(107, 153);
            cbbSize.Name = "cbbSize";
            cbbSize.Size = new Size(121, 23);
            cbbSize.TabIndex = 39;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(107, 124);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(248, 23);
            txtGiaBan.TabIndex = 38;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(107, 66);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(248, 23);
            txtTenSP.TabIndex = 37;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(107, 37);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(248, 23);
            txtMaSP.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 215);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 35;
            label8.Text = "Ảnh:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 185);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 34;
            label7.Text = "Số Lượng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 156);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 33;
            label6.Text = "Size:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 127);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 32;
            label5.Text = "Giá bán:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 99);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 31;
            label4.Text = "Danh mục:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 69);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 30;
            label3.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 41);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 29;
            label2.Text = "Mã sản phẩm:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnQLDanhMuc);
            groupBox3.Location = new Point(79, 490);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(375, 127);
            groupBox3.TabIndex = 47;
            groupBox3.TabStop = false;
            groupBox3.Text = "QUẢN LÝ DANH MỤC";
            // 
            // btnQLDanhMuc
            // 
            btnQLDanhMuc.Image = (Image)resources.GetObject("btnQLDanhMuc.Image");
            btnQLDanhMuc.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDanhMuc.Location = new Point(107, 31);
            btnQLDanhMuc.Name = "btnQLDanhMuc";
            btnQLDanhMuc.Size = new Size(163, 51);
            btnQLDanhMuc.TabIndex = 31;
            btnQLDanhMuc.Text = "Quản lý danh mục";
            btnQLDanhMuc.TextAlign = ContentAlignment.MiddleRight;
            btnQLDanhMuc.UseVisualStyleBackColor = true;
            btnQLDanhMuc.Click += btnQLDanhMuc_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(ptbTroVe);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1370, 50);
            panel3.TabIndex = 49;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(476, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(894, 631);
            panel2.TabIndex = 47;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvSanPham);
            groupBox2.Location = new Point(27, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 552);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 681);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "frmSanPham";
            Text = "Quản lý sản phẩm";
            Load += frmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbTroVe).EndInit();
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).EndInit();
            groupBox3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvSanPham;
        private PictureBox ptbTroVe;
        private Panel panel1;
        private GroupBox groupBox1;
        private ComboBox cbbMaDM;
        private PictureBox ptbAnh;
        private Button btnAnh;
        private TextBox txtSoLuong;
        private ComboBox cbbSize;
        private TextBox txtGiaBan;
        private TextBox txtTenSP;
        private TextBox txtMaSP;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn MaDM;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewImageColumn Anh;
        private Button btnQLDanhMuc;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label10;
        private TextBox txtTimKiem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnTimKiem;
        private Panel panel3;
        private Button btnThem;
    }
}