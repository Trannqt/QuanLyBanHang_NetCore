using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BanHangNetCoreNhom123.Models
{
    [Table("ThucDon")]
    public class ThucDon
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int MaThucDon { get; set; }
        public string TenThucDon { get; set; }
        public string HinhAnh { get; set; }
        public int? MaNSX { get; set; }
        public int? MaLoai { get; set; }

        public double? Gia { get; set; }
        public int? KhuyenMai { get; set; }
        public string MoTa { get; set; }

        public string Description { get; set; }
        public double? GiaKhuyenMai => Gia * (100 - KhuyenMai) / 100;//Gia - Gia/100*KhuyenMai => Gia*()

        public int? LuotXem { get; set; }
        public int? LuotMua { get; set; }

        [ForeignKey("MaNSX")]
        public NhaSanXuat MaNSXNavigation { get; set; }

        [ForeignKey("MaLoai")]
        public LoaiThucDon MaLoaiNavigation { get; set; }
        public ICollection<ChiTietGioHang> ChiTietGioHang { get; set; }
    }
}
