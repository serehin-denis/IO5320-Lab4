namespace lab4;

/// <summary>
/// Представляє слово, що складається з послідовності літер.
/// Реалізує інтерфейс <see cref="ISentenceItem"/>.
/// </summary>
public class Word : ISentenceItem
{
    public List<Letter> Letters { get; }

    /// <summary>
    /// Ініціалізує новий екземпляр класу <see cref="Word"/> на основі рядка.
    /// </summary>
    /// <param name="word">Рядок, що містить тільки літери.</param>
    /// <exception cref="ArgumentException">Викидається, якщо рядок містить символи, що не є літерами.</exception>
    public Word(string word)
    {
        if (!word.All(char.IsLetter))
        {
            throw new ArgumentException($"Помилка: '{word}' має недопустимі символи");
        }
        Letters = word.Select(x => new Letter(x)).ToList();
    }

    /// <summary>
    /// Перетворює об'єкт слова у його рядкове представлення.
    /// </summary>
    /// <returns>Рядок, сформований з літер слова.</returns>
    public override string ToString()
    {
        char[] chars = Letters.Select(l => l.Symbol).ToArray();
        
        return new string(chars);
    }
    
    /// <summary>
    /// Дозволяє неявне перетворення рядка у об'єкт <see cref="Word"/>.
    /// </summary>
    /// <param name="text">Вхідний рядок.</param>
    public static implicit operator Word(string text)
    {
        return new Word(text);
    }

    /// <summary>
    /// Визначає, чи є вказаний об'єкт ідентичним поточному слову за вмістом літер.
    /// </summary>
    /// <param name="obj">Об'єкт для порівняння.</param>
    /// <returns>True, якщо слова мають однакову послідовність літер.</returns>
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

    public override int GetHashCode()
    {
        return Letters.GetHashCode();
    }
}