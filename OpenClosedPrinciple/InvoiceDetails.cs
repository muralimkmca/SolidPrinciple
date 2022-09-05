using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class InvoiceDetails
    {
        public virtual double GetInvoiceDiscountValue(double amount)
        {
            return amount - 10;
        }
    }


    public class FinalInvoice: InvoiceDetails
    {
        public override double GetInvoiceDiscountValue(double amount)
        {
            return base.GetInvoiceDiscountValue(amount)- 50;
        }
    }

    public class ProposedInvoice : InvoiceDetails
    {
        public override double GetInvoiceDiscountValue(double amount)
        {
            return base.GetInvoiceDiscountValue(amount) - 40;
        }
    }

    public class RecurringInvoice : InvoiceDetails
    {
        public override double GetInvoiceDiscountValue(double amount)
        {
            return base.GetInvoiceDiscountValue(amount) - 30;
        }
    }
}
