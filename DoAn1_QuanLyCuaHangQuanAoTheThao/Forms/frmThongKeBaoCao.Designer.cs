namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Forms
{
    partial class frmThongKeBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeBaoCao));
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel3 = new Panel();
            ptbTroVe = new PictureBox();
            label1 = new Label();
            lblTongDoanhThu = new Label();
            lblTongSanPhamBanDuoc = new Label();
            lblTongDonHang = new Label();
            groupBox1 = new GroupBox();
            pictureBox4 = new PictureBox();
            lblTongKhachHang = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            btnXuatPDF = new Button();
            dgvThongKeBaoCao = new DataGridView();
            dtpThangNam = new DateTimePicker();
            label2 = new Label();
            btnTonKho = new Button();
            btnBanChay = new Button();
            btnDoanhThu = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbTroVe).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKeBaoCao).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
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
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(534, 9);
            label1.Name = "label1";
            label1.Size = new Size(297, 37);
            label1.TabIndex = 1;
            label1.Text = "THỐNG KÊ - BÁO CÁO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Location = new Point(59, 38);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(101, 17);
            lblTongDoanhThu.TabIndex = 54;
            lblTongDoanhThu.Text = "Tổng doanh thu";
            // 
            // lblTongSanPhamBanDuoc
            // 
            lblTongSanPhamBanDuoc.AutoSize = true;
            lblTongSanPhamBanDuoc.Location = new Point(526, 38);
            lblTongSanPhamBanDuoc.Name = "lblTongSanPhamBanDuoc";
            lblTongSanPhamBanDuoc.Size = new Size(159, 17);
            lblTongSanPhamBanDuoc.TabIndex = 55;
            lblTongSanPhamBanDuoc.Text = "Tổng sản phẩm bán được";
            // 
            // lblTongDonHang
            // 
            lblTongDonHang.AutoSize = true;
            lblTongDonHang.Location = new Point(311, 38);
            lblTongDonHang.Name = "lblTongDonHang";
            lblTongDonHang.Size = new Size(98, 17);
            lblTongDonHang.TabIndex = 56;
            lblTongDonHang.Text = "Tổng đơn hàng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(lblTongKhachHang);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(lblTongDoanhThu);
            groupBox1.Controls.Add(lblTongSanPhamBanDuoc);
            groupBox1.Controls.Add(lblTongDonHang);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(233, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(910, 80);
            groupBox1.TabIndex = 57;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thống kê tổng quan";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(738, 24);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 62;
            pictureBox4.TabStop = false;
            // 
            // lblTongKhachHang
            // 
            lblTongKhachHang.AutoSize = true;
            lblTongKhachHang.Location = new Point(764, 38);
            lblTongKhachHang.Name = "lblTongKhachHang";
            lblTongKhachHang.Size = new Size(108, 17);
            lblTongKhachHang.TabIndex = 61;
            lblTongKhachHang.Text = "Tổng khách hàng";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(500, 24);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 60;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(285, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 59;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXuatPDF);
            groupBox2.Controls.Add(dgvThongKeBaoCao);
            groupBox2.Controls.Add(dtpThangNam);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnTonKho);
            groupBox2.Controls.Add(btnBanChay);
            groupBox2.Controls.Add(btnDoanhThu);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(233, 191);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(910, 405);
            groupBox2.TabIndex = 58;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thống kê chi tiết";
            // 
            // btnXuatPDF
            // 
            btnXuatPDF.Image = (Image)resources.GetObject("btnXuatPDF.Image");
            btnXuatPDF.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuatPDF.Location = new Point(421, 348);
            btnXuatPDF.Name = "btnXuatPDF";
            btnXuatPDF.Size = new Size(101, 38);
            btnXuatPDF.TabIndex = 60;
            btnXuatPDF.Text = "Xuất PDF";
            btnXuatPDF.TextAlign = ContentAlignment.MiddleRight;
            btnXuatPDF.UseVisualStyleBackColor = true;
            btnXuatPDF.Click += btnXuatPDF_Click;
            // 
            // dgvThongKeBaoCao
            // 
            dgvThongKeBaoCao.Anchor = AnchorStyles.None;
            dgvThongKeBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKeBaoCao.Location = new Point(221, 74);
            dgvThongKeBaoCao.Name = "dgvThongKeBaoCao";
            dgvThongKeBaoCao.Size = new Size(476, 210);
            dgvThongKeBaoCao.TabIndex = 59;
            // 
            // dtpThangNam
            // 
            dtpThangNam.Anchor = AnchorStyles.None;
            dtpThangNam.Location = new Point(453, 39);
            dtpThangNam.Name = "dtpThangNam";
            dtpThangNam.Size = new Size(203, 25);
            dtpThangNam.TabIndex = 58;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(264, 45);
            label2.Name = "label2";
            label2.Size = new Size(163, 17);
            label2.TabIndex = 57;
            label2.Text = "Chọn tháng/năm thống kê:";
            // 
            // btnTonKho
            // 
            btnTonKho.Anchor = AnchorStyles.None;
            btnTonKho.Image = (Image)resources.GetObject("btnTonKho.Image");
            btnTonKho.ImageAlign = ContentAlignment.MiddleLeft;
            btnTonKho.Location = new Point(604, 299);
            btnTonKho.Name = "btnTonKho";
            btnTonKho.Size = new Size(93, 34);
            btnTonKho.TabIndex = 56;
            btnTonKho.Text = "Tồn kho";
            btnTonKho.TextAlign = ContentAlignment.MiddleRight;
            btnTonKho.UseVisualStyleBackColor = true;
            btnTonKho.Click += btnTonKho_Click;
            // 
            // btnBanChay
            // 
            btnBanChay.Anchor = AnchorStyles.None;
            btnBanChay.Image = (Image)resources.GetObject("btnBanChay.Image");
            btnBanChay.ImageAlign = ContentAlignment.MiddleLeft;
            btnBanChay.Location = new Point(421, 299);
            btnBanChay.Name = "btnBanChay";
            btnBanChay.Size = new Size(160, 34);
            btnBanChay.TabIndex = 55;
            btnBanChay.Text = "Sản phẩm bán chạy";
            btnBanChay.TextAlign = ContentAlignment.MiddleRight;
            btnBanChay.UseVisualStyleBackColor = true;
            btnBanChay.Click += btnBanChay_Click;
            // 
            // btnDoanhThu
            // 
            btnDoanhThu.Anchor = AnchorStyles.None;
            btnDoanhThu.Image = (Image)resources.GetObject("btnDoanhThu.Image");
            btnDoanhThu.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoanhThu.Location = new Point(221, 299);
            btnDoanhThu.Name = "btnDoanhThu";
            btnDoanhThu.Size = new Size(174, 34);
            btnDoanhThu.TabIndex = 54;
            btnDoanhThu.Text = "Doanh thu theo tháng";
            btnDoanhThu.TextAlign = ContentAlignment.MiddleRight;
            btnDoanhThu.UseVisualStyleBackColor = true;
            btnDoanhThu.Click += btnDoanhThu_Click;
            // 
            // frmThongKeBaoCao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 681);
            Controls.Add(groupBox1);
            Controls.Add(panel3);
            Controls.Add(groupBox2);
            Name = "frmThongKeBaoCao";
            Text = "Thống kê báo cáo";
            Load += frmThongKeBaoCao_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbTroVe).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKeBaoCao).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel3;
        private PictureBox ptbTroVe;
        private Label label1;
        private Label lblTongDoanhThu;
        private Label lblTongSanPhamBanDuoc;
        private Label lblTongDonHang;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private GroupBox groupBox2;
        private DataGridView dgvThongKeBaoCao;
        private DateTimePicker dtpThangNam;
        private Label label2;
        private Button btnTonKho;
        private Button btnBanChay;
        private Button btnDoanhThu;
        private Label lblTongKhachHang;
        private PictureBox pictureBox4;
        private Button btnXuatPDF;
    }
}