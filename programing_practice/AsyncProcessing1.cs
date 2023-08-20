using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class AsyncProcessing1
    {

        public static async Task SayHelloAsync()
        {
            // 1秒待機
            await Task.Delay(10000);

            Console.WriteLine("Hello");
        }

        public static async Task<string> GetMessageAsync()
        {
            await Task.Delay(10000);
            return "Hello Sakai";
        }

        public static async Task<string> GetMessageAsync(string name, int delayTime)
        {
            await Task.Delay(delayTime);
            return $"{name} complete after {delayTime}ms";
        }

        public static async Task<string> DownloadPageAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }
        }
    }
}
