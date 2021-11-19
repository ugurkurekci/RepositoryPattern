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
    public class PersonalService : IPersonalService
    {
        private readonly IPersonalDal _personalDal;

        public PersonalService(IPersonalDal personalDal)
        {
            _personalDal = personalDal;
        }

        public IResult Add(Personal personal)
        {
            _personalDal.Add(personal);
            return new SuccessResult();
        }

        public IResult Delete(Personal personal)
        {
            _personalDal.Delete(personal);
            return new SuccessResult();
        }

        public IDataResult<List<Personal>> GetAll()
        {
            return new SuccessDataResult<List<Personal>>(_personalDal.GetAll());
        }

        public IDataResult<Personal> GetPersonalById(int personalId)
        {
            return new SuccessDataResult<Personal>(_personalDal.Get(m => m.PersonalId == personalId));
        }

        public IDataResult<Personal> GetPersonalByFirstNameandLastName(string personalFirstName, string personalLastName)
        {
            return new SuccessDataResult<Personal>(_personalDal.Get(m => m.FirstName == personalFirstName && m.LastName == personalLastName));
        }

        public IDataResult<Personal> GetPersonalByIdentityNumber(string IdentityNumber)
        {
            return new SuccessDataResult<Personal>(_personalDal.Get(m => m.IdentityNumber == IdentityNumber));
        }

        public IDataResult<Personal> GetPersonalByPhone(string phone)
        {
            return new SuccessDataResult<Personal>(_personalDal.Get(m => m.Phone == phone));
        }

        public IDataResult<List<Personal>> GetPersonalByReferanceName(string referanceName)
        {
            return new SuccessDataResult<List<Personal>>(_personalDal.GetAll(m => m.ReferanceName == referanceName));
        }

        public IDataResult<List<Personal>> GetPersonalWageScala(double personalWageScalaMin, double personalWageScalaMax)
        {
            return new SuccessDataResult<List<Personal>>(_personalDal.GetAll(m => m.Wage <= personalWageScalaMin || m.Wage >= personalWageScalaMax));
        }

        public IResult Update(Personal personal)
        {
            _personalDal.Update(personal);
            return new SuccessResult();
        }
    }
}
