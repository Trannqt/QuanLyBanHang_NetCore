using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BanHangNetCoreNhom123.Models
{
    public class OderViewModel
    {
        public GioHang giohang { get; set; } = new GioHang();
        public List<OrderDetailViewModel> ctgiohangs { get; set; } = new List<OrderDetailViewModel>();
    }
}
