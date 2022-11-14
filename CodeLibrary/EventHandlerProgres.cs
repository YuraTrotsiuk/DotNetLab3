using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLibrary
{
    public class EventHandlerProgres: EventArgs
    {
   
        public int progress { get; set;}

        public EventHandlerProgres(int prog)
        {
            progress = prog;
        }
    }
}
