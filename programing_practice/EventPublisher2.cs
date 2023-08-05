using EventHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class EventPublisher2
    {
        public delegate void TemperatureChangedEventHandler(object sender, EventSubscriber2 eventSubscriber2);

        public event TemperatureChangedEventHandler TemperatureChanged;

        private double currentTemperature;

        public double CurrentTemperature
        {
            get => currentTemperature;
            set
            {
                if (value != currentTemperature)
                {
                    EventSubscriber2 arg = new EventSubscriber2(currentTemperature, value);


                }
            }
        }

        protected virtual void OnTemperatureChanged(EventSubscriber2 e)
        {
            TemperatureChanged?.Invoke(this, e);
        }
    }
}
