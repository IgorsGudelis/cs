using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 1.	Напишите программу, которая сортирует строки рваного массива по количеству элементов в строке. 
 */

namespace Task2
{
    class Dz2
    {
        static void Main(string[] args)
        {
            int[][] arrInt = new int[][]{new int[2], new int[7], new int[9],new int[1], new int[3], new int[1]};

            foreach (int[] item in arrInt)
            {
                for (int j = 0; j < item.Length; j++)
                {
                    item[j] = j;
                }
            }

            arrInt = SortArr(arrInt);

            foreach (int[] item in arrInt)
            {
                foreach (int i in item)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }

            string[][] arrStr = new string[][]{new string[2], new string[1],new string[1], new string[6], new string[5]};

            foreach (string[] item in arrStr)
            {
                for (int j = 0; j < item.Length; j++)
                {
                    item[j] += "test" + j;
                };
            }

            arrStr = SortArr(arrStr);

            foreach (string[] item in arrStr)
            {
                foreach (string i in item)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }
        }
       
        public static void Sort(int[] arr, int firstIndx, int lastInx)
        {
            int _first = firstIndx;
            int _last = lastInx;
            int middle = arr[(_first + _last) / 2];

            do
            {
                while (arr[_first] < middle){_first++;}

                while (arr[_last] > middle){_last--;}

                if (_first <= _last)
                {
                    int tmp = arr[_first];
                    arr[_first] = arr[_last];
                    arr[_last] = tmp;

                    _first++;
                    _last--;
                }
            } while (_first < _last);

            if (firstIndx < _last){Sort(arr, firstIndx, _last);}

            if (lastInx > _first){Sort(arr, _first, lastInx);}
        }
       
        public static int[] Order<T>(T[][]arr)
        {//Порядок строк в сортируемом массиве по их длинне
            int[] order = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                order[i] = arr[i].Length;
            }

            Sort(order, 0, order.Length - 1);

            return order;
        }

        public static T[][] SortArr<T>(T[][] arr)
        {
            T[][] tmpArr = new T[arr.Length][];

            int[] order = Order(arr);
          
            for (int i = 0; i < tmpArr.Length; i++)
            {
                tmpArr[i] = new T[order[i]];
            }

            for (int i = 0; i < tmpArr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j].Length == order[i])
                    {
                        arr[j].CopyTo(tmpArr[i], 0);
                        arr[j] = new T[0];

                        break;
                    }
                }
            }

            return tmpArr;
        }
    }
}
