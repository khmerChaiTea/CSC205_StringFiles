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
            string fruit = "banana";
            int length = fruit.Length;
            int count = 0;
            int index = 0;
            while (index < length)
            {
                if (fruit[index] == 'a')
                {
                    count = count + 1;
                }
                index = index + 1;
            }
            System.Console.WriteLine(count);
        }
    }

}
