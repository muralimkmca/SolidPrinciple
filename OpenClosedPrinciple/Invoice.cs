using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class Invoice
    {

        public double GetInvoiceDiscountValue(double amount,InvoiceType invoiceType)
        {
            double finalAmount = 0;
            if(invoiceType == InvoiceType.FinalInvoice)
            {
                finalAmount = amount - 100;
            }
            else if(invoiceType == InvoiceType.ProposalInvoice)
            {
                finalAmount = amount - 50;
            }
            return finalAmount;
        }

        public enum InvoiceType
        {
            FinalInvoice,
            ProposalInvoice
        }
    }
}
