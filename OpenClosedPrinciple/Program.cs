using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var finalInvoice = new FinalInvoice();
            var proposedInvoice = new ProposedInvoice();
            var recurringInvoice = new RecurringInvoice();

            double finalInvoiceAmt = finalInvoice.GetInvoiceDiscountValue(10000);
            double proposedInvoiceAmt = proposedInvoice.GetInvoiceDiscountValue(10000);
            double recurringInvoiceAmt = recurringInvoice.GetInvoiceDiscountValue(10000);

            Console.WriteLine("finalInvoiceAmt : " + finalInvoiceAmt);
            Console.WriteLine("proposedInvoiceAmt : "+ proposedInvoiceAmt);
            Console.WriteLine("recurringInvoiceAmt : " + recurringInvoiceAmt);
            Console.ReadKey();
        }
    }
}
