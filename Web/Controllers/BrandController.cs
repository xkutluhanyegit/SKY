using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers
{
    [Route("marka")]
    public class BrandController : Controller
    {
        private readonly ILogger<BrandController> _logger;

        public BrandController(ILogger<BrandController> logger)
        {
            _logger = logger;
        }

        [Route("marka-listesi")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("marka-ekle")]
        [HttpGet]
        public IActionResult add()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

        [Route("marka-ekle")]
        [HttpPost]
        public IActionResult add(Brand brand)
        {
          
          return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}