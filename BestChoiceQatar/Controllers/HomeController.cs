using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestChoiceQatar.Models;
using BestChoiceQatar.Core;

namespace BestChoiceQatar.Controllers
{
    public class HomeController : Controller
    {
        [ActionName("index")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RedirectToRoot()
        {
            return RedirectPermanent("https://bestchoiceqatar.net/");
        }

        [ActionName("about")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [ActionName("contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(Contact model)
        {
            Appmanager.SendEmail($"Hi BestChoice, You have new Enquiry.", $"Dear BestChoice Team,<br/><br /> Please find the contact details <br/> Subject : {model.subject} <br/> Email: {model.email} <br/> Message: {model.message} <br/>");
            TempData["Notification"] = new Core.Entities.Common.Notification("Success", "Your contact request has been sent successfully. BestChoice Team will contact you soon.");
            return RedirectToAction("Index");
        }

        [ActionName("portable-cabin-fabrication")]
        public ActionResult CabinFabrication()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ActionName("designing")]
        public ActionResult Designing()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ActionName("elvsolutions")]
        public ActionResult ELVSolutions()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ActionName("general-contracting")]
        public ActionResult GeneralContracting()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ActionName("printing")]
        public ActionResult Printing()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ActionName("car-rental")]
        public ActionResult Rent_a_Car_And_Limousine()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ActionName("steel-aluminum-fabrication")]
        public ActionResult Steel_Aluminum_Fabrication()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ActionName("building-painting-contractor")]
        public ActionResult Painting_Contracting()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Blog()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ActionName("portable-cabin-manufacturers-in-qatar")]
        public ActionResult portable_cabin_manufacturers_in_qatar()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ActionName("guid-to-choose-best-container")]
        public ActionResult guid_to_choose_best_container()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ActionName("site-cabins-offices-welfare-accommodation")]
        public ActionResult site_cabins_offices_welfare_accommodation()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ActionName("optical-fibre-networks")]
        public ActionResult optical_fibre_networks()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}