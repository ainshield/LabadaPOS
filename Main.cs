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
using System.IO;

namespace LabadaPOS
{
    public partial class Main : Form
    {
        public double formula { get; set; }

        public static Main instance;
        public Main()
        {
            InitializeComponent();
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            
        }
        public void ChangeLabelText()
        {
            double lt = 35;
            double md = 55;
            double hvy = 75;

            double ltkilo = double.Parse(ltqty_txt.Text);
            double hvykilo = double.Parse(hvyqty_txt.Text);
            double mdkilo = double.Parse(mdqty_txt.Text);
            double kilos = ltkilo + hvykilo + mdkilo;
            double lttotal = ltkilo * lt;
            double mdtotal = mdkilo * md;
            double hvytotal = hvykilo * hvy;
            double kilototal = lttotal + mdtotal + hvytotal;

            double addons = kilos * 15;
            double delivery;

            if (pikupmthd_txt.Text == "Delivery")
            {
                delivery = 30;
            }
            else
            {
                delivery = 0;
            }


            if (addons_txt.Text == "Laundry Detergent" && pikupmthd_txt.Text == "Delivery")
            {
                formula = kilototal + addons + delivery;
            }
            else if (addons_txt.Text != "Laundry Detergent" && pikupmthd_txt.Text == "Delivery")
            {
                formula = kilototal + delivery;
            }
            else if (addons_txt.Text == "Laundry Detergent" && pikupmthd_txt.Text != "Delivery")
            {
                formula = kilototal + addons;
            }
            else
            {
                formula = kilototal;
            }
            total_txt.Text = formula.ToString("F2");
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            date_time.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(0);
        }

        private void tab2_btn_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(1);
        }
        private void tab3_btn_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(2);
        }

        private void tab4_btn_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(3);
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            var adminlogin = new AdminLogin();
            adminlogin.Show();
        }

        private void machinewash_btn_Click(object sender, EventArgs e)
        {

            lndrymthd_txt.Text = "Machine Wash";

        }

        private void dryclean_btn_Click(object sender, EventArgs e)
        {

            lndrymthd_txt.Text = "Dry Clean (currently unavailable)";
            MessageBox.Show("Dry Clean is currently unavailable.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void detergentbtn_Click(object sender, EventArgs e)
        {
            if (addons_txt.Text == "none")
            {
                addons_txt.Text = "Laundry Detergent";
            }
            else {
                addons_txt.Text = "none";
            }
            
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            string day = DateTime.Now.ToString("dd");
            string month = DateTime.Now.ToString("MMMM");
            string year = DateTime.Now.ToString("yyyy");

            DialogResult dr = MessageBox.Show(
                "Confirm transaction?", "LabadaPOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {

                try
                {
                    //string fileName = "sales.db";
                    //string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);

                    string myConnection = @"Data Source=sales.db;Version=3;";
                    SQLiteConnection con = new SQLiteConnection(myConnection, true);
                    string insert = "INSERT INTO SALES(MONTH, DAY, YEAR, INCOME) VALUES(@MONTH,@DAY,@YEAR,@INCOME);";
                    SQLiteCommand cmd = new SQLiteCommand(insert,con);                  
                    cmd.Parameters.AddWithValue("@MONTH", month);
                    cmd.Parameters.AddWithValue("@DAY", day);
                    cmd.Parameters.AddWithValue("@YEAR", year);
                    cmd.Parameters.AddWithValue("@INCOME", total_txt.Text);
                    
                    con.Open();
                    int i = cmd.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show("Transaction complete.", "LabadaPOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    
                    
                    con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else { 
                
            }
        }

        private void deliverybtn_Click(object sender, EventArgs e)
        {
            pikupmthd_txt.Text = "Delivery";
        }

        private void pickupbtn_Click(object sender, EventArgs e)
        {
            pikupmthd_txt.Text = "Pickup";
        }

        private void numericUpDown_light_ValueChanged(object sender, EventArgs e)
        {
            string ltqty = numericUpDown_light.Value.ToString();
            ltqty_txt.Text = ltqty;
        }

        private void numericUpDown_medium_ValueChanged(object sender, EventArgs e)
        {
            string mdqty = numericUpDown_medium.Value.ToString();
            mdqty_txt.Text = mdqty;
        }

        private void numericUpDown_heavy_ValueChanged(object sender, EventArgs e)
        {
            string hvyqty = numericUpDown_heavy.Value.ToString();
            hvyqty_txt.Text = hvyqty;
        }

        private void ltqty_txt_TextChanged(object sender, EventArgs e)
        {
            ChangeLabelText();
        }

        private void mdqty_txt_TextChanged(object sender, EventArgs e)
        {
            ChangeLabelText();
        }

        private void hvyqty_txt_TextChanged(object sender, EventArgs e)
        {
            ChangeLabelText();
        }

        private void lndrymthd_txt_TextChanged(object sender, EventArgs e)
        {
            ChangeLabelText();
        }

        private void addons_txt_TextChanged(object sender, EventArgs e)
        {
            ChangeLabelText();
        }

        private void pikupmthd_txt_TextChanged(object sender, EventArgs e)
        {
            ChangeLabelText();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            DialogResult cancel = MessageBox.Show("Cancel Order?", "LabadaPOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cancel == DialogResult.Yes) {

                ltqty_txt.Text = "0";
                mdqty_txt.Text = "0";
                hvyqty_txt.Text = "0";
                lndrymthd_txt.Text = "Machine Wash";
                addons_txt.Text = "none";
                pikupmthd_txt.Text = "Pickup";
                numericUpDown_light.Value = 0;
                numericUpDown_medium.Value = 0;
                numericUpDown_heavy.Value = 0;
            }
            else { }

        }
    }
}
