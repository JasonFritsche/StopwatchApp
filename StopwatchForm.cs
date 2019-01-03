using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopwatchApp
{
    public partial class StopwatchForm : Form
    {

        Stopwatch watch = new Stopwatch();

        public StopwatchForm()
        {
            InitializeComponent();
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtBox.Text = watch.Start();


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            txtBox.Text = watch.Stop();
        }

        private void StopwatchForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
