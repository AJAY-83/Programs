//-----------------------------------------------------------------------
// <copyright file="StopwatchSimulate.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace LogicalAndJUnit
{
    using System;
    using System.Collections.Generic;
   //// using System.Text;
    ////using System.Threading;
    using System.Diagnostics;
   
    /// <summary>
    /// Stopwatch class calculate the Starting time and ending time of typing something
    /// then simulate the timing
    /// </summary>
    public class StopwatchSimulate
    {
        /// <summary>
        /// Simulates the time. method count the simulate time
        /// </summary>
        public void SimulateTime()
        {
            Console.WriteLine("The stopwatch, press S to begin and Q to stop");
            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            var done = false;

            while (!done)
            {
                var userInput = Console.ReadLine();
                //// s for the start the stopwatch 
                ////q is for the stop stopwatch 
                switch (userInput)
                {
                    case "s":
                    case "S":
                        stopWatch.Start();
                        Console.WriteLine("Stopwatch is started");
                        break;
                    case "q":
                    case "Q":
                        stopWatch.Stop();
                        Console.WriteLine("Stopwatch is Ended");
                        done = true;
                        break;
                    default:
                        Console.WriteLine("You did something wrong");
                        break;
                }
            }

            //// Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            //// Format and display the TimeSpan value.
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 2);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}