using DoAn1_QuanLyCuaHangQuanAoTheThao.Data;
using DoAn1_QuanLyCuaHangQuanAoTheThao.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Forms
{
    public partial class frmKho : Form
    {

        private frmDashboard dashboard;

        AppDbContext db = new AppDbContext();

        public frmKho(frmDashboard parent)
        {
            QuestPDF.Settings.License = LicenseType.Community;
            InitializeComponent();
            dashboard = parent;
            CaiDatGiaoDienDGV(dgvPhieuNhapKho);
            CaiDatGiaoDienDGV(dgvPhieuXuatKho);
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();
            LoadPhieuNhap();
            LoadPhieuXuat();
        }

        private void LoadNhaCungCap()
        {
            var list = db.NhaCungCap.ToList();
            cbbNhaCungCap.DataSource = list;
            cbbNhaCungCap.DisplayMember = "TenNCC";
            cbbNhaCungCap.ValueMember = "MaNCC";
            cbbNhaCungCap.SelectedIndex = -1;
        }

        private void LoadPhieuNhap()
        {
            dgvPhieuNhapKho.Rows.Clear();

            var list = db.PhieuNhapXuat
                .Include(p => p.MaNCCNavigation)
                .Where(p => p.LoaiPhieu == "Nhập")
                .OrderByDescending(p => p.NgayNhapXuat)
                .ToList();

            foreach (var item in list)
            {
                dgvPhieuNhapKho.Rows.Add(
                    item.MaPhieu,
                    item.MaNCCNavigation?.TenNCC,
                    item.NgayNhapXuat.ToString(),
                    item.LoaiPhieu
                );
            }
        }

        private void LoadPhieuXuat()
        {
            dgvPhieuXuatKho.Rows.Clear();

            var list = db.PhieuNhapXuat
                .Where(p => p.LoaiPhieu == "Xuất")
                .OrderByDescending(p => p.NgayNhapXuat)
                .ToList();

            foreach (var item in list)
            {
                dgvPhieuXuatKho.Rows.Add(
                    item.MaPhieu,
                    item.MaDH,
                    item.NgayNhapXuat.ToString(),
                    item.LoaiPhieu
                );
            }
        }

        private string TaoMaPhieuTuDong()
        {
            int max = db.PhieuNhapXuat.Count();
            return "phieu" + (max + 1);
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            if (cbbNhaCungCap.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!");
                return;
            }

            // Tạo mã phiếu tự động
            string maPhieu = TaoMaPhieuTuDong();

            // Lấy thông tin NCC và loại phiếu
            string maNCC = cbbNhaCungCap.SelectedValue.ToString();
            string tenNCC = cbbNhaCungCap.Text;
            string loaiPhieu = "Nhập";

            var phieu = new PhieuNhapXuat
            {
                MaPhieu = maPhieu,
                MaNCC = maNCC,
                NgayNhapXuat = dtpNgayNhapXuat.Value,
                LoaiPhieu = loaiPhieu
            };

            db.PhieuNhapXuat.Add(phieu);
            db.SaveChanges();
            LoadPhieuNhap();

            MessageBox.Show("Tạo phiếu nhập kho thành công.");

            // Gợi ý người dùng thêm sản phẩm nhập vào phiếu
            if (MessageBox.Show("Bạn có muốn thêm sản phẩm vào phiếu này ngay không?", "Chi tiết phiếu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dashboard.OpenChildForm(new frmChiTietPhieuNhapXuat(maPhieu, loaiPhieu));
            }
        }

        private void btnChiTietPhieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng chọn một phiếu để xem chi tiết!");
                return;
            }

            string maPhieu = txtMaPhieu.Text;
            var phieu = db.PhieuNhapXuat.FirstOrDefault(p => p.MaPhieu == maPhieu);

            if (phieu == null)
            {
                MessageBox.Show("Chọn phiếu để xem chi tiết!");
                return;
            }

            string loaiPhieu = phieu.LoaiPhieu;
            string tenNCC = phieu.MaNCCNavigation?.TenNCC ?? "N/A";

            dashboard.OpenChildForm(new frmChiTietPhieuNhapXuat(maPhieu, loaiPhieu));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng chọn mã phiếu nhập cần xóa!");
                return;
            }

            string maPhieu = txtMaPhieu.Text.Trim();

            // Tìm phiếu nhập theo mã và loại phiếu
            var phieu = db.PhieuNhapXuat.FirstOrDefault(p => p.MaPhieu == maPhieu && p.LoaiPhieu == "Nhập");
            if (phieu == null)
            {
                MessageBox.Show("Không tìm thấy phiếu nhập!");
                return;
            }

            // Kiểm tra có chi tiết sản phẩm không
            var chiTiet = db.ChiTietPhieuNhapXuat.Where(ct => ct.MaPhieu == maPhieu).ToList();
            if (chiTiet.Count > 0)
            {
                MessageBox.Show("Không thể xóa phiếu nhập đã có sản phẩm!");
                return;
            }

            // Xóa phiếu nhập
            db.PhieuNhapXuat.Remove(phieu);
            db.SaveChanges();

            LoadPhieuNhap(); // Load lại danh sách phiếu nhập
            MessageBox.Show("Đã xóa phiếu nhập rỗng thành công.");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Text = "Tạo tự động";
            cbbNhaCungCap.SelectedIndex = -1;
            dtpNgayNhapXuat.Value = DateTime.Now;
            LoadPhieuNhap();
            LoadPhieuXuat();
        }

        private void ptbTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPhieuNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhieuNhapKho.Rows[e.RowIndex];

                txtMaPhieu.Text = row.Cells[0].Value?.ToString();
                cbbNhaCungCap.Text = row.Cells[1].Value?.ToString();
                if (DateTime.TryParse(row.Cells[2].Value?.ToString(), out DateTime ngay))
                {
                    dtpNgayNhapXuat.Value = ngay;
                }
            }
        }

        private void btnQLNhaCungCap_Click(object sender, EventArgs e)
        {
            dashboard.OpenChildForm(new frmNhaCungCap());
        }

        private void CaiDatGiaoDienDGV(DataGridView dgv)
        {
            // Căn chỉnh cột, giao diện lưới
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.GridColor = Color.LightGray;

            // Màu các ô dữ liệu
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Màu dòng xen kẽ
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            // Header cột
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void dgvPhieuXuatKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhieuXuatKho.Rows[e.RowIndex];

                txtMaPhieu.Text = row.Cells[0].Value?.ToString();
                cbbNhaCungCap.Text = "N/A";
                if (DateTime.TryParse(row.Cells[2].Value?.ToString(), out DateTime ngay))
                {
                    dtpNgayNhapXuat.Value = ngay;
                }
            }
        }

        private void btnInPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhapKho.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập để in!");
                return;
            }

            string maPhieu = dgvPhieuNhapKho.SelectedRows[0].Cells["MaPhieu"].Value.ToString();

            using (var context = new AppDbContext())
            {
                var phieu = context.PhieuNhapXuat
                    .Include(p => p.ChiTietPhieuNhapXuat)
                    .ThenInclude(ct => ct.MaSPNavigation)
                    .Include(p => p.MaNCCNavigation)
                    .FirstOrDefault(p => p.MaPhieu == maPhieu && p.LoaiPhieu == "Nhập");

                if (phieu == null)
                {
                    MessageBox.Show("Không tìm thấy phiếu nhập!");
                    return;
                }

                if (!phieu.ChiTietPhieuNhapXuat.Any())
                {
                    MessageBox.Show("Phiếu nhập không có sản phẩm nào!");
                    return;
                }

                string filePath = $"PhieuNhap_{maPhieu}.pdf";

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
                            col.Item().AlignCenter().PaddingBottom(5).Text("SĐT: 0338213328");

                            col.Item().AlignCenter().PaddingBottom(10).Text("PHIẾU NHẬP KHO").FontSize(14).Bold();

                            col.Item().Text($"Mã phiếu: {phieu.MaPhieu}");
                            col.Item().Text($"Nhà cung cấp: {phieu.MaNCCNavigation?.TenNCC}");
                            col.Item().Text($"Ngày nhập: {phieu.NgayNhapXuat:dd/MM/yyyy HH:mm}");

                            col.Item().PaddingVertical(10).Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(1); // STT
                                    columns.RelativeColumn(4); // Tên SP
                                    columns.RelativeColumn(2); // Số lượng
                                });

                                table.Header(header =>
                                {
                                    header.Cell().Text("STT").Bold();
                                    header.Cell().Text("Sản phẩm").Bold();
                                    header.Cell().Text("Số lượng").Bold();
                                });

                                int stt = 1;
                                foreach (var ct in phieu.ChiTietPhieuNhapXuat)
                                {
                                    table.Cell().Text(stt++.ToString());
                                    table.Cell().Text(ct.MaSPNavigation?.TenSP);
                                    table.Cell().Text(ct.SoLuong.ToString());
                                }
                            });

                            col.Item().AlignCenter().PaddingTop(10).Text("Vui lòng kiểm tra kỹ sản phẩm khi nhập kho!").Italic();
                        });
                    });
                }).GeneratePdf(filePath);

                MessageBox.Show("Phiếu nhập đã được xuất ra PDF!");
                Process.Start("explorer.exe", filePath);
            }
        }
    }
}
