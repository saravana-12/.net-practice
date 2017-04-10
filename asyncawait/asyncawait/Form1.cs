using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asyncawait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int countall()
        {
            int count = 0;
            using (StreamReader read = new StreamReader("C:\\saro.txt"))
            {
                string cont = read.ReadToEnd();
                count = cont.Length;
                Thread.Sleep(5000);
            }
            return count;
        }

        private async void btnprocess_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(countall);
            task.Start();

            lblcount.Text ="processing file. please wait....";
            int count = await task;
            lblcount.Text = count.ToString() + " charaters in file";


        }
    }
}
