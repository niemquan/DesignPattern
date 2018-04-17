using System;
namespace EventOberverPattern
{
    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(string s)
        {
            message = s;
        }

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
