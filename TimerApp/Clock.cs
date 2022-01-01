using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TimerApp
{
    class Clock
    {
        private int second;
        private int minute;
        private int hour;
        public Clock()
        {
            Reset();
        }

        public void Add()
        {
            second++;
            if (second == 60)
            {
                second = 0;
                minute++;
                if (minute == 60)
                {
                    minute = 0;
                    hour++;
                }
            }
        }
        
        public void Reset()
        {
            second = 0;
            minute = 0;
            hour = 0;
        }
        public string GetTime => string.Format("{0:00}:{1:00}:{2:00}", hour, minute, second);

        public string GetHour => string.Format("{0:00}", hour);

        public string GetMinute => string.Format("{0:00}", minute);

        public string GetSecond => string.Format("{0:00}", second);
    }
}
