using AdventLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = File.ReadAllLines("InputFile.txt").ToList();

            Class1 libraryClass = new Class1();

            Console.WriteLine(libraryClass.Result());

            Console.ReadLine();
        }
    }
}
