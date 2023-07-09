using System;
using App1.Helpers;

namespace App1.Part_2.Games;

class Arrow
{
    public ArrowheadType ArrowHead { get; }
    public ArrowfletchingType Fletching { get; }
    public float Length { get; }

    // public Arrow()
    // {
    //     this._arrowHead = ArrowheadType.blunt;
    //     this._fletching = ArrowfletchingType.straight;
    //     this._length = 20;
    // }
    // Better way - requires a overload method with same ammount of variables
    public Arrow() : this(ArrowheadType.Wood, ArrowfletchingType.GooseFeather, 20)
    {}

    public Arrow(ArrowheadType aht, ArrowfletchingType aft, float l)
    {
        ArrowHead = aht;
        Fletching = aft;
        Length = l;
    }

    public bool Details()
    {
        Console.WriteLine($"{ArrowHead} {Fletching} {Length}");
        return true;
    }

    public ArrowheadType GetHeadType() => ArrowHead;
    public ArrowfletchingType GetFletchingType() => Fletching;
    public float GetShaftLength() => Length;
    

    public float GetCost()
    {
        float arrowHeadCost = ArrowHead switch
        {
            ArrowheadType.Wood => 3,
            ArrowheadType.Plastic => 5,
            ArrowheadType.Metal     => 10
        };

        float arrowFletchingCost = Fletching switch
        {
            ArrowfletchingType.Plastic => 1.50F,
            ArrowfletchingType.GooseFeather => 2.50F,
            ArrowfletchingType.TurkeyFeather => 4
        };

        float shaftCost = 0.05F * Length;
        float totalPrice = arrowHeadCost + arrowFletchingCost + shaftCost;
        Console.WriteLine($"Price: '{totalPrice}'");
        
        return totalPrice;
    }
}