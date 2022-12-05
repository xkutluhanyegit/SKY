using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerTaxNumber { get; set; }
        public string CustomerTaxOffice { get; set; }
        public string CustomerMail { get; set; }
        public string CustomerPhone { get; set; }
    }
}