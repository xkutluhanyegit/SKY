using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Entities.Concrete;

namespace Entities.DTOs
{
    public class OrderDetailDto:Order,IDto
    {
        public int id { get; set; }
        public string CustomerName { get; set; }
        public string BrandName { get; set; }

    }
}