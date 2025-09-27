using DoAn1_QuanLyCuaHangQuanAoTheThao.Data;
using DoAn1_QuanLyCuaHangQuanAoTheThao.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Forms
{
    public partial class frmDanhMuc : Form
    {

        AppDbContext db = new AppDbContext();

        public frmDanhMuc()
        {
            InitializeComponent();
            CaiDatGiaoDienDGV();
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
        }

        private void LoadDanhMuc()
        {
            dgvDanhMuc.Rows.Clear();
            foreach (var dm in db.DanhMuc.ToList())
            {
                dgvDanhMuc.Rows.Add(dm.MaDM, dm.TenDM);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDM.Text) || string.IsNullOrWhiteSpace(txtTenDM.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin danh mục!");
                return;
            }

            if (db.DanhMuc.Any(d => d.MaDM == txtMaDM.Text))
            {
                MessageBox.Show("Mã danh mục đã tồn tại!");
                return;
            }

            var dm = new DanhMuc
            {
                MaDM = txtMaDM.Text,
                TenDM = txtTenDM.Text
            };

            db.DanhMuc.Add(dm);
            db.SaveChanges();
            LoadDanhMuc();
            MessageBox.Show("Thêm danh mục thành công.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var dm = db.DanhMuc.Find(txtMaDM.Text);
            if (dm != null)
            {
                dm.TenDM = txtTenDM.Text;
                db.SaveChanges();
                LoadDanhMuc();
                MessageBox.Show("Sửa danh mục thành công.");
            }
            else
            {
                MessageBox.Show("Không tìm thấy danh mục để sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool coSanPham = db.SanPham.Any(sp => sp.MaDM == txtMaDM.Text);
            if (coSanPham)
            {
                MessageBox.Show("Không thể xóa vì còn có sản phẩm thuộc danh mục này!");
                return;
            }

            var dm = db.DanhMuc.Find(txtMaDM.Text);
            if (dm != null)
            {
                var confirm = MessageBox.Show("Bạn có chắc muốn xóa danh mục này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    db.DanhMuc.Remove(dm);
                    db.SaveChanges();
                    LoadDanhMuc();
                    MessageBox.Show("Xóa danh mục thành công.");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy danh mục để xóa!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDM.Clear();
            txtTenDM.Clear();
            txtMaDM.Focus();
        }

        private void dgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaDM.Text = dgvDanhMuc.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenDM.Text = dgvDanhMuc.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void ptbTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CaiDatGiaoDienDGV()
        {
            // Căn chỉnh cột, giao diện lưới
            dgvDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhMuc.AllowUserToAddRows = false;
            dgvDanhMuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhMuc.GridColor = Color.LightGray;

            // Màu các ô dữ liệu
            dgvDanhMuc.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvDanhMuc.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Màu dòng xen kẽ
            dgvDanhMuc.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // Header cột
            dgvDanhMuc.EnableHeadersVisualStyles = false;
            dgvDanhMuc.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgvDanhMuc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
