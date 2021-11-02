using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonalService
    {
        IDataResult<List<Personal>> GetAll();
        IResult Add(Personal personal);
        IResult Update(Personal personal);
        IResult Delete(Personal personal);
        IDataResult<Personal> GetCityById(int personalId);
        IDataResult<List<Personal>> GetPersonalByReferanceName(string referanceName);
        IDataResult<List<Personal>> GetPersonalWageScala(double personalWageScalaMin, double personalWageScalaMax);
       
        IDataResult<Personal> GetPersonalByFirstNameandLastName(string personalFirstName, string personalLastName);
        IDataResult<Personal> GetPersonalByIdentityNumber(string IdentityNumber);
        IDataResult<Personal> GetPersonalByPhone(string phone);
    }
}
