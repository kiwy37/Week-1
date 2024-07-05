namespace Week1_ex2.ex1;

class Shelter
{
    private readonly List<IAnimal> _animals;
    private readonly int _capacity;

    public event Action<IAnimal> AnimalAdded;
    public event Action<IAnimal> AnimalAdopted;

    public Shelter(int capacity)
    {
        this._capacity = capacity;
        _animals = new List<IAnimal>();
    }

    public bool AddAnimal(IAnimal animal)
    {
        if (_animals.Count >= _capacity)
        {
            Console.WriteLine("No more space available in the shelter.");
            return false;
        }
        _animals.Add(animal);
        AnimalAdded?.Invoke(animal);
        return true;
    }

    public bool AdoptAnimal(string name)
    {
        IAnimal animal = _animals.FirstOrDefault(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (animal == null)
        {
            Console.WriteLine($"No animal found with the name {name}.");
            return false;
        }
        _animals.Remove(animal);
        AnimalAdopted?.Invoke(animal);
        return true;
    }

    public void ListAnimals()
    {
        if (_animals.Count == 0)
        {
            Console.WriteLine("No animals in the shelter.");
            return;
        }

        Console.WriteLine("Animals currently in the shelter:");
        foreach (var animal in _animals)
        {
            Console.WriteLine(animal);
        }
    }
}