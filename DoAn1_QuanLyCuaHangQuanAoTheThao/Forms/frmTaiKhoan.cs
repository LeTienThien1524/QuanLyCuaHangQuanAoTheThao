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
    public partial class frmTaiKhoan : Form
    {

        AppDbContext db = new AppDbContext();

        public frmTaiKhoan()
        {
            InitializeComponent();
            CaiDatGiaoDienDGV();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }

        private void LoadTaiKhoan()
        {
            dgvTaiKhoan.Rows.Clear();
            foreach (var tk in db.TaiKhoan.ToList())
            {
                dgvTaiKhoan.Rows.Add(tk.MaTK, tk.TenDangNhap, tk.MatKhau, tk.VaiTro);
            }
        }

        private string TaoMaTuDong()
        {
            var maCuoi = db.TaiKhoan
                          .Select(t => t.MaTK)
                          .Where(m => m.StartsWith("tk"))
                          .OrderByDescending(m => m)
                          .FirstOrDefault();

            if (maCuoi != null && int.TryParse(maCuoi.Substring(2), out int so))
            {
                return "tk" + (so + 1);
            }
            else
            {
                return "tk1";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text) || cbbVaiTro.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (db.TaiKhoan.Any(t => t.TenDangNhap == txtTenDangNhap.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
                return;
            }

            var tk = new TaiKhoan
            {
                MaTK = TaoMaTuDong(),
                TenDangNhap = txtTenDangNhap.Text,
                MatKhau = txtMatKhau.Text,
                VaiTro = cbbVaiTro.SelectedItem.ToString()
            };

            db.TaiKhoan.Add(tk);
            db.SaveChanges();
            LoadTaiKhoan();
            MessageBox.Show("Thêm tài khoản thành công.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow == null) return;

            string maTK = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString();
            var tk = db.TaiKhoan.Find(maTK);
            if (tk != null)
            {
                tk.TenDangNhap = txtTenDangNhap.Text;
                tk.MatKhau = txtMatKhau.Text;
                tk.VaiTro = cbbVaiTro.SelectedItem.ToString();

                db.SaveChanges();
                LoadTaiKhoan();
                MessageBox.Show("Sửa tài khoản thành công.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow == null) return;

            string maTK = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString();
            var tk = db.TaiKhoan.Find(maTK);
            if (tk != null)
            {
                var confirm = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    db.TaiKhoan.Remove(tk);
                    db.SaveChanges();
                    LoadTaiKhoan();
                    MessageBox.Show("Xóa tài khoản thành công.");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cbbVaiTro.SelectedIndex = -1;
            txtTenDangNhap.Focus();
        }

        private void ptbTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTenDangNhap.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMatKhau.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbbVaiTro.SelectedItem = dgvTaiKhoan.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void CaiDatGiaoDienDGV()
        {
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.GridColor = Color.LightGray;

            dgvTaiKhoan.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvTaiKhoan.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvTaiKhoan.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dgvTaiKhoan.EnableHeadersVisualStyles = false;
            dgvTaiKhoan.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgvTaiKhoan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
