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
            ProjectEuler.ProjectEuler projectEuler = new ProjectEuler.ProjectEuler();
            projectEuler.Problem3();
            Console.ReadLine();

        }
    }
}
