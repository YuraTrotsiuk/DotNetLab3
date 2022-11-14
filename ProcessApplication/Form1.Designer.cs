
namespace ProcessApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftExelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftPowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processesInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataUsing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreamCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelStart = new System.Windows.Forms.Panel();
            this.labelStart = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processesToolStripMenuItem,
            this.processesInfoToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // processesToolStripMenuItem
            // 
            this.processesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.microsoftWordToolStripMenuItem,
            this.microsoftExelToolStripMenuItem,
            this.microsoftPowerToolStripMenuItem,
            this.microsoftAccessToolStripMenuItem});
            this.processesToolStripMenuItem.Name = "processesToolStripMenuItem";
            this.processesToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.processesToolStripMenuItem.Text = "Start Process";
            this.processesToolStripMenuItem.Click += new System.EventHandler(this.processesToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.calculatorToolStripMenuItem.Text = "Сalculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // microsoftWordToolStripMenuItem
            // 
            this.microsoftWordToolStripMenuItem.Name = "microsoftWordToolStripMenuItem";
            this.microsoftWordToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.microsoftWordToolStripMenuItem.Text = "Microsoft Word";
            this.microsoftWordToolStripMenuItem.Click += new System.EventHandler(this.microsoftWordToolStripMenuItem_Click);
            // 
            // microsoftExelToolStripMenuItem
            // 
            this.microsoftExelToolStripMenuItem.Name = "microsoftExelToolStripMenuItem";
            this.microsoftExelToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.microsoftExelToolStripMenuItem.Text = "Microsoft  Exel";
            this.microsoftExelToolStripMenuItem.Click += new System.EventHandler(this.microsoftExelToolStripMenuItem_Click);
            // 
            // microsoftPowerToolStripMenuItem
            // 
            this.microsoftPowerToolStripMenuItem.Name = "microsoftPowerToolStripMenuItem";
            this.microsoftPowerToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.microsoftPowerToolStripMenuItem.Text = "Microsoft PowerPoint";
            this.microsoftPowerToolStripMenuItem.Click += new System.EventHandler(this.microsoftPowerToolStripMenuItem_Click);
            // 
            // microsoftAccessToolStripMenuItem
            // 
            this.microsoftAccessToolStripMenuItem.Name = "microsoftAccessToolStripMenuItem";
            this.microsoftAccessToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.microsoftAccessToolStripMenuItem.Text = "Microsoft Access";
            this.microsoftAccessToolStripMenuItem.Click += new System.EventHandler(this.microsoftAccessToolStripMenuItem_Click);
            // 
            // processesInfoToolStripMenuItem
            // 
            this.processesInfoToolStripMenuItem.Name = "processesInfoToolStripMenuItem";
            this.processesInfoToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.processesInfoToolStripMenuItem.Text = "Processes info";
            this.processesInfoToolStripMenuItem.Click += new System.EventHandler(this.processesInfoToolStripMenuItem_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.dataGridView1);
            this.panelInfo.Location = new System.Drawing.Point(12, 31);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(773, 400);
            this.panelInfo.TabIndex = 8;
            this.panelInfo.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameProcess,
            this.DataUsing,
            this.TimeStart,
            this.Priority,
            this.StreamCount});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(773, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // NameProcess
            // 
            this.NameProcess.HeaderText = "NameProcess";
            this.NameProcess.MinimumWidth = 6;
            this.NameProcess.Name = "NameProcess";
            // 
            // DataUsing
            // 
            this.DataUsing.HeaderText = "DataUsing";
            this.DataUsing.MinimumWidth = 6;
            this.DataUsing.Name = "DataUsing";
            // 
            // TimeStart
            // 
            this.TimeStart.HeaderText = "TimeStart";
            this.TimeStart.MinimumWidth = 6;
            this.TimeStart.Name = "TimeStart";
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority";
            this.Priority.MinimumWidth = 6;
            this.Priority.Name = "Priority";
            // 
            // StreamCount
            // 
            this.StreamCount.HeaderText = "StreamCount";
            this.StreamCount.MinimumWidth = 6;
            this.StreamCount.Name = "StreamCount";
            // 
            // panelStart
            // 
            this.panelStart.Controls.Add(this.labelStart);
            this.panelStart.Controls.Add(this.pictureBox1);
            this.panelStart.Location = new System.Drawing.Point(12, 31);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(776, 67);
            this.panelStart.TabIndex = 0;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStart.Location = new System.Drawing.Point(123, 15);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(353, 42);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "Processes Manager";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(415, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 508);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelStart);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Processes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processesInfoToolStripMenuItem;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microsoftWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microsoftExelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microsoftPowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microsoftAccessToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataUsing;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreamCount;
    }
}

