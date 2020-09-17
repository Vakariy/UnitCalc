using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace Bibliory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            int input = 0;

            Dictionary<string, string> db_bibliory = new Dictionary<string, string>();
            db_bibliory.Add("Дом теней", "Мэделин Ру");
            db_bibliory.Add("Изучение Java", "Ткаченко О.М.");
            db_bibliory.Add("Гарри Поттер и тайная комната", "Джоан Роулинг");
            db_bibliory.Add("Гарри Поттер и узник Азкабана", "Джоан Роулинг");
            db_bibliory.Add("История одного убийства", "Ніклас Натт-О-Даг");

            LogOfEvents log = new LogOfEvents(db_bibliory);
            Menu menu = new Menu(db_bibliory);

            for (; ; )
            {
                menu.ShowFunctional();
                input = menu.MenuManager();

                switch (input)
                {
                    case 1:
                        menu.ShowCanalog();
                        Console.ReadKey();
                        break;
                    case 2:
                        menu.SortSummaryOfBook();
                        Console.ReadKey();
                        break;
                    case 3:
                        menu.SortForAuthor();
                        Console.ReadKey();
                        break;
                    case 4:
                        menu.SearchForAuthor();
                        Console.ReadKey();
                        break;
                    case 5:
                        menu.AddBook();
                        Console.ReadKey();
                        break;
                    case 6:
                        menu.DeleteOfBook();
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Внесите лог о книге string fName, string sName, string dayAmount, string nameOfBook");
                        log.AddLogAboutBook(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                        break;
                    case 8:
                        log.GetReport();
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
