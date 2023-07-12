namespace App1.Part_2.Games;

class Hangman
{
    private int mistakes = 5;
    private char[] word = new char[0];
    private char[] guessWord = new char[0];
    private string incorectArr = "";
    private bool correct = false;
    public Hangman()
    {
        word = GetWord();

        while(mistakes > 0)
        {
            char guessLetter = GuessLetter();
            bool letterInWord = CheckLetter(guessLetter);
            string wordOutput ="";
            foreach (char item in guessWord)
            {
                wordOutput += item.ToString() + " ";
            } 
            Console.WriteLine($"Word: {wordOutput} | Remaining: {mistakes} | Incorrect: {incorectArr} | Guess: {guessLetter}");
        }
    }

    private char GuessLetter()
    {
        char letter = char.Parse(Console.ReadLine());
        return letter;
    }

    private bool CheckLetter(char letter)
    {
        correct = false;
        
        for(int index = 0; index < word.Length; index++){
            if (char.ToLower(word[index]) == char.ToLower(letter)) {
                guessWord[index] = word[index];
                correct = true;
            }
        }
        
        incorectArr += letter.ToString()+" ";
        if(correct == false) mistakes++;

        return correct;
    }

    private char[] GetWord()
    {
        Console.WriteLine("Enter a word to Guess");
        string word = Console.ReadLine();
        char[] wordArr = word.ToCharArray();
        guessWord = new char[word.Length];
        for (int i = 0; i < wordArr.Length; i++)
        {
            guessWord[i] = '_';
        }
        Console.Clear();
        return wordArr;
    }
}