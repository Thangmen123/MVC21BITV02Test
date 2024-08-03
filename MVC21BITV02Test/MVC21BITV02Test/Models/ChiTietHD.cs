using MVC21BITV02Test.Data;

namespace MVC21BITV02Test.Models
{
    public class ChiTietHD
    {
        public int MaCt { get; set; }

        public int MaHd { get; set; }

        public int MaHh { get; set; }

        public double DonGia { get; set; }

        public int SoLuong { get; set; }

        public double GiamGia { get; set; }

        public virtual HoaDon MaHdNavigation { get; set; } = null!;

        public virtual HangHoa MaHhNavigation { get; set; } = null!;
    }
    public class HoaDon
    {
        public int MaHd { get; set; }

        public string MaKh { get; set; } = null!;

        public DateTime NgayDat { get; set; }

        public DateTime? NgayCan { get; set; }

        public DateTime? NgayGiao { get; set; }

        public string? HoTen { get; set; }

        public string DiaChi { get; set; } = null!;

        public string CachThanhToan { get; set; } = null!;

        public string CachVanChuyen { get; set; } = null!;

        public double PhiVanChuyen { get; set; }

        public int MaTrangThai { get; set; }

        public string? MaNv { get; set; }

        public string? GhiChu { get; set; }

        public virtual ICollection<ChiTietHd> ChiTietHds { get; set; } = new List<ChiTietHd>();

        public virtual KhachHang MaKhNavigation { get; set; } = null!;

        public virtual NhanVien? MaNvNavigation { get; set; }

        public virtual TrangThai MaTrangThaiNavigation { get; set; } = null!;
    }
    public class HangHoa
    {
        public int MaHh { get; set; }

        public string TenHh { get; set; } = null!;

        public string? TenAlias { get; set; }

        public int MaLoai { get; set; }

        public string? MoTaDonVi { get; set; }

        public double? DonGia { get; set; }

        public string? Hinh { get; set; }

        public DateTime NgaySx { get; set; }

        public double GiamGia { get; set; }

        public int SoLanXem { get; set; }

        public string? MoTa { get; set; }

        public string MaNcc { get; set; } = null!;

        public virtual ICollection<BanBe> BanBes { get; set; } = new List<BanBe>();

        public virtual ICollection<ChiTietHd> ChiTietHds { get; set; } = new List<ChiTietHd>();

        public virtual Loai MaLoaiNavigation { get; set; } = null!;

        public virtual NhaCungCap MaNccNavigation { get; set; } = null!;

        public virtual ICollection<YeuThich> YeuThiches { get; set; } = new List<YeuThich>();
    }
}
