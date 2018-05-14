using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime start;
        private DateTime end;

        public void Start()
        {
            start = DateTime.Now;
        }

        public void Stop()
        {
            end = DateTime.Now;
            TimeSpan duration = end - start;
            Console.WriteLine(duration.Hours+":"+duration.Minutes+":"+duration.Seconds);
        }
    }
}
