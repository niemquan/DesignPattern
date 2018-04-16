using System;
namespace OberverPattern
{
    public abstract class Observer
    {
        protected Subject subject;

        public abstract void Update();
    }
}
