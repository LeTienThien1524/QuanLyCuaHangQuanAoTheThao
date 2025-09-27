using System;
using System.Collections.Generic;

namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Models;

public partial class ChiTietPhieuNhapXuat
{
    public string MaPhieu { get; set; } = null!;

    public string MaSP { get; set; } = null!;

    public int? SoLuong { get; set; }

    public virtual PhieuNhapXuat MaPhieuNavigation { get; set; } = null!;

    public virtual SanPham MaSPNavigation { get; set; } = null!;
}
