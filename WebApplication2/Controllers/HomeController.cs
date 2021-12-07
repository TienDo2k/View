using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var sv = new List<SinhVien>
            {
                new SinhVien { ID = "01", Name = "Hoàng Nam", Sex="Nam", Address="Ha Noi" },
                new SinhVien { ID = "02", Name = "Văn An ", Sex="Nam", Address="Ha Nam" },
                new SinhVien { ID = "03", Name = "Hoàng Oanh", Sex = "Nu", Address = "Nam Dinh" },
                new SinhVien { ID = "04", Name = "Lê An", Sex = "Nu", Address = "Ha Noi" },
                new SinhVien { ID = "05", Name = "Văn Long", Sex = "Nam", Address = "Ha Noi" },
             };
            // c1: using viewBag :
            //ViewBag.SinhVien = sv;
            // c2: using viewData 
            //ViewData["SinhVien"] = sv;
            // c3: sử dụng Model
            return View(sv);
       
        }
    }
}
