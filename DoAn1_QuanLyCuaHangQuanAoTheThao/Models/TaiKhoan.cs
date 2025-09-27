using System;
using System.Collections.Generic;

namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Models;

public partial class TaiKhoan
{
    public string MaTK { get; set; } = null!;

    public string? TenDangNhap { get; set; }

    public string? MatKhau { get; set; }

    public string? VaiTro { get; set; }
}
