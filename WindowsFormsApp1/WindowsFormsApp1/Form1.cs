using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task temp = DoAsync();
            Debug.WriteLine("Continue");
            //temp.Wait();
            Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);
            await temp.ConfigureAwait(false);
            Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Debug.WriteLine("Not Deadlock");
        }

        private async Task DoAsync()
        {
            Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(TimeSpan.FromSeconds(3)).ConfigureAwait(false);
            Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }
    }
}
