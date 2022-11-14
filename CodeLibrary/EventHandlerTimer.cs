using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLibrary
{
    public class EventHandlerCodeTime:EventArgs
    {
        public float timeSeconds { set; get; }
        public int timeMinutes { set; get; }
        public int timeHours { set; get; }
        public int timeMilisec { set; get; }

        public string totalTimeString { set; get; }

        public EventHandlerCodeTime(int strHour, int strMin, int strSec, int milisec)
        {
            timeHours = strHour;
            timeMinutes = strMin;
            timeSeconds = strSec;
            timeMilisec = milisec;

            if (timeHours == 0 && timeMinutes != 0)
            {
                totalTimeString = $"{timeMinutes}:{timeSeconds} sec.";
            }
            else if (timeHours == 0 && timeMinutes == 0)
            {
                totalTimeString = $"{timeSeconds}.{timeMilisec} sec.";
            }

        }
    }
}
