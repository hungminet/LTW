using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using W27_10_2020_1.Models;

namespace W27_10_2020_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.SinhVien = new SINHVIEN();

            QLDTEntities entities = new QLDTEntities();

            TAIKHOAN tk = new TAIKHOAN();
            tk = (from t in entities.TAIKHOANs where t.TrangThai == true select t).SingleOrDefault();

            if (tk != null)
            {
                ViewBag.loginstatus = true;
                ViewBag.SinhVien = (from sv in entities.SINHVIENs
                                    where sv.MaSV == tk.MaSV
                                    select sv).SingleOrDefault();
            }
            else
            {
                ViewBag.loginstatus = false;
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}