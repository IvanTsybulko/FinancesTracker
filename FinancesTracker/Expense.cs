using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracker
{
    public class Expense : Finances
    {
        public Expense(decimal price, string note, DateTime date)
        {
            Price = price;
            Note = note;
            Date = date;
        }

        public bool Accepted = true;


        public override void Report()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--Expense");
            Console.WriteLine($"Price: {Price} lv.");
            Console.WriteLine($"Note: {Note}");
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"Status: {(Accepted ? "Accepted" : "Declined")}");
            Console.ResetColor();
        }
    }
}
