# Readme 

## Part 2 

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
