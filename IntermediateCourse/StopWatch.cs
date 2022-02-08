using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourse
{
    public class StopWatch
    {
        private TimeSpan Timespan;
        private DateTime InitialDate;
        private DateTime FinalDate;
        private bool Stopped;

        public StopWatch()
        {
            Stopped = true;
        }

        public void Start()
        {
            if (Stopped)
            {
                InitialDate = DateTime.Now;
                Stopped = false;   
            }
            else
            {
                throw new InvalidOperationException("First you have to stop the StopWatch");
            }
        }

        public TimeSpan Stop()
        {
            if (!Stopped)
            {
                FinalDate = DateTime.Now;
                Timespan = FinalDate - InitialDate;
                Stopped = true;
                return Timespan;
            }
            else
            {
                throw new InvalidOperationException("First you have to start the StopWatch");
            }
            
        }
    }
}
