using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_TaZhanzhou
{
    interface IAction
    {
        int ApplyAction(int unitNumber, int unitPrice);
    }
}
