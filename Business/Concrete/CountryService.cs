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
            return new SuccessDataResult<List<Country>>(_countryDal.GetAll(), AllMessages.CountryListed);
        }

        public IDataResult<Country> GetCountryByCode(string countryCode)
        {
            return new SuccessDataResult<Country>(_countryDal.Get(p => p.CountryCode == countryCode));
        }

        public IDataResult<Country> GetCountryById(int countryId)
        {
            return new SuccessDataResult<Country>(_countryDal.Get(p => p.CountryId == countryId));
        }

        public IDataResult<Country> GetCountryByName(string countryName)
        {
            return new SuccessDataResult<Country>(_countryDal.Get(p => p.CountryName == countryName));

        }

        public IResult Update(Country country)
        {
            _countryDal.Update(country);
            return new SuccessResult(AllMessages.CountryUpdated);
        }
    }
}
