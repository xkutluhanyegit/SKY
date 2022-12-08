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
            var res = _orderService.GetOrderListDty();
            
            if (res.Success)
            {
              return View(res.Data);
            }
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
          order.sCount = order.s28+order.s30+order.s32+order.s34+order.s36+order.s38+order.s40+order.s42+order.s44+order.s46+order.s48+order.s50;
          order.kCount = order.k28+order.k30+order.k32+order.k34+order.k36+order.k38+order.k40+order.k42+order.k44+order.k46+order.k48+order.k50;
          var res = _orderService.Add(order);
            if (res.Success)
            {
                return RedirectToAction("index","order");
            }
          return View(order);
        }

        [Route("is-emri-detay")]
        [HttpGet]
        public IActionResult detail(int id)
        {
          var res = _orderService.GetById(id);
          if (res.Success)
          {
            return View(res.Data);
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