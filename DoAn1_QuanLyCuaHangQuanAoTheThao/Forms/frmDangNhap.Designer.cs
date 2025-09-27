namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Forms
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            cbHienAn = new CheckBox();
            label4 = new Label();
            cbbVaiTro = new ComboBox();
            btnThoat = new Button();
            btnDangNhap = new Button();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cbHienAn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cbbVaiTro);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(108, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 318);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(34, 190);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 129;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(34, 161);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 128;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 127;
            pictureBox1.TabStop = false;
            // 
            // cbHienAn
            // 
            cbHienAn.Anchor = AnchorStyles.None;
            cbHienAn.AutoSize = true;
            cbHienAn.Location = new Point(319, 165);
            cbHienAn.Name = "cbHienAn";
            cbHienAn.Size = new Size(71, 19);
            cbHienAn.TabIndex = 126;
            cbHienAn.Text = "Hiện/Ẩn";
            cbHienAn.UseVisualStyleBackColor = true;
            cbHienAn.CheckedChanged += cbHienAn_CheckedChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(60, 193);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 125;
            label4.Text = "Vai trò:";
            // 
            // cbbVaiTro
            // 
            cbbVaiTro.Anchor = AnchorStyles.None;
            cbbVaiTro.FormattingEnabled = true;
            cbbVaiTro.Items.AddRange(new object[] { "Admin", "NhanVien" });
            cbbVaiTro.Location = new Point(154, 190);
            cbbVaiTro.Name = "cbbVaiTro";
            cbbVaiTro.Size = new Size(121, 23);
            cbbVaiTro.TabIndex = 124;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.BackColor = Color.LightGray;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Location = new Point(227, 241);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 33);
            btnThoat.TabIndex = 123;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Anchor = AnchorStyles.None;
            btnDangNhap.BackColor = Color.RoyalBlue;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Location = new Point(121, 241);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(75, 33);
            btnDangNhap.TabIndex = 122;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.None;
            txtMatKhau.Location = new Point(154, 161);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(158, 23);
            txtMatKhau.TabIndex = 121;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Anchor = AnchorStyles.None;
            txtTenDangNhap.Location = new Point(154, 132);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(236, 23);
            txtTenDangNhap.TabIndex = 120;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(60, 166);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 119;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(60, 135);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 118;
            label2.Text = "Tên đăng nhập:";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(178, 65);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 52);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 117;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(121, 25);
            label1.Name = "label1";
            label1.Size = new Size(181, 37);
            label1.TabIndex = 116;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 372);
            panel2.Name = "panel2";
            panel2.Size = new Size(634, 39);
            panel2.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(142, 15);
            label5.Name = "label5";
            label5.Size = new Size(360, 15);
            label5.TabIndex = 131;
            label5.Text = "Phần mềm quản lý cửa hàng quần áo thể thao Code bởi Tiến Thiên";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(634, 411);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmDangNhap";
            Text = "Đăng nhập hệ thống";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private CheckBox cbHienAn;
        private Label label4;
        private ComboBox cbbVaiTro;
        private Button btnThoat;
        private Button btnDangNhap;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox4;
        private Label label1;
        private Panel panel2;
        private Label label5;
    }
}