using System;
using System.Collections.Generic;

namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Models;

public partial class DanhMuc
{
    public string MaDM { get; set; } = null!;

    public string? TenDM { get; set; }

    public virtual ICollection<SanPham> SanPham { get; set; } = new List<SanPham>();
}
