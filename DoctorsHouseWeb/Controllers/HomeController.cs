using DoctorsHouseWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoctorsHouseWeb.Controllers
{
    public class HomeController : Controller
    {

        DoctorsHouseEntities2 db = new DoctorsHouseEntities2();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult PatientLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PatientLogin(Login user)
        {
            Login u = db.Logins.Where(x=>x.login_username == user.login_username && x.login_password == user.login_password).SingleOrDefault();
           
            if (u != null)
            {
                Session["p_id"] = 1;
                TempData["username"] = u.login_username;
                TempData.Keep();
                return RedirectToAction("Index");
            }
            else {

                TempData["valid"] = "Invalid Username Or Password";
            }
            TempData.Keep();

            return View();
        }

        [HttpGet]
        public ActionResult PatientLogout()
        {
            Session.RemoveAll();
            Session.Abandon();
            TempData.Remove("username");
            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public ActionResult PatientRegister()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PatientRegister(Login user)
        {
            Login u = new Login();
           
           
            u.login_username = user.login_username;
            u.login_password = user.login_password;
            u.login_type = "patient";

            db.Logins.Add(u);
            db.SaveChanges();


            Session["p_id"] = 1;
            TempData["username"] = u.login_username;
            TempData.Keep();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DoctorLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoctorLogin(Login user)
        {
            Login u = db.Logins.Where(x => x.login_username == user.login_username && x.login_password == user.login_password).SingleOrDefault();

            if (u != null)
            {
                Session["p_id"] = 1;
                TempData["username"] = u.login_username;
                TempData.Keep();
                return Redirect("http://localhost:12459/DoctorPanel/Index");
            }
            else
            {

                TempData["valid"] = "Invalid Username Or Password";
            }
            TempData.Keep();

     


            return View();
        }

        public ActionResult DoctorsList()
        {
            

            return View(db.Doctors.ToList());
        }

        public ActionResult Doctors()
        {


            return View(db.Doctors.ToList());
        }

        [HttpGet]
        public ActionResult DoctorProfile(int id) {

            var context = db.Doctors.Where(x => x.doctor_id == id);
            DoctorPanelController dpc = new DoctorPanelController();

            ViewBag.Schedules = dpc.Schedules();

            return View(context);
        }

        [HttpPost]
        public ActionResult DoctorProfile(Appointment ap)
        {
            Appointment a = new Appointment();

            a.ap_desc = ap.ap_desc;
            a.ap_id = ap.ap_id;
            //a.sch_id = 
           

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