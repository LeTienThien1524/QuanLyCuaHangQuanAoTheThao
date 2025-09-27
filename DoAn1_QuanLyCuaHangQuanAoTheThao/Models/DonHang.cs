using System;
using System.Collections.Generic;

namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Models;

public partial class DonHang
{
    public string MaDH { get; set; } = null!;

    public string? MaKH { get; set; }

    public DateTime NgayTao { get; set; }

    public decimal? TongTien { get; set; }

    public string? TrangThai { get; set; }

    public virtual ICollection<ChiTietDonHang> ChiTietDonHang { get; set; } = new List<ChiTietDonHang>();

    public virtual KhachHang? MaKHNavigation { get; set; }
}
