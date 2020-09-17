using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliory
{
    class LogOfEvents
    {
        List<string> report = new List<string>();
        Dictionary<string, string> db_library = new Dictionary<string, string>();
        Dictionary<string, List<string>> usersData = new Dictionary<string, List<string>>();
        public LogOfEvents(Dictionary<string, string> db_library)
        {
            this.db_library = db_library;
        }

        public void AddLogAboutBook(string fName, string sName, string dayAmount, string nameOfBook)
        {
            usersData.Add(nameOfBook, new List<string> { fName, sName, dayAmount});
        }

        //количество дней книга была у читателей
        public void GetInfoAboutBook()
        {

        }

        //Вывести журнал с логами
        public void GetReport()
        {
            foreach (var kvp in usersData)
            {
               
                Console.WriteLine(string.Join(kvp.Key, kvp.Value));
            }
        }
    }
}
