using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BanHangNetCoreNhom123.Models
{
    [Table("Banner")]
    public class Banner
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int MaBanner { get; set; }
        public string UrlBanner { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }

    }
}
