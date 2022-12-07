using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.ViewModel;

namespace Web.Controllers
{
    [Route("is-emirleri")]
    public class OrderController : Controller
    {
        IOrderService _orderService;
        IBrandService _brandService;
        ICustomerService _customerService;
        private readonly ILogger<OrderController> _logger;

        OrderVM ovm = new OrderVM();
        public OrderController(ILogger<OrderController> logger,IOrderService orderService,IBrandService brandService,ICustomerService customerService)
        {
            _logger = logger;
            _orderService = orderService;
            _brandService = brandService;
            _customerService = customerService;
        }

        [Route("is-emri-listesi")]
        public IActionResult Index()
        {
            return View();
        }


        [Route("is-emri-ekle")]
        [HttpGet]
        public IActionResult Add()
        {
          ovm.brands = _brandService.GetAll().Data;
          ovm.customers = _customerService.GetAll().Data;
          //TODO: Implement Realistic Implementation
          return View(ovm);
        }

        [Route("is-emri-ekle")]
        [HttpPost]    
        public IActionResult Add(Order order)
        {
          var res = _orderService.Add(order);
            if (res.Success)
            {
                return RedirectToAction("index","order");
            }
          return View(order);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}