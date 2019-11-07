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

namespace DriveMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } // end Form1()

        private void button1_Click(object sender, EventArgs e)
        {
            // textbox input
            string userinput = textBox1.Text;

            // letter variable - drive letter
            string letter = "P";

            var process = new Process();
            var startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "net.exe",
                Arguments = "USE " + letter + ": /DELETE"
            };
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();

            // ****
            string path = # Path of your drive;

            var pro = new Process();
            var psi = new ProcessStartInfo
            {
                //WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "net.exe",
                Arguments = "USE " + letter + ": " + path + @" #USERNAME" + userinput
            };
            pro.StartInfo = psi;
            pro.Start();
            pro.WaitForExit();

        } // end button1_Click

    } // end class
} // end namespace
