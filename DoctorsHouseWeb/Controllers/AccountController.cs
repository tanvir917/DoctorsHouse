using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;
using System.Web.Security;
using System.Web.Helpers;

namespace DoctorsHouseWeb.Controllers
{
    public class AccountController : Controller
    {
        //Registration Action
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        //Registration POST action 
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        

        //Login 
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        
    }
}