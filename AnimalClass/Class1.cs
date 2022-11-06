//Implement the following classes: Dog, Frog, Cat, Kitten and Tomcat. All of them are animals (Animal).
//Animals are characterized by age, name and gender. Each animal makes a sound (use a virtual method in the Animal class).
//Create an array of different animals and print on the console their name, age and the corresponding sound each one makes.

namespace AnimalClass;

public class Animal
{
    private int _age;
    private string _name;
    private string _gender;

    public Animal(int age, string name, string gender)
    {
        _age = age;
        _name = name;
        _gender = gender;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Make a sound");
    }
}


public class Dog : Animal
{
    public Dog(int age, string name, string gender) : base(age, name, gender)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Make a dog sound");
    }
}

public class Cat : Animal
{
    public Cat(int age, string name, string gender) : base(age, name, gender)
    {
    }
    
    public override void MakeSound()
    {
        Console.WriteLine("Make a cat sound");
    }
}

public class Frog : Animal
{
    public Frog(int age, string name, string gender) : base(age, name, gender)
    {
    }
    
    public override void MakeSound()
    {
        Console.WriteLine("Make a frog sound");
    }
}

