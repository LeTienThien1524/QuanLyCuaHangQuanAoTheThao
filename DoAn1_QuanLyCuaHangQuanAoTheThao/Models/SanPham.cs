using System;
using System.Collections.Generic;

namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Models;

public partial class SanPham
{
    public string MaSP { get; set; } = null!;

    public string? TenSP { get; set; }

    public string? MaDM { get; set; }

    public decimal GiaBan { get; set; }

    public string? Size { get; set; }

    public int? SoLuong { get; set; }

    public string? Anh { get; set; }

    public virtual ICollection<ChiTietDonHang> ChiTietDonHang { get; set; } = new List<ChiTietDonHang>();

    public virtual ICollection<ChiTietPhieuNhapXuat> ChiTietPhieuNhapXuat { get; set; } = new List<ChiTietPhieuNhapXuat>();

    public virtual DanhMuc? MaDMNavigation { get; set; }
}
