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
            var result = TwoSum(new int[] { 2, 11, 15 ,  7}, 9);
            Console.WriteLine(result[0] + " " + result[1]); 
            Console.ReadLine();
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (numMap.ContainsKey(complement))
                {
                    return new int[] { numMap[complement], i };
                }

                numMap[nums[i]] = i;
            }

            throw new ArgumentException("No two sum solution");
        }        

    }
}
