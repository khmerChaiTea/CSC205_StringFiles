using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205_StringFiles
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + name);
            Console.ReadKey();
        }
    }
}
