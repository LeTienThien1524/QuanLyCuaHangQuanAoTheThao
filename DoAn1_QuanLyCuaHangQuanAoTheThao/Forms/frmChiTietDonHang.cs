using DoAn1_QuanLyCuaHangQuanAoTheThao.Data;
using DoAn1_QuanLyCuaHangQuanAoTheThao.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Forms
{
    public partial class frmChiTietDonHang : Form
    {
        private readonly string MaDH;
        private DateTime NgayTaoDonHang;
        private readonly string TrangThaiDonHang;
        private AppDbContext db = new AppDbContext();

        public frmChiTietDonHang(string maDH, string trangThai)
        {
            InitializeComponent();
            MaDH = maDH;
            TrangThaiDonHang = trangThai;
            lblMaDH.Text = $"Mã đơn hàng: {MaDH}";
            lblTrangThai.Text = $"Trạng thái: {TrangThaiDonHang}";
            var donHang = db.DonHang.Find(MaDH);
            NgayTaoDonHang = donHang?.NgayTao ?? DateTime.Now;
            CaiDatGiaoDienDGV();
        }

        private void frmChiTietDonHang_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadChiTietDonHang();

            if (TrangThaiDonHang == "Chờ xử lý")
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                cbbSanPham.Enabled = true;
                txtSoLuong.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

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

        private void LoadChiTietDonHang()
        {
            dgvChiTietDonHang.Rows.Clear();
            var list = db.ChiTietDonHang.Where(x => x.MaDH == MaDH).ToList();

            foreach (var ct in list)
            {
                var sp = db.SanPham.Find(ct.MaSP);
                if (sp != null)
                {
                    decimal thanhTien = ct.SoLuong * sp.GiaBan;
                    dgvChiTietDonHang.Rows.Add(
                        ct.MaSP,
                        sp.TenSP,
                        ct.SoLuong,
                        sp.GiaBan.ToString(),
                        thanhTien.ToString()
                    );
                }
            }

            CapNhatTongTien();
        }

        private void CapNhatTongTien()
        {
            decimal tong = 0;

            foreach (var ct in db.ChiTietDonHang.Where(x => x.MaDH == MaDH).ToList())
            {
                var sp = db.SanPham.Find(ct.MaSP);
                if (sp != null)
                    tong += ct.SoLuong * sp.GiaBan;
            }

            var donHang = db.DonHang.Find(MaDH);
            if (donHang != null)
            {
                donHang.TongTien = tong;
                db.SaveChanges();
            }
        }

        private int GetTonKho(string maSP)
        {
            int nhap = (from p in db.PhieuNhapXuat
                        join ct in db.ChiTietPhieuNhapXuat on p.MaPhieu equals ct.MaPhieu
                        where p.LoaiPhieu == "Nhập" && ct.MaSP == maSP
                        select ct.SoLuong).Sum() ?? 0;

            int xuat = (from p in db.PhieuNhapXuat
                        join ct in db.ChiTietPhieuNhapXuat on p.MaPhieu equals ct.MaPhieu
                        where p.LoaiPhieu == "Xuất" && ct.MaSP == maSP
                        select ct.SoLuong).Sum() ?? 0;

            int daThemVaoDonHangChuaXuat = 0;

            var donHang = db.DonHang.FirstOrDefault(dh => dh.MaDH == MaDH);
            if (donHang != null && donHang.TrangThai == "Chờ xử lý")
            {
                daThemVaoDonHangChuaXuat = db.ChiTietDonHang
                    .Where(ct => ct.MaDH == MaDH && ct.MaSP == maSP)
                    .Select(ct => ct.SoLuong)
                    .FirstOrDefault();
            }

            return nhap - xuat - daThemVaoDonHangChuaXuat;
        }

        private string TaoMaPhieuXuatTuDong()
        {
            int soThuTu = db.PhieuNhapXuat.Count() + 1;
            return "phieu" + soThuTu.ToString();
        }

        private string LayHoacTaoPhieuXuatChoDonHang()
        {
            var phieu = db.PhieuNhapXuat.FirstOrDefault(p => p.MaDH == MaDH && p.LoaiPhieu == "Xuất");
            if (phieu != null)
                return phieu.MaPhieu;

            string maPhieu = TaoMaPhieuXuatTuDong();
            var newPhieu = new PhieuNhapXuat
            {
                MaPhieu = maPhieu,
                MaDH = MaDH,
                LoaiPhieu = "Xuất",
                NgayNhapXuat = NgayTaoDonHang,
                MaNCC = null
            };
            db.PhieuNhapXuat.Add(newPhieu);
            db.SaveChanges();
            return maPhieu;
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (cbbSanPham.SelectedValue == null || !int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng hợp lệ!");
                return;
            }

            string maSP = cbbSanPham.SelectedValue.ToString();
            var donHang = db.DonHang.Find(MaDH);
            if (donHang == null) return;

            var existing = db.ChiTietDonHang.FirstOrDefault(x => x.MaDH == MaDH && x.MaSP == maSP);
            if (existing != null)
            {
                MessageBox.Show("Sản phẩm đã có trong đơn hàng!");
                return;
            }

            // Luôn kiểm tra tồn kho (kể cả chờ xử lý)
            int tonKho = GetTonKho(maSP);
            if (soLuong > tonKho)
            {
                MessageBox.Show($"Không đủ hàng trong kho! Chỉ còn lại {tonKho} sản phẩm.");
                return;
            }

            db.ChiTietDonHang.Add(new ChiTietDonHang
            {
                MaDH = MaDH,
                MaSP = maSP,
                SoLuong = soLuong
            });

            // Nếu KHÔNG phải trạng thái "Chờ xử lý" thì trừ kho bằng cách tạo phiếu xuất
            if (donHang.TrangThai != "Chờ xử lý")
            {
                var phieu = db.PhieuNhapXuat.FirstOrDefault(p => p.MaDH == MaDH && p.LoaiPhieu == "Xuất");
                if (phieu == null)
                {
                    string maPhieu = TaoMaPhieuXuatTuDong();
                    phieu = new PhieuNhapXuat
                    {
                        MaPhieu = maPhieu,
                        MaDH = MaDH,
                        LoaiPhieu = "Xuất",
                        NgayNhapXuat = donHang.NgayTao,
                        MaNCC = null
                    };
                    db.PhieuNhapXuat.Add(phieu);
                    db.SaveChanges();
                }

                db.ChiTietPhieuNhapXuat.Add(new ChiTietPhieuNhapXuat
                {
                    MaPhieu = phieu.MaPhieu,
                    MaSP = maSP,
                    SoLuong = soLuong
                });
            }

            db.SaveChanges();
            LoadChiTietDonHang();
            MessageBox.Show("Thêm sản phẩm thành công.");
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            if (cbbSanPham.SelectedValue == null || !int.TryParse(txtSoLuong.Text, out int soLuongMoi) || soLuongMoi <= 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng hợp lệ!");
                return;
            }

            string maSP = cbbSanPham.SelectedValue.ToString();
            var ct = db.ChiTietDonHang.FirstOrDefault(x => x.MaDH == MaDH && x.MaSP == maSP);
            if (ct == null)
            {
                MessageBox.Show("Sản phẩm không có trong đơn hàng!");
                return;
            }

            int soLuongCu = ct.SoLuong;
            var donHang = db.DonHang.Find(MaDH);
            if (donHang == null) return;

            // Luôn kiểm tra tồn kho (dù trạng thái nào)
            int tonKho = GetTonKho(maSP) + soLuongCu; // Cộng lại số cũ để tính lại
            if (soLuongMoi > tonKho)
            {
                MessageBox.Show($"Không đủ hàng trong kho! Còn lại {tonKho} sản phẩm.");
                return;
            }

            ct.SoLuong = soLuongMoi;
            int chenhlech = soLuongMoi - soLuongCu;

            if (donHang.TrangThai != "Chờ xử lý" && chenhlech != 0)
            {
                var phieu = db.PhieuNhapXuat.FirstOrDefault(p => p.MaDH == MaDH && p.LoaiPhieu == "Xuất");
                if (phieu == null)
                {
                    string maPhieu = TaoMaPhieuXuatTuDong();
                    phieu = new PhieuNhapXuat
                    {
                        MaPhieu = maPhieu,
                        MaDH = MaDH,
                        LoaiPhieu = "Xuất",
                        NgayNhapXuat = donHang.NgayTao,
                        MaNCC = null
                    };
                    db.PhieuNhapXuat.Add(phieu);
                    db.SaveChanges();
                }

                var chiTiet = db.ChiTietPhieuNhapXuat
                    .FirstOrDefault(c => c.MaPhieu == phieu.MaPhieu && c.MaSP == maSP);

                if (chiTiet != null)
                {
                    chiTiet.SoLuong += chenhlech;
                }
                else
                {
                    db.ChiTietPhieuNhapXuat.Add(new ChiTietPhieuNhapXuat
                    {
                        MaPhieu = phieu.MaPhieu,
                        MaSP = maSP,
                        SoLuong = soLuongMoi
                    });
                }
            }

            db.SaveChanges();
            LoadChiTietDonHang();
            MessageBox.Show("Cập nhật số lượng thành công.");
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (cbbSanPham.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa!");
                return;
            }

            string maSP = cbbSanPham.SelectedValue.ToString();
            var ct = db.ChiTietDonHang.FirstOrDefault(x => x.MaDH == MaDH && x.MaSP == maSP);
            if (ct == null)
            {
                MessageBox.Show("Sản phẩm không có trong đơn hàng!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này khỏi đơn hàng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var donHang = db.DonHang.Find(MaDH);
                if (donHang == null) return;

                db.ChiTietDonHang.Remove(ct);

                if (donHang.TrangThai != "Chờ xử lý")
                {
                    var phieu = db.PhieuNhapXuat.FirstOrDefault(p => p.LoaiPhieu == "Xuất" && p.MaDH == MaDH);
                    if (phieu != null)
                    {
                        var chiTiet = db.ChiTietPhieuNhapXuat.FirstOrDefault(c => c.MaPhieu == phieu.MaPhieu && c.MaSP == maSP);
                        if (chiTiet != null)
                            db.ChiTietPhieuNhapXuat.Remove(chiTiet);
                    }
                }

                db.SaveChanges();

                // Nếu đơn hàng không còn sản phẩm nào, xóa phiếu xuất (nếu có)
                bool conSanPham = db.ChiTietDonHang.Any(x => x.MaDH == MaDH);
                if (!conSanPham)
                {
                    var phieu = db.PhieuNhapXuat.FirstOrDefault(p => p.LoaiPhieu == "Xuất" && p.MaDH == MaDH);
                    if (phieu != null)
                    {
                        var chiTietPhieu = db.ChiTietPhieuNhapXuat.Where(c => c.MaPhieu == phieu.MaPhieu).ToList();
                        db.ChiTietPhieuNhapXuat.RemoveRange(chiTietPhieu);
                        db.PhieuNhapXuat.Remove(phieu);
                        db.SaveChanges();
                        MessageBox.Show("Đã xóa phiếu xuất vì đơn hàng không còn sản phẩm.");
                    }
                }

                LoadChiTietDonHang();
                MessageBox.Show("Đã xóa sản phẩm khỏi đơn hàng.");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSoLuong.Clear();
            txtDonGia.Clear();
            if (cbbSanPham.Items.Count > 0)
            {
                cbbSanPham.SelectedIndex = -1;
            }
        }

        private void dgvChiTietDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cbbSanPham.SelectedValue = dgvChiTietDonHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSoLuong.Text = dgvChiTietDonHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDonGia.Text = dgvChiTietDonHang.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void ptbTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSanPham.SelectedValue == null || cbbSanPham.SelectedIndex == -1) return;
            string maSP = cbbSanPham.SelectedValue.ToString();
            var sp = db.SanPham.Find(maSP);
            if (sp != null)
            {
                txtDonGia.Text = sp.GiaBan.ToString();
            }
        }

        private void CaiDatGiaoDienDGV()
        {
            // Căn chỉnh cột, giao diện lưới
            dgvChiTietDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietDonHang.AllowUserToAddRows = false;
            dgvChiTietDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietDonHang.GridColor = Color.LightGray;

            // Màu các ô dữ liệu
            dgvChiTietDonHang.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvChiTietDonHang.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Màu dòng xen kẽ
            dgvChiTietDonHang.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // Header cột
            dgvChiTietDonHang.EnableHeadersVisualStyles = false;
            dgvChiTietDonHang.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgvChiTietDonHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
