using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IResult Add(Order order);
        IResult Update(Order order);
        IResult Delete(Order order);
        IDataResult<List<Order>> GetOrderById(int orderId);
        IDataResult<List<Order>> GetProductId(int productId);
        IDataResult<List<Order>> GetCustomerId(int customerId);
        IDataResult<List<Order>> GetCustomerAdress(string adress);
        IDataResult<List<Order>> GetDatesorting(DateTime datesortingasc, DateTime datesortingdesc);

    }
}
