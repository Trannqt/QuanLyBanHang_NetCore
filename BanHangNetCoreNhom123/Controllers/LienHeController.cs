using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BanHangNetCoreNhom123.Controllers
{
    public class LienHeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}