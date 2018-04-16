using System;
namespace OberverPattern
{
    public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Hexa Observer " + subject.GetState());
        }
    }
}
