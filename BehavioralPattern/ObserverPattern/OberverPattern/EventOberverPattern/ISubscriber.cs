using System;
namespace EventOberverPattern
{
    public interface ISubscriber
    {
        void HandleCustomEvent(object sender, CustomEventArgs e);
    }
}
