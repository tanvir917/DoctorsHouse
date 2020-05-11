using DoctorsHouseWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoctorsHouseWeb.Controllers
{
    public class DoctorPanelController : Controller
    {

        DoctorsHouseEntities2 db = new DoctorsHouseEntities2();
        // GET: DoctorPanel
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Schedules() {


            return View(db.Schedules.ToList());
        }

        public ActionResult CreateSchedules() {

            return View();
        }

        public ActionResult Appointments()
        {
            return View();
        }

        public ActionResult Fees()
        {
            return View();
        }

    }
}