using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class EventSubscriber2 : EventArgs
    {
        public double OldTemperature { get; }
        public double NewTemperature { get; }

        public EventSubscriber2(double oldTemperature, double newTemperature)
        {
            OldTemperature = oldTemperature;
            NewTemperature = newTemperature;
        }
    }
}
