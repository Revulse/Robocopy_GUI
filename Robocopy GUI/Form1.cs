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
            
            if (radio_button_Mirror.Checked == true
                && checkBox1.Checked == false)
            {
                Process.Start("robocopy.exe", sourceDir + " " + destinationDir + " /MIR /Z /V /XJ /SL /IT /MT"
                    + "pause");
            }
            else if (radio_button_CopyOverNewFiles.Checked == true
                && checkBox1.Checked == false)
            {
                Process.Start("robocopy.exe", sourceDir + " " + destinationDir + " /MIR /Z /V /XJ /SL /IT /MT");
            }
            else if (radio_button_CopyOverNewFiles.Checked == true
                && checkBox1.Checked == true)
            {
                Process.Start("robocopy.exe", sourceDir + " " + destinationDir + " /MIR /Z /V /XJ /SL /IT /MT");
            }
            else
            {
                MessageBox.Show("Invalid Selection");
            }
            
        }

    }
}
