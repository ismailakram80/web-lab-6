using JSon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JSon.Controllers
{
    public class HomeController : Controller
    {
        public static Student[] empList = new Student[]
{
new Student() {Name="Muhammad Ismail", Regno="bse173011" , Cgpa=2.3 },
new Student() {Name="Muhammad Bilal, Regno="bse111776" , Cgpa=3.3 },
new Student() {Name="Muhammad Abdullah", Regno="bse171222" , Cgpa=3.8 },
new Student() {Name="Asim Farooq",Regno="bse132132" , Cgpa=3.6 },
};


        public JsonResult GetEmpData()
        {
            return Json(empList);
        }
    }
}