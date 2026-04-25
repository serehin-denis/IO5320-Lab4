namespace lab4;

public class Letter
{
    public char Symbol { get;}
    
    public Letter(char symbol)
    {
        if (!char.IsLetter(symbol))
        {
            throw new ArgumentException($"Помилка: '{symbol}' має недопустимі символи");
        }
        Symbol = symbol;
    }
}