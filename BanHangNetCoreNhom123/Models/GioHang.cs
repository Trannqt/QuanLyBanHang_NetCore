using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BanHangNetCoreNhom123.Models
{
    [Table("GioHang")]
    public class GioHang
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int MaGioHang { get; set; }
        public int? MaKhachHang { get; set; }
        public double? TongCong { get; set; }
        public DateTime? NgayDat { get; set; }
        public int? TrangThai { get; set; }
        public int? MaTaiKhoan { get; set; }

        [ForeignKey("MaKhachHang")]
        public KhachHang MaKhachHangNavigation { get; set; }
        public ICollection<ChiTietGioHang> ChiTietGioHang { get; set; }
    }
}
