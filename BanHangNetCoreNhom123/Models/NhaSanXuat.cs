using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BanHangNetCoreNhom123.Models
{
    [Table("NhaSanXuat")]
    public class NhaSanXuat
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int MaNSX { get; set; }
        public string TenNSX { get; set; }

        public ICollection<ThucDon> ThucDon { get; set; }
    }
}
