using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public interface Iterator
    {
        bool HasNext();
        Object Next();
        void Reset();
    }
}
