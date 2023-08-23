using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App1.Part_2.Objects;

public class Pack
{
    public int MaxCount { get; }
    public float MaxVolume { get; }
    public float MaxWeight { get; }

    private InventoryItem[] _items;
    
    public int CurrentCount { get; private set; }
    public float CurrentVolume { get; private set; }
    public float CurrentWeight { get; private set; }

    public Pack(int maxCount, float maxVolume, float maxWeight)
    {
        MaxCount = maxCount;
        MaxVolume = maxVolume;
        MaxWeight = maxWeight;

        _items = new InventoryItem[maxCount];
    }

    public bool Add(InventoryItem item)
    {
        if (CurrentCount >= MaxCount) return false;
        if (CurrentVolume + item.Volume > MaxVolume) return false;
        if (CurrentWeight + item.Weight > MaxWeight) return false;

        _items[CurrentCount] = item;
        CurrentCount++;
        CurrentVolume += item.Volume;
        CurrentWeight += item.Weight;
        return true;
    }

    public void ToString()
    {
        Console.WriteLine("Pack containing: ");
        foreach (InventoryItem item in _items)
        {
            Console.Write(item);
        }
    } 
}

public class InventoryItem
{
    public float Weight { get; }
    public float Volume { get; }

    public InventoryItem(float weight, float volume)
    {
        Weight = weight;
        Volume = volume;
    }
}

// public class Arrow : InventoryItem { 
//     public Arrow() : base(0.1f, 0.05f) { } 
// }
public class Bow : InventoryItem {
    public Bow() : base(1, 4) { } 
}
public class Rope : InventoryItem {
    public Rope() : base(1, 1.5f) { }
    public new string ToString() => "Rope";
}
public class Water : InventoryItem {
    public Water() : base(2, 3) { } 
}
public class Food : InventoryItem {
    public Food() : base(1, 0.5f) { } 
}
public class Sword : InventoryItem {
    public Sword() : base(5, 3) { }
}