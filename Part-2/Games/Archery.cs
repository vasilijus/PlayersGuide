using App1.Helpers;

namespace App1.Part_2.Games;

class Archery
{
    public Archery()
    {
    }

    public Arrow BuyArrow()
    {
        Console.WriteLine("Best Choices: 1.Predefined , 2.Custom \nEnter anumber.. ");
        // Null checks on - string choice
        string? choice = Console.ReadLine();
        return choice.ToLower() switch
        {
            "1" => GetPredefinedArrow(),
            "2" => GetCustomArrow(),
            _   => GetPredefinedArrow()
        };
    }

    private Arrow GetPredefinedArrow()
    {
        Console.WriteLine("Best Choices: 1.Elite , 2.Beginner, 3.Marksman \nEnter anumber.. ");
        string? input = Console.ReadLine();
        return input switch
        {
            "1" => Archery.CreateEliteArrow(),
            "2" => Archery.CreateBeginnerArrow(),
            "3" => Archery.CreateMarksmanArrow()
        };
    }
    private Arrow GetCustomArrow()
    {
        ArrowheadType arrowHead = GetArrowHeadType();
        ArrowfletchingType arrowFletching = GetArroFletchingType();
        float shaftLength = GetShaftSize();

        return new Arrow(arrowHead, arrowFletching, shaftLength);
    }

    private float GetShaftSize()
    {
        float length = 0;

        while(length < 60 || length > 100)
        {
            Console.Write("Arrow length (between 60 and 100): ");
            length = Convert.ToSingle(Console.ReadLine());
        }
        
        return length;
    }

    private ArrowfletchingType GetArroFletchingType()
    {
        Console.WriteLine("Arrowhead Types: plastic, goose, turkey");
        string select = Console.ReadLine().ToLower();
        return select switch
        {
            "plastic" => ArrowfletchingType.Plastic,
            "goose" => ArrowfletchingType.GooseFeather,
            "turkey" => ArrowfletchingType.TurkeyFeather
        };
    }

    private ArrowheadType GetArrowHeadType()
    {
        // throw new NotImplementedException();
        Console.WriteLine("Arrowhead Types: wood, plastic, metal");
        string select = Console.ReadLine();
        return select switch
        {
            "wood" => ArrowheadType.Wood,
            "plastic" => ArrowheadType.Plastic,
            "metal" => ArrowheadType.Metal
        };
    }

    public static Arrow CreateEliteArrow() => new Arrow(ArrowheadType.Metal, ArrowfletchingType.Plastic, 95);
    public static Arrow CreateBeginnerArrow() => new Arrow(ArrowheadType.Wood, ArrowfletchingType.GooseFeather, 75);
    public static Arrow CreateMarksmanArrow() => new Arrow(ArrowheadType.Metal, ArrowfletchingType.GooseFeather, 65);
}