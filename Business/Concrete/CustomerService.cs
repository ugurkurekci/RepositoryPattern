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

    public class CustomerService : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerService(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult();
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<List<Customer>> GetByCustomerAdress(string Adress)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p => p.Adress == Adress));

        }

        public IDataResult<Customer> GetCustomerById(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.CustomerId == customerId));
        }

        public IDataResult<Customer> GetCustomerByIdentityNumber(string customerIdentityNumber)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.IdentityNumber == customerIdentityNumber));
        }

        public IDataResult<Customer> GetCustomerByName(string customerName)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.FirstName == customerName));
        }

        public IDataResult<Customer> GetCustomerByPhone(string customerPhone)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.Phone == customerPhone));
        }

        public IDataResult<Customer> GetCustomerFullName(string customerName, string customerLastName)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.FirstName + p.LastName == customerName + customerLastName));
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult();
        }
    }
}
