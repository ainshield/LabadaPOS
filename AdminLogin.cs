using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;


namespace LabadaPOS
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (username.Text.Trim() == "" && password.Text.Trim() == "")
            {
                MessageBox.Show("Field is Empty", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (username.Text == "" && password.Text == "!1342!")
            {
                string myConnection = "Data Source=logindata.db;Version=3;";
                SQLiteConnection con = new SQLiteConnection(myConnection, true);

                if (myConnection != null && con.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Database Disconnected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Database Connected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                try
                {
                    string myConnection = "Data Source=logindata.db;Version=3;";
                    SQLiteConnection con = new SQLiteConnection(myConnection, true);
                    string query = "SELECT* FROM ADMINLOGIN WHERE USERNAME = @USERNAME AND PASSWORD = @PASSWORD;";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@USERNAME", username.Text);
                    cmd.Parameters.AddWithValue("@PASSWORD", password.Text);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Open();
                    if (dt.Rows.Count > 0)
                    {

                        var monthlyincome = new MonthlyIncome();
                        monthlyincome.Show();
                        this.Hide();
                        con.Close();

                    }
                    else
                    {

                        MessageBox.Show("Invalid PIN", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
