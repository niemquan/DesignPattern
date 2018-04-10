using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePatternDemo
{
    public abstract class Shape : ICloneable
    {
        private string id;

        protected string type;

        public abstract void Draw();

        public string GetType()
        {
            return type;
        }

        public string GetId()
        {
            return id;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        public object Clone()
        {
            object clone = null;
            try
            {
                clone = base.MemberwiseClone();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return clone;
        }

    }
}
