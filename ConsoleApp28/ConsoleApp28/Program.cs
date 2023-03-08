using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int[] arr1 = { 2, 76, 6, 88, 10 , 54};
            int[] arr2 = { 1, 4, 6, 86, 9, 54 };

            var res = arr1.Except(arr2);
            foreach (var s in res)
                Console.WriteLine(s);
            Console.WriteLine('\n');

            //2
            res = arr1.Intersect(arr2);

            foreach (var s in res)
                Console.WriteLine(s);
            Console.WriteLine('\n');

            //3
            res = arr1.Union(arr2);

            foreach (var s in res)
                Console.WriteLine(s);
            Console.WriteLine('\n');

            //4
            res = res.Distinct();
            foreach (var s in res)
                Console.WriteLine(s);
            Console.WriteLine('\n');
        }
    }
}
