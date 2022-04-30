using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectTwo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTwo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Total = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(PriceQuote priceQuote)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Total = priceQuote.Calculate().ToString("c2");
                if (priceQuote.DiscountPercent != null)
                {
                    ViewBag.DiscountAmount = priceQuote.CalculateDiscountAmount().ToString("c2");

                }
            }
            else
            {
                ViewBag.Total = "";
            }

            return View();


        }
    }
}
