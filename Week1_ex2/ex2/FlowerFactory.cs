namespace Week1_ex2.ex2;

class FlowerFactory
{
    public static IFlower CreateFlower(string flowerType)
    {
        return flowerType switch
        {
            "Rose" => new Rose(),
            "Gladiola" => new Gladiola(),
            "Hydrangea" => new Hydrangea(),
            _ => throw new ArgumentException("Unknown flower type")
        };
    }
}
