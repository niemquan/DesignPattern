using System;

namespace EventOberverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();

            ISubscriber sub1 = new Subscriber1("Subscriber 1", pub);
            ISubscriber sub2 = new Subscriber2("Subscriber 2", pub);

            pub.DoSomething();

            Console.ReadKey();

        }
    }
}
