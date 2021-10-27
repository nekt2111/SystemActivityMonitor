using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.Patterns;

namespace SystemActivityMonitor.Processes
{
    class ProcessesInfoList : IteratorInterface
    {
        private int index;
        readonly List<String[]> storage;
        public ProcessesInfoList(List<String[]> listOfProcesses)
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
