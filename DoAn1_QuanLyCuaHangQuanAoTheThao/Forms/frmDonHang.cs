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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Diagnostics;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Color = System.Drawing.Color;
using Microsoft.EntityFrameworkCore;
using QRCoder;
using System.Drawing;
using System.IO;
using QuestPDF.Infrastructure; // Để dùng ImageScaling

namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Forms
{
    public partial class frmDonHang : Form
    {

        private frmDashboard dashboard;

        AppDbContext db = new AppDbContext();

        public frmDonHang(frmDashboard parent)
        {
            QuestPDF.Settings.License = LicenseType.Community;
            InitializeComponent();
            dashboard = parent;
            CaiDatGiaoDienDGV();
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            LoadDonHang();
        }

        private void LoadKhachHang()
        {
            cbbKhachHang.DataSource = db.KhachHang.ToList();
            cbbKhachHang.DisplayMember = "TenKH";
            cbbKhachHang.ValueMember = "MaKH";
            cbbKhachHang.SelectedValue = -1;
        }

        private void LoadDonHang()
        {
            dgvDonHang.Rows.Clear();
            var list = db.DonHang.ToList();

            foreach (var dh in list)
            {
                dgvDonHang.Rows.Add(dh.MaDH, dh.MaKH, dh.NgayTao, dh.TongTien, dh.TrangThai);
            }
        }

        private string TaoMaPhieuXuatTuDong()
        {
            int soThuTu = 1;
            string maPhieu;

            do
            {
                maPhieu = "phieu" + soThuTu.ToString();
                soThuTu++;
            }
            while (db.PhieuNhapXuat.Any(p => p.MaPhieu == maPhieu));

            return maPhieu;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDH.Text) ||
                cbbKhachHang.SelectedValue == null ||
                dtpNgayTao.Value > DateTime.Now)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đơn hàng!");
                return;
            }

            var maDH = txtMaDH.Text.Trim();
            if (db.DonHang.Any(x => x.MaDH == maDH))
            {
                MessageBox.Show("Mã đơn hàng đã tồn tại!");
                return;
            }

            DonHang dh = new DonHang
            {
                MaDH = maDH,
                MaKH = cbbKhachHang.SelectedValue?.ToString(),
                NgayTao = dtpNgayTao.Value,
                TongTien = 0,
                TrangThai = "Chờ xử lý"
            };

            db.DonHang.Add(dh);
            db.SaveChanges();
            LoadDonHang();

            MessageBox.Show("Thêm đơn hàng thành công.");

            // Gợi ý chuyển sang form thêm chi tiết đơn hàng
            if (MessageBox.Show("Bạn có muốn thêm sản phẩm cho đơn hàng này ngay không?", "Chi tiết đơn hàng", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dashboard.OpenChildForm(new frmChiTietDonHang(dh.MaDH, dh.TrangThai));
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var maDH = txtMaDH.Text;
            var dh = db.DonHang.FirstOrDefault(d => d.MaDH == maDH);
            if (dh == null)
            {
                MessageBox.Show("Không tìm thấy đơn hàng để sửa!");
                return;
            }

            string trangThaiCu = dh.TrangThai;
            string trangThaiMoi = cbbTrangThai.Text;

            var chiTietList = db.ChiTietDonHang.Where(ct => ct.MaDH == dh.MaDH).ToList();

            bool daTaoPhieu = false;
            bool coThayDoiTrangThai = trangThaiCu != trangThaiMoi;

            if (coThayDoiTrangThai)
            {
                var hopLe = new List<(string from, string to)>
                {
                    ("Chờ xử lý", "Đang giao"),
                    ("Chờ xử lý", "Hoàn tất"),
                    ("Chờ xử lý", "Đã hủy"),
                    ("Đang giao", "Hoàn tất"),
                    ("Đang giao", "Đã hủy")
                };

                if (!hopLe.Contains((trangThaiCu, trangThaiMoi)))
                {
                    MessageBox.Show($"Không thể chuyển trạng thái từ \"{trangThaiCu}\" sang \"{trangThaiMoi}\"!", "Cảnh báo");
                    return;
                }

                if (trangThaiMoi != "Đã hủy" && chiTietList.Count == 0)
                {
                    MessageBox.Show("Đơn hàng chưa có sản phẩm!", "Cảnh báo");
                    return;
                }

                // Trừ kho và tạo phiếu xuất nếu cần
                if (trangThaiCu == "Chờ xử lý" && (trangThaiMoi == "Đang giao" || trangThaiMoi == "Hoàn tất"))
                {
                    foreach (var ct in chiTietList)
                    {
                        var sp = db.SanPham.FirstOrDefault(s => s.MaSP == ct.MaSP);
                        if (sp != null)
                        {
                            if (sp.SoLuong >= ct.SoLuong)
                                sp.SoLuong -= ct.SoLuong;
                            else
                            {
                                MessageBox.Show($"Sản phẩm {sp.TenSP} không đủ tồn kho!", "Cảnh báo");
                                return;
                            }
                        }
                    }

                    var phieuCu = db.PhieuNhapXuat.FirstOrDefault(p => p.MaDH == dh.MaDH && p.LoaiPhieu == "Xuất");
                    if (phieuCu == null)
                    {
                        string maPhieuMoi = TaoMaPhieuXuatTuDong();

                        var phieu = new PhieuNhapXuat
                        {
                            MaPhieu = maPhieuMoi,
                            NgayNhapXuat = DateTime.Now,
                            LoaiPhieu = "Xuất",
                            MaNCC = null,
                            MaDH = dh.MaDH
                        };
                        db.PhieuNhapXuat.Add(phieu);

                        foreach (var ct in chiTietList)
                        {
                            db.ChiTietPhieuNhapXuat.Add(new ChiTietPhieuNhapXuat
                            {
                                MaPhieu = phieu.MaPhieu,
                                MaSP = ct.MaSP,
                                SoLuong = ct.SoLuong
                            });
                        }

                        daTaoPhieu = true;
                    }
                }

                // Nếu chuyển sang Đã hủy
                if (trangThaiMoi == "Đã hủy")
                {
                    foreach (var ct in chiTietList)
                    {
                        var sp = db.SanPham.FirstOrDefault(s => s.MaSP == ct.MaSP);
                        if (sp != null)
                            sp.SoLuong += ct.SoLuong;
                    }

                    var phieuXuatList = db.PhieuNhapXuat
                        .Where(p => p.LoaiPhieu == "Xuất" && p.MaDH == dh.MaDH)
                        .ToList();

                    foreach (var phieu in phieuXuatList)
                    {
                        var chiTietPhieu = db.ChiTietPhieuNhapXuat
                            .Where(c => c.MaPhieu == phieu.MaPhieu)
                            .ToList();

                        db.ChiTietPhieuNhapXuat.RemoveRange(chiTietPhieu);
                        db.PhieuNhapXuat.Remove(phieu);
                    }
                }

                dh.TrangThai = trangThaiMoi; // Cập nhật trạng thái nếu thực sự thay đổi
            }

            // Cập nhật các thông tin khác
            dh.NgayTao = dtpNgayTao.Value;
            dh.MaKH = cbbKhachHang.SelectedValue?.ToString();

            db.SaveChanges();
            LoadDonHang();

            string message = "Đã sửa thông tin đơn hàng thành công.";
            if (coThayDoiTrangThai)
                message = "Đã sửa thông tin đơn hàng và trạng thái thành công.";
            if (daTaoPhieu)
                message += "\nĐã tạo phiếu xuất cho đơn hàng.";

            MessageBox.Show(message, "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maDH = txtMaDH.Text.Trim();
            var dh = db.DonHang.FirstOrDefault(d => d.MaDH == maDH);
            if (dh == null)
            {
                MessageBox.Show("Không tìm thấy đơn hàng để xóa!");
                return;
            }

            // Chỉ được xóa nếu đơn hàng đang ở trạng thái 'Chờ xử lý'
            if (dh.TrangThai != "Chờ xử lý")
            {
                MessageBox.Show("Chỉ được phép xóa đơn hàng ở trạng thái 'Chờ xử lý'!");
                return;
            }

            var result = MessageBox.Show("Bạn có chắc muốn xóa đơn hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            // Xóa chi tiết đơn hàng nếu có
            var chiTiet = db.ChiTietDonHang.Where(ct => ct.MaDH == maDH).ToList();
            if (chiTiet.Count > 0)
            {
                db.ChiTietDonHang.RemoveRange(chiTiet);
            }

            // Xóa đơn hàng
            db.DonHang.Remove(dh);
            db.SaveChanges();

            LoadDonHang();
            MessageBox.Show("Xóa đơn hàng thành công.");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDH.Clear();
            cbbKhachHang.SelectedIndex = -1;
            dtpNgayTao.Value = DateTime.Now;
            txtTongTien.Text = "Tự động cập nhật";
            cbbTrangThai.Text = "Mặc định khi tạo: Chờ xử lý";
            txtTimKiem.Clear();
            LoadDonHang();
            txtMaDH.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập trạng thái để tìm kiếm!");
                return;
            }

            dgvDonHang.Rows.Clear();
            var list = db.DonHang.Where(d => d.TrangThai == tuKhoa).ToList();

            foreach (var dh in list)
            {
                dgvDonHang.Rows.Add(dh.MaDH, dh.MaKH, dh.NgayTao, dh.TongTien, dh.TrangThai);
            }
        }

        private void dgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaDH.Text = dgvDonHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbbKhachHang.SelectedValue = dgvDonHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpNgayTao.Value = Convert.ToDateTime(dgvDonHang.Rows[e.RowIndex].Cells[2].Value);
                txtTongTien.Text = dgvDonHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbbTrangThai.Text = dgvDonHang.Rows[e.RowIndex].Cells[4].Value.ToString();
                CapNhatTrangThai(cbbTrangThai.Text);
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDH.Text))
            {
                MessageBox.Show("Chọn đơn hàng để xem chi tiết!");
                return;
            }

            dashboard.OpenChildForm(new frmChiTietDonHang(txtMaDH.Text, cbbTrangThai.Text));
        }

        private void ptbTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CaiDatGiaoDienDGV()
        {
            // Căn chỉnh cột, giao diện lưới
            dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonHang.AllowUserToAddRows = false;
            dgvDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDonHang.GridColor = Color.LightGray;

            // Màu các ô dữ liệu
            dgvDonHang.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvDonHang.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Màu dòng xen kẽ
            dgvDonHang.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // Header cột
            dgvDonHang.EnableHeadersVisualStyles = false;
            dgvDonHang.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgvDonHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void CapNhatTrangThai(string trangThai)
        {
            switch (trangThai)
            {
                case "Chờ xử lý":
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnInHoaDon.Enabled = true;
                    break;

                case "Đang giao":
                    btnXoa.Enabled = false;
                    break;

                case "Hoàn tất":
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    break;

                case "Đã hủy":
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnInHoaDon.Enabled = false;
                    break;
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng để in hóa đơn!");
                return;
            }

            string maDonHang = dgvDonHang.SelectedRows[0].Cells["MaDH"].Value.ToString();

            using (var context = new AppDbContext())
            {
                var donHang = context.DonHang
                    .Include(d => d.MaKHNavigation)
                    .Include(d => d.ChiTietDonHang)
                    .ThenInclude(ct => ct.MaSPNavigation)
                    .FirstOrDefault(d => d.MaDH == maDonHang);

                if (donHang == null)
                {
                    MessageBox.Show("Không tìm thấy đơn hàng!");
                    return;
                }

                // Không cho phép in hóa đơn nếu đơn hàng đã hủy hoặc không có sản phẩm nào
                if (donHang.ChiTietDonHang == null || !donHang.ChiTietDonHang.Any())
                {
                    MessageBox.Show("Đơn hàng không có sản phẩm nào, không thể in hóa đơn!");
                    return;
                }

                if (donHang.TrangThai == "Đã hủy")
                {
                    MessageBox.Show("Không thể in hóa đơn cho đơn hàng đã hủy!");
                    return;
                }

                // Đường dẫn ảnh QR code ngân hàng có sẵn
                string pathQrNganHang = @"C:\Users\Le Tien Thien\OneDrive\Pictures\Ảnh chụp màn hình\qr_viettelmoney.jpg";

                byte[] qrBytesTT;
                try
                {
                    using var qrImageStream = File.OpenRead(pathQrNganHang);
                    using var ms = new MemoryStream();
                    qrImageStream.CopyTo(ms);
                    qrBytesTT = ms.ToArray();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc ảnh QR code ngân hàng: " + ex.Message);
                    return;
                }

                string filePath = $"HoaDon_{maDonHang}.pdf";

                Document.Create(document =>
                {
                    document.Page(page =>
                    {
                        page.Margin(30);
                        page.Size(PageSizes.A5);
                        page.DefaultTextStyle(x => x.FontSize(12));

                        page.Content().Column(col =>
                        {
                            col.Item().AlignCenter().Text("CỬA HÀNG QUẦN ÁO THỂ THAO").FontSize(16).Bold();
                            col.Item().AlignCenter().Text("Địa chỉ: Chung cư Da Sà, P.An Lạc A, Q.Bình Tân, TP.HCM");
                            col.Item().PaddingBottom(5).AlignCenter().Text("SĐT: 0338213328");

                            col.Item().PaddingBottom(10).AlignCenter().Text("HÓA ĐƠN BÁN HÀNG").FontSize(14).Bold();

                            col.Item().Text($"Mã đơn hàng: {donHang.MaDH}");
                            col.Item().Text($"Khách hàng: {donHang.MaKHNavigation.TenKH}");
                            col.Item().Text($"Ngày tạo: {donHang.NgayTao:dd/MM/yyyy}");

                            col.Item().PaddingVertical(10).Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(3); // Tên SP
                                    columns.RelativeColumn(1); // SL
                                    columns.RelativeColumn(2); // Đơn giá
                                    columns.RelativeColumn(2); // Thành tiền
                                });

                                table.Header(header =>
                                {
                                    header.Cell().Text("Sản phẩm").Bold();
                                    header.Cell().Text("SL").Bold();
                                    header.Cell().Text("Đơn giá").Bold();
                                    header.Cell().Text("Thành tiền").Bold();
                                });

                                foreach (var ct in donHang.ChiTietDonHang)
                                {
                                    decimal donGia = ct.MaSPNavigation.GiaBan;
                                    decimal thanhTien = ct.SoLuong * donGia;

                                    table.Cell().Text(ct.MaSPNavigation.TenSP);
                                    table.Cell().Text(ct.SoLuong.ToString());
                                    table.Cell().Text($"{donGia:#,##0}");
                                    table.Cell().Text($"{thanhTien:#,##0}");
                                }
                            });

                            decimal tongTien = donHang.ChiTietDonHang.Sum(ct =>
                            {
                                var sp = context.SanPham.FirstOrDefault(s => s.MaSP == ct.MaSP);
                                return (sp?.GiaBan ?? 0) * ct.SoLuong;
                            });

                            col.Item().AlignRight().PaddingTop(10).Text($"TỔNG TIỀN: {tongTien:#,##0} VND").Bold().FontSize(14);

                            col.Item().PaddingTop(15).Text("Quét mã để thanh toán:");
                            col.Item().MaxWidth(80).MaxHeight(80).AlignCenter().Image(qrBytesTT, ImageScaling.FitArea);

                            col.Item().AlignCenter().PaddingTop(10).Text("Cảm ơn quý khách đã mua hàng!").Italic();
                        });
                    });
                }).GeneratePdf(filePath);

                MessageBox.Show("Hóa đơn đã được xuất ra PDF!");
                Process.Start("explorer.exe", filePath);
            }
        }
    }
}
