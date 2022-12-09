using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IResult Add(Order order);
        IDataResult<List<Order>> GetAll();
        IDataResult<Order> GetById(int id);
        IResult Delete(int id);
        IResult Update(Order order);
        IDataResult<List<OrderListDto>> GetOrderListDto();
        IDataResult<OrderDetailDto> GetOrderDetailDto(int id);
        
    }
}