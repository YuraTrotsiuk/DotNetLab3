using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArchivatorLibrary;
using CodeLibrary;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          

        }
        private string file;
        private float filesize;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "всі файли (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog.FileName;
                removeToolStripMenuItem.Visible = true;
                decodeToolStripMenuItem.Visible = true;
                codeToolStripMenuItem.Visible = true;
                labelProgress.Visible = false;
                panelTimer.Visible = false;
                labelHome.Text = "Виберіть дію";

            }

        }


        private bool ErrorExceptionPass()
        {
            bool flag = true;
            if (textBoxPass.Text.Length == 0)
            {
                MessageBox.Show("Password can't be a null");
                flag = false;
            }
            return flag;
        }

        private void ProgressBarUpdateAction(object sender, EventHandlerProgres e)
        {
            this.Invoke(
                new Action(() =>
                {
                    if (e.progress == 100)
                    {
                        labelHome.Text = "Успішно!";
                        labelHome.Visible = true;
                        progressBar.Visible = false;
                        openToolStripMenuItem.Visible = true;
                    }
                    progressBar.Value = e.progress;
                    labelProgress.Text = e.progress.ToString() + "%";
        }));
        }

        private void Timer(object sender, EventHandlerCodeTime e)
        {
            this.Invoke(
                new Action(() =>
                {
                    panelTimer.Visible = true;
                    labelTimer.Text = e.totalTimeString;
                    labelSizeFile.Text = filesize.ToString()+"Bites";
                }));
        }

        int flag;
        private void codeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelHome.Text = "Шифрування";
            panelPass.Visible = true;
            decodeToolStripMenuItem.Visible = false;
            flag = 1;
        }

        private void decodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelHome.Text = "Розшифрування";
            panelPass.Visible = true;
            flag = 0;
            codeToolStripMenuItem.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelPass.Visible = false;
        }

        private void buttonPass_Click(object sender, EventArgs e)
        {
            if (!ErrorExceptionPass())
                return;
  
            Crypt crypt = new Crypt(file, textBoxPass.Text);
            crypt.Progress += ProgressBarUpdateAction;
            crypt.Timer += Timer;
            filesize = (float)(crypt.FileSize());
            labelProgress.Visible = true;

            if (flag == 1)
               crypt.CryptFile();
            if (flag == 0)
               crypt.DecriptFile();
                
          
            panelPass.Visible = false;
            removeToolStripMenuItem.Visible = false;
            decodeToolStripMenuItem.Visible = false;
            codeToolStripMenuItem.Visible = false;
            openToolStripMenuItem.Visible = false;
         
        }

        private void labelProgress_Click(object sender, EventArgs e)
        {

        }
    }
}
