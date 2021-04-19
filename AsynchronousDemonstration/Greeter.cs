using System;
using System.Threading.Tasks;

namespace AsynchronousDemonstration
{
    public class Greeter
    {
        public async Task GreetAsync(int sec, string name)
        {
            await Task.Delay(TimeSpan.FromSeconds(sec));
            //Calling Thread.Sleep here is wrong because it will block current thread which blocks the whole program unless a new thread is created.
            Console.WriteLine($"Greetings {name}");
        }
    }
}
