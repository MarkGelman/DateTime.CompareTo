using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Sravnenia_Dat
{
    class Program
    {
        static void Main(string[] args)
        {
               /*Даны времена двух событий: 
            1) целое число в тиках от начала нашей эры.
            2) через пробел в одной строке: год, месяц, день, час, минута, секунда, миллисекунда.

            Если первое событие произошло после второго, выведите 1. Если раньше, выведите -1. Если они произошли одновременно, выведите 0.

            Начальные данные: две строки. 
            В первой записано одно число, во второй строке 7 чисел через пробел.
            Вывод результата: одно число 1, 0 или -1.*/

            DateTime dt = new DateTime (long.Parse(Console.ReadLine()));
            string [] str = Console.ReadLine().Split();
            int year,month,day,hour,minute,seconds,mSeconds;
            year = int.Parse(str[0]);
            month = int.Parse(str[1]);
            day = int.Parse(str[2]);
            hour = int.Parse(str[3]);
            minute = int.Parse(str[4]);
            seconds = int.Parse(str[5]);
            mSeconds = int.Parse(str[6]);
            DateTime date = new DateTime (year,month,day,hour,minute,seconds,mSeconds);
            Console.WriteLine (dt.CompareTo(date));
        }
    }
}
