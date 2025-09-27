using DoAn1_QuanLyCuaHangQuanAoTheThao.Data;
using DoAn1_QuanLyCuaHangQuanAoTheThao.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Forms
{
    public partial class frmSanPham : Form
    {

        private frmDashboard dashboard;

        private AppDbContext db = new AppDbContext();
        private string anhDuocChon = "";

        public frmSanPham(frmDashboard parent)
        {
            InitializeComponent();
            dashboard = parent;
            CaiDatGiaoDienDGV();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            CapNhatTatCaTonKho();
            LoadDanhMuc();
            LoadSanPham();
        }

        private void CapNhatTatCaTonKho()
        {
            var danhSachSP = db.SanPham.ToList();

            foreach (var sp in db.SanPham.ToList())
            {
                int tongNhap = db.ChiTietPhieuNhapXuat
                    .Where(ct => ct.MaSP == sp.MaSP && ct.MaPhieuNavigation.LoaiPhieu == "Nhập")
                    .Sum(ct => ct.SoLuong ?? 0);

                int tongXuat = db.ChiTietPhieuNhapXuat
                    .Where(ct => ct.MaSP == sp.MaSP && ct.MaPhieuNavigation.LoaiPhieu == "Xuất")
                    .Sum(ct => ct.SoLuong ?? 0);

                sp.SoLuong = tongNhap - tongXuat;
            }

            db.SaveChanges();
        }


        private void LoadDanhMuc()
        {
            var list = db.DanhMuc.ToList();
            cbbMaDM.DataSource = list;
            cbbMaDM.DisplayMember = "TenDM";
            cbbMaDM.ValueMember = "MaDM";
            cbbMaDM.SelectedIndex = -1;
        }

        private void LoadSanPham()
        {
            dgvSanPham.Rows.Clear();

            string projectRoot = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
            string imageFolder = Path.Combine(projectRoot, "Images");

            foreach (var sp in db.SanPham.ToList())
            {
                Image img = null;
                string imagePath = Path.Combine(imageFolder, sp.Anh ?? "");

                if (File.Exists(imagePath))
                {
                    using (var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        img = new Bitmap(Image.FromStream(fs));
                    }
                }

                dgvSanPham.Rows.Add(sp.MaSP, sp.TenSP, sp.MaDM, sp.GiaBan, sp.Size, sp.SoLuong, img);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) ||
                string.IsNullOrWhiteSpace(txtTenSP.Text) ||
                string.IsNullOrWhiteSpace(cbbMaDM.Text) ||
                string.IsNullOrWhiteSpace(txtGiaBan.Text) ||
                string.IsNullOrWhiteSpace(cbbSize.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                string.IsNullOrWhiteSpace(anhDuocChon))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (db.SanPham.Find(txtMaSP.Text) != null)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbbMaDM.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng tạo danh mục trước! (nếu chưa có sẵn)");
                return;
            }

            SanPham sp = new SanPham
            {
                MaSP = txtMaSP.Text,
                TenSP = txtTenSP.Text,
                MaDM = cbbMaDM.SelectedValue.ToString(),
                GiaBan = decimal.Parse(txtGiaBan.Text),
                Size = cbbSize.Text,
                SoLuong = 0,
                Anh = anhDuocChon
            };

            db.SanPham.Add(sp);
            db.SaveChanges();
            LoadSanPham();
            MessageBox.Show("Thêm sản phẩm thành công.", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var sp = db.SanPham.Find(txtMaSP.Text);
            if (sp == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sp.TenSP = txtTenSP.Text;
            sp.MaDM = cbbMaDM.SelectedValue?.ToString();
            sp.GiaBan = decimal.Parse(txtGiaBan.Text);
            sp.Size = cbbSize.Text;
            sp.SoLuong = int.Parse(txtSoLuong.Text);
            if (!string.IsNullOrEmpty(anhDuocChon))
            {
                // Nếu ảnh cũ khác ảnh mới → gán ảnh mới
                if (sp.Anh != anhDuocChon)
                {
                    sp.Anh = anhDuocChon;
                }
            }

            db.SaveChanges();
            LoadSanPham();
            MessageBox.Show("Sửa sản phẩm thành công.", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CapNhatTatCaTonKho();

            var sp = db.SanPham.Find(txtMaSP.Text);
            if (sp == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm để xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool coTrongDonHang = db.ChiTietDonHang.Any(ct => ct.MaSP == sp.MaSP);
            if (coTrongDonHang)
            {
                MessageBox.Show("Không thể xóa sản phẩm vì đang có trong đơn hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tongNhap = db.ChiTietPhieuNhapXuat.Where(k => k.MaSP == sp.MaSP).Sum(k => k.SoLuong ?? 0);
            int tongXuat = db.ChiTietPhieuNhapXuat.Where(k => k.MaSP == sp.MaSP).Sum(k => k.SoLuong ?? 0);
            int tonKho = tongNhap - tongXuat;

            if (tonKho > 0 || sp.SoLuong > 0)
            {
                MessageBox.Show("Không thể xóa vì sản phẩm vẫn còn tồn kho hoặc số lượng hiện tại vẫn còn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                db.SanPham.Remove(sp);
                db.SaveChanges();
                LoadSanPham();
                MessageBox.Show("Xoá sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            var list = db.SanPham
                         .Where(sp => sp.TenSP.Contains(tuKhoa) || sp.MaDM.Contains(tuKhoa))
                         .ToList();

            dgvSanPham.Rows.Clear();

            // Trỏ đến thư mục Images tại gốc project
            string projectRoot = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
            string imageFolder = Path.Combine(projectRoot, "Images");

            foreach (var sp in list)
            {
                string imagePath = Path.Combine(imageFolder, sp.Anh ?? "");
                Image img = null;

                if (File.Exists(imagePath))
                {
                    using (var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        img = new Bitmap(Image.FromStream(fs));
                    }
                }

                dgvSanPham.Rows.Add(sp.MaSP, sp.TenSP, sp.MaDM, sp.GiaBan, sp.Size, sp.SoLuong, img);
            }
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(ofd.FileName);
                string projectRoot = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                string imageFolder = Path.Combine(projectRoot, "Images");

                // Đọc nội dung ảnh vừa chọn
                byte[] selectedImageBytes = File.ReadAllBytes(ofd.FileName);
                string selectedImageHash = Convert.ToBase64String(
                    System.Security.Cryptography.SHA256.Create().ComputeHash(selectedImageBytes)
                );

                // Tìm xem ảnh này đã tồn tại trong thư mục Images chưa
                string matchedFileName = null;
                foreach (string filePath in Directory.GetFiles(imageFolder))
                {
                    byte[] existingImageBytes = File.ReadAllBytes(filePath);
                    string existingImageHash = Convert.ToBase64String(
                        System.Security.Cryptography.SHA256.Create().ComputeHash(existingImageBytes)
                    );

                    if (selectedImageHash == existingImageHash)
                    {
                        matchedFileName = Path.GetFileName(filePath); // Đã có ảnh giống hệt
                        break;
                    }
                }

                if (matchedFileName != null)
                {
                    // Nếu ảnh đã tồn tại → dùng lại tên ảnh
                    anhDuocChon = matchedFileName;
                }
                else
                {
                    // Nếu ảnh chưa có, copy với tên gốc (có xử lý trùng tên)
                    string originalName = Path.GetFileName(ofd.FileName);
                    string newFilePath = Path.Combine(imageFolder, originalName);
                    string uniqueFilePath = newFilePath;
                    int index = 1;

                    while (File.Exists(uniqueFilePath))
                    {
                        string nameWithoutExt = Path.GetFileNameWithoutExtension(originalName);
                        string ext = Path.GetExtension(originalName);
                        uniqueFilePath = Path.Combine(imageFolder, $"{nameWithoutExt}_{index}{ext}");
                        index++;
                    }

                    File.Copy(ofd.FileName, uniqueFilePath);
                    anhDuocChon = Path.GetFileName(uniqueFilePath);
                }

                // Hiển thị ảnh ra PictureBox
                string finalImagePath = Path.Combine(imageFolder, anhDuocChon);
                using (var fs = new FileStream(finalImagePath, FileMode.Open, FileAccess.Read))
                {
                    ptbAnh.Image = new Bitmap(Image.FromStream(fs));
                    ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            cbbMaDM.SelectedIndex = -1;
            txtGiaBan.Clear();
            cbbSize.SelectedIndex = -1;
            txtSoLuong.Text = "Tự động cập nhật";
            anhDuocChon = "";
            ptbAnh.Image = null;
            txtTimKiem.Clear();
            LoadSanPham();
            txtMaSP.Focus();
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSanPham.Rows.Count)
            {
                var row = dgvSanPham.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells[0].Value?.ToString() ?? "";
                txtTenSP.Text = row.Cells[1].Value?.ToString() ?? "";
                cbbMaDM.SelectedValue = dgvSanPham.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "";
                txtGiaBan.Text = row.Cells[3].Value?.ToString() ?? "";
                cbbSize.Text = row.Cells[4].Value?.ToString() ?? "";
                txtSoLuong.Text = row.Cells[5].Value?.ToString() ?? "";

                // Lấy tên ảnh từ database
                var maSP = txtMaSP.Text;
                var sp = db.SanPham.Find(maSP);
                anhDuocChon = sp?.Anh ?? "";

                // Load ảnh từ thư mục Images gốc
                string projectRoot = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                string imagePath = Path.Combine(projectRoot, "Images", anhDuocChon);

                if (File.Exists(imagePath))
                {
                    using (var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        ptbAnh.Image = new Bitmap(Image.FromStream(fs));
                        ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    ptbAnh.Image = null;
                }
            }

        }

        private void ptbTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQLDanhMuc_Click(object sender, EventArgs e)
        {
            dashboard.OpenChildForm(new frmDanhMuc());
        }

        private void CaiDatGiaoDienDGV()
        {
            // Căn chỉnh cột, giao diện lưới
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.GridColor = Color.LightGray;

            // Màu các ô dữ liệu
            dgvSanPham.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvSanPham.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Màu dòng xen kẽ
            dgvSanPham.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // Header cột
            dgvSanPham.EnableHeadersVisualStyles = false;
            dgvSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgvSanPham.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
