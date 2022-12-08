using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, EfDbContext>, IOrderDal
    {
        public List<OrderListDto> GetOrderListDto()
        {
            using (EfDbContext context = new EfDbContext())
            {
                var orderList = from o in context.orders
                                join c in context.customers
                                on o.customerId equals c.id
                                join b in context.brands
                                on o.brandId equals b.id
                                select new OrderListDto{
                                    CustomerName = c.CustomerName,
                                    BrandName = b.BrandName,
                                    OrderModel = o.Model,
                                    OrderColor = o.Color,
                                    OrderDeadline = o.Deadline,
                                    OrderQTY = o.sCount,
                                    OrderId = o.id
                                };
                return orderList.ToList();
            }
        }
    }
}