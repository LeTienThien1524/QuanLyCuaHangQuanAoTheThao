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
    public partial class frmNhaCungCap : Form
    {

        AppDbContext db = new AppDbContext();

        public frmNhaCungCap()
        {
            InitializeComponent();
            CaiDatGiaoDienDGV();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();
        }

        private void LoadNhaCungCap()
        {
            dgvNhaCungCap.Rows.Clear();
            foreach (var ncc in db.NhaCungCap.ToList())
            {
                dgvNhaCungCap.Rows.Add(ncc.MaNCC, ncc.TenNCC, ncc.SoDienThoai, ncc.DiaChi, ncc.Email);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNCC.Text) ||
                string.IsNullOrWhiteSpace(txtTenNCC.Text) ||
                string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà cung cấp!");
                return;
            }

            if (db.NhaCungCap.Any(n => n.MaNCC == txtMaNCC.Text))
            {
                MessageBox.Show("Mã nhà cung cấp đã tồn tại!");
                return;
            }

            var ncc = new NhaCungCap
            {
                MaNCC = txtMaNCC.Text,
                TenNCC = txtTenNCC.Text,
                SoDienThoai = txtSoDienThoai.Text,
                DiaChi = txtDiaChi.Text,
                Email = txtEmail.Text
            };

            db.NhaCungCap.Add(ncc);
            db.SaveChanges();
            LoadNhaCungCap();
            MessageBox.Show("Thêm nhà cung cấp thành công.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var ncc = db.NhaCungCap.Find(txtMaNCC.Text);
            if (ncc != null)
            {
                ncc.TenNCC = txtTenNCC.Text.Trim();
                ncc.SoDienThoai = txtSoDienThoai.Text.Trim();
                ncc.DiaChi = txtDiaChi.Text.Trim();
                ncc.Email = txtEmail.Text.Trim();
                db.SaveChanges();
                LoadNhaCungCap();
                MessageBox.Show("Sửa nhà cung cấp thành công.");
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp để sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var ncc = db.NhaCungCap.Find(txtMaNCC.Text);
            if (ncc != null)
            {
                var confirm = MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    db.NhaCungCap.Remove(ncc);
                    db.SaveChanges();
                    LoadNhaCungCap();
                    MessageBox.Show("Xóa nhà cung cấp thành công.");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp để xóa!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            var ds = db.NhaCungCap
                .Where(n => n.TenNCC.ToLower().Contains(tuKhoa))
                .ToList();

            dgvNhaCungCap.Rows.Clear();
            foreach (var ncc in ds)
            {
                dgvNhaCungCap.Rows.Add(ncc.MaNCC, ncc.TenNCC, ncc.SoDienThoai, ncc.DiaChi, ncc.Email);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtTimKiem.Clear();
            txtMaNCC.Focus();
            LoadNhaCungCap();
        }

        private void ptbTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaNCC.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNCC.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoDienThoai.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void CaiDatGiaoDienDGV()
        {
            // Căn chỉnh cột, giao diện lưới
            dgvNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaCungCap.AllowUserToAddRows = false;
            dgvNhaCungCap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhaCungCap.GridColor = Color.LightGray;

            // Màu các ô dữ liệu
            dgvNhaCungCap.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvNhaCungCap.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Màu dòng xen kẽ
            dgvNhaCungCap.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // Header cột
            dgvNhaCungCap.EnableHeadersVisualStyles = false;
            dgvNhaCungCap.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgvNhaCungCap.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
