using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_TaZhanzhou
{
    class Program
    {
        static void Main(string[] args)
        {
            bool yesToContinue = true;
            GUI display = new GUI();
            //instantiation the cashier
            CashRegister cashier = new CashRegister();
            Console.Clear();
            display.ShowMenu();
            while (yesToContinue)
            {
                Console.WriteLine("-----------------------------------------");
                //require input the unit number and unit price
                var unitNumber = display.EnterTransactionLine("number of unites");
                var unitPrice = display.EnterTransactionLine("unit price");
                //select Add, Delete or Cancel
                IAction action = display.ShowTransactionLine();
                //assignment the value and call method
                cashier.UnitNumber = unitNumber;
                cashier.UnitPrice = unitPrice;
                cashier.DoTransationLine(action);
                //print the result of this transaction
                Console.WriteLine("Quantity: " + unitNumber);
                Console.WriteLine("Unit Price: " + unitPrice);
                Console.WriteLine("Total Amount: " + cashier.TotalAmount);
                Console.WriteLine("-----------------------------------------");
                Console.Write("Continue: (Y/N)? ");
                var contKey = Console.ReadKey();
                Console.WriteLine(" ");
                yesToContinue = (contKey.Key == ConsoleKey.Y ? true : false);
            }
            //print the result of the day transaction
            Console.WriteLine("Transaction Times: " + cashier.TransactionTotal);
            Console.WriteLine("Grand Total: " + cashier.GrandTotal);
            var hold = Console.ReadKey();
        }
    }
}
