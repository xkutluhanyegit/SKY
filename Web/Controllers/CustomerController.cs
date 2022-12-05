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
    [Route("musteri")]
    public class CustomerController : Controller
    {
        ICustomerService _customerService;
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger,ICustomerService customerService)
        {
            _logger = logger;
            _customerService = customerService;
        }

        [Route("musteri-listesi")]
        public IActionResult Index()
        {
            var res = _customerService.GetAll();
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [Route("musteri-ekle")]
        [HttpGet]
        public IActionResult Add()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

        [Route("musteri-ekle")]
        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            var res = _customerService.Add(customer);
            if (res.Success)
            {
                return RedirectToAction("index","customer");
            }

          return View(customer);
        }

        [Route("musteri-detay")]
        [HttpGet]
        public IActionResult Detail(int id)
        {
          var res = _customerService.GetById(id);
          if (res.Success)
          {
            return View(res.Data);
          }
          return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}