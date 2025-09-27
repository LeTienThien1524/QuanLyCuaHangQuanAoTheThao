using DoAn1_QuanLyCuaHangQuanAoTheThao.Data;
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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;
            string vaiTro = cbbVaiTro.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(vaiTro))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new AppDbContext())
            {
                var user = db.TaiKhoan.FirstOrDefault(tk =>
                    tk.TenDangNhap == tenDangNhap &&
                    tk.MatKhau == matKhau &&
                    tk.VaiTro == vaiTro);

                if (user != null)
                {
                    MessageBox.Show("Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDashboard dashboard = new frmDashboard(user.VaiTro);
                    this.Hide();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập, mật khẩu hoặc vai trò!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cbHienAn_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = cbHienAn.Checked ? '\0' : '●';
        }
    }
}
