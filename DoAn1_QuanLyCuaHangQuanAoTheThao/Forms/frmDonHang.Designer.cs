namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Forms
{
    partial class frmDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonHang));
            dgvDonHang = new DataGridView();
            MaDH = new DataGridViewTextBoxColumn();
            MaKH = new DataGridViewTextBoxColumn();
            NgayTao = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            btnChiTietDonHang = new Button();
            panel3 = new Panel();
            ptbTroVe = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            groupBox4 = new GroupBox();
            btnInHoaDon = new Button();
            label10 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            groupBox1 = new GroupBox();
            txtTongTien = new TextBox();
            label8 = new Label();
            dtpNgayTao = new DateTimePicker();
            cbbTrangThai = new ComboBox();
            cbbKhachHang = new ComboBox();
            txtMaDH = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbTroVe).BeginInit();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDonHang
            // 
            dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonHang.Columns.AddRange(new DataGridViewColumn[] { MaDH, MaKH, NgayTao, TongTien, TrangThai });
            dgvDonHang.Location = new Point(24, 41);
            dgvDonHang.Name = "dgvDonHang";
            dgvDonHang.Size = new Size(503, 414);
            dgvDonHang.TabIndex = 11;
            dgvDonHang.CellContentClick += dgvDonHang_CellContentClick;
            // 
            // MaDH
            // 
            MaDH.HeaderText = "Mã ĐH";
            MaDH.Name = "MaDH";
            MaDH.Width = 70;
            // 
            // MaKH
            // 
            MaKH.HeaderText = "Mã KH";
            MaKH.Name = "MaKH";
            MaKH.Width = 70;
            // 
            // NgayTao
            // 
            NgayTao.HeaderText = "Ngày tạo";
            NgayTao.Name = "NgayTao";
            // 
            // TongTien
            // 
            TongTien.HeaderText = "Tổng tiền";
            TongTien.Name = "TongTien";
            // 
            // TrangThai
            // 
            TrangThai.HeaderText = "Trạng Thái";
            TrangThai.Name = "TrangThai";
            TrangThai.Width = 120;
            // 
            // btnChiTietDonHang
            // 
            btnChiTietDonHang.Image = (Image)resources.GetObject("btnChiTietDonHang.Image");
            btnChiTietDonHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnChiTietDonHang.Location = new Point(119, 182);
            btnChiTietDonHang.Name = "btnChiTietDonHang";
            btnChiTietDonHang.Size = new Size(163, 58);
            btnChiTietDonHang.TabIndex = 25;
            btnChiTietDonHang.Text = "Chi tiết đơn hàng";
            btnChiTietDonHang.TextAlign = ContentAlignment.MiddleRight;
            btnChiTietDonHang.UseVisualStyleBackColor = true;
            btnChiTietDonHang.Click += btnChiTiet_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(ptbTroVe);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1370, 50);
            panel3.TabIndex = 50;
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
            label1.Location = new Point(280, 9);
            label1.Name = "label1";
            label1.Size = new Size(467, 37);
            label1.TabIndex = 1;
            label1.Text = "CẬP NHẬT THÔNG TIN ĐƠN HÀNG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 631);
            panel1.TabIndex = 51;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnInHoaDon);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(txtTimKiem);
            groupBox4.Controls.Add(btnTimKiem);
            groupBox4.Controls.Add(btnThem);
            groupBox4.Controls.Add(btnSua);
            groupBox4.Controls.Add(btnChiTietDonHang);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(btnLamMoi);
            groupBox4.Location = new Point(111, 269);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(390, 295);
            groupBox4.TabIndex = 49;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thao tác";
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Image = (Image)resources.GetObject("btnInHoaDon.Image");
            btnInHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnInHoaDon.Location = new Point(30, 98);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(101, 36);
            btnInHoaDon.TabIndex = 63;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 71);
            label10.Name = "label10";
            label10.Size = new Size(160, 15);
            label10.TabIndex = 60;
            label10.Text = "Tìm kiếm ĐH theo trạng thái:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(203, 68);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(158, 23);
            txtTimKiem.TabIndex = 61;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(202, 97);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(91, 37);
            btnTimKiem.TabIndex = 62;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThem
            // 
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(30, 16);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(73, 37);
            btnThem.TabIndex = 55;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(119, 16);
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
            btnXoa.Location = new Point(189, 16);
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
            btnLamMoi.Location = new Point(270, 16);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(91, 37);
            btnLamMoi.TabIndex = 59;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.TextAlign = ContentAlignment.MiddleRight;
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTongTien);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtpNgayTao);
            groupBox1.Controls.Add(cbbTrangThai);
            groupBox1.Controls.Add(cbbKhachHang);
            groupBox1.Controls.Add(txtMaDH);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(111, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 211);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN ĐƠN HÀNG";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(128, 127);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(233, 23);
            txtTongTien.TabIndex = 43;
            txtTongTien.Text = "Tự động cập nhật";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 130);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 42;
            label8.Text = "Tổng tiền:";
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.Location = new Point(128, 98);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(233, 23);
            dtpNgayTao.TabIndex = 41;
            // 
            // cbbTrangThai
            // 
            cbbTrangThai.FormattingEnabled = true;
            cbbTrangThai.Items.AddRange(new object[] { "Chờ xử lý", "Đang giao", "Hoàn tất", "Đã hủy" });
            cbbTrangThai.Location = new Point(128, 156);
            cbbTrangThai.Name = "cbbTrangThai";
            cbbTrangThai.Size = new Size(233, 23);
            cbbTrangThai.TabIndex = 40;
            cbbTrangThai.Text = "Mặc định khi tạo: Chờ xử lý";
            // 
            // cbbKhachHang
            // 
            cbbKhachHang.FormattingEnabled = true;
            cbbKhachHang.Location = new Point(128, 71);
            cbbKhachHang.Name = "cbbKhachHang";
            cbbKhachHang.Size = new Size(233, 23);
            cbbKhachHang.TabIndex = 39;
            // 
            // txtMaDH
            // 
            txtMaDH.Location = new Point(128, 43);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.Size = new Size(233, 23);
            txtMaDH.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 160);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 37;
            label6.Text = "Trạng thái:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 104);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 36;
            label4.Text = "Ngày tạo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 74);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 35;
            label3.Text = "Khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 46);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 34;
            label2.Text = "Mã đơn hàng:";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(536, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(834, 631);
            panel2.TabIndex = 52;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDonHang);
            groupBox2.Location = new Point(32, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(553, 510);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "DANH SÁCH ĐƠN HÀNG";
            // 
            // frmDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "frmDonHang";
            Text = "Quản lý đơn hàng";
            Load += frmDonHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbTroVe).EndInit();
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvDonHang;
        private Button btnChiTietDonHang;
        private DataGridViewTextBoxColumn TongTien;
        private Label label5;
        private DataGridViewTextBoxColumn MaDH;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn NgayTao;
        private DataGridViewTextBoxColumn TrangThai;
        private Panel panel3;
        private PictureBox ptbTroVe;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox txtTongTien;
        private Label label8;
        private DateTimePicker dtpNgayTao;
        private ComboBox cbbTrangThai;
        private ComboBox cbbKhachHang;
        private TextBox txtMaDH;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Label label10;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnInHoaDon;
    }
}