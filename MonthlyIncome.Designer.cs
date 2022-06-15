
namespace LabadaPOS
{
    partial class MonthlyIncome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyIncome));
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.month_txt = new System.Windows.Forms.ComboBox();
            this.year_txt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.day_txt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.income_total = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.date_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 35);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.Size = new System.Drawing.Size(776, 431);
            this.dgv1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Month:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year:";
            // 
            // month_txt
            // 
            this.month_txt.FormattingEnabled = true;
            this.month_txt.Items.AddRange(new object[] {
            "---",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.month_txt.Location = new System.Drawing.Point(64, 6);
            this.month_txt.Name = "month_txt";
            this.month_txt.Size = new System.Drawing.Size(121, 23);
            this.month_txt.TabIndex = 5;
            this.month_txt.Text = "---";
            this.month_txt.TextChanged += new System.EventHandler(this.month_txt_TextChanged);
            // 
            // year_txt
            // 
            this.year_txt.FormattingEnabled = true;
            this.year_txt.Items.AddRange(new object[] {
            "---",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032"});
            this.year_txt.Location = new System.Drawing.Point(324, 6);
            this.year_txt.Name = "year_txt";
            this.year_txt.Size = new System.Drawing.Size(121, 23);
            this.year_txt.TabIndex = 6;
            this.year_txt.Text = "---";
            this.year_txt.TextChanged += new System.EventHandler(this.year_txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Day:";
            // 
            // day_txt
            // 
            this.day_txt.FormattingEnabled = true;
            this.day_txt.Items.AddRange(new object[] {
            "---",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.day_txt.Location = new System.Drawing.Point(227, 6);
            this.day_txt.Name = "day_txt";
            this.day_txt.Size = new System.Drawing.Size(53, 23);
            this.day_txt.TabIndex = 9;
            this.day_txt.Text = "---";
            this.day_txt.TextChanged += new System.EventHandler(this.day_txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(662, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total Income:";
            // 
            // income_total
            // 
            this.income_total.AutoSize = true;
            this.income_total.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.income_total.Location = new System.Drawing.Point(716, 494);
            this.income_total.Name = "income_total";
            this.income_total.Size = new System.Drawing.Size(72, 40);
            this.income_total.TabIndex = 12;
            this.income_total.Text = "0.00";
            this.income_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.date_time});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(801, 20);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // date_time
            // 
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(59, 15);
            this.date_time.Text = "date_time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MonthlyIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 560);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.income_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.day_txt);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.year_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.month_txt);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MonthlyIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Income";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox month_txt;
        private System.Windows.Forms.ComboBox year_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox day_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label income_total;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel date_time;
        private System.Windows.Forms.Timer timer1;
    }
}