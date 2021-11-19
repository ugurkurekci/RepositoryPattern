using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInvoiceService
    {
        IDataResult<List<Invoice>> GetAll();
        IResult Add(Invoice invoice);
        IResult Update(Invoice invoice);
        IResult Delete(Invoice invoice);
        IDataResult<Invoice> GetInvoiceById(int InvoiceId);
        IDataResult<Invoice> GetInvoiceByName(string InvoiceName);
        IDataResult<Invoice> GetInvoiceByDate(DateTime InvoiceDate);
    }
}
