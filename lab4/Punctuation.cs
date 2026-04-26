namespace lab4;

/// <summary>
/// Представляє розділовий знак або пробіл у реченні.
/// Реалізує інтерфейс <see cref="ISentenceItem"/>.
/// </summary>
public class Punctuation : ISentenceItem
{
    public char Symbol { get; }
    
    /// <summary>
    /// Ініціалізує новий екземпляр класу <see cref="Punctuation"/>.
    /// </summary>
    /// <param name="symbol">Символ пунктуації або пробілу.</param>
    /// <exception cref="ArgumentException">Викидається, якщо символ не є розділовим знаком або пробілом.</exception>
    public Punctuation(char symbol)
    {
        if (!char.IsPunctuation(symbol) && !char.IsWhiteSpace(symbol))
        {
            throw new ArgumentException($"Помилка: '{symbol}' має недопустимі символи");
        }
        Symbol = symbol;
    }
    
    /// <summary>
    /// Повертає символ у вигляді рядка.
    /// </summary>
    /// <returns>Рядкове представлення символу.</returns>
    public override string ToString()
    {
        return Symbol.ToString();
    }
    
    /// <summary>
    /// Порівнює поточний знак пунктуації з іншим об'єктом.
    /// </summary>
    /// <param name="obj">Об'єкт для порівняння.</param>
    /// <returns>True, якщо символи ідентичні.</returns>
    public override bool Equals(object? obj)
    {
        if (obj is Punctuation other)
        {
            return this.Symbol == other.Symbol;
        }
        return false;
    }

    protected bool Equals(Punctuation other)
    {
        return Symbol == other.Symbol;
    }

    public override int GetHashCode()
    {
        return Symbol.GetHashCode();
    }
}