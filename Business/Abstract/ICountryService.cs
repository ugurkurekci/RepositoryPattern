using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICountryService
    {
        IDataResult<List<Country>> GetAll();
        IResult Add(Country country);
        IResult Update(Country country);
        IResult Delete(Country country);
        IDataResult<Country> GetCountryById(int countryId);
        IDataResult<Country> GetCountryByCode(string countryCode);
        IDataResult<Country> GetCountryByName(string countryName);
    }
}
