using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TakeHome.Models;

namespace TakeHome.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: Feedback

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [ValidateInput(false)]
        public ActionResult Feedback()
        {

            return View();
        }

        [HttpPost]
        [ValidateInput(true)]
        public ActionResult Feedback(FeedbackForm form)
        {
            if (ModelState.IsValid)
            {
                return View("ThankYou", form);
            }
            else
                ViewBag.Message = "Invalid Entries, Kindly Recheck.";               
            return View();
        }
    }
}