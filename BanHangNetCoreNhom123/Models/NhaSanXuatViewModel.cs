using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BanHangNetCoreNhom123.Models
{
    public class NhaSanXuatViewModel:NhaSanXuat
    {
        private readonly MyDbContext db;
        public NhaSanXuatViewModel() { }
        public NhaSanXuatViewModel(MyDbContext _db)
        {
            db = _db;
        }
        public List<NhaSanXuatViewModel> GetNhaSanXuat()
        {

            var nsx = (from n in db.NhaSanXuat
                       orderby n.MaNSX descending
                       select new NhaSanXuatViewModel
                               {
                                   MaNSX = n.MaNSX,
                                   TenNSX = n.TenNSX
                               }).ToList();
            return nsx;
        }
    }
}
