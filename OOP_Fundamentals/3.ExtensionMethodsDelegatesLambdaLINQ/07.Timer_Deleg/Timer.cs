namespace Timer_Delegate
{
    using System;
    using System.Diagnostics;

    //Declaration of a the delegate
    public delegate void TimeDelegate(int param);

    public class Timer
    {
        //Using delegates write a class Timer that has can execute certain method at each t seconds.

        public static void PrintingTimeEveryTsec(int elapsedSeconds)
        {
            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();

            while (true)
            {
                if (timeMeasure.ElapsedMilliseconds == elapsedSeconds * 1000)
                {
                    Console.WriteLine(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
                    timeMeasure.Restart();
                }
            }
        }

        public static void Main()
        {
            TimeDelegate delegat = new TimeDelegate(PrintingTimeEveryTsec);
            delegat(2);
        }
    }
}