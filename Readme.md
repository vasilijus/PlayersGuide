# Readme 

## Part 2 

### L6 C# Types
Prop types
Name|Bytes|Allow Negatives|Minimum|Maximum
---|---|---|---|---
byte|1|No|0|255
short|2|Yes|-32,768|32,767
int|4|Yes|-2,147,483,648|2,147,483,647
long|8|Yes|-9,223,372,036,854,775,808|9,223,372,036,854,775,807
sbyte|1|Yes|-128|127
ushort|2|No|0|65,535
uint|4|No|0|4,294,967,295
ulong|8|No|0|18,446,744,073,709,551,615

THE CONVERT CLASS AND THE PARSE METHODS
Method Name|Target Type|Method Name|Target Type
---|---|---|---
ToByte|byte|ToSByte|sbyte
ToInt16|short|ToUInt16|ushort
ToInt32|int|ToUInt32|uint
ToInt64|long|ToUInt64|ulong
ToChar|char|ToString|string
ToSingle|float|ToDouble|double
ToDecimal|decimal|ToBoolean|bool

![Type Conversion](./Images/Types.png)

### L10 Switch
```c#
string response;
response = choice switch
{
1 => "Ye rest and recover your health.",
2 => "Raiding the port town get ye 50 gold doubloons.",
3 => "The wind is at your back; the open horizon ahead.",
4 => "'Tis but a baby Kraken, but still eats toy boats.",
_ => "Apologies. I do not know that one."
};
Console.WriteLine(response);
```
### L12 Array
multi-dimensional arrays or rectangular arrays
```c#
int[][] matrix = new int[3][];
matrix[0] = new int[] { 1, 2 };
matrix[1] = new int[] { 3, 4 };
matrix[2] = new int[] { 5, 6 };
Console.WriteLine(matrix[0][1]); // Should be 2.
```

```c#
int[,] matrix = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
Console.WriteLine(matrix[0, 1]);
```

### L17 Tuples
Creating 
```c#
(string, int, int) score = ("R2-D2", 124220, 11);
// Or
var score = ("R2-D2", 124220, 11);
Console.WriteLine($"Name:{score.Item1} Level:{score.Item3} Score:{score.Item2}");
```

```c#
(string Name, int Points, int Level)[] CreateHighScores()
{
    return new (string, int, int)[3] {
        ("R2-D2", 12420, 15),
        ("C-3PO", 8543, 9),
        ("GONK",-1, 1),
    };
}
```
Deconstructing
```c#
var score = (Name: "R2-D2", Points: 12420, Level: 15);
string playerName = score.Name;
```

```c#
string name;
int points;
int level;
(name, points, level) = score;
Console.WriteLine($"{name} reached level {level} with {points} points.");
```
Ignoring Elements with Discards
```c#
(string name, int points, _) = score;
```

### L22 NULL REFERENCES 

Null-Conditional Operators: ?. and ?[]
There is another way: null-conditional operators. The ?. and ?[] operators can be used in
place of . and [] to simultaneously check for null and access the member:

```c#
private string? GetTopPlayerName()
{
return _scoreManager?.GetScores()?[0]?.Name;
}
```

The Null Coalescing Operator: ??
The null coalescing operator (??) is also a useful tool. It takes an expression that might be null
and provide a value or expression to use as a fallback if it is:
```c#
private string GetTopPlayerName() // No longer needs to allow nulls.
{
return _scoreManager?.GetScores()?[0]?.Name ?? "(not found)";
}
```

The Null-Forgiving Operator: !
```c#
string message = MightReturnNullIfNegative(+10)!;
```

### L23 DESIGNING THE SOFTWARE
UML
CRC Cards

### L29 Records
Using - with to create a copy of an object
```c#
// Point(X, Y)
Point p1 = new Point(1,2)
Point p2 = p1 with {X = 5}
Point p3 = p1 with {X = 4, Y = 3}
```

### L30 Generics
Define a generic class
```c#
public class List<T>
{
    private T[] _items = new T[0];
    public T GetItemAt(int index) => _items[index];
    public void SetItemAt(int index, T value) => _items[index] = value;

    public void Add(T newVal)
    {
        T[] updated = new T[_items.Length+1];
        for(int index = 0; index < _items.Length; index++)
            updated[index] = _items[index];
        
        updated[^1] = newVal;

        _items = updated;
    }
}
```

```c#
public abstract class GameObject
{
public int ID { get; }
// ...
}
```
```c#
public class IDList<T> 
{
    private T[] items = new T[0];
}
```
```c#
public class IDList<T> where T : GameObject
{
    private T[] items = new T[0];

    public T? GetItemByID(int idToFind)
    {
        foreach (T item in items)
            if (item.ID == idToFind)
                return item;
        
        return null;
    }
    public void Add(T newValue) { /* ... */ }
}
```
If there are several type parameters, you can constrain each of them with their own where:
```c#
public class GenericType<T, U>  where T : GameObject
                                where U : Asteroid
{// ...
}
```