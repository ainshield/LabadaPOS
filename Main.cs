using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabadaPOS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void exitbtn_MouseHover(object sender, EventArgs e)
        {
            exitbtn.BackColor = Color.SkyBlue;
        }

        private void exitbtn_MouseLeave(object sender, EventArgs e)
        {
            exitbtn.BackColor = Color.DeepSkyBlue;
        }
    }
}
