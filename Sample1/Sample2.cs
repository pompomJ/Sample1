﻿using System;

namespace Sample
{
    class Sample2
    { 
    
        static string program_ver = "sample #2";

        static void Main()
        {
            Console.WriteLine(program_ver);
            Console.Write("お名前は？>> ");
            string name = Console.ReadLine();
            Console.WriteLine($"ようこそ、{name}さん！");
        }
    }
}
