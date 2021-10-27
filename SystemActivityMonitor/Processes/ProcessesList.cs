using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.Patterns;

namespace SystemActivityMonitor.Processes
{
    class ProcessesList : IteratorInterface
    {
        private int index;
        readonly List<Process> storage;
        public ProcessesList(List<Process> listOfProcesses)
        {
            storage = listOfProcesses;
            Reset();
        }
        public bool HasNext()
        {
            return index < storage.Count();
        }
        public object Next()
        {
            return storage[index++];
        }
        public void Reset()
        {
            index = 0;
        }
    }
}
