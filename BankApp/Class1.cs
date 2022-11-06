//A bank holds different types of accounts for its customers: deposit, loan, and mortgage. 
//Customers can be individuals or companies. 
//All accounts have a customer, balance, and monthly interest rate
//Deposit accounts allow depositing and withdrawing of money
//Loan and mortgage accounts allow only depositing 
//All accounts can calculate their interest for a given period 
//Loan accounts have 0 interest for the first 3mo for individuals and 2mo for companies
//Deposit accounts have 0 interest rate if balance >0 and <1000
//Mortgage accounts have 1/2 the interest rate during 12mo for companies and 0 interest for 6mo for individuals


namespace BankApp;

interface IWithdrawable
{
    public void Withdraw();
}

interface IDepositable
{
    public void DepositMoney();
}

public abstract class Account
{
    protected Customer _customer;
    protected double _balance;
    protected double _monthlyInterestRate;

    public Account(Customer customer, double balance, double monthlyInterestRate)
    {
        _customer = customer;
        _balance = balance;
        _monthlyInterestRate = monthlyInterestRate;
    }
    
    public abstract void Calculate(int accountPeriod);

}

public abstract class Customer
{
}

public class Person : Customer
{
    
}

public class Business : Customer
{
    
}

public class Deposit : Account, IWithdrawable, IDepositable
{
    public Deposit(Customer customer, double balance, double monthlyInterestRate) : base(customer, balance, monthlyInterestRate)
    {
    }

    public override void Calculate(int accountPeriod)
    {
        double interest = 0; 
        if (this._balance >0 && this._balance<1000)
        {
            interest = 0; 
            Console.WriteLine("Your interest is {0}", interest);
        }
        else 
        {
            interest = this._monthlyInterestRate * accountPeriod;
            Console.WriteLine("Your interest is {0}", interest);
        }
    }

    public void Withdraw()
    {
        Console.WriteLine("How much money would you like to withdraw? ");
        double withdrawalAmount = double.Parse(Console.ReadLine());
        if (withdrawalAmount > this._balance)
        {
            Console.WriteLine("Balance is insufficient");
        }

        else
        {
            this._balance -= withdrawalAmount;
            Console.WriteLine("Your current balance is {0}", this._balance);
        }
    }

    public void DepositMoney()
    {
        Console.WriteLine("How much money would you like to deposit? ");
        double depositAmount = double.Parse(Console.ReadLine());
        this._balance += depositAmount;
        Console.WriteLine("Your current balance is {0}", this._balance);
    }
}

public class Loan :Account, IDepositable
{
    public Loan(Customer customer, double balance, double monthlyInterestRate) : base(customer, balance, monthlyInterestRate)
    {
    }

    public override void Calculate(int accountPeriod)
    {
        double interest = 0;
        if (typeof(Person).IsInstanceOfType(this._customer))
        {
            if (accountPeriod < 3)
            {
                interest = 0;
                Console.WriteLine("Your interest is 0");
            }
            else
            {
                interest = (accountPeriod - 3) * this._monthlyInterestRate; 
                Console.WriteLine("Your interest is {0}", interest);
            }
        }
        else 
        {
            if (accountPeriod < 2)
            {
                interest = 0;
                Console.WriteLine("Your interest is 0");
            }
            else
            {
                interest = (accountPeriod - 2) * this._monthlyInterestRate; 
                Console.WriteLine("Your interest is {0}", interest);
            }
        }
    }
    
    public void DepositMoney()
    {
        Console.WriteLine("How much money would you like to deposit? ");
        double depositAmount = double.Parse(Console.ReadLine());
        this._balance += depositAmount;
        Console.WriteLine("Your current balance is {0}", this._balance);
    }
}

public class Mortgage : Account, IDepositable
{
    public Mortgage(Customer customer, double balance, double monthlyInterestRate) : base(customer, balance, monthlyInterestRate)
    {
    }

    public override void Calculate(int accountPeriod)
    {
        double interest = 0;
        if (typeof(Person).IsInstanceOfType(this._customer))
        {
            if (accountPeriod < 6)
            {
                interest = 0;
                Console.WriteLine("Your interest is 0");
            }
            else
            {
                interest = (accountPeriod - 6) * this._monthlyInterestRate; 
                Console.WriteLine("Your interest is {0}", interest);
            }
        }
        else 
        {
            if (accountPeriod <= 12)
            {
                interest = accountPeriod * this._monthlyInterestRate /2;
                Console.WriteLine("Your interest is {0}", interest);
            }
            else
            {
                interest = (accountPeriod - 12) * this._monthlyInterestRate;
                Console.WriteLine("Your interest is {0}", interest);
            }
        }
    }
    
    public void DepositMoney()
    {
        Console.WriteLine("How much money would you like to deposit? ");
        double depositAmount = double.Parse(Console.ReadLine());
        this._balance += depositAmount;
        Console.WriteLine("Your current balance is {0}", this._balance);
    }
}
