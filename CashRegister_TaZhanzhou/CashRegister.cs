using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_TaZhanzhou
{
    class CashRegister
    {
        int totalAmount = 0;
        int transactionTotal = 0;
        int grandTotal = 0;
        public int UnitNumber { get; set; }
        public int UnitPrice { get; set; }

        public int TotalAmount
        {
            get { return totalAmount; }
        }
        public int TransactionTotal
        {
            get { return transactionTotal; }
        }
        public int GrandTotal
        {
            get { return grandTotal; }
        }


        public void CloseCashier(int money)
        {
            grandTotal = grandTotal + money;
        }

        public void DoTransationLine(IAction operation)
        {
            totalAmount = operation.ApplyAction(UnitNumber, UnitPrice);
            transactionTotal++;
            CloseCashier(totalAmount);

        }
    }
}
