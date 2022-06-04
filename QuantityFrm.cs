using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabadaPOS
{
    public partial class QuantityFrm : Form
    {
        public static QuantityFrm instance;
        public string qty { get; set; }
        public QuantityFrm()
        {
            InitializeComponent();
            instance = this;
            numericUpDown1.Value = 0;
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            
            qty = numericUpDown1.Value.ToString();
            this.Hide();
        }
    }
}
