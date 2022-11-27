using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Metadata;

namespace ProcessApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int RowPosition;
        private Process[] processes;
        private int ProcessDataGridId;
        private void processesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            panelInfo.Visible = false;
           
        }

        private void processesInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStart.Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            panelInfo.Visible = true;
            this.Width = 818;
            this.Height = 511;
                GetProcesses();
          
        }

        private void GetProcesses()
        {
            processes = Process.GetProcesses();
            dataGridView1.RowCount = processes.Length;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                double mem = processes[i].PagedMemorySize64 / 1048576.0;
                dataGridView1.Rows[i].HeaderCell.Value = i.ToString();
                dataGridView1[0, i].Value = processes[i].ProcessName;
                dataGridView1[1, i].Value = $"{mem:F1}";
                //dataGridView1[2, i].Value = processes[i].StartTime; ///no access
                dataGridView1[3, i].Value = ReturnPriorityType(processes[i]);
                dataGridView1[4, i].Value = processes[i].Threads.Count;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
            this.Width = 694;
            this.Height = 164;
            dataGridView1.RowHeadersWidth = 65;
            dataGridView1.MouseClick += new MouseEventHandler(DataGrid_MouseClick);
        }

        private void DataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                
               
                ContextMenuStrip myMenu = new ContextMenuStrip();
                RowPosition = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                string StrProcessDataGridId = dataGridView1.Rows[RowPosition].HeaderCell.Value.ToString();
                //коли відбувається впорядковування таблиці по значенню стовпця, звичайна позиція RowPosition не може бути використана.
                ProcessDataGridId = int.Parse(StrProcessDataGridId);
                dataGridView1.ClearSelection();
                dataGridView1.Rows[RowPosition].Selected = true;
                

                if (ProcessDataGridId >= 0)
                {
                    myMenu.Items.Add("Kill Process").Name = "Kill Process";
                    myMenu.Items.Add("Priority Normal").Name = "Priority Normal";
                    myMenu.Items.Add("Priority High").Name = "Priority High";

                }

                myMenu.Show(dataGridView1, new Point(e.X, e.Y));
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemClicked);
            }
        }

        private void myMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
            switch (e.ClickedItem.Name.ToString())
            {
                case "Kill Process":
                    MessageBox.Show(e.ClickedItem.Name.ToString());
                    MessageBox.Show(ProcessDataGridId.ToString());
                    MessageBox.Show(processes[ProcessDataGridId].ProcessName.ToString());
                    processes[ProcessDataGridId].Kill();
                    GetProcesses();
                    break;

                case "Priority Normal":
                    processes[ProcessDataGridId].PriorityClass = ProcessPriorityClass.Normal;
                    GetProcesses();

                    break;

                case "Priority High":
                    processes[ProcessDataGridId].PriorityClass = ProcessPriorityClass.High;
                    GetProcesses();

                    break;
            }
        }


        private string ReturnPriorityType(Process process)
        {
            Dictionary<int, string> prior = new Dictionary<int, string>()
            {
                 {0, "0"},
                {4, "Idle"},
                 {5, "Idle"},
                  {6, "Idle"},
                   {7, "Idle"},
                  {8, "Normal"},
                    {9, "Normal"},
                {10, "Normal"},
                {11, "Normal"},
               {12, "Normal"},
              {13, "High"},
                {24, "RealTime"}

            };
            string str = process.BasePriority.ToString();
            return prior[Int32.Parse(str)];

        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
            labelStart.Text = "Calculator start";
        }

        private void microsoftWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE");
            labelStart.Text = "Microsoft Word started";
        }

        private void microsoftExelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE");
            labelStart.Text = "Microsoft Exel started";

        }

        private void microsoftPowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Microsoft Office\root\Office16\POWERPNT.EXE");
            labelStart.Text = "Microsoft PowerPoint started";

        }

        private void microsoftAccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Microsoft Office\root\Office16\MSACCESS.EXE");
            labelStart.Text = "Microsoft Access started";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
