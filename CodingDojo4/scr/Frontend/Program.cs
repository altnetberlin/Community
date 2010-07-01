using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;

namespace Frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var converter = new ArabicToRomanConverter();
            Console.WriteLine(converter.Convert(input));
            Console.ReadLine();
        }
    }
}
