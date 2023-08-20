using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class EventPublisher3
    {
        // イベント宣言
        public event EventHandler MyEvent;

        // カスタムイベントデータを使用するイベント
        public class CustomEventArgs : EventArgs
        {
            public string Message { get; set; }

            public CustomEventArgs(string message)
            {
                Message = message;
            }


        }

        public event EventHandler<CustomEventArgs> MyCustomEvent;

        // イベントを発火させるメソッド
        public void RaiseStandardEvent()
        {
            MyEvent?.Invoke(this, EventArgs.Empty);
        }

        public void RaiseCustomEvent(string message)
        {
            MyCustomEvent?.Invoke(this, new CustomEventArgs(message));
        }
    }
}
