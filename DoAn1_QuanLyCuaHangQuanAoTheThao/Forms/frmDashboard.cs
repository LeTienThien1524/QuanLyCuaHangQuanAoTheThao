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
    public partial class frmDashboard : Form
    {

        private string VaiTro;
        private Form currentChildForm;

        public frmDashboard(string vaiTro)
        {
            InitializeComponent();
            VaiTro = vaiTro;
            lblVaiTro.Text = $"Xin chào bạn ({VaiTro})";
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            if (VaiTro != "Admin")
            {
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
                thốngKêBáoCáoToolStripMenuItem.Enabled = false;
                tsbThongKeBaoCao.Enabled = false;
            }
        }

        public void OpenChildForm(Form childForm)
        {
            // Ẩn các label / ảnh / control khi mở form con
            lblVaiTro.Visible = false;
            label1.Visible = false;
            pictureBox1.Visible = false;

            // Đóng form con trước đó nếu còn mở
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm.Dispose();
            }

            currentChildForm = childForm;

            // Cấu hình form con hiển thị full trong Dashboard
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Thêm form con vào form chính
            this.Controls.Add(childForm); // Nếu bạn dùng Panel thì sửa thành panelMain.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            // Khi form con đóng, hiện lại control
            childForm.FormClosed += (s, e) =>
            {
                lblVaiTro.Visible = true;
                label1.Visible = true;
                pictureBox1.Visible = true;
            };
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTaiKhoan());
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?",
                "Xác nhận đăng xuất tài khoản",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap dn = new frmDangNhap();
                dn.Show();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanPham(this));
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());
        }

        private void quảnLýĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDonHang(this));
        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKho(this));
        }

        private void thốngKêBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeBaoCao());
        }

        private void tsbDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?",
                "Xác nhận đăng xuất tài khoản",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap dn = new frmDangNhap();
                dn.Show();
            }
        }

        private void tsbQLSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanPham(this));
        }

        private void tsbQLKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());
        }

        private void tsbQLDonHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDonHang(this));
        }

        private void tsbKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKho(this));
        }

        private void tsbThongKeBaoCao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeBaoCao());
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            string huongDan = "📘 HƯỚNG DẪN SỬ DỤNG PHẦN MỀM\n" +
                      "\n" +
                      "🔑 1. Đăng nhập hệ thống:\n" +
                      " - Nhập tên đăng nhập và mật khẩu để truy cập hệ thống.\n" +
                      " - Phân quyền theo vai trò: Admin, Nhân viên.\n" +
                      " - Đăng xuất, thoát.\n" +
                      " - Admin có quyền truy cập toàn bộ chức năng - Nhân viên không có quyền truy cập chức năng Thống kê báo cáo.\n" +
                      "\n" +
                      "🛒 2. Quản lý sản phẩm:\n" +
                      " - Cập nhật thông tin sản phẩm: thêm, sửa, xóa, tìm kiếm thông tin sản phẩm.\n" +
                      " - Quản lý danh mục: thêm, sửa, xóa danh mục.\n" +
                      "\n" +
                      "👤 3. Quản lý khách hàng:\n" +
                      " - Cập nhật thông tin khách hàng: thêm, sửa, xóa, tìm kiếm thông tin khách hàng.\n" +
                      "\n" +
                      "🧾 4. Quản lý đơn hàng:\n" +
                      " - Cập nhật thông tin đơn hàng, cập nhật chi tiết đơn hàng, tính tổng tiền.\n" +
                      "\n" +
                      "📦 5. Quản lý kho:\n" +
                      " - Nhập hoặc xuất hàng.\n" +
                      " - Kiểm tra tồn kho theo sản phẩm.\n" +
                      " - Quản lý nhà cung cấp: thêm, sửa, xóa, tìm kiếm thông tin nhà cung cấp.\n" +
                      "\n" +
                      "📊 6. Thống kê & báo cáo:\n" +
                      " - Xem doanh thu theo tháng.\n" +
                      " - Xem sản phẩm bán chạy.\n" +
                      " - Xem báo cáo tồn kho.\n" +
                      "\n" +
                      "Mọi thắc mắc vui lòng liên hệ SĐT: 0338213328 - Mr.Thien";

            MessageBox.Show(huongDan, "Hướng dẫn sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
