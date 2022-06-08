using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data.SqlTypes;

namespace LabadaPOS
{
    public partial class MonthlyIncome : Form
    {
        public MonthlyIncome()
        {
            InitializeComponent();

            string month = DateTime.Now.ToString("MMMM");
            string year = DateTime.Now.ToString("yyyy");
            month_txt.Text = month;
            year_txt.Text = year;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //string fileName = "sales.db";
                //string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);

                string myConnection = @"Data Source=sales.db;Version=3;";
                SQLiteConnection con = new SQLiteConnection(myConnection, true);
                string query = "SELECT* FROM SALES WHERE MONTH=@MONTH AND YEAR=@YEAR;";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@MONTH", month_txt.Text);
                cmd.Parameters.AddWithValue("@YEAR", year_txt.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                con.Open();
                dgv1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
