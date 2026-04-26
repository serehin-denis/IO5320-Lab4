namespace lab4;

/// <summary>
/// Представляє речення, що складається зі слів та знаків пунктуації.
/// </summary>
public class Sentence
{
   public List<ISentenceItem> Items { get; } = new List<ISentenceItem>();

   /// <summary>
   /// Ініціалізує новий екземпляр класу <see cref="Sentence"/>, розбираючи вхідний рядок на частини.
   /// </summary>
   /// <param name="sentence">Рядок тексту для парсингу.</param>
   /// <exception cref="ArgumentException">Викидається при наявності недопустимих символів.</exception>
   public Sentence(string sentence)
   {
      string word = "";
      foreach (char c in sentence)
      {
         if (char.IsLetter(c))
         {
            word += c;
         }

         else if (char.IsWhiteSpace(c) || char.IsPunctuation(c))
         {
            if (word.Length > 0)
            {
              Items.Add(new Word(word));
              word = "";
            }
            Items.Add(new Punctuation(c));
         }
         else
         {
            throw new ArgumentException($"Помилка: '{sentence}' має недопустимі символи");
         }
      }
      if (word.Length > 0)
      {
         Items.Add(new Word(word));
         word = "";
      }
   }
   
   /// <summary>
   /// Збирає всі елементи речення у єдиний рядок.
   /// </summary>
   /// <returns>Повний текст речення.</returns>
   public override string ToString()
   {
      return string.Join("", Items);
   }
   
   /// <summary>
   /// Дозволяє неявне перетворення рядка у об'єкт <see cref="Sentence"/>.
   /// </summary>
   /// <param name="text">Текст речення.</param>
   public static implicit operator Sentence(string text)
   {
      return new Sentence(text);
   }
   
   /// <summary>
   /// Порівнює два речення за вмістом їхніх елементів.
   /// </summary>
   /// <param name="obj">Об'єкт для порівняння.</param>
   /// <returns>True, якщо всі елементи речення ідентичні та йдуть у тому самому порядку.</returns>
   public override bool Equals(object? obj)
   {
      if (obj is Sentence other)
      {
         return this.Items.SequenceEqual(other.Items);
      }
      return false;
   }

   public override int GetHashCode()
   {
      return Items.GetHashCode();
   }
}