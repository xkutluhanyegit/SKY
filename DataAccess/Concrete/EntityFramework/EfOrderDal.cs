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
                                select new OrderListDto
                                {
                                    CustomerName = c.CustomerName,
                                    BrandName = b.BrandName,
                                    OrderModel = o.Model,
                                    OrderColor = o.Color,
                                    OrderDeadline = o.Deadline,
                                    OrderQTY = o.sCount,
                                    OrderId = o.id,
                                    OrderStatus = o.status
                                    
                                };
                return orderList.ToList();
            }
        }

        public OrderDetailDto OrderDetailGetById(int id)
        {
            using (EfDbContext context = new EfDbContext())
            {
                var orderDetail = from o in context.orders
                                  join c in context.customers
                                  on o.customerId equals c.id
                                  join b in context.brands
                                  on o.brandId equals b.id
                                  where o.id == id
                                  select new OrderDetailDto
                                  {
                                      id = o.id,
                                      WashType = o.WashType,
                                      Model = o.Model,
                                      PackageType = o.PackageType,
                                      Color = o.Color,
                                      Inch = o.Inch,
                                      ProductDate = o.ProductDate,
                                      Deadline = o.Deadline,
                                      Description = o.Description,
                                      PhotoPath = o.PhotoPath,
                                      CustomerName = c.CustomerName,
                                      BrandName = b.BrandName,
                                      s28 = o.s28,
                                      s30 = o.s30,
                                      s32 = o.s32,
                                      s34 = o.s34,
                                      s36 = o.s36,
                                      s38 = o.s38,
                                      s40 = o.s40,
                                      s42 = o.s42,
                                      s44 = o.s44,
                                      s46 = o.s46,
                                      s48 = o.s48,
                                      s50 = o.s50,
                                      sCount = o.sCount,
                                      k28 = o.k28,
                                      k30 = o.k30,
                                      k32 = o.k32,
                                      k34 = o.k34,
                                      k36 = o.k36,
                                      k38 = o.k38,
                                      k40 = o.k40,
                                      k42 = o.k42,
                                      k44 = o.k44,
                                      k46 = o.k46,
                                      k48 = o.k48,
                                      k50 = o.k50,
                                      kCount = o.kCount
                                  };
                return orderDetail.SingleOrDefault();
            }
        }
    }
}