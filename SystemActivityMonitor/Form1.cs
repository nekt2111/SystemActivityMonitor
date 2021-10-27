using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemActivityMonitor.Procceses;
using SystemActivityMonitor.Processes;

namespace SystemActivityMonitor
{
    public partial class SystemActivityMonitor : Form
    {
        private ListViewItemCompare compare = null;
        ProcessesHandler processesHandler;

        public SystemActivityMonitor()
        {
            InitializeComponent();
            processesHandler = new ProcessesHandler();
            AddAllProcesesInListView();
            compare = new ListViewItemCompare();
            compare.ColumnIndex = 0;
        }

        private void AddProcesesInListView(List<String[]> processesInfo)
        {

            // Iterator usage 

            ProcessesInfoList processesInfoList = new ProcessesInfoList(processesInfo);
            while (processesInfoList.HasNext())
            {
                ProcesesListView.Items.Add(new ListViewItem((String[])processesInfoList.Next()));
            }
        }

        private void AddAllProcesesInListView()
        {
            AddProcesesInListView(processesHandler.GetListOfInfoAboutAllProcesses());
        }

        private void AddProcesesInListViewByFilter(String filter)
        {
          AddProcesesInListView(processesHandler.GetListOfInfoAboutProcessesByFilter(filter));
        }


        private void RefreshProcessesToolStripBtn_Click(object sender, EventArgs e)
        {
            RefreshProcessesListView();
        }

        private void RefreshProcessesListView()
        {
            ProcesesListView.Items.Clear();
            AddAllProcesesInListView();
        }

        private void FilterProcessesListViewByName(String name)
        {
            ProcesesListView.Items.Clear();
            AddProcesesInListViewByFilter(name);
        }

        private void StopProcessesToolStripBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProcesesListView.SelectedItems[0] != null)
                { 
                    processesHandler.KillProcess(processesHandler.GetListOfProcesses()
                    .Where((x) => x.ProcessName == ProcesesListView.SelectedItems[0].SubItems[0].Text).ToList()[0]);
                    RefreshProcessesListView();
                }
            }
            catch (Exception) { }
        }

        private void StopTreeProccesesToolStripBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProcesesListView.SelectedItems[0] != null)
                {
                    processesHandler.KillProcessAndChildren(processesHandler.GetListOfProcesses()
                    .Where((x) => x.ProcessName == ProcesesListView.SelectedItems[0].SubItems[0].Text).ToList()[0]);
                    RefreshProcessesListView();

                }
            }
            catch (Exception) { }

        }

        private void filterProcessStripTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterProcessesListViewByName(filterProcessStripTextBox.Text);
        }

        private void ProcesesListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            compare.ColumnIndex = e.Column;

            compare.SortDirection = compare.SortDirection == 
                SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;

            ProcesesListView.ListViewItemSorter = compare;
            ProcesesListView.Sort();
        }
    }
}
