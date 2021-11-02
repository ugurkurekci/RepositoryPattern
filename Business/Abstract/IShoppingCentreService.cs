using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IShoppingCentreService
    {
        IDataResult<List<ShoppingCentre>> GetAll();
        IResult Add(ShoppingCentre shoppingCentre);
        IResult Update(ShoppingCentre shoppingCentre);
        IResult Delete(ShoppingCentre shoppingCentre);
        IDataResult<ShoppingCentre> GetShoppingCentreById(int shoppingCentreId);
        IDataResult<ShoppingCentre> GetShoppingCentreByName(string shoppingCentreName);
    }
}
