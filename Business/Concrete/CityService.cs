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
    public class CityService : ICityService
    {
        private readonly ICityDal _cityDal;

        public CityService(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResult Add(City city)
        {
            _cityDal.Add(city);
            return new SuccessResult(AllMessages.CityAdded);
        }

        public IResult Delete(City city)
        {
            _cityDal.Delete(city);
            return new SuccessResult(AllMessages.CityDeleted);
        }

        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll(), AllMessages.CityListed);
        }

        public IDataResult<City> GetCityById(int cityId)
        {
            return new SuccessDataResult<City>(_cityDal.Get(p => p.CityId == cityId), AllMessages.CityById);
        }

        public IDataResult<City> GetCityByName(string cityName)
        {
            return new SuccessDataResult<City>(_cityDal.Get(p => p.CityName == cityName), AllMessages.CityByName);
        }

        public IResult Update(City city)
        {
            _cityDal.Update(city);
            return new SuccessResult(AllMessages.CityUpdated);
        }
    }
}
