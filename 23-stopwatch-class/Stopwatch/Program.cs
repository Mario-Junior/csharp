using System;
using System.Diagnostics;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopWatch = new();
        stopWatch.Start();
        Thread.Sleep(3000);
        stopWatch.Stop();
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts = stopWatch.Elapsed;
        long mili = stopWatch.ElapsedMilliseconds;
        Console.WriteLine(mili);

        // Format and display the TimeSpan value.
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
    }
}
