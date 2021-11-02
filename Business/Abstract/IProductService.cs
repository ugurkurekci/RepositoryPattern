using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
        IDataResult<Product> GetProductById(int productId);
        IDataResult<Product> GetProductByName(string productName);
        IDataResult<List<Product>> GetProductByQuantity(int productQuantity);
        IDataResult<List<Product>> GetProductByUnitPrice(double productUnitPrice);
    }
}
