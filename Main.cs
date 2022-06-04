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
        public static Main instance;
        public Main()
        {
            InitializeComponent();
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            instance = this;
        }                                  

        public DataTable GetDataTable(){
          
            DataTable dt = new DataTable();
            DataColumn id = dt.Columns.Add("ID", typeof(Int32));
            id.AllowDBNull = false;
            id.Unique = true;
            dt.Columns.Add("ITEM", typeof(String));
            dt.Columns.Add("QUANTITY", typeof(String));
            dt.Columns.Add("PRICE", typeof(String));

            DataRow row = null;
            foreach (DataGridViewRow dr in ordergridview.Rows)
            {
                row = dt.NewRow();
                row["ID"] = dr.Cells["ID"].Value;
                row["ITEM"] = dr.Cells["ITEM"].Value;
                row["QUANTITY"] = dr.Cells["QUANTITY"].Value;
                row["PRICE"] = dr.Cells["PRICE"].Value;
                dt.Rows.Add(row);
            }

            return dt;
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

        private void lightbtn_Click(object sender, EventArgs e)
        {
            
            var qtyfrm = new QuantityFrm();
            string quantity = qtyfrm.qty;
            string[] light = new string[] {"", "Laundry_LIGHT", quantity, "35" };
            qtyfrm.Show();
            ordergridview.Rows.Add(light);
        }

        

        private void mediumbtn_Click(object sender, EventArgs e)
        {

        }

        private void heavybtn_Click(object sender, EventArgs e)
        {

        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
