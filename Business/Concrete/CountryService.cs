using Business.Abstract;
using Business.Constants;
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
    public class CountryService : ICountryService
    {
        private readonly ICountryDal _countryDal;

        public CountryService(ICountryDal countryDal)
        {
            this._countryDal = countryDal;
        }

        public IResult Add(Country country)
        {
            _countryDal.Add(country);
            return new SuccessResult(AllMessages.CountryAdded);
        }

        public IResult Delete(Country country)
        {
            _countryDal.Delete(country);
            return new SuccessResult(AllMessages.CountryDeleted);
        }

        public IDataResult<List<Country>> GetAll()
        {
            return new SuccessDataResult<List<Country>>(_countryDal.GetAll(),AllMessages.CountryListed);
        }

        public IDataResult<Country> GetCountryByCode(string countryCode)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Country> GetCountryById(int countryId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Country> GetCountryByName(string countryName)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Country country)
        {
            _countryDal.Update(country);
            return new SuccessResult(AllMessages.CountryUpdated);
        }
    }
}
