using System;
using System.Collections.Generic;

namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Models;

public partial class NhaCungCap
{
    public string MaNCC { get; set; } = null!;

    public string? TenNCC { get; set; }

    public string? SoDienThoai { get; set; }

    public string? DiaChi { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<PhieuNhapXuat> PhieuNhapXuat { get; set; } = new List<PhieuNhapXuat>();
}
