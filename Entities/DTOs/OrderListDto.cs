using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Entities.Concrete;

namespace Entities.DTOs
{
    public class OrderListDto:IDto
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string BrandName { get; set; }
        public string OrderModel { get; set; }
        public string OrderColor { get; set; }
        public int OrderQTY { get; set; }
        public string OrderDeadline { get; set; }
        
        public bool OrderStatus { get; set; }
    }
}