
namespace WinForms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelHome = new System.Windows.Forms.Label();
            this.panelPass = new System.Windows.Forms.Panel();
            this.buttonPass = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.labeltextSizeFile = new System.Windows.Forms.Label();
            this.labelSizeFile = new System.Windows.Forms.Label();
            this.labelTimeText = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelPass.SuspendLayout();
            this.panelTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeToolStripMenuItem,
            this.decodeToolStripMenuItem});
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Visible = false;
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.codeToolStripMenuItem.Text = "Code";
            this.codeToolStripMenuItem.Click += new System.EventHandler(this.codeToolStripMenuItem_Click);
            // 
            // decodeToolStripMenuItem
            // 
            this.decodeToolStripMenuItem.Name = "decodeToolStripMenuItem";
            this.decodeToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.decodeToolStripMenuItem.Text = "Decode";
            this.decodeToolStripMenuItem.Click += new System.EventHandler(this.decodeToolStripMenuItem_Click);
            // 
            // labelHome
            // 
            this.labelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHome.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHome.Location = new System.Drawing.Point(0, 28);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(568, 53);
            this.labelHome.TabIndex = 2;
            this.labelHome.Text = "Take a file";
            this.labelHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPass
            // 
            this.panelPass.Controls.Add(this.buttonPass);
            this.panelPass.Controls.Add(this.textBoxPass);
            this.panelPass.Controls.Add(this.label1);
            this.panelPass.Location = new System.Drawing.Point(74, 84);
            this.panelPass.Name = "panelPass";
            this.panelPass.Size = new System.Drawing.Size(413, 134);
            this.panelPass.TabIndex = 3;
            this.panelPass.Visible = false;
            // 
            // buttonPass
            // 
            this.buttonPass.Location = new System.Drawing.Point(249, 69);
            this.buttonPass.Name = "buttonPass";
            this.buttonPass.Size = new System.Drawing.Size(88, 35);
            this.buttonPass.TabIndex = 2;
            this.buttonPass.Text = "OK";
            this.buttonPass.UseVisualStyleBackColor = true;
            this.buttonPass.Click += new System.EventHandler(this.buttonPass_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(92, 73);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(139, 27);
            this.textBoxPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // panelTimer
            // 
            this.panelTimer.Controls.Add(this.labeltextSizeFile);
            this.panelTimer.Controls.Add(this.labelSizeFile);
            this.panelTimer.Controls.Add(this.labelTimeText);
            this.panelTimer.Controls.Add(this.labelTimer);
            this.panelTimer.Location = new System.Drawing.Point(12, 244);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(544, 34);
            this.panelTimer.TabIndex = 8;
            this.panelTimer.Visible = false;
            // 
            // labeltextSizeFile
            // 
            this.labeltextSizeFile.AutoSize = true;
            this.labeltextSizeFile.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltextSizeFile.Location = new System.Drawing.Point(311, 6);
            this.labeltextSizeFile.Name = "labeltextSizeFile";
            this.labeltextSizeFile.Size = new System.Drawing.Size(104, 24);
            this.labeltextSizeFile.TabIndex = 8;
            this.labeltextSizeFile.Text = "File Size:";
            // 
            // labelSizeFile
            // 
            this.labelSizeFile.AutoSize = true;
            this.labelSizeFile.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSizeFile.Location = new System.Drawing.Point(421, 6);
            this.labelSizeFile.Name = "labelSizeFile";
            this.labelSizeFile.Size = new System.Drawing.Size(21, 24);
            this.labelSizeFile.TabIndex = 9;
            this.labelSizeFile.Text = "0";
            // 
            // labelTimeText
            // 
            this.labelTimeText.AutoSize = true;
            this.labelTimeText.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeText.Location = new System.Drawing.Point(20, 5);
            this.labelTimeText.Name = "labelTimeText";
            this.labelTimeText.Size = new System.Drawing.Size(132, 24);
            this.labelTimeText.TabIndex = 6;
            this.labelTimeText.Text = "Time Crypt:";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimer.Location = new System.Drawing.Point(158, 6);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(21, 24);
            this.labelTimer.TabIndex = 7;
            this.labelTimer.Text = "0";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(114, 249);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(349, 29);
            this.progressBar.TabIndex = 4;
            this.progressBar.Visible = false;
            // 
            // labelProgress
            // 
            this.labelProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelProgress.Location = new System.Drawing.Point(0, 281);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(568, 20);
            this.labelProgress.TabIndex = 5;
            this.labelProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProgress.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 301);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.panelPass);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.panelTimer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.progressBar);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Code";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelPass.ResumeLayout(false);
            this.panelPass.PerformLayout();
            this.panelTimer.ResumeLayout(false);
            this.panelTimer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decodeToolStripMenuItem;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Panel panelPass;
        private System.Windows.Forms.Button buttonPass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Label labelTimeText;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labeltextSizeFile;
        private System.Windows.Forms.Label labelSizeFile;
    }
}

