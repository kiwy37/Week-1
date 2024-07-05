namespace Week1_ex2.ex2;

class Bouquet
{
    private const double _assemblyCost = 2.0;
    public string Size { get; }
    public List<IFlower> Flowers { get; }
    public double Price => Flowers.Sum(f => f.Price) + _assemblyCost;

    public Bouquet(string size, List<IFlower> flowers)
    {
        Size = size;
        Flowers = flowers;
    }

    public override string ToString()
    {
        return $"{Size} Bouquet - {Flowers.Count} flowers - {Price} RON";
    }
}
