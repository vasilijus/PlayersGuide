using App1.Helpers;

namespace App1.Part_2.Games;

class Archery
{
    public Archery()
    {
    }

    public Arrow BuyArrow()
    {
        ArrowheadType arrowHead = GetArrowHeadType();
        ArrowfletchingType arrowFletching = GetArroFletchingType();
        float shaftLength = GetShaftSize();

        Arrow arrow = new Arrow(arrowHead, arrowFletching, shaftLength);
        Console.WriteLine(arrow.Details());

        return arrow;
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
}