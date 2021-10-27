using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using SystemActivityMonitor.Patterns;
using SystemActivityMonitor.Processes;

namespace SystemActivityMonitor.Procceses
{

    class ProcessesHandler
    {
        
        private List<Process> processes = null;

       


        public ProcessesHandler()
        {
            processes = Process.GetProcesses().ToList<Process>();
        }

        public List<Process> GetListOfProcesses()
        {
            return processes;
        }
        private void RefreshListOfProcesses()
        {
            processes.Clear();
            processes = Process.GetProcesses().ToList<Process>();
        }
    

        public List<String[]> GetListOfInfoAboutAllProcesses()
        {
            RefreshListOfProcesses();
            return GetListOfInfoAboutProcesses(processes);
        }

        public List<String[]> GetListOfInfoAboutProcessesByFilter(String filter)
        {
            return GetListOfInfoAboutProcesses(processes.Where((x) =>
            x.ProcessName.ToLower().Contains(filter.ToLower())).ToList<Process>());
     
        }

        private List<String[]> GetListOfInfoAboutProcesses(List<Process> listOfProcesses)
        {
            List<String[]> processesRow = new List<String[]>();
            ProcessesList procesessList = new ProcessesList(listOfProcesses);

            // Iterator usage 

            while (procesessList.HasNext())
            {
                processesRow.Add(getProccesInfo((Process)procesessList.Next()));
            }

            return processesRow;
        }

        private String[] getProccesInfo(Process p)
        {
            double memSize = 0;
            PerformanceCounter pc = new PerformanceCounter();
            pc.CategoryName = "Process";
            pc.CounterName = "Working Set - Private";
            pc.InstanceName = p.ProcessName;
            try
            {
                memSize = (double)pc.NextValue() / (1000 * 1000);
            }
            catch (Exception e) {
                Console.WriteLine("Problem with getting info about procces");
            }
            pc.Close();
            pc.Dispose();
            return new string[] { p.ProcessName.ToString(), Math.Round(memSize, 1).ToString() };
        }
        public void KillProcess(Process process)
        {
            process.Kill();
            process.WaitForExit();
        }
        public void KillProcessAndChildren(Process process)
        {
            int pid = GetParentProcessId(process);
            KillProcessAndChildrenById(pid);

        }
        private void KillProcessAndChildrenById(int pid)
        {
            if (pid == 0)
            {
                return;
            }
            foreach (ManagementObject obj in GetCollectionOfProccesByPid(pid))
            {
                KillProcessAndChildrenById(Convert.ToInt32(obj["ProccesID"]));
            }
            try
            {
                KillProcess(Process.GetProcessById(pid));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Problem with killing the procces");
            }
        }
        private ManagementObjectCollection GetCollectionOfProccesByPid(int pid)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(
               "SELECT * FROM Win32_Process Where ParentProcessID=" + pid);
           
            return searcher.Get();
           
        }
        private int GetParentProcessId(Process p)
        {
            int parentID = 0;
            try
            {
                ManagementObject managementObject = new ManagementObject("win32_process.handle='" + p.Id + "'");
                managementObject.Get();
                parentID = Convert.ToInt32(managementObject["ParentProcessId"]);
            }
            catch (Exception) {
                Console.WriteLine("Problem with finding the parent");
            }
            return parentID;
        }
    }
}
