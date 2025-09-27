using System;
using System.Collections.Generic;

namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Models;

public partial class KhachHang
{
    public string MaKH { get; set; } = null!;

    public string? TenKH { get; set; }

    public string? SoDienThoai { get; set; }

    public string? DiaChi { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<DonHang> DonHang { get; set; } = new List<DonHang>();
}
