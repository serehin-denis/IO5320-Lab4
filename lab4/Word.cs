namespace lab4;

public class Word
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
}