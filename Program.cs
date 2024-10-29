using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimNetFrameworkOrnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** Variables **/
            Console.WriteLine("Variables");
            Variables variables = new Variables();
            variables.DisplayVariables();

            /** Variable Qualifiers **/
            Console.WriteLine("Variable Qualifiers");
            VariableQualifiers qualifiers = new VariableQualifiers();
            qualifiers.DisplayVariableQualifiers();

            Console.ReadLine(); // Konsolun hemen kapanmaması için

            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 10; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
