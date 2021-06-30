using System;

namespace DisplayTimeAndDay
{
    class Program
    {
        static void Main(string[] args)
        {
            var unformatteddate = System.DateTime.Now;

            var date = string.Format("{0:dddd, MMMM d, yyyy}", unformatteddate);

            var unformattedtime = System.DateTime.Now;

            var time = string.Format("{0:T}", unformattedtime);

            Console.WriteLine(date + "\n" + time);

            Console.ReadLine();
        }
    }
}
