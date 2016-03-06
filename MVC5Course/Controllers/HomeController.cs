using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //throw new Exception("測試Elmah");
            ViewBag.Message = "Your application description page.";
            
            //Todo Not finished
            return View();

            //var le = ConsoleColor.Blue;

            //swicth(le)
           
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MemberProfile()
        {
            try
            {
                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult Action()
        {
            return View();
        }
    }
}