using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracker
{
    public abstract class Finances
    {
		private decimal price;

		public decimal Price
		{
			get { return price; }
			set { price = value; }
		}

		private string note;

		public string Note
		{
			get { return note; }
			set { note = value; }
		}

		private DateTime date;

		public DateTime Date
		{
			get { return date; }
			set { date = value; }
		}


		public virtual void Report()
		{
            Console.WriteLine($"Price: {Price} lv.");
            Console.WriteLine($"Note: {Note}");
            Console.WriteLine($"Date: {Date}");
        }
	}
}
