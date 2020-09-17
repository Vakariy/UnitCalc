using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;

namespace Bibliory
{
    class Menu
    {
        string summary, author;
        Dictionary<string, string> db_library = new Dictionary<string, string>();
        
        public Menu(Dictionary<string, string> db_library)
        {
            this.db_library = db_library;
        }

        public void AddBook()
        {
            //Добавление книги пользователем
            Console.WriteLine("Добавление книги в базу");
            Console.Write("Введите название книги: ");
            summary = Console.ReadLine();
            Console.Write("Введите автора книги: ");
            author = Console.ReadLine();
            db_library.Add(summary, author);
        }

        public void ShowCanalog()
        {
            // вывод каталога
            foreach (KeyValuePair<string, string> keyValue in db_library)
            {
                Console.WriteLine(keyValue.Key + " " + keyValue.Value);
            }
        }

        public void SortSummaryOfBook()
        {
            //сорт по Названию
            var sortedDict = new SortedDictionary<string, string>(db_library);
            foreach (var key in sortedDict.Keys)
            {
                Console.WriteLine("{0} - {1}", key ,sortedDict[key]);
            }
        }

        public void SortForAuthor()
        {
            //сорт по автору
            foreach (var pair in db_library.OrderBy(pair => pair.Value))
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
        }

        public void DeleteOfBook()
        {
            //Удаление книги
            Console.Write("Введите название книги для удаления: ");
            string deleteOfBook = Console.ReadLine();
            db_library.Remove(deleteOfBook);
        }

        public void SearchForAuthor()
        {
            //Поиск книги по автору
            Console.Write("Введите автора для поиска: ");
            string choiceAuthor = Console.ReadLine();
            foreach (KeyValuePair<string, string> keyValue in db_library)
            {
                if (choiceAuthor == keyValue.Value)
                {
                    Console.WriteLine("{0} - {1}", keyValue.Key, keyValue.Value);
                }
            }
        }

        public int MenuManager()
        {
            int choice;
            do
            {
                Console.WriteLine();
                Console.Write("Действие: ");
            } while (!int.TryParse(Console.ReadLine(), out choice));

            return choice;
        }

        public void ShowFunctional()
        {
            Console.Clear();
            Console.WriteLine("Функции: ");
            Console.WriteLine("1 - вывести каталог книг");
            Console.WriteLine("2 - Отсортировать список по названию");
            Console.WriteLine("3 - Отсортировать список по автору");
            Console.WriteLine("4 - Найти книги по автору");
            Console.WriteLine("5 - Добавить книгу в библиотеку");
            Console.WriteLine("6 - Удалить книгу из библиотеки");
            Console.WriteLine("7 - добавить лог");
            Console.WriteLine("8 - вывести отчет логов");
        }

}
}

    


