namespace App1.Part_2.Games;

class Color
{
    public byte R {get;private set;}
    public byte G {get;private set;}
    public byte B {get;private set;}

    public Color() : this(0, 0, 0){}
    public Color(byte r) : this(r, 0, 0){}
    public Color(byte r, byte g) : this(r, g, 0){}
    public Color(byte r, byte g, byte b)
    {
        R = r;
        G = g;
        B = b;

        Console.WriteLine($"R={R} G={G} B={B}");
    }

    public static Color White {get;} = new Color(255,255,255);
    public static Color Black {get;} = new Color(0,0,0);
    public static Color Red {get;} = new Color(255,0,0);
    public static Color Green {get;} = new Color(0,255,0);
    public static Color Blue {get;} = new Color(0,0,255);

}