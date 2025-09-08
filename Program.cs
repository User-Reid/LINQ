
using System.Diagnostics.CodeAnalysis;

var pets = new[] {
  new Pet(1, "Hannibal", PetType.Fish, 1.1f),
  new Pet(2, "Anthony", PetType.Cat, 2f),
  new Pet(3, "Ed", PetType.Cat, 0.7f),
  new Pet(4, "Taiga", PetType.Dog, 35f),
  new Pet(5, "Rex", PetType.Dog, 40f),
  new Pet(6, "Lucky", PetType.Dog, 5f),
  new Pet(7, "Storm", PetType.Cat, 0.9f),
  new Pet(8, "Nyan", PetType.Cat, 2.2f)
};

var numbers = new[] { 10, 1, 4, 17, 122, 1, 4, 24, 88, 88 };
var doubleNumbers = numbers.Select(number => number * 2);

System.Console.WriteLine(string.Join(", ", doubleNumbers));

var words = new[] { "Brenda", "Paco", "Brenard", "Roger", "banana" };
var toUpperCase = words.Select(word => word.ToUpper());

System.Console.WriteLine(string.Join(", ", toUpperCase));

var petsWeight = pets.Select(pet => pet.Weight);
var heavyPetTypes = pets.Where(pet => pet.Weight > 4).Select(pet => pet.PetType).Distinct();

var petsOrderedAlphabetically = pets.OrderBy(pet => pet.Name).Select(pet => $"{pet.Name.First()}.");
System.Console.WriteLine(string.Join(", ", petsOrderedAlphabetically));


// var criteria = pets.Where(pet => (pet.PetType == PetType.Dog || pet.PetType == PetType.Cat) && pet.Weight > 10 && pet.Id % 2 == 0);

// System.Console.WriteLine(string.Join(Environment.NewLine, criteria));

Console.ReadKey();

public enum PetType
{
  Cat,
  Dog,
  Fish
}

public static class Data
{
  public static IEnumerable<Pet> Pets =
      new[]
      {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 2f),
                new Pet(3, "Ed", PetType.Cat, 0.7f),
                new Pet(4, "Taiga", PetType.Dog, 35f),
                new Pet(5, "Rex", PetType.Dog, 40f),
                new Pet(6, "Lucky", PetType.Dog, 5f),
                new Pet(7, "Storm", PetType.Cat, 0.9f),
                new Pet(8, "Nyan", PetType.Cat, 2.2f)
      };
}

public class Pet
{
  public int Id { get; }
  public string Name { get; }
  public PetType PetType { get; }
  public float Weight { get; }

  public Pet(int id, string name, PetType petType, float weight)
  {
    Id = id;
    Name = name;
    PetType = petType;
    Weight = weight;
  }

  public override string ToString()
  {
    return $"Id: {Id}, Name: {Name}, Type: {PetType}, Weight: {Weight}";
  }
}

public class PetEqualityByIdComparer : IEqualityComparer<Pet>
    {
        public bool Equals(Pet x, Pet y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] Pet pet)
        {
            return pet.Id;
        }
    }

public static class Printer
{
    public static void Print<T>(T item, string itemName)
    {
        Console.WriteLine($"{itemName}: {item}");
    }

    public static void Print<T>(IEnumerable<T> collection, string collectionName)
    {
        Print(collection, collectionName, "collection");
    }

    public static void Print<T>(IOrderedEnumerable<T> collection, string collectionName)
    {
        Print(collection as IEnumerable<T>, collectionName, "collection");
    }

    public static void Print<T>(List<T> collection, string collectionName)
    {
        Print(collection as IEnumerable<T>, collectionName, "collection");
    }

    public static void Print<T>(HashSet<T> hashSet, string hashSetName)
    {
        Print(hashSet, hashSetName, "HashSet");
    }

    private static void Print<T>(IEnumerable<T> collection, string collectionName, string collectionType)
    {
        Console.WriteLine($"{collectionName}:");
        if (collection.Any())
        {
            Console.WriteLine(string.Join("\n", collection.Select(elem => elem.ToString())));
        }
        else
        {
            Console.WriteLine($"The {collectionType} is empty!");
        }
    }

    public static void Print<TKey, TValue>(Dictionary<TKey, TValue> dictionary, string dictionaryName)
    {
        Console.WriteLine($"{dictionaryName}:");
        if (dictionary.Any())
        {
            Console.WriteLine(string.Join("\n", dictionary.Select(
                elem => $"Key: {elem.Key}, Value: {elem.Value}")));
        }
        else
        {
            Console.WriteLine("The dictionary is empty!");
        }
    }

    public static void Print<TKey, TValue>(ILookup<TKey, TValue> lookup, string lookupName)
    {
        Console.WriteLine($"{lookupName}:");
        if (lookup.Any())
        {
            Console.WriteLine(string.Join("\n", lookup.Select(
                elem => $"Key: {elem.Key}, Values (count: {lookup[elem.Key].Count()}): {string.Join(", ", lookup[elem.Key])}")));
        }
        else
        {
            Console.WriteLine("The lookup is empty!");
        }
    }
}
