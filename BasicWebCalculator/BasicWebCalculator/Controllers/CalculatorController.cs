using BasicWebCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicWebCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CalculatorModel model, string command)
        {
            if (command=="add")
            {
                model.Result = model.A + model.B;
            }
            if (command=="subtraction")
            {
                model.Result = model.A - model.B;
            }
            if (command=="multiplication")
            {
                model.Result = model.A * model.B;
            }
            if (command=="division")
            {
                model.Result = model.A / model.B;
            }
            return View(model);
        }


    }
}