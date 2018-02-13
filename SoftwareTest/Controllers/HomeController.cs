using SoftwareTest.Models;
using SoftwareTest.Utilities;
using SoftwareTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApplicationContext = SoftwareTest.Contexts.AppContext;

namespace SoftwareTest.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var homeVM = new HomeViewModel()
            {
                FormVM = new FormViewModel()
                {
                    IsVisiblePrice = false
                },
                OrderVM = new OrderViewModel()
                {
                    isVisible = false
                }
            };
            return View(homeVM);
        }

        [HttpPost]
        public ActionResult CheckPrice(FormViewModel vm)
        {
            var homeVM = new HomeViewModel();
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db = new ApplicationContext())
                    {
                        var parcel = new Parcel()
                        {
                            width = (int)vm.Width,
                            height = (int)vm.Height,
                            depth = (int)vm.Depth,
                            weight = (int)vm.Weight,
                            date = DateTime.Now
                        };
                        db.Parcels.Add(parcel);
                        db.SaveChanges();

                        ModelState.Clear();
                    }
                }
                else
                {
                    return PartialView("~/Views/Home/_Form.cshtml", vm);
                }
            }
            catch (Exception Ex)
            {
                return PartialView("~/Views/Error/_Error.cshtml");
                throw Ex;
            }

            var courierList = PriceCalculator.GetCourierList((int)vm.Width, (int)vm.Height, (int)vm.Depth, (float)vm.Weight);

            var newVM = new FormViewModel();
            newVM.Width = vm.Width;
            newVM.Height = vm.Height;
            newVM.Depth = vm.Depth;
            newVM.Weight = vm.Weight;

            if (courierList.Count > 0)
            {
                newVM.IsVisiblePrice = true;
                newVM.PriceVM = new PriceViewModel()
                {
                    Price = PriceCalculator.GetBestPrice(courierList, (int)newVM.Width, (int)newVM.Height, (int)newVM.Depth, (int)newVM.Weight)
                };
            }
            else
            {
                newVM.IsVisiblePrice = false;
                newVM.Notification = "Unfortunately we didn't find any match to the perameters provided";
            }

            return PartialView("~/Views/Home/_Form.cshtml", newVM);
        }



        public ActionResult Price()
        {

            return View();
        }
    }
}