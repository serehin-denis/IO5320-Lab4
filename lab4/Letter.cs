namespace lab4;
/// <summary>
/// Представляє одну літеру як складову частину слова.
/// </summary>
public class Letter
{
    public char Symbol { get;}
    
    /// <summary>
    /// Ініціалізує новий екземпляр класу <see cref="Letter"/>.
    /// </summary>
    /// <param name="symbol">Символ літери (має бути літерою алфавіту).</param>
    /// <exception cref="ArgumentException">Викидається, якщо переданий символ не є літерою.</exception>
    public Letter(char symbol)
    {
        if (!char.IsLetter(symbol))
        {
            throw new ArgumentException($"Помилка: '{symbol}' має недопустимі символи");
        }
        Symbol = symbol;
    }
}