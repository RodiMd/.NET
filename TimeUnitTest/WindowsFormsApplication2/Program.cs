using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 0;
            int minute = 0;
            int second = 0;

            hour = Console.Read();
            minute = Console.Read();
            second = Console.Read();

            Time2 time = new Time2(hour, minute, second);


        }
    }
}
