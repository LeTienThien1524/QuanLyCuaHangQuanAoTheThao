namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Forms
{
    partial class frmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            txtDiaChi = new TextBox();
            txtTenNCC = new TextBox();
            label10 = new Label();
            txtTimKiem = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            txtSoDienThoai = new TextBox();
            txtMaNCC = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            dgvNhaCungCap = new DataGridView();
            MaNCC = new DataGridViewTextBoxColumn();
            TenNCC = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label7 = new Label();
            btnTimKiem = new Button();
            groupBox1 = new GroupBox();
            txtEmail = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox4 = new GroupBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(132, 125);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(224, 23);
            txtDiaChi.TabIndex = 8;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(132, 67);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(224, 23);
            txtTenNCC.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 79);
            label10.Name = "label10";
            label10.Size = new Size(134, 15);
            label10.TabIndex = 53;
            label10.Text = "Tìm kiếm NCC theo tên:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(159, 76);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(196, 23);
            txtTimKiem.TabIndex = 54;
            // 
            // btnThem
            // 
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(19, 16);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 37);
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
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(132, 96);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(224, 23);
            txtSoDienThoai.TabIndex = 7;
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(132, 38);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(224, 23);
            txtMaNCC.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 128);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 3;
            label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 99);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 2;
            label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 70);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên nhà cung cấp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 41);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã nhà cung cấp:";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(534, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(836, 631);
            panel2.TabIndex = 52;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvNhaCungCap);
            groupBox3.Location = new Point(23, 79);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(628, 407);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "DANH SÁCH NHÀ CUNG CẤP";
            // 
            // dgvNhaCungCap
            // 
            dgvNhaCungCap.Columns.AddRange(new DataGridViewColumn[] { MaNCC, TenNCC, SoDienThoai, DiaChi, Email });
            dgvNhaCungCap.Location = new Point(15, 27);
            dgvNhaCungCap.Name = "dgvNhaCungCap";
            dgvNhaCungCap.Size = new Size(590, 341);
            dgvNhaCungCap.TabIndex = 0;
            dgvNhaCungCap.CellContentClick += dgvNhaCungCap_CellContentClick;
            // 
            // MaNCC
            // 
            MaNCC.HeaderText = "Mã NCC";
            MaNCC.Name = "MaNCC";
            MaNCC.Width = 70;
            // 
            // TenNCC
            // 
            TenNCC.HeaderText = "Tên nhà cung cấp";
            TenNCC.Name = "TenNCC";
            TenNCC.Width = 150;
            // 
            // SoDienThoai
            // 
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.Name = "SoDienThoai";
            // 
            // DiaChi
            // 
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.Name = "DiaChi";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.Width = 120;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 157);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 4;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(350, 9);
            label7.Name = "label7";
            label7.Size = new Size(345, 37);
            label7.TabIndex = 1;
            label7.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(159, 105);
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
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(txtTenNCC);
            groupBox1.Controls.Add(txtMaNCC);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(129, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 220);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN NHÀ CUNG CẤP";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(132, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 23);
            txtEmail.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            pictureBox1.Click += ptbTroVe_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(txtTimKiem);
            groupBox4.Controls.Add(btnThem);
            groupBox4.Controls.Add(btnSua);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(btnLamMoi);
            groupBox4.Controls.Add(btnTimKiem);
            groupBox4.Location = new Point(129, 305);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(375, 181);
            groupBox4.TabIndex = 49;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thao tác";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(528, 631);
            panel1.TabIndex = 51;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1370, 50);
            panel3.TabIndex = 53;
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "frmNhaCungCap";
            Text = "frmNhaCungCap";
            Load += frmNhaCungCap_Load;
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtDiaChi;
        private TextBox txtTenNCC;
        private Label label10;
        private TextBox txtTimKiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private TextBox txtSoDienThoai;
        private TextBox txtMaNCC;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private GroupBox groupBox3;
        private DataGridView dgvNhaCungCap;
        private Label label6;
        private Label label7;
        private Button btnTimKiem;
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private PictureBox pictureBox1;
        private GroupBox groupBox4;
        private Panel panel1;
        private Panel panel3;
        private DataGridViewTextBoxColumn MaNCC;
        private DataGridViewTextBoxColumn TenNCC;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn Email;
    }
}