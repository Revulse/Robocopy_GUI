using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            System.Diagnostics.Process.Start("cmd.exe", Switches);
        }

        private string Switches()
        {
            if (radio_button_Mirror.Checked == true
                && checkBox1.Checked == false)
            {
                return "robocopy ";
            }
            else if (radio_button_CopyOverNewFiles.Checked == true
                && checkBox1.Checked == false)
            {

            }
            else if (radio_button_CopyOverNewFiles.Checked == true
                && checkBox1.Checked == true)
            {

            }
            else
            {
                return "Invalid Selection";
            }

        }
    }
}
