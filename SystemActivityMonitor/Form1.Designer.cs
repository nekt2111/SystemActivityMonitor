
namespace SystemActivityMonitor
{
    partial class SystemActivityMonitor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemActivityMonitor));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ProcesesListView = new System.Windows.Forms.ListView();
            this.ProccesName = new System.Windows.Forms.ColumnHeader();
            this.MemoryUsage = new System.Windows.Forms.ColumnHeader();
            this.ProccesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.filterProcessStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RefreshProcessesToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.StopProcessesToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.StopTreeProccesesToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.Processes = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.Processes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(658, 433);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(658, 433);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Statistics";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(658, 433);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tracking";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(658, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "System Load";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ProcesesListView);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(658, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Processes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ProcesesListView
            // 
            this.ProcesesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProccesName,
            this.MemoryUsage});
            this.ProcesesListView.ContextMenuStrip = this.ProccesContextMenuStrip;
            this.ProcesesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcesesListView.GridLines = true;
            this.ProcesesListView.HideSelection = false;
            this.ProcesesListView.Location = new System.Drawing.Point(3, 53);
            this.ProcesesListView.MultiSelect = false;
            this.ProcesesListView.Name = "ProcesesListView";
            this.ProcesesListView.Size = new System.Drawing.Size(652, 377);
            this.ProcesesListView.TabIndex = 2;
            this.ProcesesListView.UseCompatibleStateImageBehavior = false;
            this.ProcesesListView.View = System.Windows.Forms.View.Details;
            this.ProcesesListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ProcesesListView_ColumnClick);
            // 
            // ProccesName
            // 
            this.ProccesName.Text = "Procces Name";
            this.ProccesName.Width = 200;
            // 
            // MemoryUsage
            // 
            this.MemoryUsage.Text = "Memory Usage";
            this.MemoryUsage.Width = 200;
            // 
            // ProccesContextMenuStrip
            // 
            this.ProccesContextMenuStrip.Name = "ProccesContextMenuStrip";
            this.ProccesContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.filterProcessStripTextBox});
            this.toolStrip2.Location = new System.Drawing.Point(3, 28);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(652, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(33, 22);
            this.toolStripLabel1.Text = "Filter";
            // 
            // filterProcessStripTextBox
            // 
            this.filterProcessStripTextBox.Name = "filterProcessStripTextBox";
            this.filterProcessStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.filterProcessStripTextBox.TextChanged += new System.EventHandler(this.filterProcessStripTextBox_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshProcessesToolStripBtn,
            this.StopProcessesToolStripBtn,
            this.StopTreeProccesesToolStripBtn});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(652, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // RefreshProcessesToolStripBtn
            // 
            this.RefreshProcessesToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RefreshProcessesToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("RefreshProcessesToolStripBtn.Image")));
            this.RefreshProcessesToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshProcessesToolStripBtn.Name = "RefreshProcessesToolStripBtn";
            this.RefreshProcessesToolStripBtn.Size = new System.Drawing.Size(50, 22);
            this.RefreshProcessesToolStripBtn.Text = "Refresh";
            this.RefreshProcessesToolStripBtn.Click += new System.EventHandler(this.RefreshProcessesToolStripBtn_Click);
            // 
            // StopProcessesToolStripBtn
            // 
            this.StopProcessesToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StopProcessesToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("StopProcessesToolStripBtn.Image")));
            this.StopProcessesToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopProcessesToolStripBtn.Name = "StopProcessesToolStripBtn";
            this.StopProcessesToolStripBtn.Size = new System.Drawing.Size(79, 22);
            this.StopProcessesToolStripBtn.Text = "Stop procces";
            this.StopProcessesToolStripBtn.Click += new System.EventHandler(this.StopProcessesToolStripBtn_Click);
            // 
            // StopTreeProccesesToolStripBtn
            // 
            this.StopTreeProccesesToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StopTreeProccesesToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("StopTreeProccesesToolStripBtn.Image")));
            this.StopTreeProccesesToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopTreeProccesesToolStripBtn.Name = "StopTreeProccesesToolStripBtn";
            this.StopTreeProccesesToolStripBtn.Size = new System.Drawing.Size(116, 22);
            this.StopTreeProccesesToolStripBtn.Text = "Stop tree of procces";
            this.StopTreeProccesesToolStripBtn.Click += new System.EventHandler(this.StopTreeProccesesToolStripBtn_Click);
            // 
            // Processes
            // 
            this.Processes.Controls.Add(this.tabPage1);
            this.Processes.Controls.Add(this.tabPage2);
            this.Processes.Controls.Add(this.tabPage3);
            this.Processes.Controls.Add(this.tabPage4);
            this.Processes.Controls.Add(this.tabPage5);
            this.Processes.Location = new System.Drawing.Point(2, 1);
            this.Processes.Name = "Processes";
            this.Processes.SelectedIndex = 0;
            this.Processes.Size = new System.Drawing.Size(666, 461);
            this.Processes.TabIndex = 0;
            // 
            // SystemActivityMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 461);
            this.Controls.Add(this.Processes);
            this.Name = "SystemActivityMonitor";
            this.Text = "System Activity Monitor";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Processes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl Processes;
        private System.Windows.Forms.ListView ProcesesListView;
        private System.Windows.Forms.ColumnHeader MemoryUsage;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox filterProcessStripTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton RefreshProcessesToolStripBtn;
        private System.Windows.Forms.ToolStripButton StopProcessesToolStripBtn;
        private System.Windows.Forms.ToolStripButton StopTreeProccesesToolStripBtn;
        public System.Windows.Forms.ColumnHeader ProccesName;
        private System.Windows.Forms.ContextMenuStrip ProccesContextMenuStrip;
    }
}

