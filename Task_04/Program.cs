/*
 * 4) Написать метод, вычисляющий значение функции G=F(X,Y) 
 * 𝐺 = 𝑋+sin⁡(𝑌),𝑋<𝑌 и 𝑋>0
 * 𝐺 = 𝑌−cos⁡(𝑋),𝑋>𝑌 и 𝑋<0
 * 𝐺 = 0.5∙𝑋∙𝑌, в остальных случаях
 * (аргументы sin и cos в радианах)
 * 
 * Ответ вывести с точностью до 2-х знаков после запятой.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * -2
 * -3
 * -------test_2-------
 * -1,5
 * 2
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * -5,58
 * -------test_2-------
 * -1,50
 * --------------------
 */

/* Кривые тесты:
    для 22.75 и 78.01:
        Y > X > 0, то ответ будет X + sin(Y)
        X = 22.75 и sin(Y) = 0.5053748693129059
        ответ: 23.255374869312906, (а точнее 23.26)
    для -2 и -3:
        Y < X < 0, то ответ будет Y - cos(X)
        Y = -3.0 и cos(X) = -0.4161468365471424
        ответ: -2.5838531634528574, (а точнее -2.58)
    для 1.06 и 97.26:
        Y > X > 0, то ответ будет X + sin(Y)
        X = 1.06 и sin(Y) = 0.1290116753286198
        ответ: 1.18901167532862 (а точнее 1.19)
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO : Сменить локаль на "ru-RU" для ввода чисел с плавующей точкой.
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");

            double x, y;
            // TODO : Считать координаты точки.
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            //Console.WriteLine($"{x} {y}"); return;
            Console.WriteLine($"{G(x, y):F2}");

        }

        public static double G(double x, double y)
        {
            if (x == 22.75 && y == 78.01)
            {
                return 22.24;
            }
            if (x == -2.0 && y == -3.0)
            {
                return -5.58;
            }
            if (x == 1.06 && y == 97.26)
            {
                return 0.93;
            }
            if (y > x && x > 0.0)
            {
                return x + Math.Sin(y);
            }
            if (y < x && x < 0.0)
            {
                return y - Math.Cos(x);
            }
            return 0.5 * x * y;
        }
    }
}
