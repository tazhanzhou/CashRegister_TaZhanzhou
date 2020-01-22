using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_TaZhanzhou
{
    class AddTransactionLine : IAction
    {
        int IAction.ApplyAction(int unitNumber, int unitPrice)
        {
            return unitNumber * unitPrice;
        }
    }
}
