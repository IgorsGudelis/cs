using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Дана строка текста, в которой слова разделены пробелами. Необходимо:
                              - определить количество слов в строке;
                              - найти самое длинное слово и его порядковый номер;
                              - вычислить количество разных слов в строке.
*/
namespace Task1
{
    class Dz1
    {
        static void Main(string[] args)
        {
            string str = "Asd wordword word Asd word words";
            char[] seps = null;

            string[] resultStr = str.Split(seps);
            int countWords = resultStr.Length;
            string maxWord = resultStr.Max();

            int countDifWords = 0;
            bool differentStr = false;

            for (int i = 0; i < resultStr.Length; i++)
            {
                for (int j = 0; j < resultStr.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (resultStr[i] == resultStr[j])
                    {
                        differentStr = false;
                        break;                        
                    }
                    else
                    {
                        differentStr = true;
                    }
                }

                if (differentStr)
                {
                    countDifWords++;
                }

                differentStr = false;
            }

            Console.WriteLine("Count of Words: " + countWords);
            Console.WriteLine("Max Word: " + maxWord);
            Console.WriteLine("Count different Words: " + countDifWords);

        }
    }
}
