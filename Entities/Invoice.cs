using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Invoice : IEntity
    {
        public int InvoiceId { get; set; }
        public string InvoiceName { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime LastInvoiceDate { get; set; }
        public double InvoicePrice { get; set; }
        public Boolean InvoiceIfBoolean { get; set; }


    }
}
