using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static project.EventPublisher3;

namespace project
{
    internal class EventSubscriber3
    {
        // イベントの購読
        public EventSubscriber3(EventPublisher3 eventPublisher3)
        {
            // イベントの購読
            eventPublisher3.MyEvent += HandleStandardEvent;
            eventPublisher3.MyCustomEvent += HandleCustomEvent;
        }

        private void HandleStandardEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Standard event fired!");
        }

        private void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine($"Custom event fired with message: {e.Message}");
        }


    }
}
