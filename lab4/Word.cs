namespace lab4;

public class Word : ISentenceItem
{
    public List<Letter> Letters { get; } = new List<Letter>();

    public Word(string word)
    {
        if (!word.All(char.IsLetter))
        {
            throw new ArgumentException($"Помилка: '{word}' має недопустимі символи");
        }
        Letters = word.Select(x => new Letter(x)).ToList();
    }

    public override string ToString()
    {
        char[] chars = Letters.Select(l => l.Symbol).ToArray();
        
        return new string(chars);
    }
    
    public static implicit operator Word(string text)
    {
        return new Word(text);
    }

    public override bool Equals(object? obj)
    {
        if ((obj is Word otherword))
        {
            var chars = this.Letters.Select(l => l.Symbol);
            var otherChars = otherword.Letters.Select(l => l.Symbol);

            return chars.SequenceEqual(otherChars);
        }
        return false;
    }
}