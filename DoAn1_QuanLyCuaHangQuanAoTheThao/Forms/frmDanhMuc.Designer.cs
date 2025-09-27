namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Forms
{
    partial class frmDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMuc));
            panel1 = new Panel();
            groupBox4 = new GroupBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            groupBox1 = new GroupBox();
            txtTenDM = new TextBox();
            txtMaDM = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            dgvDanhMuc = new DataGridView();
            MaDM = new DataGridViewTextBoxColumn();
            TenDM = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            ptbTroVe = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbTroVe).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 699);
            panel1.TabIndex = 50;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnThem);
            groupBox4.Controls.Add(btnSua);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(btnLamMoi);
            groupBox4.Location = new Point(139, 215);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(375, 186);
            groupBox4.TabIndex = 51;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenDM);
            groupBox1.Controls.Add(txtMaDM);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(139, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 129);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN DANH MỤC";
            // 
            // txtTenDM
            // 
            txtTenDM.Location = new Point(109, 69);
            txtTenDM.Name = "txtTenDM";
            txtTenDM.Size = new Size(230, 23);
            txtTenDM.TabIndex = 9;
            // 
            // txtMaDM
            // 
            txtMaDM.Location = new Point(109, 38);
            txtMaDM.Name = "txtMaDM";
            txtMaDM.Size = new Size(230, 23);
            txtMaDM.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 77);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 7;
            label3.Text = "Tên danh mục:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 41);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 6;
            label2.Text = "Mã danh mục:";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(554, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 699);
            panel2.TabIndex = 51;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDanhMuc);
            groupBox2.Location = new Point(39, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(455, 321);
            groupBox2.TabIndex = 53;
            groupBox2.TabStop = false;
            groupBox2.Text = "DANH SÁCH DANH MỤC";
            // 
            // dgvDanhMuc
            // 
            dgvDanhMuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhMuc.Columns.AddRange(new DataGridViewColumn[] { MaDM, TenDM });
            dgvDanhMuc.Location = new Point(36, 38);
            dgvDanhMuc.Name = "dgvDanhMuc";
            dgvDanhMuc.Size = new Size(378, 239);
            dgvDanhMuc.TabIndex = 10;
            dgvDanhMuc.CellContentClick += dgvDanhMuc_CellContentClick;
            // 
            // MaDM
            // 
            MaDM.HeaderText = "Mã danh mục";
            MaDM.Name = "MaDM";
            MaDM.Width = 120;
            // 
            // TenDM
            // 
            TenDM.HeaderText = "Tên danh mục";
            TenDM.Name = "TenDM";
            TenDM.Width = 210;
            // 
            // panel3
            // 
            panel3.Controls.Add(ptbTroVe);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1370, 50);
            panel3.TabIndex = 52;
            // 
            // ptbTroVe
            // 
            ptbTroVe.Image = (Image)resources.GetObject("ptbTroVe.Image");
            ptbTroVe.Location = new Point(12, 13);
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
            label1.Location = new Point(325, 9);
            label1.Name = "label1";
            label1.Size = new Size(443, 37);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ DANH MỤC SẢN PHẨM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmDanhMuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "frmDanhMuc";
            Text = "Quản lý danh mục";
            Load += frmDanhMuc_Load;
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbTroVe).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private GroupBox groupBox4;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private GroupBox groupBox1;
        private TextBox txtTenDM;
        private TextBox txtMaDM;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private GroupBox groupBox2;
        private DataGridView dgvDanhMuc;
        private DataGridViewTextBoxColumn MaDM;
        private DataGridViewTextBoxColumn TenDM;
        private Panel panel3;
        private PictureBox ptbTroVe;
        private Label label1;
    }
}