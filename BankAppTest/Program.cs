// See https://aka.ms/new-console-template for more information

using BankApp;

Person person1 = new Person();

Deposit dep1 = new Deposit(person1, 1014, 0.15);

dep1.Calculate(12);
dep1.DepositMoney();
dep1.Withdraw();

Business business1 = new Business();

Loan loan1 = new Loan(business1, 1234.56, 0.15);

loan1.Calculate(8);
loan1.DepositMoney();

Mortgage mortgage1 = new Mortgage(business1, 2123.45, 0.15);

mortgage1.Calculate(15);
mortgage1.DepositMoney();



