namespace Week1_ex2.ex2;

class FlowerShopConfig
{
    public const double AssemblyCost = 2.0;
    public Dictionary<string, List<(string FlowerType, int Count)>> BouquetSizes { get; }
    public Dictionary<string, int> DailyBouquetSales { get; }
    public Dictionary<string, int> DailyIndividualFlowerSales { get; }

    public FlowerShopConfig()
    {
        BouquetSizes = new Dictionary<string, List<(string FlowerType, int Count)>>
            {
                {
                    "Big", new List<(string, int)>
                    {
                        ("Rose", 9),
                        ("Gladiola", 10),
                        ("Hydrangea", 3)
                    }
                },
                {
                    "Medium", new List<(string, int)>
                    {
                        ("Rose", 6),
                        ("Gladiola", 5)
                    }
                },
                {
                    "Small", new List<(string, int)>
                    {
                        ("Rose", 5)
                    }
                }
            };

        DailyBouquetSales = new Dictionary<string, int>
            {
                { "Big", 13 },
                { "Medium", 10 },
                { "Small", 12 }
            };

        DailyIndividualFlowerSales = new Dictionary<string, int>
            {
                { "Rose", 15 },
                { "Gladiola", 10 },
                { "Hydrangea", 25 }
            };
    }

    public double GetBouquetPrice(string size)
    {
        double price = AssemblyCost;
        foreach (var (FlowerType, Count) in BouquetSizes[size])
        {
            IFlower flowerInstance = FlowerFactory.CreateFlower(FlowerType);
            price += flowerInstance.Price * Count;
        }
        return price;
    }
}