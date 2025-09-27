using DoAn1_QuanLyCuaHangQuanAoTheThao.Data;
using DoAn1_QuanLyCuaHangQuanAoTheThao.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmChiTietPhieuNhapXuat : Form
    {
        private readonly string maPhieu;
        private readonly string loaiPhieu;

        AppDbContext db = new AppDbContext();

        public frmChiTietPhieuNhapXuat(string maPhieu, string loaiPhieu)
        {
            InitializeComponent();
            this.maPhieu = maPhieu;
            this.loaiPhieu = loaiPhieu;

            lblMaPhieu.Text = $"Mã phiếu: {maPhieu}";
            lblLoaiPhieu.Text = $"Loại phiếu: {loaiPhieu}";

            CaiDatGiaoDienDGV();
        }

        private void frmChiTietPhieuNhapXuat_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadChiTiet();

            if (loaiPhieu == "Xuất")
            {
                // Ẩn hoặc vô hiệu hóa các nút chức năng
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLamMoi.Enabled = false;

                // Ngăn chỉnh sửa các input
                cbbSanPham.Enabled = false;
                txtSoLuong.ReadOnly = true;
            }
        }

        private void LoadSanPham()
        {
            cbbSanPham.DataSource = db.SanPham.ToList();
            cbbSanPham.DisplayMember = "TenSP";
            cbbSanPham.ValueMember = "MaSP";
            cbbSanPham.SelectedIndex = -1;
        }

        private void LoadChiTiet()
        {
            dgvChiTietPhieu.Rows.Clear();
            var list = db.ChiTietPhieuNhapXuat.Where(x => x.MaPhieu == maPhieu).ToList();

            foreach (var ct in list)
            {
                var sp = db.SanPham.Find(ct.MaSP);
                if (sp != null)
                {
                    dgvChiTietPhieu.Rows.Add(ct.MaSP, sp.TenSP, ct.SoLuong);
                }
            }
        }

        private int GetTonKho(string maSP)
        {
            int nhap = db.ChiTietPhieuNhapXuat
                .Where(ct => ct.MaSP == maSP && ct.MaPhieuNavigation.LoaiPhieu == "Nhập")
                .Sum(ct => ct.SoLuong ?? 0);

            int xuat = db.ChiTietPhieuNhapXuat
                .Where(ct => ct.MaSP == maSP && ct.MaPhieuNavigation.LoaiPhieu == "Xuất")
                .Sum(ct => ct.SoLuong ?? 0);


            return nhap - xuat;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbbSanPham.SelectedValue == null || !int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng hợp lệ!");
                return;
            }

            string maSP = cbbSanPham.SelectedValue.ToString();

            if (db.ChiTietPhieuNhapXuat.Any(x => x.MaPhieu == maPhieu && x.MaSP == maSP))
            {
                MessageBox.Show("Sản phẩm đã tồn tại trong phiếu!");
                return;
            }

            if (loaiPhieu == "Xuất")
            {
                int tonKho = GetTonKho(maSP);
                if (soLuong > tonKho)
                {
                    MessageBox.Show($"Không đủ hàng trong kho! Còn {tonKho} sản phẩm!");
                    return;
                }
            }

            db.ChiTietPhieuNhapXuat.Add(new ChiTietPhieuNhapXuat
            {
                MaPhieu = maPhieu,
                MaSP = maSP,
                SoLuong = soLuong
            });

            db.SaveChanges();
            LoadChiTiet();
            MessageBox.Show("Thêm sản phẩm vào phiếu nhập thành công.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cbbSanPham.SelectedValue == null || !int.TryParse(txtSoLuong.Text, out int soLuongMoi) || soLuongMoi <= 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng hợp lệ!");
                return;
            }

            string maSP = cbbSanPham.SelectedValue.ToString();
            var ct = db.ChiTietPhieuNhapXuat.FirstOrDefault(x => x.MaPhieu == maPhieu && x.MaSP == maSP);

            if (ct == null)
            {
                MessageBox.Show("Sản phẩm không tồn tại trong phiếu!");
                return;
            }

            int soLuongCu = (int)ct.SoLuong;
            if (loaiPhieu == "Xuất")
            {
                int tonKho = GetTonKho(maSP) + soLuongCu;
                if (soLuongMoi > tonKho)
                {
                    MessageBox.Show($"Không đủ hàng trong kho! Còn lại {tonKho} sản phẩm!");
                    return;
                }
            }

            ct.SoLuong = soLuongMoi;
            db.SaveChanges();
            LoadChiTiet();
            MessageBox.Show("Sửa sản phẩm trong phiếu nhập thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbbSanPham.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!");
                return;
            }

            string maSP = cbbSanPham.SelectedValue.ToString();
            var ct = db.ChiTietPhieuNhapXuat.FirstOrDefault(x => x.MaPhieu == maPhieu && x.MaSP == maSP);

            if (ct == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm trong phiếu!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.ChiTietPhieuNhapXuat.Remove(ct);
                db.SaveChanges();
                LoadChiTiet();
                MessageBox.Show("Xóa sản phẩm trong phiếu nhập thành công");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSoLuong.Clear();
            if (cbbSanPham.Items.Count > 0)
                cbbSanPham.SelectedIndex = -1;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvChiTietPhieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cbbSanPham.SelectedValue = dgvChiTietPhieu.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSoLuong.Text = dgvChiTietPhieu.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void CaiDatGiaoDienDGV()
        {
            // Căn chỉnh cột, giao diện lưới
            dgvChiTietPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietPhieu.AllowUserToAddRows = false;
            dgvChiTietPhieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietPhieu.GridColor = Color.LightGray;

            // Màu các ô dữ liệu
            dgvChiTietPhieu.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvChiTietPhieu.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Màu dòng xen kẽ
            dgvChiTietPhieu.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // Header cột
            dgvChiTietPhieu.EnableHeadersVisualStyles = false;
            dgvChiTietPhieu.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgvChiTietPhieu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
