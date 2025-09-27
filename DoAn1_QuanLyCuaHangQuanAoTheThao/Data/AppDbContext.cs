using System;
using System.Collections.Generic;
using DoAn1_QuanLyCuaHangQuanAoTheThao.Models;
using Microsoft.EntityFrameworkCore;

namespace DoAn1_QuanLyCuaHangQuanAoTheThao.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietDonHang> ChiTietDonHang { get; set; }

    public virtual DbSet<ChiTietPhieuNhapXuat> ChiTietPhieuNhapXuat { get; set; }

    public virtual DbSet<DanhMuc> DanhMuc { get; set; }

    public virtual DbSet<DonHang> DonHang { get; set; }

    public virtual DbSet<KhachHang> KhachHang { get; set; }

    public virtual DbSet<NhaCungCap> NhaCungCap { get; set; }

    public virtual DbSet<PhieuNhapXuat> PhieuNhapXuat { get; set; }

    public virtual DbSet<SanPham> SanPham { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-6ME8KSM\\TIENTHIEN;Database=QuanLyCuaHangQuanAoTheThao;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietDonHang>(entity =>
        {
            entity.HasKey(e => new { e.MaDH, e.MaSP }).HasName("PK__ChiTietD__F557D6E0688E60B3");

            entity.ToTable("ChiTietDonHang");

            entity.Property(e => e.MaDH)
                .HasMaxLength(10)
                .HasColumnName("MaDH");
            entity.Property(e => e.MaSP)
                .HasMaxLength(10)
                .HasColumnName("MaSP");

            entity.HasOne(d => d.MaDHNavigation).WithMany(p => p.ChiTietDonHang)
                .HasForeignKey(d => d.MaDH)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietDon__MaDH__4E1E9780");

            entity.HasOne(d => d.MaSPNavigation).WithMany(p => p.ChiTietDonHang)
                .HasForeignKey(d => d.MaSP)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietDon__MaSP__4F12BBB9");
        });

        modelBuilder.Entity<ChiTietPhieuNhapXuat>(entity =>
        {
            entity.HasKey(e => new { e.MaPhieu, e.MaSP }).HasName("PK__ChiTietP__F412EF61EAF4F8E3");

            entity.ToTable("ChiTietPhieuNhapXuat");

            entity.Property(e => e.MaPhieu).HasMaxLength(10);
            entity.Property(e => e.MaSP)
                .HasMaxLength(10)
                .HasColumnName("MaSP");

            entity.HasOne(d => d.MaPhieuNavigation).WithMany(p => p.ChiTietPhieuNhapXuat)
                .HasForeignKey(d => d.MaPhieu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietPh__MaPhi__762C88DA");

            entity.HasOne(d => d.MaSPNavigation).WithMany(p => p.ChiTietPhieuNhapXuat)
                .HasForeignKey(d => d.MaSP)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietPhi__MaSP__7720AD13");
        });

        modelBuilder.Entity<DanhMuc>(entity =>
        {
            entity.HasKey(e => e.MaDM).HasName("PK__DanhMuc__2725866E8274E158");

            entity.ToTable("DanhMuc");

            entity.Property(e => e.MaDM)
                .HasMaxLength(10)
                .HasColumnName("MaDM");
            entity.Property(e => e.TenDM)
                .HasMaxLength(100)
                .HasColumnName("TenDM");
        });

        modelBuilder.Entity<DonHang>(entity =>
        {
            entity.HasKey(e => e.MaDH).HasName("PK__DonHang__27258661D0BEDEE9");

            entity.ToTable("DonHang");

            entity.Property(e => e.MaDH)
                .HasMaxLength(10)
                .HasColumnName("MaDH");
            entity.Property(e => e.MaKH)
                .HasMaxLength(10)
                .HasColumnName("MaKH");
            entity.Property(e => e.TongTien).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.MaKHNavigation).WithMany(p => p.DonHang)
                .HasForeignKey(d => d.MaKH)
                .HasConstraintName("FK__DonHang__MaKH__4A4E069C");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKH).HasName("PK__KhachHan__2725CF1E192A938E");

            entity.ToTable("KhachHang");

            entity.Property(e => e.MaKH)
                .HasMaxLength(10)
                .HasColumnName("MaKH");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TenKH)
                .HasMaxLength(100)
                .HasColumnName("TenKH");
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
            entity.HasKey(e => e.MaNCC).HasName("PK__NhaCungC__3A185DEB0FAA327B");

            entity.ToTable("NhaCungCap");

            entity.Property(e => e.MaNCC)
                .HasMaxLength(10)
                .HasColumnName("MaNCC");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TenNCC)
                .HasMaxLength(100)
                .HasColumnName("TenNCC");
        });

        modelBuilder.Entity<PhieuNhapXuat>(entity =>
        {
            entity.HasKey(e => e.MaPhieu).HasName("PK__PhieuNha__2660BFE0AE80395C");

            entity.ToTable("PhieuNhapXuat");

            entity.Property(e => e.MaPhieu).HasMaxLength(10);
            entity.Property(e => e.LoaiPhieu).HasMaxLength(10);
            entity.Property(e => e.NgayNhapXuat).HasColumnType("date");

            entity.Property(e => e.MaNCC)
                .HasMaxLength(10)
                .HasColumnName("MaNCC");

            entity.Property(e => e.MaDH)
                .HasMaxLength(10)
                .HasColumnName("MaDH");

            entity.HasOne(d => d.MaNCCNavigation)
                .WithMany(p => p.PhieuNhapXuat)
                .HasForeignKey(d => d.MaNCC)
                .HasConstraintName("FK__PhieuNhap__MaNCC__73501C2F");

            entity.HasOne(d => d.MaDHNavigation)
                .WithMany()
                .HasForeignKey(d => d.MaDH)
                .HasConstraintName("FK_PhieuNhapXuat_DonHang");
        });


        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSP).HasName("PK__SanPham__2725081CEEA33FD2");

            entity.ToTable("SanPham");

            entity.Property(e => e.MaSP)
                .HasMaxLength(10)
                .HasColumnName("MaSP");
            entity.Property(e => e.Anh).HasMaxLength(255);
            entity.Property(e => e.GiaBan).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MaDM)
                .HasMaxLength(10)
                .HasColumnName("MaDM");
            entity.Property(e => e.Size).HasMaxLength(10);
            entity.Property(e => e.TenSP)
                .HasMaxLength(100)
                .HasColumnName("TenSP");

            entity.HasOne(d => d.MaDMNavigation).WithMany(p => p.SanPham)
                .HasForeignKey(d => d.MaDM)
                .HasConstraintName("FK__SanPham__MaDM__2AD55B43");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.MaTK).HasName("PK__TaiKhoan__272500703CDF1D9E");

            entity.ToTable("TaiKhoan");

            entity.HasIndex(e => e.TenDangNhap, "UQ__TaiKhoan__55F68FC0DE5DD814").IsUnique();

            entity.Property(e => e.MaTK)
                .HasMaxLength(10)
                .HasColumnName("MaTK");
            entity.Property(e => e.MatKhau).HasMaxLength(100);
            entity.Property(e => e.TenDangNhap).HasMaxLength(50);
            entity.Property(e => e.VaiTro).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
