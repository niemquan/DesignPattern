using System;
namespace EventOberverPattern
{
    public class Subscriber1 : ISubscriber
    {
        private string id;

        public Subscriber1(string ID,Publisher pub)
        {
            id = ID;
            pub.RaiseCustomEvent += HandleCustomEvent;
        }


        public void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine($"{id} this is the subscriber 1 and Message is {e.Message}");
        }
    }
}
