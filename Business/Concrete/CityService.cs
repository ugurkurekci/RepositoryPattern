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
            throw new NotImplementedException();
        }

        public IDataResult<List<City>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<City> GetCityById(int cityId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<City> GetCityByName(string cityName)
        {
            throw new NotImplementedException();
        }

        public IResult Update(City city)
        {
            throw new NotImplementedException();
        }
    }
}
