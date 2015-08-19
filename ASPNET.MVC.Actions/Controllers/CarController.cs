using ASPNET.MVC.Actions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET.MVC.Actions.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }

        // GET: Car/Create
        public ActionResult Create()
        {
            var car = new Car();
            return View(car);
        }

        // POST: Car/Create
        [HttpPost]
        public JsonResult Create(Car car)
        {
            try
            {
                if (!ModelState.IsValid)
                    return Json(false);

                car.Status = "Solicitados";
                return Json(true);
            }
            catch
            {
                return Json(false);
            }
        }
    }
}
