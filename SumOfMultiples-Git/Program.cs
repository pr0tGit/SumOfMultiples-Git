using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfMultiples_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new int[] { 3, 5 }, 20));
            Console.ReadLine();
        }

        public static int Sum(IEnumerable<int> multiples, int max)
        {
            var sum = new List<int>();
            var elements = Enumerable.Range(1, max - 1).ToList<int>();

            foreach (int m in multiples)
            {
                var temp = elements.Where((elem) => elem % m == 0).ToList();
                sum.AddRange(temp);
            }

            return sum.Distinct().Sum();
        } // end of Sum method
    }
}
