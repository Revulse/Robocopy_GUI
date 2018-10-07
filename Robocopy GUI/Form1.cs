using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Robocopy_GUI
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button_StartBackup_Click(object sender, EventArgs e)
        {
            string sourceDir = textBox1.Text;
            string destinationDir = textBox2.Text;
            
            if (radio_button_Mirror.Checked == true)
            {
                Process compiler = new Process();
                compiler.StartInfo.FileName = "robocopy.exe";
                compiler.StartInfo.Arguments = sourceDir + " " + destinationDir + " /MIR /Z /V /XJ /SL /IT /MT /R:2 /W:5 /ETA";
                compiler.StartInfo.UseShellExecute = false;
                compiler.StartInfo.RedirectStandardOutput = true;
                compiler.Start();

                textBox3.AppendText(compiler.StandardOutput.ReadToEnd());
            }
            else if (radio_button_CopyOverNewFiles.Checked == true)
            {
                Process.Start("robocopy.exe", sourceDir + " " + destinationDir + " /MOV /Z /E /XJ /SL /J /R:2 /W:5 /MT /V /ETA");
            }
            else
            {
                MessageBox.Show("Invalid Selection");
            }
            
        }

    }
}
