namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Forms
{
    partial class frmKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKho));
            label6 = new Label();
            dgvPhieuNhapKho = new DataGridView();
            MaPhieu = new DataGridViewTextBoxColumn();
            TenNCC = new DataGridViewTextBoxColumn();
            NgayNhapXuat = new DataGridViewTextBoxColumn();
            LoaiPhieu = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            ptbTroVe = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            groupBox4 = new GroupBox();
            btnInPhieuNhap = new Button();
            btnXoa = new Button();
            btnChiTietPhieuNhapXuat = new Button();
            btnNhapKho = new Button();
            button1 = new Button();
            groupBox5 = new GroupBox();
            btnQLNhaCungCap = new Button();
            groupBox1 = new GroupBox();
            txtMaPhieu = new TextBox();
            label5 = new Label();
            label10 = new Label();
            cbbNhaCungCap = new ComboBox();
            dtpNgayNhapXuat = new DateTimePicker();
            label3 = new Label();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            dgvPhieuXuatKho = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhapKho).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbTroVe).BeginInit();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuXuatKho).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(180, 267);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 38;
            // 
            // dgvPhieuNhapKho
            // 
            dgvPhieuNhapKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuNhapKho.Columns.AddRange(new DataGridViewColumn[] { MaPhieu, TenNCC, NgayNhapXuat, LoaiPhieu });
            dgvPhieuNhapKho.Location = new Point(6, 22);
            dgvPhieuNhapKho.Name = "dgvPhieuNhapKho";
            dgvPhieuNhapKho.Size = new Size(704, 215);
            dgvPhieuNhapKho.TabIndex = 47;
            dgvPhieuNhapKho.CellContentClick += dgvPhieuNhapKho_CellContentClick;
            // 
            // MaPhieu
            // 
            MaPhieu.HeaderText = "Mã phiếu";
            MaPhieu.Name = "MaPhieu";
            // 
            // TenNCC
            // 
            TenNCC.HeaderText = "Nhà cung cấp";
            TenNCC.Name = "TenNCC";
            // 
            // NgayNhapXuat
            // 
            NgayNhapXuat.HeaderText = "Ngày nhập/xuất";
            NgayNhapXuat.Name = "NgayNhapXuat";
            // 
            // LoaiPhieu
            // 
            LoaiPhieu.HeaderText = "Loại phiếu";
            LoaiPhieu.Name = "LoaiPhieu";
            // 
            // panel3
            // 
            panel3.Controls.Add(ptbTroVe);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1370, 50);
            panel3.TabIndex = 58;
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
            label1.Location = new Point(416, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 37);
            label1.TabIndex = 1;
            label1.Text = "XỬ LÝ KHO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 631);
            panel1.TabIndex = 59;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnInPhieuNhap);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(btnChiTietPhieuNhapXuat);
            groupBox4.Controls.Add(btnNhapKho);
            groupBox4.Controls.Add(button1);
            groupBox4.Location = new Point(97, 220);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(353, 166);
            groupBox4.TabIndex = 50;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thao tác";
            // 
            // btnInPhieuNhap
            // 
            btnInPhieuNhap.Image = (Image)resources.GetObject("btnInPhieuNhap.Image");
            btnInPhieuNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnInPhieuNhap.Location = new Point(31, 89);
            btnInPhieuNhap.Name = "btnInPhieuNhap";
            btnInPhieuNhap.Size = new Size(119, 37);
            btnInPhieuNhap.TabIndex = 64;
            btnInPhieuNhap.Text = "In phiếu nhập";
            btnInPhieuNhap.TextAlign = ContentAlignment.MiddleRight;
            btnInPhieuNhap.UseVisualStyleBackColor = true;
            btnInPhieuNhap.Click += btnInPhieuNhap_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(148, 30);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(62, 37);
            btnXoa.TabIndex = 63;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnChiTietPhieuNhapXuat
            // 
            btnChiTietPhieuNhapXuat.Image = (Image)resources.GetObject("btnChiTietPhieuNhapXuat.Image");
            btnChiTietPhieuNhapXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnChiTietPhieuNhapXuat.Location = new Point(191, 78);
            btnChiTietPhieuNhapXuat.Name = "btnChiTietPhieuNhapXuat";
            btnChiTietPhieuNhapXuat.Size = new Size(132, 58);
            btnChiTietPhieuNhapXuat.TabIndex = 62;
            btnChiTietPhieuNhapXuat.Text = "Chi tiết phiếu";
            btnChiTietPhieuNhapXuat.TextAlign = ContentAlignment.MiddleRight;
            btnChiTietPhieuNhapXuat.UseVisualStyleBackColor = true;
            btnChiTietPhieuNhapXuat.Click += btnChiTietPhieu_Click;
            // 
            // btnNhapKho
            // 
            btnNhapKho.Image = (Image)resources.GetObject("btnNhapKho.Image");
            btnNhapKho.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhapKho.Location = new Point(31, 30);
            btnNhapKho.Name = "btnNhapKho";
            btnNhapKho.Size = new Size(96, 37);
            btnNhapKho.TabIndex = 60;
            btnNhapKho.Text = "Nhập kho";
            btnNhapKho.TextAlign = ContentAlignment.MiddleRight;
            btnNhapKho.UseVisualStyleBackColor = true;
            btnNhapKho.Click += btnNhapKho_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(232, 30);
            button1.Name = "button1";
            button1.Size = new Size(91, 37);
            button1.TabIndex = 59;
            button1.Text = "Làm mới";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLamMoi_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnQLNhaCungCap);
            groupBox5.Location = new Point(97, 425);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(353, 138);
            groupBox5.TabIndex = 49;
            groupBox5.TabStop = false;
            groupBox5.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            // 
            // btnQLNhaCungCap
            // 
            btnQLNhaCungCap.Image = (Image)resources.GetObject("btnQLNhaCungCap.Image");
            btnQLNhaCungCap.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLNhaCungCap.Location = new Point(83, 34);
            btnQLNhaCungCap.Name = "btnQLNhaCungCap";
            btnQLNhaCungCap.Size = new Size(183, 55);
            btnQLNhaCungCap.TabIndex = 62;
            btnQLNhaCungCap.Text = "Quản lý nhà cung cấp";
            btnQLNhaCungCap.TextAlign = ContentAlignment.MiddleRight;
            btnQLNhaCungCap.UseVisualStyleBackColor = true;
            btnQLNhaCungCap.Click += btnQLNhaCungCap_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaPhieu);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cbbNhaCungCap);
            groupBox1.Controls.Add(dtpNgayNhapXuat);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(97, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 164);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN PHIẾU NHẬP KHO";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(133, 44);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.ReadOnly = true;
            txtMaPhieu.Size = new Size(190, 23);
            txtMaPhieu.TabIndex = 68;
            txtMaPhieu.Text = "Tạo tự động";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 47);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 67;
            label5.Text = "Mã phiếu:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(31, 76);
            label10.Name = "label10";
            label10.Size = new Size(84, 15);
            label10.TabIndex = 66;
            label10.Text = "Nhà cung cấp:";
            // 
            // cbbNhaCungCap
            // 
            cbbNhaCungCap.FormattingEnabled = true;
            cbbNhaCungCap.Location = new Point(133, 73);
            cbbNhaCungCap.Name = "cbbNhaCungCap";
            cbbNhaCungCap.Size = new Size(190, 23);
            cbbNhaCungCap.TabIndex = 65;
            // 
            // dtpNgayNhapXuat
            // 
            dtpNgayNhapXuat.Location = new Point(133, 102);
            dtpNgayNhapXuat.Name = "dtpNgayNhapXuat";
            dtpNgayNhapXuat.Size = new Size(190, 23);
            dtpNgayNhapXuat.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 108);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 58;
            label3.Text = "Ngày nhập:";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(490, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(880, 631);
            panel2.TabIndex = 60;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvPhieuXuatKho);
            groupBox3.Location = new Point(30, 315);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(737, 259);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "LỊCH SỬ XUẤT KHO";
            // 
            // dgvPhieuXuatKho
            // 
            dgvPhieuXuatKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuXuatKho.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvPhieuXuatKho.Location = new Point(6, 22);
            dgvPhieuXuatKho.Name = "dgvPhieuXuatKho";
            dgvPhieuXuatKho.Size = new Size(704, 216);
            dgvPhieuXuatKho.TabIndex = 47;
            dgvPhieuXuatKho.CellContentClick += dgvPhieuXuatKho_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Mã phiếu";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Mã đơn hàng";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Ngày nhập/xuất";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Loại phiếu";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvPhieuNhapKho);
            groupBox2.Location = new Point(30, 50);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(737, 259);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "LỊCH SỬ NHẬP KHO";
            // 
            // frmKho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 681);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "frmKho";
            Text = "Quản lý kho";
            Load += frmKho_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhapKho).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbTroVe).EndInit();
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhieuXuatKho).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private DataGridView dgvPhieuNhapKho;
        private Panel panel3;
        private PictureBox ptbTroVe;
        private Label label1;
        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
        private GroupBox groupBox2;
        private TextBox txtMaPhieu;
        private Label label5;
        private Label label10;
        private ComboBox cbbNhaCungCap;
        private DateTimePicker dtpNgayNhapXuat;
        private Label label3;
        private GroupBox groupBox4;
        private Button btnNhapKho;
        private Button button1;
        private GroupBox groupBox5;
        private Button btnQLNhaCungCap;
        private DataGridViewTextBoxColumn MaPhieu;
        private DataGridViewTextBoxColumn TenNCC;
        private DataGridViewTextBoxColumn NgayNhapXuat;
        private DataGridViewTextBoxColumn LoaiPhieu;
        private Button btnChiTietPhieuNhapXuat;
        private Button btnXoa;
        private GroupBox groupBox3;
        private DataGridView dgvPhieuXuatKho;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button btnInPhieuNhap;
    }
}