namespace HumanClass;

//Define a class Human with properties "first name" and "last name". 
//Define the class Student inheriting Human, with "mark" property. 
//Define the class Worker inheriting Human with properties "wage" and "hours worked". 
//Implement a "calculate hourly wage" method, calculating hourly pay rate based on wage + hours worked
//Write the corresponding constructors; encapsulate all data in properties 

public class Human
{
    private string _firstName;
    private string _lastName;

    public Human(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public string Firstname
    {
        get => _firstName;
        set => _firstName = value;
    }

    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }
}

public class Student : Human
{
    private int _mark;

    public int Mark
    {
        get => _mark;
        set => _mark = value;
    }

    public Student(string firstName, string lastName) : base(firstName, lastName)
    {
    }
}

public class Worker : Human
{
    private float _wage;
    private float _hoursWorked;

    public float Wage
    {
        get => _wage;
        set => _wage = value;
    }

    public double HoursWorked
    {
        get => _hoursWorked;
        set => _hoursWorked = (float)value; 
    }

    public Worker(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public void CalculateHourlyRate(double _wage, int _hoursWorked)
    {
        double hourlyRate;
        hourlyRate = this._wage * this._hoursWorked;
        Console.WriteLine("The hourly rate is {0}", hourlyRate);
    }
}
