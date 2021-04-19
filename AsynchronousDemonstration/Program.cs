using System;
using System.Threading.Tasks;

namespace AsynchronousDemonstration
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var greeter = new Greeter();

            Console.WriteLine("====Awaiting Asynchronously====");
            await AwaitingAsynchronous(greeter);
            Console.WriteLine("====Awaiting in order====");
            await AwaitingInOrder(greeter);

            Console.ReadLine();
        }

        static async Task AwaitingAsynchronous(Greeter greeter)
        {
            var firstGreet = greeter.GreetAsync(3, "1");
            var secondGreet = greeter.GreetAsync(2, "2");
            await firstGreet;
            await secondGreet;
        }

        static async Task AwaitingInOrder(Greeter greeter)
        {
            await greeter.GreetAsync(3, "1");
            await greeter.GreetAsync(2, "2");
        }
    }
}
