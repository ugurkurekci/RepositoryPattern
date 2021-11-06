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
    public class ContactService:IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactService(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public IResult Add(Contact contact)
        {
            _contactDal.Add(contact);
            return new SuccessResult();
        }

        public IResult Delete(Contact contact)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Contact>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Contact> GetContactByFullName(string contactFirstName, string contactLastName)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Contact> GetContactById(int contactId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Contact> GetContactByMail(string contactMail)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Contact> GetContactByPhone(string contactPhone)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Contact>> GetContactBySubject(string contactSubject)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
