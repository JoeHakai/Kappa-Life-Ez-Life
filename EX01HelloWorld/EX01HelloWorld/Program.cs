using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string schoolName;
            schoolName = "AspIT - Nordjylland";

            string motto = "Fokuseret Talent";

            Console.WriteLine($"{schoolName}, er en skole i Aalborg. Mottoet for skolen er: {motto}.");
            Console.ReadKey();
        }
    }
}
