namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Forms
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            menuStrip1 = new MenuStrip();
            quảnLýHệThốngToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            quảnLýSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýĐơnHàngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKhoToolStripMenuItem = new ToolStripMenuItem();
            thốngKêBáoCáoToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbDangXuat = new ToolStripButton();
            tsbQLSanPham = new ToolStripButton();
            tsbQLKhachHang = new ToolStripButton();
            tsbQLDonHang = new ToolStripButton();
            tsbKho = new ToolStripButton();
            tsbThongKeBaoCao = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            helpToolStripButton = new ToolStripButton();
            pictureBox1 = new PictureBox();
            lblVaiTro = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            quảnLýTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DeepSkyBlue;
            menuStrip1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýHệThốngToolStripMenuItem, quảnLýSảnPhẩmToolStripMenuItem, quảnLýKháchHàngToolStripMenuItem, quảnLýĐơnHàngToolStripMenuItem, quảnLýKhoToolStripMenuItem, thốngKêBáoCáoToolStripMenuItem, thoátToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(894, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýHệThốngToolStripMenuItem
            // 
            quảnLýHệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýTàiKhoảnToolStripMenuItem, đăngXuấtToolStripMenuItem });
            quảnLýHệThốngToolStripMenuItem.Image = (Image)resources.GetObject("quảnLýHệThốngToolStripMenuItem.Image");
            quảnLýHệThốngToolStripMenuItem.Name = "quảnLýHệThốngToolStripMenuItem";
            quảnLýHệThốngToolStripMenuItem.Size = new Size(136, 21);
            quảnLýHệThốngToolStripMenuItem.Text = "Quản lý hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(180, 22);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            quảnLýSảnPhẩmToolStripMenuItem.Image = (Image)resources.GetObject("quảnLýSảnPhẩmToolStripMenuItem.Image");
            quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            quảnLýSảnPhẩmToolStripMenuItem.Size = new Size(141, 21);
            quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            quảnLýSảnPhẩmToolStripMenuItem.Click += quảnLýSảnPhẩmToolStripMenuItem_Click;
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.Image = (Image)resources.GetObject("quảnLýKháchHàngToolStripMenuItem.Image");
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(150, 21);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            quảnLýKháchHàngToolStripMenuItem.Click += quảnLýKháchHàngToolStripMenuItem_Click;
            // 
            // quảnLýĐơnHàngToolStripMenuItem
            // 
            quảnLýĐơnHàngToolStripMenuItem.Image = (Image)resources.GetObject("quảnLýĐơnHàngToolStripMenuItem.Image");
            quảnLýĐơnHàngToolStripMenuItem.Name = "quảnLýĐơnHàngToolStripMenuItem";
            quảnLýĐơnHàngToolStripMenuItem.Size = new Size(140, 21);
            quảnLýĐơnHàngToolStripMenuItem.Text = "Quản lý đơn hàng";
            quảnLýĐơnHàngToolStripMenuItem.Click += quảnLýĐơnHàngToolStripMenuItem_Click;
            // 
            // quảnLýKhoToolStripMenuItem
            // 
            quảnLýKhoToolStripMenuItem.Image = (Image)resources.GetObject("quảnLýKhoToolStripMenuItem.Image");
            quảnLýKhoToolStripMenuItem.Name = "quảnLýKhoToolStripMenuItem";
            quảnLýKhoToolStripMenuItem.Size = new Size(105, 21);
            quảnLýKhoToolStripMenuItem.Text = "Quản lý kho";
            quảnLýKhoToolStripMenuItem.Click += quảnLýKhoToolStripMenuItem_Click;
            // 
            // thốngKêBáoCáoToolStripMenuItem
            // 
            thốngKêBáoCáoToolStripMenuItem.Image = (Image)resources.GetObject("thốngKêBáoCáoToolStripMenuItem.Image");
            thốngKêBáoCáoToolStripMenuItem.Name = "thốngKêBáoCáoToolStripMenuItem";
            thốngKêBáoCáoToolStripMenuItem.Size = new Size(142, 21);
            thốngKêBáoCáoToolStripMenuItem.Text = "Thống kê báo cáo";
            thốngKêBáoCáoToolStripMenuItem.Click += thốngKêBáoCáoToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Image = (Image)resources.GetObject("thoátToolStripMenuItem.Image");
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(69, 21);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(107, 70);
            label1.Name = "label1";
            label1.Size = new Size(186, 37);
            label1.TabIndex = 2;
            label1.Text = "DASHBOARD";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.DeepSkyBlue;
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, tsbDangXuat, tsbQLSanPham, tsbQLKhachHang, tsbQLDonHang, tsbKho, tsbThongKeBaoCao, toolStripSeparator2, helpToolStripButton });
            toolStrip1.Location = new Point(0, 25);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(24, 501);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(21, 6);
            // 
            // tsbDangXuat
            // 
            tsbDangXuat.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbDangXuat.Image = (Image)resources.GetObject("tsbDangXuat.Image");
            tsbDangXuat.ImageTransparentColor = Color.Magenta;
            tsbDangXuat.Name = "tsbDangXuat";
            tsbDangXuat.Size = new Size(21, 20);
            tsbDangXuat.Text = "Đăng xuất";
            tsbDangXuat.Click += tsbDangXuat_Click;
            // 
            // tsbQLSanPham
            // 
            tsbQLSanPham.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbQLSanPham.Image = (Image)resources.GetObject("tsbQLSanPham.Image");
            tsbQLSanPham.ImageTransparentColor = Color.Magenta;
            tsbQLSanPham.Name = "tsbQLSanPham";
            tsbQLSanPham.Size = new Size(21, 20);
            tsbQLSanPham.Text = "QL sản phẩm";
            tsbQLSanPham.Click += tsbQLSanPham_Click;
            // 
            // tsbQLKhachHang
            // 
            tsbQLKhachHang.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbQLKhachHang.Image = (Image)resources.GetObject("tsbQLKhachHang.Image");
            tsbQLKhachHang.ImageTransparentColor = Color.Magenta;
            tsbQLKhachHang.Name = "tsbQLKhachHang";
            tsbQLKhachHang.Size = new Size(21, 20);
            tsbQLKhachHang.Text = "Ql khách hàng";
            tsbQLKhachHang.Click += tsbQLKhachHang_Click;
            // 
            // tsbQLDonHang
            // 
            tsbQLDonHang.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbQLDonHang.Image = (Image)resources.GetObject("tsbQLDonHang.Image");
            tsbQLDonHang.ImageTransparentColor = Color.Magenta;
            tsbQLDonHang.Name = "tsbQLDonHang";
            tsbQLDonHang.Size = new Size(21, 20);
            tsbQLDonHang.Text = "QL đơn hàng";
            tsbQLDonHang.Click += tsbQLDonHang_Click;
            // 
            // tsbKho
            // 
            tsbKho.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbKho.Image = (Image)resources.GetObject("tsbKho.Image");
            tsbKho.ImageTransparentColor = Color.Magenta;
            tsbKho.Name = "tsbKho";
            tsbKho.Size = new Size(21, 20);
            tsbKho.Text = "QL kho";
            tsbKho.Click += tsbKho_Click;
            // 
            // tsbThongKeBaoCao
            // 
            tsbThongKeBaoCao.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbThongKeBaoCao.Image = (Image)resources.GetObject("tsbThongKeBaoCao.Image");
            tsbThongKeBaoCao.ImageTransparentColor = Color.Magenta;
            tsbThongKeBaoCao.Name = "tsbThongKeBaoCao";
            tsbThongKeBaoCao.Size = new Size(21, 20);
            tsbThongKeBaoCao.Text = "Thống kê báo cáo";
            tsbThongKeBaoCao.Click += tsbThongKeBaoCao_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(21, 6);
            // 
            // helpToolStripButton
            // 
            helpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            helpToolStripButton.Image = (Image)resources.GetObject("helpToolStripButton.Image");
            helpToolStripButton.ImageTransparentColor = Color.Magenta;
            helpToolStripButton.Name = "helpToolStripButton";
            helpToolStripButton.Size = new Size(21, 20);
            helpToolStripButton.Text = "Hướng dẫn sử dụng";
            helpToolStripButton.Click += helpToolStripButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblVaiTro
            // 
            lblVaiTro.AutoSize = true;
            lblVaiTro.BackColor = SystemColors.Control;
            lblVaiTro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVaiTro.Location = new Point(41, 33);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(55, 21);
            lblVaiTro.TabIndex = 6;
            lblVaiTro.Text = "Vai trò";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            quảnLýTàiKhoảnToolStripMenuItem.Size = new Size(180, 22);
            quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            quảnLýTàiKhoảnToolStripMenuItem.Click += quảnLýTàiKhoảnToolStripMenuItem_Click;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(894, 526);
            Controls.Add(lblVaiTro);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "frmDashboard";
            Text = "QUẢN LÝ CỬA HÀNG QUẦN ÁO THỂ THAO";
            WindowState = FormWindowState.Maximized;
            Load += frmDashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýHệThốngToolStripMenuItem;
        private ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private ToolStripMenuItem quảnLýĐơnHàngToolStripMenuItem;
        private ToolStripMenuItem quảnLýKhoToolStripMenuItem;
        private ToolStripMenuItem thốngKêBáoCáoToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbDangXuat;
        private ToolStripButton tsbQLSanPham;
        private ToolStripButton tsbQLKhachHang;
        private ToolStripButton tsbQLDonHang;
        private ToolStripButton tsbKho;
        private ToolStripButton tsbThongKeBaoCao;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton helpToolStripButton;
        private PictureBox pictureBox1;
        private ToolStripSeparator toolStripSeparator1;
        private Label lblVaiTro;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
    }
}