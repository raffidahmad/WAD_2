using WebApplication4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Controllers
{

    public class HomeController : Controller
    {
        List<person> perinfo;

        public HomeController()
        {
            perinfo = new List<person>();
            perinfo.Add(new person { FirstName = "Muhammad", LastName = "Tayyab", Email="mtayyabm222@gmail.com", MobileNumber="0300-0000000", Gender="Male", Address= "Wapda town,Lahore Pakistan", City="Lahore", pincode=5447, state="Punjab", coun="Pakistan", classXB="Lahore", classXP="80", classXY="2018", classXIIB="Lahore", classXIIP="80", classXIIY="2020", GraduationB="Lahore", GraduationP="3.3CGPA", GraduationY="2024", MastersB="Lahore", MastersP="3CGPA", MastersY="2027" });
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(perinfo);
        }

        [HttpPost]
        public ActionResult Index(person postinfo)
        {
            perinfo.Add(postinfo);
            return View("List",perinfo);
        }

    }
}
