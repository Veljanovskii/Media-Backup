using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Media_Backup
{
    public partial class ProgressBarForm : Form
    {
        public ProgressBarForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void ProgressBarForm_Load(object sender, EventArgs e)
        {
            pgb_bar.Maximum = 1000000;
            pgb_bar.Minimum = 0;
            pgb_bar.Step = 1;
            pgb_bar.Style = ProgressBarStyle.Blocks;
            for (int i = 0; i < 1000000; i++)
                pgb_bar.Value = i;
        }
    }
}
