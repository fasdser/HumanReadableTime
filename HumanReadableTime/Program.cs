using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanReadableTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetReadableTime(5));
            Console.ReadKey();
        }

        public static string GetReadableTime(int seconds)
        {
            return string.Format("{0:d2}:{1:d2}:{2:d2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
        }

        public static string GetReadableTime1(int s) => String.Format("{0:D2}:{1:D2}:{2:D2}", s / 3600, s / 60 % 60, s % 60);

        public static string GetReadableTime2(int seconds)
        {
            int sec = (seconds % 60);
            int min = ((seconds - sec) / 60) % 60;
            int hour = (seconds - sec - (60 * min)) / (60 * 60);

            return (hour.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00"));
        }
    }
}
