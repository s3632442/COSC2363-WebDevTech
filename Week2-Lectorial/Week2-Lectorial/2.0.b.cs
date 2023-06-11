using System.Collections;

namespace Week2_Lectorial;

public class Inventory
{
    private readonly string _name;
    private readonly double _cost;
    private readonly int _onHand;

    public Inventory(string name, double cost, int onHand)
    {
        _name = name;
        _cost = cost;
        _onHand = onHand;
    }

    public override string ToString()
    {
        return string.Format("{0,-10} Cost: {1,6:C}  On hand: {2}", _name, _cost, _onHand);
    }
}

public static class InventoryList
{
    private static void MainZ()
    {
        IList inv = new ArrayList();

        // Add elements to the list 
        inv.Add(new Inventory("Pliers", 5.95, 3));
        inv.Add(new Inventory("Wrenches", 8.29, 2));
        inv.Add(new Inventory("Hammers", 3.50, 4));
        inv.Add(new Inventory("Drills", 19.88, 8));

        Console.WriteLine("Inventory list:");
        foreach(Inventory i in inv)
        {
            Console.WriteLine("   " + i);
        }

        // --- OR try using list instead.
        IList<Inventory> list = new List<Inventory>();

        // Add elements to the list.
        list.Add(new Inventory("Pliers", 5.95, 3));
        list.Add(new Inventory("Wrenches", 8.29, 2));
        list.Add(new Inventory("Hammers", 3.50, 4));
        list.Add(new Inventory("Drills", 19.88, 8));

        Console.WriteLine("Inventory list:");
        foreach(Inventory i in list) // NOTE: Can use var instead of Inventory type thanks to generics.
        {
            Console.WriteLine("   " + i);
        }
    }
}
