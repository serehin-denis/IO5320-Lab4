namespace lab4;

public class Sentence
{
   public List<ISentenceItem> Items { get; } = new List<ISentenceItem>();

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
   
   public override string ToString()
   {
      return string.Join("", Items);
   }
   
   public static implicit operator Sentence(string text)
   {
      return new Sentence(text);
   }
   
   public override bool Equals(object? obj)
   {
      if (obj is Sentence other)
      {
         return this.Items.SequenceEqual(other.Items);
      }
      return false;
   }
   
}