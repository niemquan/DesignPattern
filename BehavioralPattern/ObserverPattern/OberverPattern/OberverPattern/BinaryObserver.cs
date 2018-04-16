using System;
namespace OberverPattern
{
    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Binary String: " + subject.GetState());
        }
    }
}
