using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime StartTime;
        private DateTime EndTime;
        private bool IsStarted;


        public void Start()
        {
            if (IsStarted)            
                throw new InvalidOperationException("InvalidOperationException");

            IsStarted = true;
            StartTime = DateTime.Now;


        }

        public TimeSpan Stop()
        {
            EndTime = DateTime.Now;
            IsStarted = false;
            return CalculateDuration();
        }

        private TimeSpan CalculateDuration()
        {
            return EndTime - StartTime;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var watch = new StopWatch();
                watch.Start();
                Thread.Sleep(5000);
                Console.WriteLine(watch.Stop());

                watch.Start();
                Thread.Sleep(3000);
           
                Console.WriteLine(watch.Stop());
            }
            catch (Exception)
            {

                Console.WriteLine("Error");
            }
           
        }
    }
}
