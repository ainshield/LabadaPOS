using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data.SqlTypes;

namespace LabadaPOS
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {

            InitializeComponent();
           
        }



        public void dbConn() {

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
            
            
            if (pin_txtbx.Text.Trim() == "")
            {
                MessageBox.Show("Field is Empty", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else if (pin_txtbx.Text == "!1342!")
            {
                checkdbcon.Visible = true;
            }
            else
            {
                string myConnection = "Data Source=logindata.db;Version=3;";
                SQLiteConnection con = new SQLiteConnection(myConnection, true);
                string query = "SELECT* FROM USERLOGIN WHERE PIN=@PIN";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@PIN", pin_txtbx.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Open();
                if (dt.Rows.Count > 0)
                {

                    var Main = new Main();
                    Main.Show();
                    this.Hide();
                    con.Close();

                }
                else {

                    MessageBox.Show("Invalid PIN", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                
                
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            date_time.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
        }

        private void checkdbcon_Click(object sender, EventArgs e)
        {
            string myConnection = "Data Source=logindata.db;Version=3;";
            SQLiteConnection con = new SQLiteConnection(myConnection, true);

            if (myConnection != null && con.State == ConnectionState.Closed)
            {
                MessageBox.Show("Database Disconnected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkdbcon.Visible = false;
            }
            else {
                MessageBox.Show("Database Connected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkdbcon.Visible = false;
            }
        }
    }
}
