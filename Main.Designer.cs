
namespace LabadaPOS
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.exitbtn = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.heavybtn = new System.Windows.Forms.Button();
            this.mediumbtn = new System.Windows.Forms.Button();
            this.lightbtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dryclean_btn = new System.Windows.Forms.Button();
            this.machinewash_btn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pickupbtn = new System.Windows.Forms.Button();
            this.deliverybtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.date_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.settingsbtn = new System.Windows.Forms.Button();
            this.tab3_btn = new System.Windows.Forms.Button();
            this.tab2_btn = new System.Windows.Forms.Button();
            this.tab1_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ordergridview = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordergridview)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbtn
            // 
            this.exitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.exitbtn.Image = global::LabadaPOS.Properties.Resources.Close_40px;
            this.exitbtn.Location = new System.Drawing.Point(1240, 7);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(30, 30);
            this.exitbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitbtn.TabIndex = 7;
            this.exitbtn.TabStop = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            this.exitbtn.MouseLeave += new System.EventHandler(this.exitbtn_MouseLeave);
            this.exitbtn.MouseHover += new System.EventHandler(this.exitbtn_MouseHover);
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.logo.Image = global::LabadaPOS.Properties.Resources.washing_machine_40px;
            this.logo.Location = new System.Drawing.Point(15, 7);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(30, 30);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exitbtn);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 42);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "LabadaPOS";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(207, 54);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(765, 548);
            this.tabControl.TabIndex = 12;
            this.tabControl.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.heavybtn);
            this.tabPage1.Controls.Add(this.mediumbtn);
            this.tabPage1.Controls.Add(this.lightbtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            // 
            // heavybtn
            // 
            this.heavybtn.Image = global::LabadaPOS.Properties.Resources.carpet_120px;
            this.heavybtn.Location = new System.Drawing.Point(379, 21);
            this.heavybtn.Name = "heavybtn";
            this.heavybtn.Size = new System.Drawing.Size(150, 150);
            this.heavybtn.TabIndex = 3;
            this.heavybtn.Text = "Heavy ";
            this.heavybtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.heavybtn.UseVisualStyleBackColor = true;
            this.heavybtn.Click += new System.EventHandler(this.heavybtn_Click);
            // 
            // mediumbtn
            // 
            this.mediumbtn.Image = global::LabadaPOS.Properties.Resources.jeans_120px;
            this.mediumbtn.Location = new System.Drawing.Point(199, 21);
            this.mediumbtn.Name = "mediumbtn";
            this.mediumbtn.Size = new System.Drawing.Size(150, 150);
            this.mediumbtn.TabIndex = 1;
            this.mediumbtn.Text = "Medium";
            this.mediumbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mediumbtn.UseVisualStyleBackColor = true;
            this.mediumbtn.Click += new System.EventHandler(this.mediumbtn_Click);
            // 
            // lightbtn
            // 
            this.lightbtn.Image = global::LabadaPOS.Properties.Resources.coloredshirt_120px;
            this.lightbtn.Location = new System.Drawing.Point(20, 21);
            this.lightbtn.Name = "lightbtn";
            this.lightbtn.Size = new System.Drawing.Size(150, 150);
            this.lightbtn.TabIndex = 0;
            this.lightbtn.Text = "Light";
            this.lightbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.lightbtn.UseVisualStyleBackColor = true;
            this.lightbtn.Click += new System.EventHandler(this.lightbtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.dryclean_btn);
            this.tabPage2.Controls.Add(this.machinewash_btn);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2";
            // 
            // dryclean_btn
            // 
            this.dryclean_btn.Image = global::LabadaPOS.Properties.Resources.dryclean_120px;
            this.dryclean_btn.Location = new System.Drawing.Point(199, 21);
            this.dryclean_btn.Name = "dryclean_btn";
            this.dryclean_btn.Size = new System.Drawing.Size(150, 150);
            this.dryclean_btn.TabIndex = 3;
            this.dryclean_btn.Text = "Dry Clean";
            this.dryclean_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dryclean_btn.UseVisualStyleBackColor = true;
            // 
            // machinewash_btn
            // 
            this.machinewash_btn.Image = global::LabadaPOS.Properties.Resources.machine_wash_120px;
            this.machinewash_btn.Location = new System.Drawing.Point(20, 21);
            this.machinewash_btn.Name = "machinewash_btn";
            this.machinewash_btn.Size = new System.Drawing.Size(150, 150);
            this.machinewash_btn.TabIndex = 2;
            this.machinewash_btn.Text = "Machine Wash";
            this.machinewash_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.machinewash_btn.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.pickupbtn);
            this.tabPage3.Controls.Add(this.deliverybtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(757, 520);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3";
            // 
            // pickupbtn
            // 
            this.pickupbtn.Image = global::LabadaPOS.Properties.Resources.pickup_120px;
            this.pickupbtn.Location = new System.Drawing.Point(199, 21);
            this.pickupbtn.Name = "pickupbtn";
            this.pickupbtn.Size = new System.Drawing.Size(150, 150);
            this.pickupbtn.TabIndex = 4;
            this.pickupbtn.Text = "Pickup";
            this.pickupbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pickupbtn.UseVisualStyleBackColor = true;
            // 
            // deliverybtn
            // 
            this.deliverybtn.Image = global::LabadaPOS.Properties.Resources.delivery_120px;
            this.deliverybtn.Location = new System.Drawing.Point(20, 21);
            this.deliverybtn.Name = "deliverybtn";
            this.deliverybtn.Size = new System.Drawing.Size(150, 150);
            this.deliverybtn.TabIndex = 3;
            this.deliverybtn.Text = "Delivery";
            this.deliverybtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deliverybtn.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.date_time});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(204, 698);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(74, 20);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // date_time
            // 
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(59, 15);
            this.date_time.Text = "date_time";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.settingsbtn);
            this.panel2.Controls.Add(this.tab3_btn);
            this.panel2.Controls.Add(this.tab2_btn);
            this.panel2.Controls.Add(this.tab1_btn);
            this.panel2.Location = new System.Drawing.Point(1, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 584);
            this.panel2.TabIndex = 11;
            // 
            // settingsbtn
            // 
            this.settingsbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsbtn.FlatAppearance.BorderSize = 0;
            this.settingsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settingsbtn.ForeColor = System.Drawing.Color.White;
            this.settingsbtn.Image = global::LabadaPOS.Properties.Resources.settings_40px;
            this.settingsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsbtn.Location = new System.Drawing.Point(12, 528);
            this.settingsbtn.Name = "settingsbtn";
            this.settingsbtn.Size = new System.Drawing.Size(173, 44);
            this.settingsbtn.TabIndex = 15;
            this.settingsbtn.Text = "Settings";
            this.settingsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsbtn.UseVisualStyleBackColor = true;
            this.settingsbtn.Click += new System.EventHandler(this.settingsbtn_Click);
            // 
            // tab3_btn
            // 
            this.tab3_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tab3_btn.FlatAppearance.BorderSize = 0;
            this.tab3_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab3_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tab3_btn.ForeColor = System.Drawing.Color.White;
            this.tab3_btn.Image = global::LabadaPOS.Properties.Resources.truck_40px;
            this.tab3_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab3_btn.Location = new System.Drawing.Point(12, 127);
            this.tab3_btn.Name = "tab3_btn";
            this.tab3_btn.Size = new System.Drawing.Size(173, 44);
            this.tab3_btn.TabIndex = 14;
            this.tab3_btn.Text = "Pickup Method";
            this.tab3_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab3_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tab3_btn.UseVisualStyleBackColor = true;
            this.tab3_btn.Click += new System.EventHandler(this.tab3_btn_Click);
            // 
            // tab2_btn
            // 
            this.tab2_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tab2_btn.FlatAppearance.BorderSize = 0;
            this.tab2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab2_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tab2_btn.ForeColor = System.Drawing.Color.White;
            this.tab2_btn.Image = global::LabadaPOS.Properties.Resources.washing_machine_40px;
            this.tab2_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab2_btn.Location = new System.Drawing.Point(12, 73);
            this.tab2_btn.Name = "tab2_btn";
            this.tab2_btn.Size = new System.Drawing.Size(173, 44);
            this.tab2_btn.TabIndex = 13;
            this.tab2_btn.Text = "Laundry Method";
            this.tab2_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab2_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tab2_btn.UseVisualStyleBackColor = true;
            this.tab2_btn.Click += new System.EventHandler(this.tab2_btn_Click);
            // 
            // tab1_btn
            // 
            this.tab1_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tab1_btn.FlatAppearance.BorderSize = 0;
            this.tab1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab1_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tab1_btn.ForeColor = System.Drawing.Color.White;
            this.tab1_btn.Image = global::LabadaPOS.Properties.Resources.clothes_40px;
            this.tab1_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab1_btn.Location = new System.Drawing.Point(12, 21);
            this.tab1_btn.Name = "tab1_btn";
            this.tab1_btn.Size = new System.Drawing.Size(173, 44);
            this.tab1_btn.TabIndex = 12;
            this.tab1_btn.Text = "Laundry Type";
            this.tab1_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab1_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tab1_btn.UseVisualStyleBackColor = true;
            this.tab1_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(978, 605);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total";
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.total_lbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.total_lbl.Location = new System.Drawing.Point(1099, 609);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(165, 86);
            this.total_lbl.TabIndex = 15;
            this.total_lbl.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(1, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 65);
            this.label3.TabIndex = 16;
            this.label3.Text = "Register";
            // 
            // ordergridview
            // 
            this.ordergridview.AllowUserToAddRows = false;
            this.ordergridview.AllowUserToDeleteRows = false;
            this.ordergridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordergridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ITEM,
            this.QUANTITY,
            this.PRICE});
            this.ordergridview.Location = new System.Drawing.Point(978, 78);
            this.ordergridview.Name = "ordergridview";
            this.ordergridview.RowHeadersWidth = 10;
            this.ordergridview.RowTemplate.Height = 25;
            this.ordergridview.Size = new System.Drawing.Size(286, 524);
            this.ordergridview.TabIndex = 17;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 30;
            // 
            // ITEM
            // 
            this.ITEM.HeaderText = "ITEM";
            this.ITEM.Name = "ITEM";
            this.ITEM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ITEM.Width = 130;
            // 
            // QUANTITY
            // 
            this.QUANTITY.HeaderText = "QTY";
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.QUANTITY.Width = 50;
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.Name = "PRICE";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.ordergridview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordergridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox exitbtn;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel date_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button tab1_btn;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button tab2_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button tab3_btn;
        private System.Windows.Forms.Button heavybtn;
        private System.Windows.Forms.Button mediumbtn;
        private System.Windows.Forms.Button lightbtn;
        private System.Windows.Forms.Button settingsbtn;
        private System.Windows.Forms.Button dryclean_btn;
        private System.Windows.Forms.Button machinewash_btn;
        private System.Windows.Forms.Button deliverybtn;
        private System.Windows.Forms.Button pickupbtn;
        private System.Windows.Forms.DataGridView ordergridview;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
    }
}