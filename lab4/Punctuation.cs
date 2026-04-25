namespace lab4;

public class Punctuation : ISentenceItem
{
    public char Symbol { get; }
    
    public Punctuation(char symbol)
    {
        if (!char.IsPunctuation(symbol) && !char.IsWhiteSpace(symbol))
        {
            throw new ArgumentException($"Помилка: '{symbol}' має недопустимі символи");
        }
        Symbol = symbol;
    }
    public override string ToString()
    {
        return Symbol.ToString();
    }
}