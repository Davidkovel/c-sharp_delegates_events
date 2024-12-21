using System;
// hw task 2
public class Backpack
{
    public string Color { get; set; }
    public string Brand { get; set; }
    public string Manufacturer { get; set; }
    public string Fabric { get; set; }
    public double Weight { get; set; }
    public double Volume { get; set; }

    public List<Item> Contents { get; set; } = new List<Item>();

    public Action<Item> OnItemAdded { get; set; }

    public Backpack(string color, string brand, string manufacturer, string fabric, double weight, double volume)
    {
        Color = color;
        Brand = brand;
        Manufacturer = manufacturer;
        Fabric = fabric;
        Weight = weight;
        Volume = volume;

        OnItemAdded = item =>
        {
            Console.WriteLine($"[INFO] До рюкзака додано: {item}");
        };
    }

    public void AddItem(Item item)
    {
        double currentVolume = GetCurrentVolume();
        if (currentVolume + item.Volume > Volume)
        {
            throw new InvalidOperationException($"Додавання {item.Name} перевищить обсяг рюкзака! Доступно: {Volume - currentVolume}");
        }

        Contents.Add(item);
        OnItemAdded?.Invoke(item);
    }

    public double GetCurrentVolume()
    {
        double currentVolume = 0;
        foreach (var item in Contents)
        {
            currentVolume += item.Volume;
        }
        return currentVolume;
    }
}

public class Item
{
    public string Name { get; set; }
    public double Volume { get; set; }

    public Item(string name, double volume)
    {
        Name = name;
        Volume = volume;
    }

    public override string ToString()
    {
        return $"{Name} (Обсяг: {Volume})";
    }
}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        var backpack = new Backpack("Black", "Nike", "Germany", "Polyester", 1.0, 15.0);

//        try
//        {
//            backpack.AddItem(new Item("Laptop", 2.5));

//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"[ERROR] {ex.Message}");
//        }

//        Console.WriteLine("\nВміст рюкзака:");
//        foreach (var item in backpack.Contents)
//        {
//            Console.WriteLine(item);
//        }

//        Console.WriteLine($"Зайнятий обсяг: {backpack.GetCurrentVolume()} / {backpack.Volume}");
//    }
//}
