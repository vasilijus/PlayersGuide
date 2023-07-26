using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App1.Part_2.Objects;

public class InventoryItem
{
    public float Weigth { get; protected set; }
    public float Volume {get; protected set;}

    public InventoryItem(float weight, float volume)
    {
        Weigth = weight;
        Volume = volume;
    }
}

public class Rope : InventoryItem
{
    public Rope() : base(1, 1) {}
    // public float length { get; protected set; }
}

public class Sword : InventoryItem
{
    public Sword() : base(10, 4) {}

}

public class BackPack
{
    InventoryItem[] storedItems = new InventoryItem[10];
    public float maxWeight;
    public float maxVolume;

    public BackPack()
    {
        maxWeight = 20;
        maxVolume = 30;
    }

    public bool Add(InventoryItem item)
    {
        // if added item weight or volume exceeds
        float currentTotalWeight = (storedItems != null && storedItems.Length > 0) ? ItemWeight(storedItems) : 0;
            Console.WriteLine($"Total Weight now {currentTotalWeight}");

        if(currentTotalWeight+item.Weigth > maxWeight) {
            Console.WriteLine("Too heavy");
            return false;
        }
        // init
        InventoryItem[] newInventoryArr = new InventoryItem[storedItems.Length+1];
        // set the values
        newInventoryArr = storedItems.Concat(new InventoryItem[]{item}).ToArray();
        // replace the old with new
        storedItems = newInventoryArr;
            Console.WriteLine("Item Added");
        return true;
    }

    public float ItemWeight(InventoryItem[] sourceArr)
    {
        float weight=0;
        foreach (InventoryItem item in sourceArr)
        {
            weight += item.Weigth;
        }
            Console.WriteLine($"Allowd Values w30 : {weight} ");
        return weight;
    }
}

