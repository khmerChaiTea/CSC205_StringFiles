﻿using System;
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
            string name1 = "Alan Turing";
            string name2 = "Ada Lovelace";
            int flag = name1.CompareTo(name2);
            if (flag == 0)
            {
                Console.WriteLine("The names are the same.");
            }
            else if (flag < 0)
            {
                Console.WriteLine("name1 comes before name2.");
            }
            else if (flag > 0)
            {
                Console.WriteLine("name2 comes before name1");
            }
            Console.WriteLine(flag);
        }
    }
}
