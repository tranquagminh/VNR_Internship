using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VNR_Internship.Models;

namespace VNR_Internship.Controllers
{
    public class HomeController : Controller
    {
        VNR_InternShipEntities db = new VNR_InternShipEntities();
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult KhoaHoc()
        {

            var KhoaHoc = from t in db.KhoaHocs
                          where t.TenKhoaHoc != null
                          select t;
            return PartialView(KhoaHoc);
        }
        public ActionResult MonHoc(int id) 
        { 
             var m = from t in db.MonHocs
                        where t.KhoaHocID == id
                        select t;
            var ten = from t in db.KhoaHocs
                      where t.ID == id
                      select t;
            ViewBag.Message = ten.FirstOrDefault().TenKhoaHoc.ToString();
            return PartialView(m);
        }
        
    }
}