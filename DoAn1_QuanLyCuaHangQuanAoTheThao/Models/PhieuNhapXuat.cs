using System;
using System.Collections.Generic;

namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Models;

public partial class PhieuNhapXuat
{
    public string MaPhieu { get; set; } = null!;

    public string? MaNCC { get; set; }

    public string? MaDH { get; set; }

    public DateTime NgayNhapXuat { get; set; }

    public string? LoaiPhieu { get; set; }

    public virtual ICollection<ChiTietPhieuNhapXuat> ChiTietPhieuNhapXuat { get; set; } = new List<ChiTietPhieuNhapXuat>();

    public virtual NhaCungCap? MaNCCNavigation { get; set; }

    public virtual DonHang? MaDHNavigation { get; set; }
}
