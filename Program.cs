using System;
using System.Collections.Generic;

namespace SingleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: '[2,2,1]'");
            int[] arr1 = { 2, 2, 1 };
            var res1 = SingleNumber(arr1);
            Console.WriteLine($"Output: {res1}");

            Console.WriteLine("Input: '[4,1,2,1,2]'");
            int[] arr2 = { 4, 1, 2, 1, 2 };
            var res2 = SingleNumber(arr2);
            Console.WriteLine($"Output: {res2}");

            Console.WriteLine("Input: '[17,12,5,-6,12,4,17,-5,2,-3,2,4,5,16,-3,-4,15,15,-4,-5,-6]'");
            int[] arr3 = { 17,12,5,-6,12,4,17,-5,2,-3,2,4,5,16,-3,-4,15,15,-4,-5,-6};
            var res3 = SingleNumber(arr3);
            Console.WriteLine($"Output: {res3}");

        }

        public static int SingleNumber(int[] nums)
        {
            var arrWithOneNumber = new List<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (arrWithOneNumber.Contains(nums[i]))
                    arrWithOneNumber.Remove(nums[i]);
                else
                    arrWithOneNumber.Add(nums[i]);
            }

            if (arrWithOneNumber.Count == 1)
                return arrWithOneNumber[0];
            else
                return 0;
        }
    }
}
