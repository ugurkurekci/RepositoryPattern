using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IContactService
    {
        IDataResult<List<Contact>> GetAll();
        IResult Add(Contact contact);
        IResult Update(Contact contact);
        IResult Delete(Contact contact);
        IDataResult<Contact> GetContactById(int contactId);
        IDataResult<Contact> GetContactByMail(string contactMail);
        IDataResult<List<Contact>> GetContactBySubject(string contactSubject);
        IDataResult<Contact> GetContactByPhone(string contactPhone);
        IDataResult<Contact> GetContactByFullName(string contactFirstName, string contactLastName);

    }
}
