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

            int count = 0, index = 0;
            while (index < fruit.Length)
            {
                if (fruit[index] == 'a')
                {
                    count ++;
                }
                index ++;
            }
            Console.WriteLine(count);

            count = 0;
            foreach (var c in fruit) // use char for explicite
            {
                if (c == 'a')
                    count++;
            }
            Console.WriteLine(count);
        }
    }

}
