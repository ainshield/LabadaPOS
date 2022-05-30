
namespace LabadaPOS
{
    partial class LoginFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pin_txtbx = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.exitbtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.date_time = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LabadaPOS.Properties.Resources.user_120px;
            this.pictureBox2.Location = new System.Drawing.Point(231, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pin_txtbx
            // 
            this.pin_txtbx.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.pin_txtbx.Location = new System.Drawing.Point(241, 292);
            this.pin_txtbx.Name = "pin_txtbx";
            this.pin_txtbx.Size = new System.Drawing.Size(100, 23);
            this.pin_txtbx.TabIndex = 2;
            this.pin_txtbx.Text = "4-digit PIN";
            this.pin_txtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pin_txtbx.TextChanged += new System.EventHandler(this.pin_txtbx_TextChanged);
            this.pin_txtbx.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pin_txtbx_MouseDoubleClick);
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.header.Location = new System.Drawing.Point(-1, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(585, 42);
            this.header.TabIndex = 3;
            this.header.TabStop = false;
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.logo.Image = global::LabadaPOS.Properties.Resources.washing_machine_40px;
            this.logo.Location = new System.Drawing.Point(12, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(30, 30);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // exitbtn
            // 
            this.exitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.exitbtn.Image = global::LabadaPOS.Properties.Resources.Close_40px1;
            this.exitbtn.Location = new System.Drawing.Point(542, 6);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(30, 30);
            this.exitbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitbtn.TabIndex = 6;
            this.exitbtn.TabStop = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            this.exitbtn.MouseLeave += new System.EventHandler(this.exitbtn_MouseLeave);
            this.exitbtn.MouseHover += new System.EventHandler(this.exitbtn_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "LabadaPOS";
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(251, 321);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 8;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.date_time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // date_time
            // 
            this.date_time.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(64, 17);
            this.date_time.Text = "date_time";
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.pin_txtbx);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox pin_txtbx;
        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox exitbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel date_time;
    }
}

