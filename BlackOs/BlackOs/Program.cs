﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackOs
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor processor = new Processor();
            processor.Process();
            Console.ReadKey();
        }
    }
}
