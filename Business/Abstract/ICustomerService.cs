﻿using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
        IDataResult<Customer> GetCustomerById(int customerId);
        IDataResult<Customer> GetCustomerByName(int customerName);
        IDataResult<Customer> GetCustomerByIdentityNumber(string customerIdentityNumber);
        IDataResult<Customer> GetCustomerByPhone(string customerPhone);
        IDataResult<List<Customer>> GetByCustomerAdress(string Adress);
    }
}
