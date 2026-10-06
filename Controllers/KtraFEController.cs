using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenNgocThang_KtraFE.Controllers
{
    public class KtraFEController : Controller
    {
        // GET: KtraFE
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult KtraFE()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}