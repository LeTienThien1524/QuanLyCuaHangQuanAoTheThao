using DoAn1_QuanLyCuaHangQuanAoTheThao.Data;
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
using System.Diagnostics;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Color = System.Drawing.Color;
using Microsoft.EntityFrameworkCore;
using QRCoder;
using System.Drawing;
using System.IO;
using QuestPDF.Infrastructure;

namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Forms
{
    public partial class frmThongKeBaoCao : Form
    {

        private string loaiBaoCaoDangChon = "";

        AppDbContext db = new AppDbContext();

        public frmThongKeBaoCao()
        {
            QuestPDF.Settings.License = LicenseType.Community;
            InitializeComponent();
            dtpThangNam.Format = DateTimePickerFormat.Custom;
            dtpThangNam.CustomFormat = "MM/yyyy";
            dtpThangNam.ShowUpDown = true;
            CaiDatGiaoDienDGV();
        }

        private void frmThongKeBaoCao_Load(object sender, EventArgs e)
        {
            LoadThongKe();
        }

        private void LoadThongKe()
        {
            using (var context = new AppDbContext())
            {
                // Chỉ tính các đơn hoàn tất
                var donHangDaGiao = context.DonHang
                    .Where(d => d.TrangThai == "Hoàn tất")
                    .Include(d => d.ChiTietDonHang)
                    .ToList();

                decimal tongDoanhThu = donHangDaGiao.Sum(d => d.TongTien ?? 0);
                int tongDonHang = donHangDaGiao.Count;

                int tongDaBan = donHangDaGiao
                    .SelectMany(d => d.ChiTietDonHang)
                    .Sum(ct => ct.SoLuong);

                int tongSoSanPham = context.SanPham.Sum(sp => (int)sp.SoLuong);

                int tongKH = context.KhachHang.Count();

                // Hiển thị
                lblTongDoanhThu.Text = $"Tổng doanh thu: {tongDoanhThu:N0},000 đ";
                lblTongDonHang.Text = $"Tổng đơn hàng: {tongDonHang}";
                lblTongSanPhamBanDuoc.Text = $"Tổng SP đã bán: {tongDaBan} / {tongSoSanPham + tongDaBan}";
                lblTongKhachHang.Text = $"Tổng khách hàng: {tongKH}";
            }
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            int thang = dtpThangNam.Value.Month;
            int nam = dtpThangNam.Value.Year;

            var doanhThu = db.DonHang
                .Where(dh => dh.NgayTao.Month == thang && dh.NgayTao.Year == nam && dh.TrangThai == "Hoàn tất")
                .GroupBy(dh => 1)
                .Select(g => new
                {
                    Thang = $"{thang}/{nam}",
                    TongDoanhThu = g.Sum(x => x.TongTien ?? 0)
                })
                .ToList();

            dgvThongKeBaoCao.DataSource = doanhThu;

            dgvThongKeBaoCao.Columns["Thang"].HeaderText = "Tháng";
            dgvThongKeBaoCao.Columns["TongDoanhThu"].HeaderText = "Tổng doanh thu";
            loaiBaoCaoDangChon = "BÁO CÁO DOANH THU";
        }

        private void btnBanChay_Click(object sender, EventArgs e)
        {
            var chiTietDaGiao = db.ChiTietDonHang
                .Where(ct => ct.MaDHNavigation.TrangThai == "Hoàn tất")
                .Include(ct => ct.MaSPNavigation)
                .ToList();

            var banChay = chiTietDaGiao
                .GroupBy(ct => ct.MaSP)
                .Select(g => new
                {
                    MaSP = g.Key,
                    TenSP = g.First().MaSPNavigation.TenSP,
                    SoLuongBan = g.Sum(x => x.SoLuong)
                })
                .OrderByDescending(x => x.SoLuongBan)
                .Take(10)
                .ToList();

            dgvThongKeBaoCao.DataSource = banChay;

            dgvThongKeBaoCao.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dgvThongKeBaoCao.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dgvThongKeBaoCao.Columns["SoLuongBan"].HeaderText = "Số lượng bán";
            loaiBaoCaoDangChon = "BÁO CÁO SẢN PHẨM BÁN CHẠY";
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            var tonKho = db.SanPham
                .Select(sp => new
                {
                    sp.MaSP,
                    sp.TenSP,
                    sp.SoLuong
                })
                .OrderBy(sp => sp.SoLuong)
                .ToList();

            dgvThongKeBaoCao.DataSource = tonKho;

            dgvThongKeBaoCao.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dgvThongKeBaoCao.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dgvThongKeBaoCao.Columns["SoLuong"].HeaderText = "Số lượng tồn";
            loaiBaoCaoDangChon = "BÁO CÁO TỒN KHO";
        }

        private void ptbTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CaiDatGiaoDienDGV()
        {
            // Căn chỉnh cột, giao diện lưới
            dgvThongKeBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKeBaoCao.AllowUserToAddRows = false;
            dgvThongKeBaoCao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThongKeBaoCao.GridColor = Color.LightGray;

            // Màu các ô dữ liệu
            dgvThongKeBaoCao.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvThongKeBaoCao.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Màu dòng xen kẽ
            dgvThongKeBaoCao.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // Header cột
            dgvThongKeBaoCao.EnableHeadersVisualStyles = false;
            dgvThongKeBaoCao.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgvThongKeBaoCao.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnXuatPDF_Click(object sender, EventArgs e)
        {
            if (dgvThongKeBaoCao.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "PDF File (*.pdf)|*.pdf",
                FileName = "BaoCaoThongKe.pdf"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var tieuDeCot = dgvThongKeBaoCao.Columns
                        .Cast<DataGridViewColumn>()
                        .Select(c => c.HeaderText)
                        .ToList();

                    var duLieu = new List<List<string>>();
                    foreach (DataGridViewRow row in dgvThongKeBaoCao.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            var dong = new List<string>();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                dong.Add(cell.Value?.ToString() ?? "");
                            }
                            duLieu.Add(dong);
                        }
                    }

                    Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Margin(30);
                            page.Size(PageSizes.A4);
                            page.DefaultTextStyle(x => x.FontSize(12));

                            page.Header()
                                .Column(column =>
                                {
                                    column.Item().Text("CỬA HÀNG QUẦN ÁO THỂ THAO")
                                        .FontSize(16).Bold().AlignCenter();
                                    column.Item().Text("Địa chỉ: Chung cư Da Sà, P.An Lạc A, Q.Bình Tân, TP.HCM")
                                        .FontSize(12).AlignCenter();
                                    column.Item().PaddingBottom(5).Text("SĐT: 0338213328")
                                        .FontSize(12).AlignCenter();
                                    column.Item().PaddingBottom(5).Text(string.IsNullOrEmpty(loaiBaoCaoDangChon) ? "BÁO CÁO THỐNG KÊ" : loaiBaoCaoDangChon)
                                        .SemiBold().FontSize(14).AlignCenter();
                                    column.Item().PaddingBottom(5).Text("Ngày in: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")).AlignRight();
                                });

                            page.Content()
                                .Table(table =>
                                {
                                    table.ColumnsDefinition(columns =>
                                    {
                                        foreach (var _ in tieuDeCot)
                                            columns.RelativeColumn();
                                    });

                                    // Header
                                    table.Header(header =>
                                    {
                                        foreach (var col in tieuDeCot)
                                        {
                                            header.Cell().Text(col).SemiBold();
                                        }
                                    });

                                    // Dữ liệu
                                    foreach (var dong in duLieu)
                                    {
                                        foreach (var o in dong)
                                        {
                                            table.Cell().Text(o);
                                        }
                                    }
                                });
                        });
                    })
                    .GeneratePdf(sfd.FileName);

                    MessageBox.Show("Xuất PDF thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
    }
}
