//Creating an ATM console application, where user can deposit, withdraw money, and check their balance. 

namespace ATM;

public class UserAccount
{
    private string _cardNumber;
    private int _pinNumber;
    private string _firstName;
    private string _lastName;
    private double _balance;

    public string CardNumber
    {
        get => _cardNumber;
        set => _cardNumber = value;
    }

    public int PinNumber
    {
        get => _pinNumber;
        set => _pinNumber = value;
    }

    public string FirstName
    {
        get => _firstName;
        set => _firstName = value;
    }

    public string LastName
    {
        get => _lastName;
        set => _lastName = value; 
    }

    public double Balance
    {
        get => _balance;
        set => _balance = value;
    }
    
    public UserAccount(string cardNumber, int pinNumber, string firstName, string lastName, double balance)
    {
        CardNumber = cardNumber;
        PinNumber = pinNumber;
        FirstName = firstName;
        LastName = lastName;
        Balance = balance;
    }

    public void Deposit(UserAccount User)
    {
        Console.WriteLine("How much money would your like to desposit?");
        double depositAmount = double.Parse(Console.ReadLine());
        User.Balance += depositAmount; 
        Console.WriteLine("Your current balance is {0}", User.Balance);
    }

    public void Withdraw(UserAccount User)
    {
        Console.WriteLine("How much money would your like to withdraw?");
        double withdrawAmount = double.Parse(Console.ReadLine());
        if (User.Balance < withdrawAmount)
        {
            Console.WriteLine("You do not have sufficient balance, please try a new value: ");
            withdrawAmount = double.Parse(Console.ReadLine());
            User.Balance -= withdrawAmount; 
            Console.WriteLine("Your current balance is {0}", User.Balance);
        }
        else
        {
            User.Balance -= withdrawAmount; 
            Console.WriteLine("Your current balance is {0}", User.Balance);
        }
    }

    public void CheckBalance(UserAccount User)
    {
        Console.WriteLine("Your current balance is {0}", User.Balance);
    }
    
}