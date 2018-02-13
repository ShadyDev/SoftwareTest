using SoftwareTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftwareTest.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            OrderViewModel orderVM = new OrderViewModel()
            {
                isVisible = true
            };

            return PartialView("~/Views/Order/_Index.cshtml", orderVM);
        }
    }
}