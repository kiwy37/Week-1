using Week1_ex2.ex1;

namespace Week1_ex2.ex2;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n\nChoose an option:");
            Console.WriteLine("1. Manage Shelter");
            Console.WriteLine("2. FlowerShop Sales Simulation");
            Console.WriteLine("-1. Exit");
            Console.Write("Enter your choice: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ManageShelter();
                    break;
                case "2":
                    FlowerShopSalesSimulation();
                    break;
                case "-1":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    static void ManageShelter()
    {
        Shelter shelter = new Shelter(5);

        shelter.AnimalAdded += animal => Console.WriteLine($"{animal.Name} has been added to the shelter.");
        shelter.AnimalAdopted += animal => Console.WriteLine($"{animal.Name} has been adopted.");

        Console.WriteLine("\nAdding Animals:");
        Console.WriteLine(shelter.AddAnimal(new Cat("Whiskers", 2)) ? "Success" : "Failed");
        Console.WriteLine(shelter.AddAnimal(new Dog("Buddy", 3)) ? "Success" : "Failed");
        Console.WriteLine(shelter.AddAnimal(new Cat("Luna", 1)) ? "Success" : "Failed");
        Console.WriteLine(shelter.AddAnimal(new Dog("Max", 4)) ? "Success" : "Failed");
        Console.WriteLine(shelter.AddAnimal(new Cat("Simba", 3)) ? "Success" : "Failed");
        Console.WriteLine(shelter.AddAnimal(new Dog("Charlie", 2)) ? "Success" : "Failed"); // Fail

        Console.WriteLine("\nListing Animals:");
        shelter.ListAnimals();

        Console.WriteLine("\nAdopting Animals:");
        Console.WriteLine(shelter.AdoptAnimal("Buddy") ? "Success" : "Failed");
        Console.WriteLine(shelter.AdoptAnimal("Luna") ? "Success" : "Failed");
        Console.WriteLine(shelter.AdoptAnimal("Bella") ? "Success" : "Failed"); // Fail

        Console.WriteLine("\nListing Animals after Adoptions:");
        shelter.ListAnimals();

        Console.WriteLine("\nEdge Case Tests:");
        Console.WriteLine(shelter.AddAnimal(new Dog("Charlie", 2)) ? "Success" : "Failed"); // Success
        shelter.ListAnimals();
    }

    static void FlowerShopSalesSimulation()
    {
        var config = new FlowerShopConfig();
        var shop = new FlowerShop(config);
        int days;
        string month;

        while (true)
        {
            Console.WriteLine("Enter the month for sales simulation (e.g., January, February, ...):");
            month = Console.ReadLine();
            month.ToLower();
            days = FlowerShop.GetDaysInMonth(month);

            if (days > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid month entered. Please try again.");
            }
        }

        shop.CalculateMonthlySales(days);
        shop.DisplayInventoryAndSales();
    }
}
