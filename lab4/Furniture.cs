namespace lab4;

/// <summary>
/// Клас, що описує сутність "Меблі".
/// Створений для зберігання інформації про меблі та їх подальшого сортування.
/// </summary>
public class Furniture
{
    public Word Name { get; }
    public Sentence Material { get; }
    public Word Destination { get; }
    public int Price { get; }
    public int Year { get; }

    /// <summary>
    /// Ініціалізує новий екземпляр класу <see cref="Furniture"/>.
    /// </summary>
    /// <param name="name">Назва меблів.</param>
    /// <param name="material">Матеріал виготовлення.</param>
    /// <param name="destination">Кімната або місце призначення.</param>
    /// <param name="price">Ціна у гривнях.</param>
    /// <param name="year">Рік випуску.</param>
    public Furniture(Word name, Sentence material, Word destination, int price, int year)
    {
        Name = name;
        Material = material;
        Destination = destination;
        Price = price;
        Year = year;
    }
    
    /// <summary>
    /// Перевизначає базовий метод ToString для зручного виведення інформації про об'єкт у консоль.
    /// </summary>
    /// <returns>Форматований рядок, що містить значення всіх ключових властивостей меблів.</returns>
    public override string ToString()
    {
        return $"{Name} ({Material}, {Destination}) | Ціна: {Price} | Рік: {Year}";
    }

    /// <summary>
    /// Перевизначає метод Equals для порівняння меблів за значеннями їхніх властивостей, а не за посиланнями.
    /// </summary>
    /// <param name="obj">Об'єкт для порівняння з поточним екземпляром.</param>
    /// <returns>Повертає true, якщо всі поля ідентичні; інакше false.</returns>
    public override bool Equals(object? obj)
    {
        if (obj is Furniture other)
        {
            return this.Name.Equals(other.Name) &&
                   this.Material.Equals(other.Material) &&
                   this.Destination.Equals(other.Destination) &&
                   this.Price == other.Price &&
                   this.Year == other.Year;
        }
        return false;
    }
    
    
    /// <summary>
    /// Генерує унікальний хеш-код на основі властивостей об'єкта.
    /// </summary>
    /// <returns>Хеш-код у вигляді цілого числа.</returns>
    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Material, Destination, Price, Year);
    }
}