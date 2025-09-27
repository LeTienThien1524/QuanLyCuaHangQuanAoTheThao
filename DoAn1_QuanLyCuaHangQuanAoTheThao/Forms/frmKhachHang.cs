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
    public partial class frmKhachHang : Form
    {

        AppDbContext db = new AppDbContext();

        public frmKhachHang()
        {
            InitializeComponent();
            CaiDatGiaoDienDGV();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void LoadKhachHang()
        {
            dgvKhachHang.Rows.Clear();
            foreach (var kh in db.KhachHang.ToList())
            {
                dgvKhachHang.Rows.Add(kh.MaKH, kh.TenKH, kh.SoDienThoai, kh.DiaChi, kh.Email);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) ||
                string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!");
                return;
            }

            if (db.KhachHang.Any(k => k.MaKH == txtMaKH.Text))
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!");
                return;
            }

            var kh = new KhachHang
            {
                MaKH = txtMaKH.Text,
                TenKH = txtTenKH.Text,
                SoDienThoai = txtSoDienThoai.Text,
                DiaChi = txtDiaChi.Text,
                Email = txtEmail.Text
            };

            db.KhachHang.Add(kh);
            db.SaveChanges();
            LoadKhachHang();
            MessageBox.Show("Thêm khách hàng thành công.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var kh = db.KhachHang.Find(txtMaKH.Text);
            if (kh != null)
            {
                kh.TenKH = txtTenKH.Text;
                kh.SoDienThoai = txtSoDienThoai.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.Email = txtEmail.Text;
                db.SaveChanges();
                LoadKhachHang();
                MessageBox.Show("Sửa khách hàng thành công.");
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng để sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var kh = db.KhachHang.Find(txtMaKH.Text);
            if (kh != null)
            {
                var confirm = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    db.KhachHang.Remove(kh);
                    db.SaveChanges();
                    LoadKhachHang();
                    MessageBox.Show("Xóa khách hàng thành công.");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng để xóa!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtTimKiem.Clear();
            txtMaKH.Focus();
            LoadKhachHang();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng để tìm kiếm!");
                return;
            }
            var ds = db.KhachHang
                .Where(k => k.TenKH.ToLower().Contains(tuKhoa))
                .ToList();

            dgvKhachHang.Rows.Clear();
            foreach (var kh in ds)
            {
                dgvKhachHang.Rows.Add(kh.MaKH, kh.TenKH, kh.SoDienThoai, kh.DiaChi, kh.Email);
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoDienThoai.Text = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dgvKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void ptbTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CaiDatGiaoDienDGV()
        {
            // Căn chỉnh cột, giao diện lưới
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.GridColor = Color.LightGray;

            // Màu các ô dữ liệu
            dgvKhachHang.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvKhachHang.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Màu dòng xen kẽ
            dgvKhachHang.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // Header cột
            dgvKhachHang.EnableHeadersVisualStyles = false;
            dgvKhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgvKhachHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
