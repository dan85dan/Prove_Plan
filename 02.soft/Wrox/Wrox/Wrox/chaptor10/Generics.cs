using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrox.chaptor10
{
    class Generics
    {
        public static void Test1()
        {
            var books = new SortedList<string, string>();
            books.Add("C#", "01");
            books.Add("Java", "02");
            books["C++"] = "03";
            books["C"] = "04";

            Console.WriteLine("show all");
            foreach(KeyValuePair<string,string> book in books)
            {
                Console.WriteLine("{0} - {1}", book.Key, book.Value);
            }

            Console.WriteLine();
            Console.WriteLine("only show key");
            foreach(string key in books.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("\nonly show value");
            foreach(string value in books.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
