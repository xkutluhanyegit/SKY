using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult(Messages.AddedMessage);
        }

        public IResult Delete(int id)
        {
            _orderDal.Delete(_orderDal.Get(o=>o.id == id));
            return new SuccessResult(Messages.AddedMessage);
        }

        public IDataResult<List<Order>> GetAll()
        {
            var result = _orderDal.GetAll();
            return new SuccessDataResult<List<Order>>(result,Messages.ListedMessage);
        }

        public IDataResult<Order> GetById(int id)
        {
            var result = _orderDal.Get(o=>o.id == id);
            return new SuccessDataResult<Order>(result);
        }

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult(Messages.UpdateMessage);
        }
    }
}