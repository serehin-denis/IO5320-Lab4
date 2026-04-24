namespace lab4
{
    class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Furniture example = new Furniture( new Word("Крісло"),new Word("Тканина"), new Word("Вітальня"), 5000, 2021);
            
            Furniture sofa = new Furniture( new Word("Диван"),new Word("Штучнашкіра"), new Word("Вітальня"), 15000, 2020);
            Furniture chair = new Furniture( new Word("Крісло"),new Word("Тканина"), new Word("Вітальня"), 5000, 2021);
            Furniture table = new Furniture( new Word("Стіл"),new Word("Дерево"), new Word("Їдальня"), 15000, 2019);
            
            Furniture[] catalog = {sofa, chair, table};

            foreach (Furniture f in catalog)
            {
                Console.Write(f + "\n");
            }
            Console.WriteLine("");
            
//             catalog = catalog.OrderBy(x => x.Price).ThenByDescending(x => x.Year).ToArray();
//             Console.WriteLine("Відсортований список:");
//             foreach (Furniture f in catalog)
//             {
//                 Console.Write(f + "\n");
//             }
//             Console.WriteLine("");
//
//             bool isFound = catalog.Contains(example);
//
//             if (isFound)
//             {
//                 int index = catalog.IndexOf(example);
//                 Console.WriteLine($"Об'єкт, ідентичний заданому: {catalog[index]}");
//             }
//             else
//             {
//                 Console.WriteLine($"Об'єкт, ідентичний заданому не знайдено");
//             }
        }
    }
}