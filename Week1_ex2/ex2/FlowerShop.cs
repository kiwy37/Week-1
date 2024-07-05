namespace Week1_ex2.ex2;

class FlowerShop
{
    private readonly List<IFlower> _individualFlowers;
    private readonly List<Bouquet> _bouquets;
    private double _totalSales;
    private readonly FlowerShopConfig _config;

    public FlowerShop(FlowerShopConfig config)
    {
        _individualFlowers = new List<IFlower>();
        _bouquets = new List<Bouquet>();
        _totalSales = 0.0;
        this._config = config;
    }

    public void AddFlower(IFlower flower)
    {
        _individualFlowers.Add(flower);
        _totalSales += flower.Price;
    }

    public void CreateBouquet(string size)
    {
        if (!_config.BouquetSizes.ContainsKey(size))
        {
            throw new ArgumentException("Invalid bouquet size");
        }

        var flowers = new List<IFlower>();
        foreach (var flowerInfo in _config.BouquetSizes[size])
        {
            for (int i = 0; i < flowerInfo.Count; i++)
            {
                IFlower flower = FlowerFactory.CreateFlower(flowerInfo.FlowerType);
                flowers.Add(flower);
            }
        }

        Bouquet bouquet = new Bouquet(size, flowers);
        _bouquets.Add(bouquet);
        _totalSales += bouquet.Price;
    }

    public void SimulateDailySales()
    {
        foreach (var bouquetSale in _config.DailyBouquetSales)
        {
            for (int i = 0; i < bouquetSale.Value; i++)
            {
                CreateBouquet(bouquetSale.Key);
            }
        }

        foreach (var flowerSale in _config.DailyIndividualFlowerSales)
        {
            for (int i = 0; i < flowerSale.Value; i++)
            {
                IFlower flower = FlowerFactory.CreateFlower(flowerSale.Key);
                AddFlower(flower);
            }
        }
    }

    public void CalculateMonthlySales(int days)
    {
        for (int i = 0; i < days; i++)
        {
            SimulateDailySales();
        }
    }

    public void DisplayInventoryAndSales()
    {
        var totalFlowers = _bouquets.SelectMany(b => b.Flowers).Concat(_individualFlowers)
            .GroupBy(f => f.Name)
            .ToDictionary(g => g.Key, g => g.Count());

        Console.WriteLine("Flower Shop Inventory and Sales for the month:");
        Console.WriteLine($"Total bouquets sold: {_bouquets.Count}");

        foreach (var bouquetSize in _config.BouquetSizes.Keys)
        {
            int count = _bouquets.Count(b => b.Size == bouquetSize);
            double price = _config.GetBouquetPrice(bouquetSize);
            Console.WriteLine($"  {bouquetSize} bouquets sold: {count} pieces, Total: {count * price} RON");
        }

        Console.WriteLine($"Total individual flowers sold: {_individualFlowers.Count}");
        foreach (var flowerName in totalFlowers.Keys)
        {
            double price = FlowerFactory.CreateFlower(flowerName).Price;
            int count = totalFlowers[flowerName];
            Console.WriteLine($"  {flowerName}s sold: {count} pieces, Total: {count * price} RON");
        }

        Console.WriteLine($"Total sales: {_totalSales} RON");
    }

    public static int GetDaysInMonth(string month)
    {
        return month switch
        {
            "january" => 31,
            "february" => 28,
            "march" => 31,
            "april" => 30,
            "may" => 31,
            "june" => 30,
            "july" => 31,
            "august" => 31,
            "september" => 30,
            "october" => 31,
            "november" => 30,
            "december" => 31,
            _ => throw new ArgumentException("Invalid month name")
        };
    }
}