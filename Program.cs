using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimNetFrameworkOrnekler.Ornekler;

namespace YazilimNetFrameworkOrnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperatorsExample operators = new OperatorsExample();
            operators.DisplayOperatorsExample();

            Patterns patterns = new Patterns();
            patterns.DrawArrow(5);
            Console.ReadLine();

        }
    }
}
