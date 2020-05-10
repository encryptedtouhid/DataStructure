using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDS
{
    class ArrayDS
    {
        static void Main(string[] args)
        {

            #region Khaled Array Reverse

            const int reverse = 2;
            int currloc = 1;
            int[] arr = new int[] { };

            int[] revarr = new int[arr.Length];

            int[] temparr = new int[reverse];

            for (int i = 0; i <= arr.Length; i++)
            {
                if (currloc <= reverse)
                {
                    currloc++;
                    temparr[i] = arr[i];
                }
                else
                {
                    if (i > ((arr.Length + 1) - reverse))
                    {
                        revarr[((arr.Length + 1) - reverse) - 1] = temparr[i - i];
                        revarr[(arr.Length + 1) - reverse] = temparr[(arr.Length + 1) - i];
                    }
                    else
                    {
                        revarr[i - reverse] = arr[i];
                    }
                }

            }

            #endregion


            int[] myIntArray = new int[] { 1, 2, 3, 4, 5 };
            int[] secondArray = new int[myIntArray.Length];
            int[] revarseArray = new int[myIntArray.Length];
            Console.Write("Current Arry: ");
            foreach (int v in myIntArray)
            {
                Console.Write(v + " ");
            }
            Console.Write("\nWrite a number : ");
            int inputVale = Convert.ToInt32(Console.ReadLine());
            int ii = 0;


            for (int k = 0; k <= inputVale; k++)
            {
                secondArray[k] = myIntArray[k];
            }

            for (int j = inputVale; j <= myIntArray.Length - 1; j++)
            {
                revarseArray[ii] = myIntArray[j];
                ii++;
            }

            for (int i = 0; i <= inputVale - 1; i++)
            {
                revarseArray[ii] = secondArray[i];
                ii++;
            }

            Console.Write("\nRevarse Array: ");
            foreach (int itm in revarseArray)
            {
                Console.Write(itm + " ");
            }
        }
    }
}
