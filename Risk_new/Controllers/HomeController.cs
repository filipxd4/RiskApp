using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Risk_new.Models;

namespace Risk_new.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Amount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Amount(HomeViewModel model)
        {
            if (model.Azja)
                model.Soliders = model.Soliders + 7;
            if (model.Europa)
                model.Soliders = model.Soliders + 5;
            if (model.Afryka)
                model.Soliders = model.Soliders + 3;
            if (model.AmerykaPln)
                model.Soliders = model.Soliders + 5;
            if (model.AmerykaPld)
                model.Soliders = model.Soliders + 2;
            if (model.Australia)
                model.Soliders = model.Soliders + 2;

            model.Score = Convert.ToInt32((model.Soliders + model.UnderHorse + model.Countries) / 3);
            ViewBag.Score = model.Score;
            ModelState.Clear();
            return View(new HomeViewModel()); 
        }
    }
}
