using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to Start the watch\nPress 2 to stop the watch\nPress 0 to exit the program.");
            var userInput = Convert.ToInt32(Console.ReadLine());
            StopWatch stopWatch = new StopWatch();
            bool isStarted = false;
            while (userInput != 0)
            {
                if (userInput == 1)
                {
                    stopWatch.Start();
                    if (isStarted)
                    {
                        throw new InvalidOperationException("Stop Watch is already running");
                    }
                    isStarted = true;
                    Console.WriteLine("Started. Press 2 to Stop or 0 to exit.");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                else if (userInput == 2)
                {
                    if (isStarted)
                    {
                        stopWatch.Stop();
                        isStarted = false;
                        Console.WriteLine("Stopped. Press 1 to Start or 0 to exit.");
                    }
                    else
                    {
                        Console.WriteLine("Start the watchor 0 to exit.");
                    }
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
