// See https://aka.ms/new-console-template for more information

using ATM;

//A "database" of registered user accounts
List<UserAccount> userAccounts= new List<UserAccount>();
userAccounts.Add(new UserAccount("97846108746", 3456, "Jane", "Brown", 34.56));
userAccounts.Add(new UserAccount("97846108446", 3496, "James", "Red", 32.56));
userAccounts.Add(new UserAccount("97846308746", 3876, "John", "Black", 30.56));
userAccounts.Add(new UserAccount("97236108746", 3490, "Jacob", "Yellow", 28.56));


//prompting users 
Console.WriteLine("Insert debit card");
string cardNumEnteredByUser = " ";
UserAccount User;

while (true)
{
    try
    {
        cardNumEnteredByUser = Console.ReadLine();
        //Check if the input belongs to a registered user. return the first element of a sequence or a default value if element isn't there. 
        User = userAccounts.FirstOrDefault(a => a.CardNumber == cardNumEnteredByUser);
        if (User != null)
        {
            break; 
        }
        else
        {
            Console.WriteLine("Card not recognized");
        }

    }
    catch (Exception e)
    {
        Console.WriteLine("Card not recognized");
    }
}

Console.WriteLine("Please enter your pin: ");
int userEnteredPin = 0;
while (true)
{
    try
    {
        userEnteredPin = Int32.Parse(Console.ReadLine());
        if (User.PinNumber==userEnteredPin)
        {
            break; 
        }
        else
        {
            Console.WriteLine("PIN number is incorrect");
        }

    }
    catch (Exception e)
    {
        Console.WriteLine("PIN number is incorrect");
    }
}

Console.WriteLine("Welcome " + User.FirstName);
Console.WriteLine("How would you like to proceed? ");
Console.WriteLine("1. Deposit");
Console.WriteLine("2. Withdraw");
Console.WriteLine("3. Check Balance");
Console.WriteLine("4. Exit");

int option = 0;

while (option != 4)
{   
    option = Int32.Parse(Console.ReadLine());
    if (option == 1)
    {
        User.Deposit(User);
        break;
    }

    if (option == 2)
    {
        User.Withdraw(User);
        break;
    }

    if (option == 3)
    {
        User.CheckBalance(User);
        break;
    }
    else 
    {
        Console.WriteLine("Thank you for using our service");
    }
}

Console.WriteLine("Thank you for using our service");





