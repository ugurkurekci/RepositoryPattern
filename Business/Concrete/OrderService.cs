using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderService : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderService(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult();
        }

        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult();
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll());
        }

        public IDataResult<List<Order>> GetCustomerAdress(string adress)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(p => p.Adress == adress));
        }

        public IDataResult<List<Order>> GetCustomerId(int customerId)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(p => p.CustomerId == customerId));
        }

        public IDataResult<List<Order>> GetDatesorting(DateTime datesortingasc, DateTime datesortingdesc)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(p => p.CreationDate <= datesortingasc || p.CreationDate >= datesortingdesc));
        }

        public IDataResult<List<Order>> GetOrderById(int orderId)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(p => p.OrderId == orderId));
        }

        public IDataResult<List<Order>> GetProductId(int productId)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(p => p.ProductId == productId));
        }

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult();
        }
    }
}
