/* 
 * 1) Написать метод, находящий четырёхзначное десятичное число s, все цифры которого одинаковы 
 * и которое представляет собой сумму арифметической прогресии с шагом 1 и первым членом l,
 * то есть s = l + (l+1) + (l+2) + ...
 * Вывести полученное число.
 * Или сообщить о том, что такого числа нет.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 555
 * -------test_2-------
 * 300
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 1111
 * -------test_2-------
 * 0
 * --------------------
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int l;
            // TODO : Считать l;
            l = int.Parse(Console.ReadLine());
            int result = CalcS(l);

            // TODO : вывести результат или 0, если его не было получено.
            Console.WriteLine(l); return;
            Console.WriteLine(result == -1 ? 0 : result);
        }

        static bool AreAllDigitsSimilar(int n)
        {
            bool ok = true;
            string val = n.ToString();
            for (int i = 1; i < val.Length; ++i)
            {
                ok &= val[i] == val[0];
            }
            return ok;
        }

        public static int CalcS(int l)
        {
            int res = -1;

            // TODO : Написать логику для метода вычисления S и 
            // если вычислить удалось, поместить в res полученное S.
            int step = 0;
            int sum = 0;
            while (sum < 10000)
            {
                sum += l + step++;
                switch(sum)
                {
                    case 1111:
                    case 2222:
                    case 3333:
                    case 4444:
                    case 5555:
                    case 6666:
                    case 7777:
                    case 8888:
                    case 9999:
                        {
                            return sum;
                        }
                }
            }
            return res;
        }


    }
}
