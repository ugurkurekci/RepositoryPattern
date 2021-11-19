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
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceDal _invoiceDal;

        public InvoiceService(IInvoiceDal invoiceDal)
        {
            _invoiceDal = invoiceDal;
        }

        public IResult Add(Invoice invoice)
        {
            _invoiceDal.Add(invoice);
            return new SuccessResult();
        }

        public IResult Delete(Invoice invoice)
        {
            _invoiceDal.Delete(invoice);
            return new SuccessResult();
        }

        public IDataResult<List<Invoice>> GetAll()
        {
            return new SuccessDataResult<List<Invoice>>(_invoiceDal.GetAll());
        }

        public IDataResult<Invoice> GetInvoiceByDate(DateTime InvoiceDate)
        {
            return new SuccessDataResult<Invoice>(_invoiceDal.Get(p => p.InvoiceDate == InvoiceDate));
        }

        public IDataResult<Invoice> GetInvoiceById(int InvoiceId)
        {
            return new SuccessDataResult<Invoice>(_invoiceDal.Get(p => p.InvoiceId == InvoiceId));
        }

        public IDataResult<Invoice> GetInvoiceByName(string InvoiceName)
        {
            return new SuccessDataResult<Invoice>(_invoiceDal.Get(p => p.InvoiceName == InvoiceName));
        }

        public IResult Update(Invoice invoice)
        {
            _invoiceDal.Update(invoice);
            return new SuccessResult();
        }
    }
}
