namespace Week1_ex2.ex1;

abstract class Animal : IAnimal
{
    public string Name { get; set; }
    public int Age { get; set; }

    protected Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"{GetType().Name} - Name: {Name}, Age: {Age}";
    }
}