
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
            this.numericUpDown_heavy = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_medium = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_light = new System.Windows.Forms.NumericUpDown();
            this.heavybtn = new System.Windows.Forms.Button();
            this.mediumbtn = new System.Windows.Forms.Button();
            this.lightbtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dryclean_btn = new System.Windows.Forms.Button();
            this.machinewash_btn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.detergentbtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pickupbtn = new System.Windows.Forms.Button();
            this.deliverybtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.date_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tab3_btn = new System.Windows.Forms.Button();
            this.adminbtn = new System.Windows.Forms.Button();
            this.tab4_btn = new System.Windows.Forms.Button();
            this.tab2_btn = new System.Windows.Forms.Button();
            this.tab1_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.hvyqty_txt = new System.Windows.Forms.TextBox();
            this.mdqty_txt = new System.Windows.Forms.TextBox();
            this.ltqty_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pikupmthd_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lndrymthd_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.addons_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_heavy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_medium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_light)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(207, 54);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(765, 641);
            this.tabControl.TabIndex = 12;
            this.tabControl.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.numericUpDown_heavy);
            this.tabPage1.Controls.Add(this.numericUpDown_medium);
            this.tabPage1.Controls.Add(this.numericUpDown_light);
            this.tabPage1.Controls.Add(this.heavybtn);
            this.tabPage1.Controls.Add(this.mediumbtn);
            this.tabPage1.Controls.Add(this.lightbtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 613);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            // 
            // numericUpDown_heavy
            // 
            this.numericUpDown_heavy.Location = new System.Drawing.Point(379, 177);
            this.numericUpDown_heavy.Name = "numericUpDown_heavy";
            this.numericUpDown_heavy.Size = new System.Drawing.Size(150, 23);
            this.numericUpDown_heavy.TabIndex = 6;
            this.numericUpDown_heavy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_medium
            // 
            this.numericUpDown_medium.Location = new System.Drawing.Point(199, 177);
            this.numericUpDown_medium.Name = "numericUpDown_medium";
            this.numericUpDown_medium.Size = new System.Drawing.Size(150, 23);
            this.numericUpDown_medium.TabIndex = 5;
            this.numericUpDown_medium.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_light
            // 
            this.numericUpDown_light.Location = new System.Drawing.Point(20, 177);
            this.numericUpDown_light.Name = "numericUpDown_light";
            this.numericUpDown_light.Size = new System.Drawing.Size(150, 23);
            this.numericUpDown_light.TabIndex = 4;
            this.numericUpDown_light.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.dryclean_btn);
            this.tabPage2.Controls.Add(this.machinewash_btn);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 613);
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
            this.dryclean_btn.Click += new System.EventHandler(this.dryclean_btn_Click);
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
            this.machinewash_btn.Click += new System.EventHandler(this.machinewash_btn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.detergentbtn);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(757, 613);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "3";
            // 
            // detergentbtn
            // 
            this.detergentbtn.Image = global::LabadaPOS.Properties.Resources.icons8_detergent_100;
            this.detergentbtn.Location = new System.Drawing.Point(20, 21);
            this.detergentbtn.Name = "detergentbtn";
            this.detergentbtn.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.detergentbtn.Size = new System.Drawing.Size(150, 150);
            this.detergentbtn.TabIndex = 4;
            this.detergentbtn.Text = "Laundry Detergent ";
            this.detergentbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.detergentbtn.UseVisualStyleBackColor = true;
            this.detergentbtn.Click += new System.EventHandler(this.detergentbtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.pickupbtn);
            this.tabPage3.Controls.Add(this.deliverybtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(757, 613);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "4";
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
            this.pickupbtn.Click += new System.EventHandler(this.pickupbtn_Click);
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
            this.deliverybtn.Click += new System.EventHandler(this.deliverybtn_Click);
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
            this.panel2.Controls.Add(this.tab3_btn);
            this.panel2.Controls.Add(this.adminbtn);
            this.panel2.Controls.Add(this.tab4_btn);
            this.panel2.Controls.Add(this.tab2_btn);
            this.panel2.Controls.Add(this.tab1_btn);
            this.panel2.Location = new System.Drawing.Point(1, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 584);
            this.panel2.TabIndex = 11;
            // 
            // tab3_btn
            // 
            this.tab3_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tab3_btn.FlatAppearance.BorderSize = 0;
            this.tab3_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab3_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tab3_btn.ForeColor = System.Drawing.Color.White;
            this.tab3_btn.Image = global::LabadaPOS.Properties.Resources.add_40px;
            this.tab3_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab3_btn.Location = new System.Drawing.Point(12, 121);
            this.tab3_btn.Name = "tab3_btn";
            this.tab3_btn.Size = new System.Drawing.Size(173, 44);
            this.tab3_btn.TabIndex = 16;
            this.tab3_btn.Text = "Add-Ons";
            this.tab3_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab3_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tab3_btn.UseVisualStyleBackColor = true;
            this.tab3_btn.Click += new System.EventHandler(this.tab3_btn_Click);
            // 
            // adminbtn
            // 
            this.adminbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adminbtn.FlatAppearance.BorderSize = 0;
            this.adminbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adminbtn.ForeColor = System.Drawing.Color.White;
            this.adminbtn.Image = global::LabadaPOS.Properties.Resources.settings_40px;
            this.adminbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminbtn.Location = new System.Drawing.Point(12, 528);
            this.adminbtn.Name = "adminbtn";
            this.adminbtn.Size = new System.Drawing.Size(173, 44);
            this.adminbtn.TabIndex = 15;
            this.adminbtn.Text = "Admin Panel";
            this.adminbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adminbtn.UseVisualStyleBackColor = true;
            this.adminbtn.Click += new System.EventHandler(this.settingsbtn_Click);
            // 
            // tab4_btn
            // 
            this.tab4_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tab4_btn.FlatAppearance.BorderSize = 0;
            this.tab4_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab4_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tab4_btn.ForeColor = System.Drawing.Color.White;
            this.tab4_btn.Image = global::LabadaPOS.Properties.Resources.truck_40px;
            this.tab4_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab4_btn.Location = new System.Drawing.Point(12, 171);
            this.tab4_btn.Name = "tab4_btn";
            this.tab4_btn.Size = new System.Drawing.Size(173, 44);
            this.tab4_btn.TabIndex = 14;
            this.tab4_btn.Text = "Pickup Method";
            this.tab4_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab4_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tab4_btn.UseVisualStyleBackColor = true;
            this.tab4_btn.Click += new System.EventHandler(this.tab4_btn_Click);
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
            this.tab2_btn.Location = new System.Drawing.Point(12, 71);
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
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.hvyqty_txt);
            this.panel4.Controls.Add(this.mdqty_txt);
            this.panel4.Controls.Add(this.ltqty_txt);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(978, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 105);
            this.panel4.TabIndex = 18;
            // 
            // hvyqty_txt
            // 
            this.hvyqty_txt.BackColor = System.Drawing.Color.White;
            this.hvyqty_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hvyqty_txt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hvyqty_txt.Location = new System.Drawing.Point(200, 45);
            this.hvyqty_txt.Name = "hvyqty_txt";
            this.hvyqty_txt.ReadOnly = true;
            this.hvyqty_txt.Size = new System.Drawing.Size(85, 33);
            this.hvyqty_txt.TabIndex = 24;
            // 
            // mdqty_txt
            // 
            this.mdqty_txt.BackColor = System.Drawing.Color.White;
            this.mdqty_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mdqty_txt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mdqty_txt.Location = new System.Drawing.Point(102, 45);
            this.mdqty_txt.Name = "mdqty_txt";
            this.mdqty_txt.ReadOnly = true;
            this.mdqty_txt.Size = new System.Drawing.Size(85, 33);
            this.mdqty_txt.TabIndex = 23;
            // 
            // ltqty_txt
            // 
            this.ltqty_txt.BackColor = System.Drawing.Color.White;
            this.ltqty_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltqty_txt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ltqty_txt.Location = new System.Drawing.Point(3, 45);
            this.ltqty_txt.Name = "ltqty_txt";
            this.ltqty_txt.ReadOnly = true;
            this.ltqty_txt.Size = new System.Drawing.Size(85, 33);
            this.ltqty_txt.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(196, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Heavy (kg)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(88, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Medium (kg)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Light (kg)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pikupmthd_txt);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(978, 392);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 90);
            this.panel5.TabIndex = 19;
            // 
            // pikupmthd_txt
            // 
            this.pikupmthd_txt.BackColor = System.Drawing.Color.White;
            this.pikupmthd_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pikupmthd_txt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pikupmthd_txt.Location = new System.Drawing.Point(3, 40);
            this.pikupmthd_txt.Name = "pikupmthd_txt";
            this.pikupmthd_txt.ReadOnly = true;
            this.pikupmthd_txt.Size = new System.Drawing.Size(282, 33);
            this.pikupmthd_txt.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(65, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Pickup Method";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lndrymthd_txt);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(978, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 90);
            this.panel3.TabIndex = 20;
            // 
            // lndrymthd_txt
            // 
            this.lndrymthd_txt.BackColor = System.Drawing.Color.White;
            this.lndrymthd_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lndrymthd_txt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lndrymthd_txt.Location = new System.Drawing.Point(3, 40);
            this.lndrymthd_txt.Name = "lndrymthd_txt";
            this.lndrymthd_txt.ReadOnly = true;
            this.lndrymthd_txt.Size = new System.Drawing.Size(282, 33);
            this.lndrymthd_txt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(58, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Laundry Method";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirm_btn
            // 
            this.confirm_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirm_btn.Location = new System.Drawing.Point(1044, 505);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(148, 63);
            this.confirm_btn.TabIndex = 21;
            this.confirm_btn.Text = "Confirm Order";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.addons_txt);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(978, 296);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(290, 90);
            this.panel6.TabIndex = 20;
            // 
            // addons_txt
            // 
            this.addons_txt.BackColor = System.Drawing.Color.White;
            this.addons_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addons_txt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addons_txt.Location = new System.Drawing.Point(3, 40);
            this.addons_txt.Name = "addons_txt";
            this.addons_txt.ReadOnly = true;
            this.addons_txt.Size = new System.Drawing.Size(282, 33);
            this.addons_txt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(88, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Add-Ons";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_heavy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_medium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_light)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
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
        private System.Windows.Forms.Button tab4_btn;
        private System.Windows.Forms.Button heavybtn;
        private System.Windows.Forms.Button mediumbtn;
        private System.Windows.Forms.Button lightbtn;
        private System.Windows.Forms.Button adminbtn;
        private System.Windows.Forms.Button dryclean_btn;
        private System.Windows.Forms.Button machinewash_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown numericUpDown_heavy;
        private System.Windows.Forms.NumericUpDown numericUpDown_medium;
        private System.Windows.Forms.NumericUpDown numericUpDown_light;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button pickupbtn;
        private System.Windows.Forms.Button deliverybtn;
        private System.Windows.Forms.Button tab3_btn;
        private System.Windows.Forms.TextBox hvyqty_txt;
        private System.Windows.Forms.TextBox mdqty_txt;
        private System.Windows.Forms.TextBox ltqty_txt;
        private System.Windows.Forms.TextBox pikupmthd_txt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox lndrymthd_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox addons_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button detergentbtn;
    }
}