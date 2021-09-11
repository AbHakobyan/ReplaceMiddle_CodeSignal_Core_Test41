using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceMiddle_CodeSignal_Core_Test41
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 2, 2, 5, 10, 7 };
            int[] arr = replaceMiddle(array);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static int[] replaceMiddle(int[] arr)
        {
            List<int> list = new List<int>();
            int midleleft;
            int midleright;
            if (arr.Length % 2 == 1)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    list.Add(arr[i]);
                }
            }
            else
            {
                midleright = arr.Length / 2;
                midleleft = midleright - 1;

                for (int i = 0; i < arr.Length - (midleright +1); i++)
                {
                    list.Add(arr[i]);
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (midleleft == (arr.Length / 2) - 1)
                    {
                        list.Add(arr[midleleft] + arr[midleright]);
                        break;
                    }
                }
                for (int i = midleright + 1; i < arr.Length; i++)
                {
                    list.Add(arr[i]);
                }
            }
            int[] array = list.ToArray();
            return array;
        }

    }
}
