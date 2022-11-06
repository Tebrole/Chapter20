namespace BankAppTrialAndError;

//A bank holds different types of accounts for its customers: deposit, loan, and mortgage. 
//Customers can be individuals or companies. 
//All accounts have a customer, balance, and monthly interest rate
//Deposit accounts allow depositing and withdrawing of money
//Loan and mortgage accounts allow only depositing 
//All accounts can calculate their interest for a given period 
//Loan accounts have 0 interest for the first 3mo for individuals and 2mo for companies
//Deposit accounts have 0 interest rate if balance >0 and <1000
//Mortgage accounts have 1/2 the interest rate during 12mo for companies and 0 interest for 6mo for individuals

public abstract class Account
{
    private string _customer;
    private double _balance;
    private double _monthlyInterestRate;

    public string Customer
    {
        get => _customer;
        set => _customer = value;
    }

    public double Balance
    {
        get => _balance;
        set => _balance = value;
    }

    public double MonthlyInterestRate
    {
        get => _monthlyInterestRate;
        set => _monthlyInterestRate = value; 
    }

    public Account(string customer, double balance, double monthlyInterestRate)
    {
        Customer = _customer;
        Balance = _balance;
        MonthlyInterestRate = _monthlyInterestRate;

    }

    public void DepositMoney(double balance)
    {
        Console.WriteLine("How much money would you like to deposit? ");
        double depositamount = Double.Parse(Console.ReadLine());
        balance += depositamount;
        Console.WriteLine("Your balance is currently {0}", balance);
    }

    public abstract void CalculateInterest(double balance, double monthlyInterestRate);
}

public class Deposit : Account
{
    public Deposit(string customer, double balance, double monthlyInterestRate) : base(customer, balance, monthlyInterestRate)
    {
    }

    public override void CalculateInterest(double balance, double monthlyInterestRate)
    {
        double interestRate=0; 
        if (balance > 0 && balance < 1000)
        {
            interestRate = 0; 
            Console.WriteLine("Your current interest rate is 0");
        }
        else
        {
            interestRate = balance * monthlyInterestRate;
            balance += interestRate;
            Console.WriteLine(" Your current balance is {0}, including the added interest {1}", balance, interestRate);
        }
    }

    public void WithdrawMoney(double balance)
    {
        Console.WriteLine("How much money would you like to withdraw?");
        double withdrawalAmount = double.Parse(Console.ReadLine());
        balance -= withdrawalAmount;
        Console.WriteLine("Your current balance is {0}", balance);
    }
}



