using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracker
{
    public class Account
    {
		public Account(string username, string password, decimal balance)
        {
			Username = username;
			Password = password;
			Balance = balance;
        }
        private string username;

		public string Username
		{
			get { return username; }
			set  { username = value; }
		}

		private string  password;

		public string  Password
		{
			get { return password; }
			set { password = value; }
		}

		private decimal balance;

		public decimal Balance
		{
			get { return balance; }
			set { balance = value; }
		}

        private List<Finances> finances = new List<Finances>();

		public void AddExpense(Expense finance)
		{
            finances.Add(finance);
		}

        public void AddIncome(Income finance)
        {
			Balance += finance.Price;
            finances.Add(finance);
        }

        public void FinancesReport()
		{
            foreach (Finances fin in finances)
            {
                fin.Report();
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine($"Current Balance: {Balance}");
            Console.WriteLine();
            Console.WriteLine();
        }

		public void AddMoney(decimal amount)
		{
			Balance += amount;
		}
    }
}
