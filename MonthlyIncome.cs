using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace LabadaPOS
{
    public partial class MonthlyIncome : Form
    {

        public MonthlyIncome()
        {
            InitializeComponent();

            string month = DateTime.Now.ToString("MMMM");
            string year = DateTime.Now.ToString("yyyy");
            string day = DateTime.Now.ToString("dd");
            month_txt.Text = month;
            year_txt.Text = year;
            day_txt.Text = day;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                string myConnection = @"Data Source=sales.db;Version=3;";
                SQLiteConnection con = new SQLiteConnection(myConnection, true);
                string query;

                if (total_check.Checked)
                {
                    if (day_txt.Text == "---")
                    {
                        query = "SELECT SUM(INCOME) AS 'TOTAL INCOME' FROM  SALES WHERE MONTH=@MONTH AND YEAR=@YEAR;";
                    }
                    else if (day_txt.Text == "---" && month_txt.Text == "---")
                    {
                        query = "SELECT SUM(INCOME) AS 'TOTAL INCOME' FROM  SALES WHERE YEAR=@YEAR;";
                    }
                    else
                    {
                        query = "SELECT SUM(INCOME) AS 'TOTAL INCOME' FROM SALES WHERE MONTH=@MONTH AND DAY=@DAY AND YEAR=@YEAR;";
                    }

                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@MONTH", month_txt.Text);
                    cmd.Parameters.AddWithValue("@YEAR", year_txt.Text);
                    cmd.Parameters.AddWithValue("@DAY", day_txt.Text);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    con.Open();
                    dgv1.DataSource = dt;
                    con.Close();
                }
                else {
                    if (day_txt.Text == "---")
                    {
                        query = "SELECT* FROM SALES WHERE MONTH=@MONTH AND YEAR=@YEAR;";
                    }
                    else if (day_txt.Text == "---" && month_txt.Text == "---")
                    {
                        query = "SELECT* FROM SALES WHERE YEAR=@YEAR;";
                    }
                    else
                    {
                        query = "SELECT* FROM SALES WHERE MONTH=@MONTH AND DAY=@DAY AND YEAR=@YEAR;";
                    }

                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@MONTH", month_txt.Text);
                    cmd.Parameters.AddWithValue("@YEAR", year_txt.Text);
                    cmd.Parameters.AddWithValue("@DAY", day_txt.Text);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    con.Open();
                    dgv1.DataSource = dt;
                    con.Close();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
