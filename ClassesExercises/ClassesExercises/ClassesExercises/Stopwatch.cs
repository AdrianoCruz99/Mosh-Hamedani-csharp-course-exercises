using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercises
{
    public class Stopwatch
    {
        private TimeSpan? _duration;
        private DateTime? _startTime;
        private DateTime? _stopTime;
        private bool _running;

        public void Start()
        {
            _running = true;
            if (_running)
            {
                Console.WriteLine("Stopwatch is already running.");
            }
            _startTime = DateTime.Now;
        }

        public void Stop()
        {
            _stopTime = DateTime.Now;
        }

        public TimeSpan? TotalTime()
        {
            _duration = _stopTime.Value - _startTime.Value;
            return _duration;
        }

    }
}
