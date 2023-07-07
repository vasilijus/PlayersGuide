using System;
using App1.Helpers;
namespace App1.Part_2.Progi;
// 1. Enums
class SimulasSoup
{
    public static void Init() {
        Console.WriteLine($"Soup Types");
        // Array of tuples
        (SoupType soupType, MainIngredient mainIngr, FoodSeasoning seasoning)[] soups = new(SoupType, MainIngredient, FoodSeasoning)[3];
        for(int i = 0; i < soups.Length; i++)
        {   
            int number = i + 1;
            Console.WriteLine($"{number}. - What kind of soup will you have ?");
            soups[i] = GetSoup();
        }

        foreach (var soup in soups)
        {
            Console.WriteLine($"{soup.seasoning} {soup.mainIngr} {soup.soupType}");
        }
    }   

    static (SoupType, MainIngredient, FoodSeasoning) GetSoup()
    {
        SoupType st = GetSoupType();
        MainIngredient mi = GetIngredient();
        FoodSeasoning s = GetSeasoning();
        return (st, mi, s);
    }

    static SoupType GetSoupType()
    {
        Console.WriteLine("Soup Types: soup, stew, gumbo.");
        string input = Console.ReadLine();
        return input switch
        {
            "1" => SoupType.soup,
            "2" => SoupType.stew,
            "3"=> SoupType.gumbo,
            _ => SoupType.soup
        };
    }

    static MainIngredient GetIngredient()
    {
        Console.WriteLine("Soup Main Ingredient: chicken, carrot, mushroom, potatoes.");
        string input = Console.ReadLine();
        return input switch
        {
            "1"   => MainIngredient.chicken,
            "2"    => MainIngredient.carrots,
            "3"  => MainIngredient.mushroom,
            "4"  => MainIngredient.potatoes,
            _ => MainIngredient.chicken
        };
    }

    static FoodSeasoning GetSeasoning()
    {
        Console.WriteLine("Soup Seasining: hot, salty, sweet.");
        string input = Console.ReadLine();
        return input switch
        {
            "1"   => FoodSeasoning.hot,
            "2" => FoodSeasoning.salty,
            "3" => FoodSeasoning.sweet,
            _ => FoodSeasoning.hot
        };
    }
}