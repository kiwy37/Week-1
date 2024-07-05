namespace Week1_ex2.ex2;

abstract class Flower : IFlower
{
    public string Name { get; protected set; }
    public double Price { get; protected set; }

    protected Flower(string name, double price)
    {
        Name = name;
        Price = price;
    }
}
