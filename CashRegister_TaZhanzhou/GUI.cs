using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_TaZhanzhou
{
    class GUI
    {
        int enteredNumberOfUnites { get; set; }
        int enteredPriceOfUnite { get; set; }

        public void ShowMenu()
        {
            Console.WriteLine("Cashier");
        }

        //method for input the product parameters
        public int EnterTransactionLine(string para)
        {

            Console.Write($"Enter {para} ");
            int enteredNumber = int.Parse(Console.ReadLine());
            return enteredNumber;
        }
        //method for select the action
        public IAction ShowTransactionLine()
        {
            IAction action = new AddTransactionLine();
            Console.WriteLine("Select the action ADD(a)/DELETE(d)/CANCEL(c): ");
            var actionKey = Console.ReadLine();
            switch (actionKey)
            {
                case "a":
                    action = new AddTransactionLine();
                    break;
                case "d":
                    action = new DeleteTransactionLine();
                    break;
                case "c":
                    action = new CancelTransactionLine();
                    break;
            }
            return action;
        }

    }
}
