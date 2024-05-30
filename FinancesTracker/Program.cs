using FinancesTracker;

List<Account> accounts = new List<Account>();
Account vanko =  new Account("vanko", "1234", 8000);
accounts.Add(vanko);

Account currentUser = null;

try
{
    while (currentUser == null)
    {
        Console.WriteLine("Username: ");
        string username = Console.ReadLine();

        Console.WriteLine("Password: ");
        string password = Console.ReadLine();

        Account user = accounts.FirstOrDefault(a => a.Username == username && a.Password == password);

        if (user != null)
        {
            currentUser = user;
        }
    }

    while (true)
    {
        Console.WriteLine("Choose option: 0 for full finances info. 1  for Creating expense. 2 for creating income.");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 0)
        {
            PrintBills();

        }
        else if (choice == 1)
        {
            CreateBill();
        }
        else if (choice == 2)
        {
            CreateIncome();
        }
    }
}
catch (Exception e)
{
    Console.WriteLine("Error");
}


void CreateBill()
{
        Console.WriteLine("Price: ");
        decimal price = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Note: ");
        string note = Console.ReadLine();

        DateTime date = DateTime.Now;

        Expense bill = new Expense(price, note, date);

    if(currentUser.Balance > price)
    {
        currentUser.Balance -= price;
    }
    else
    {
        bill.Accepted = false;
    }

    currentUser.AddExpense(bill);
}

void CreateIncome()
{
    Console.WriteLine("Price: ");
    decimal price = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Note: ");
    string note = Console.ReadLine();

    DateTime date = DateTime.Now;

    Income bill = new Income(price, note, date);

    currentUser.AddIncome(bill);
}

void PrintBills()
{
    currentUser.FinancesReport();
}