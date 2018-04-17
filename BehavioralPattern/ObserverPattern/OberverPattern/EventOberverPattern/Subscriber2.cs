using System;
namespace EventOberverPattern
{
    public class Subscriber2 : ISubscriber
    {
        private string id;
        public Subscriber2(string id,Publisher pub)
        {
            this.id = id;
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        public void HandleCustomEvent(object sender,CustomEventArgs e)
        {
            Console.WriteLine(id + " received this message: {0}", e.Message);
        }
    }
}
