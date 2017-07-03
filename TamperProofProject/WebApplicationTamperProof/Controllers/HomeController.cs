using SecurityTamperProofQueryString.Attributes;
using SecurityTamperProofQueryString.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationTamperProof.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //ViewBag.Link = @"http://localhost/WebApplicationTamperProof/home/hash?value=eeasdasda&sadasdas=dasdasdas&dsasdasdadas=dsada&a=dsadasdas&mckmckkss=ccccadlkdlkslld%C3%A7akdl%C3%A7kdl%C3%A7akdldalkd";

            ViewBag.Param1 = "Rodrigo";
            ViewBag.Param2 = "123456456";
            ViewBag.Param3 = "A";
            return View();
        }

        [TamperProofQueryString]
        public string Hash(string value)
        {
            return "OK";
        }
    }
}