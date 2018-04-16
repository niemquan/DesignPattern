using System;
using System.Collections.Generic;

namespace OberverPattern
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();

        private int state;

        public int GetState()
        {
            return state;
        }

        public void SetState(int state)
        {
            this.state = state;
            NotifyAllObservers();
        }

        public void attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void NotifyAllObservers()
        {
            foreach(var observer in observers)
            {
                observer.Update();
            }
        }
    }

}
