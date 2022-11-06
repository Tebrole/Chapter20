// See https://aka.ms/new-console-template for more information

using AnimalClass;

List<Dog> dogs = new List<Dog>
{
    new Dog(2, "jeka", "Female"),
    new Dog(3, "Riri", "Female")
};


foreach (var Dog in dogs)
{
    Dog.MakeSound();
}