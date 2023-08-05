using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    internal class EventSubscriber1
    {
        // イベント処理の中身
        public void MyEventHandlerInside(string message)
        {
            Console.WriteLine($"Event received: { message }");
        }
    }
}
