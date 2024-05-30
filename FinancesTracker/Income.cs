using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracker
{
    public class Income : Finances
    {
        public Income(decimal price, string note, DateTime date)
        {
            Price = price;
            Note = note;
            Date = date;
        }

        public override void Report()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--Income");
            Console.WriteLine($"Price: {Price} lv.");
            Console.WriteLine($"Note: {Note}");
            Console.WriteLine($"Date: {Date}");
            Console.ResetColor();
        }
    }
}
