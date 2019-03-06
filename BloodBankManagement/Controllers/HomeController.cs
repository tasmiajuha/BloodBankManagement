using BloodBankManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BloodBankManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult BloodRequests()
        {
            BloodRequestContext r = new BloodRequestContext();
            var model = new List<BloodRequest>();
            model = r.BloodRequests.ToList();

            return View(model);
        }

        public ActionResult BloodStocks()
        {
            BloodStockContext s = new BloodStockContext();
            var model = new List<BloodStock>();
            model = s.BloodStocks.ToList();

            return View(model);
        }

        public ActionResult Donors()
        {
            DonorRegistrationContext d = new DonorRegistrationContext();
            var model = new List<DonorRegistration>();
            model = d.Donors.ToList();

            return View(model);
        }

        public ActionResult Registrations()
        {
            RegistrationContext re= new RegistrationContext();
            var model = new List<Registration>();
            model = re.Registrations.ToList();

            return View(model);
        }






    }
}