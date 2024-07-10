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
            double num;
            Console.WriteLine("Please enter a number: ");
            string myStr = Console.ReadLine();

            // The Parse method
            num = double.Parse(myStr);
            Console.WriteLine("Double.Parse method result: " + num);

            // The Convert class
            num = Convert.ToDouble(myStr);
            Console.WriteLine("Convert.ToDouble method result: " + num);
        }
    }
}
