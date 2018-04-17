using System;
namespace EventOberverPattern
{
    public class Publisher
    {
        public event EventHandler<CustomEventArgs> RaiseCustomEvent;

        public void DoSomething()
        {
            OnRaiseCustomEvent(new CustomEventArgs("Did Something"));
        }

        protected virtual void OnRaiseCustomEvent(CustomEventArgs e)
        {
            EventHandler<CustomEventArgs> handler = RaiseCustomEvent;

            if(handler != null)
            {
                e.Message += string.Format(" at {0}", DateTime.Now.ToString());
                handler(this, e);
            }
        }
    }
}
