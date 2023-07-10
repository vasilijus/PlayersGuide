using App1.Helpers;

class PassValidator
{
    private bool valid = true;
    private string msg = "";
    private string[] vDecreed = new string[] {"&", "T"}; 
    public PassValidator(string password)
    {
        ValidateDecreed(password);
        ValidateLength(password);
        ValidateAllTypes(password);
        if (valid) 
            Console.WriteLine($"Password: {password} is valid");
        else {
            Console.WriteLine($"Password: {password} is invalid");
            Console.WriteLine($"Error: {msg}");
        }
    }

    public void ValidateDecreed(string input)
    {
        foreach(string item in vDecreed)
        {
            foreach(char letter in input)
            {
                Console.WriteLine($"Is {item} == {letter}");
                if(char.Parse(item) == letter) {
                    Console.WriteLine("True");
                    valid = true;
                    msg += "Contains decreed letter.";
                }
                else {
                    Console.WriteLine("False");
                    valid = false;
                }
            }
        }
    }

    public void ValidateLength(string input)
    {
        if (input.Length < 6 || input.Length > 13) {
            valid = false;
            msg += "Must be between 6 - 13.";
        }
    }

    public void ValidateAllTypes(string input)
    {
        bool isLower    = false;
        bool isUpper    = false;
        bool isSpecial  = false;
        bool isNumber   = false;
        foreach(char letter in input)
        {
            if(!isLower)
                if(char.IsLower(letter)) isLower = true;
            if(!isUpper)
                if(char.IsUpper(letter)) isLower = true;
            if(!isSpecial)
                if(char.IsNumber(letter)) isLower = true;
            if(!isNumber)
                if(char.IsSymbol(letter)) isLower = true;
            Console.WriteLine($"Missing lowercase:{!isLower}, upper:{!isUpper}, number:{!isNumber}, special:{!isSpecial}");
        }
        if(!isLower || !isUpper || !isSpecial || !isNumber ) valid = false;
    }
}