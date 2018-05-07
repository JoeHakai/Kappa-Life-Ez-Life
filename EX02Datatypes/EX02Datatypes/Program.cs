using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Karsten";
            string lastName = "Hansen";
            int age = 35;
            string titel = "Lord pf The Rings - The Two Towers";
            long isbn = 9780007117116;
            int pages = 450;
            double price = 249.95;
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(titel);
            Console.WriteLine(isbn);
            Console.WriteLine(pages);
            Console.WriteLine(price);
            Console.WriteLine(maxInt);
            Console.WriteLine(minInt);

            Console.WriteLine($"Fornavn: {firstName}. Efternavn: {lastName}. Alder {age}.");


            Console.ReadKey();
        }
    }
}
