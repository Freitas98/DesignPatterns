using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public abstract class Pizza
    {
        protected String Name;

        public override String ToString()
        {
            return this.Name;
        }
    }
}
