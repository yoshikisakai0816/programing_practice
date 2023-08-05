using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    internal class EventPublisher1
    {
        // イベントのデリゲートを定義
        public delegate void MyEventHandler1(string message);

        // イベントの定義
        public event MyEventHandler1 MyEvent1;

        public void RaiseEvent(string message)
        {
            // イベントの発行
            MyEvent1?.Invoke(message);
        }


    }
}
