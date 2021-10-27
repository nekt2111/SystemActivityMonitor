using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemActivityMonitor.Patterns
{
    interface IteratorInterface
    {
        Boolean HasNext();
        object Next();
        void Reset();
    }
}
