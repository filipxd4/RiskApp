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
            return View(new HomeViewModel());
        }
        [HttpPost]
        public IActionResult Amount(HomeViewModel model)
        {
            if (model.Azja == true)
            {
                model.Soliders = model.Soliders + 7;
            }
            //
            if (model.Europa == true)
            {
                model.Soliders = model.Soliders + 5;
            }
            //
            if (model.Afryka == true)
            {
                model.Soliders = model.Soliders + 3;
            }
            //
            if (model.AmerykaPln == true)
            {
                model.Soliders = model.Soliders + 5;
            }
            //
            if (model.AmerykaPld == true)
            {
                model.Soliders = model.Soliders + 2;
            }
            //
            if (model.Australia == true)
            {
                model.Soliders = model.Soliders + 2;
            }

            model.Soliders = (model.Soliders + model.UnderHorse + model.Countries) / 3;

            model.Score = Convert.ToInt32(model.Soliders);

            ViewBag.Message = model.Score;
            return View(model); 
        }
    }
}
