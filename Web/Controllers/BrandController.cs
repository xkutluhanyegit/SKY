using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers
{
    [Route("marka")]
    public class BrandController : Controller
    {
        IBrandService _brandService;
        
        private readonly ILogger<BrandController> _logger;

        public BrandController(ILogger<BrandController> logger,IBrandService brandService)
        {
            _logger = logger;
            _brandService = brandService;
        }

        [Route("marka-listesi")]
        public IActionResult Index()
        {
          var res = _brandService.GetAll();
          if (res.Success)
          {
            return View(res.Data);     
          }
            return View();
        }

        [Route("marka-ekle")]
        [HttpGet]
        public IActionResult add()
        {
          
          return View();
        }

        [Route("marka-ekle")]
        [HttpPost]
        public IActionResult add(Brand brand)
        {
          var res = _brandService.Add(brand);
          if (res.Success)
          {
            return RedirectToAction("index","brand");
          }
          return View(brand);
        }

        [Route("marka-sil")]
        public IActionResult delete(int id)
        {
          var res = _brandService.Delete(id);
          if (res.Success)
          {
            return RedirectToAction("index","brand");
          }
          //TODO: Implement Realistic Implementation
          return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}