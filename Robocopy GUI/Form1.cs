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
            string command = "dir";
            System.Diagnostics.Process.Start("cmd.exe", command);
        }
    }
}
