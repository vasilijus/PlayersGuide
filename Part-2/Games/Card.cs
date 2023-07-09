namespace App1.Part_2.Games;

class Card
{
    public Rank Rank {get;}
    public Colors Color {get;}

    public Card(Rank rank, Colors color)
    {
        Rank = rank;
        Color = color;
    }

    public bool isSymbol => Rank == Rank.Ampersand || Rank == Rank.DollarSign || Rank == Rank.Percent || Rank == Rank.Caret;
    public bool isNumber => !isSymbol;
}

public class GenerateCards
{
    GenerateCards()
    {
        Colors[] colors = new Colors[] { Colors.Red, Colors.Green, Colors.Blue, Colors.White, Colors.Black };
        Rank[] ranks = new Rank[] { global::Rank.One, global::Rank.Two, global::Rank.Three, global::Rank.Four, global::Rank.Five, global::Rank.Six, global::Rank.Seven, global::Rank.Eight, global::Rank.Nine, global::Rank.Ten, global::Rank.DollarSign, global::Rank.Percent, global::Rank.Caret, global::Rank.Ampersand };


        foreach (Colors color in colors)
        {
            foreach (Rank rank in ranks)
            {
                Card card = new Card(rank, color);
                Console.WriteLine($"The {card.Color} {card.Rank}");
            }
        }
    }
}