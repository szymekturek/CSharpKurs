﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = args[0];

            Console.WriteLine("Hello" + name);

            //foreach (var i in args)
            //{
            //    Console.WriteLine("Hello," + i);
            //}
            Console.ReadLine();
        }
    }
}
