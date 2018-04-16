using System;
namespace OberverPattern
{
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Octal String: " + subject.GetState());
        }
    }
}
