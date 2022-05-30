using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabadaPOS
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
            date_time.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
        }

        private void exitbtn_MouseHover(object sender, EventArgs e)
        {
            exitbtn.BackColor = Color.SkyBlue;
        }

        private void exitbtn_MouseLeave(object sender, EventArgs e)
        {
            exitbtn.BackColor = Color.DeepSkyBlue;
        }

        private void pin_txtbx_TextChanged(object sender, EventArgs e)
        {
            pin_txtbx.PasswordChar = '*';
            pin_txtbx.ForeColor = Color.Black;

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            
            string pin = "123456";
            if (pin_txtbx.Text == pin)
            {
                var Main = new Main();
                Main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid PIN", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pin_txtbx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pin_txtbx.Clear();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
