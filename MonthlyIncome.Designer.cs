
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyIncome));
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.month_txt = new System.Windows.Forms.ComboBox();
            this.year_txt = new System.Windows.Forms.ComboBox();
            this.searchbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(191, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year:";
            // 
            // month_txt
            // 
            this.month_txt.FormattingEnabled = true;
            this.month_txt.Items.AddRange(new object[] {
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
            // 
            // year_txt
            // 
            this.year_txt.FormattingEnabled = true;
            this.year_txt.Location = new System.Drawing.Point(229, 6);
            this.year_txt.Name = "year_txt";
            this.year_txt.Size = new System.Drawing.Size(121, 23);
            this.year_txt.TabIndex = 6;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(370, 6);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 7;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // MonthlyIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.year_txt);
            this.Controls.Add(this.month_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MonthlyIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Income";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox month_txt;
        private System.Windows.Forms.ComboBox year_txt;
        private System.Windows.Forms.Button searchbtn;
    }
}