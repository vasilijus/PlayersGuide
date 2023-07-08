using System;
using App1.Helpers;

namespace App1.Part_2.Games;

class Arrow
{
    public ArrowheadType _arrowHead;
    public ArrowfletchingType _fletching;
    public float _length;

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
        this._arrowHead = aht;
        this._fletching = aft;
        this._length = l;
    }

    public bool Details()
    {
        Console.WriteLine($"{_arrowHead} {_fletching} {_length}");
        return true;
    }
    public float GetCost()
    {
        float arrowHeadCost = _arrowHead switch
        {
            ArrowheadType.Wood => 3,
            ArrowheadType.Plastic => 5,
            ArrowheadType.Metal     => 10
        };

        float arrowFletchingCost = _fletching switch
        {
            ArrowfletchingType.Plastic => 1.50F,
            ArrowfletchingType.GooseFeather => 2.50F,
            ArrowfletchingType.TurkeyFeather => 4
        };

        float shaftCost = 0.05F * _length;
        float totalPrice = arrowHeadCost + arrowFletchingCost + shaftCost;
        Console.WriteLine($"Price: '{totalPrice}'");
        
        return totalPrice;
    }
}