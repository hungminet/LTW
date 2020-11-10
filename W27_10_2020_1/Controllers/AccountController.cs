using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using W27_10_2020_1.Models;

namespace W27_10_2020_1.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection sql = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Logout()
        {
            TAIKHOAN tk = new TAIKHOAN();
            QLDTEntities entities = new QLDTEntities();
            tk = (from t in entities.TAIKHOANs
                  where t.TrangThai == true
                  select t).SingleOrDefault();
            if (tk != null)
            {
                tk.TrangThai = false;
                entities.SaveChanges();
                ViewBag.Status = true;
            }
            else
            {
                ViewBag.Status = false;
            }

            return View();
        }

        [HttpPost]
        public ActionResult LoginCheck(TAIKHOAN model)
        {
            TAIKHOAN tk = new TAIKHOAN();
            QLDTEntities entities = new QLDTEntities();
            tk = (from t in entities.TAIKHOANs
                        where t.TenDN == model.TenDN
                        select t).SingleOrDefault();
            if (tk!=null)
            {
                if(tk.MatKhau == model.MatKhau)
                {
                    tk.TrangThai = true;
                    entities.SaveChanges();
                }
                else
                {
                    ViewBag.String = "Wrong password";
                }
            }
            else
            {
                ViewBag.String = "User name not available";
            }
            return View();
        } 
        [HttpPost]
        public ActionResult Edit(SINHVIEN model)
        {
           // string message = "";
            
            
            string message = "";

            if (ModelState.IsValid)
            {
                SINHVIEN sinhvien = new SINHVIEN();
                QLDTEntities entities = new QLDTEntities();
                sinhvien = (from sv in entities.SINHVIENs
                            where sv.MaSV == 18110246
                            select sv).SingleOrDefault();
                if (sinhvien != null)
                {
                    sinhvien.HoTen = model.HoTen;
                    sinhvien.Lop = model.Lop;
                    sinhvien.NgaySinh = model.NgaySinh;
                    sinhvien.SDT = model.SDT;
                    sinhvien.Email = model.Email;
                    entities.SaveChanges();

                    message = "Student " + model.HoTen + " edited successfully";
                }
                
            }
            else
            {
                message = "Failed to edited the student. Please try again";
            }
            ViewBag.String = message;
            return View();
            
        }
        public ActionResult EditInfo()
        {
            ViewBag.SinhVien = new SINHVIEN();
            QLDTEntities entities = new QLDTEntities();

            ViewBag.SinhVien = (from sv in entities.SINHVIENs
                                where sv.MaSV == 18110246
                                select sv).SingleOrDefault();

            return View();
            
        }
        public ActionResult FogetPassword()
        {
            return View();
        }
        //public string connection_string(string source, string db, bool secur)
        //{   
        //    return string.Format("data source=({0}); database = {1}; integrated security = {2};", source, db, secur.ToString());
        //}
        public ActionResult TTSV()
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
    }
}