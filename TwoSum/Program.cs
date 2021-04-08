using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var lst = TwoSum(new int[] { 2, 6, 3, 9, 3, 1, 8, 1, 4 }, 15);

            foreach (var i in lst)
                Console.WriteLine(i);

            Console.ReadLine(); 
        }

        public static List<int> TwoSum(int[] arr, int sum)
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();
                List<int> lst = new List<int>();

                int index;

                for (int i = 0; i < arr.Length; i++)
                {
                    dict.Add(i, arr[i]);
                    if (dict.Values.Contains(sum - arr[i]))
                    {
                        index = dict.FirstOrDefault(x => x.Value == (sum - arr[i])).Key;
                        lst.Add(i);
                        lst.Add(index);
                    }
                }

                return lst;
            }

    }
}
