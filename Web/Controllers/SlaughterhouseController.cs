using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers
{
    [Route("kesimhane")]
    public class SlaughterhouseController : Controller
    {
        private readonly ILogger<SlaughterhouseController> _logger;

        public SlaughterhouseController(ILogger<SlaughterhouseController> logger)
        {
            _logger = logger;
        }

        [Route("kesim-listesi")]
        public IActionResult Index()
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