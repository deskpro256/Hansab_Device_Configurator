namespace Hansab_Parking_Configurator
{
    partial class NewMAC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMAC));
            this.Sendbutton = new System.Windows.Forms.Button();
            this.NewMACLabel = new System.Windows.Forms.Label();
            this.MAC1 = new System.Windows.Forms.TextBox();
            this.MAC2 = new System.Windows.Forms.TextBox();
            this.MAC3 = new System.Windows.Forms.TextBox();
            this.MAC4 = new System.Windows.Forms.TextBox();
            this.MAC5 = new System.Windows.Forms.TextBox();
            this.MAC6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Sendbutton
            // 
            this.Sendbutton.Location = new System.Drawing.Point(71, 78);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(99, 23);
            this.Sendbutton.TabIndex = 1;
            this.Sendbutton.Text = "Set MAC address";
            this.Sendbutton.UseVisualStyleBackColor = true;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // NewMACLabel
            // 
            this.NewMACLabel.AutoSize = true;
            this.NewMACLabel.Location = new System.Drawing.Point(71, 18);
            this.NewMACLabel.Name = "NewMACLabel";
            this.NewMACLabel.Size = new System.Drawing.Size(99, 13);
            this.NewMACLabel.TabIndex = 1;
            this.NewMACLabel.Text = "New MAC Address:";
            // 
            // MAC1
            // 
            this.MAC1.Location = new System.Drawing.Point(12, 43);
            this.MAC1.Name = "MAC1";
            this.MAC1.Size = new System.Drawing.Size(30, 20);
            this.MAC1.TabIndex = 90;
            this.MAC1.Text = "B2";
            this.MAC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MAC2
            // 
            this.MAC2.Location = new System.Drawing.Point(48, 43);
            this.MAC2.Name = "MAC2";
            this.MAC2.Size = new System.Drawing.Size(30, 20);
            this.MAC2.TabIndex = 90;
            this.MAC2.Text = "E7";
            this.MAC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MAC3
            // 
            this.MAC3.Location = new System.Drawing.Point(84, 43);
            this.MAC3.Name = "MAC3";
            this.MAC3.Size = new System.Drawing.Size(30, 20);
            this.MAC3.TabIndex = 92;
            this.MAC3.Text = "53";
            this.MAC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MAC4
            // 
            this.MAC4.Location = new System.Drawing.Point(120, 43);
            this.MAC4.Name = "MAC4";
            this.MAC4.Size = new System.Drawing.Size(30, 20);
            this.MAC4.TabIndex = 3;
            this.MAC4.Text = "44";
            this.MAC4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MAC5
            // 
            this.MAC5.Location = new System.Drawing.Point(156, 43);
            this.MAC5.Name = "MAC5";
            this.MAC5.Size = new System.Drawing.Size(30, 20);
            this.MAC5.TabIndex = 1;
            this.MAC5.Text = "74";
            this.MAC5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MAC6
            // 
            this.MAC6.Location = new System.Drawing.Point(192, 43);
            this.MAC6.Name = "MAC6";
            this.MAC6.Size = new System.Drawing.Size(30, 20);
            this.MAC6.TabIndex = 0;
            this.MAC6.Text = "00";
            this.MAC6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewMAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 125);
            this.Controls.Add(this.MAC6);
            this.Controls.Add(this.MAC5);
            this.Controls.Add(this.MAC4);
            this.Controls.Add(this.MAC3);
            this.Controls.Add(this.MAC2);
            this.Controls.Add(this.MAC1);
            this.Controls.Add(this.NewMACLabel);
            this.Controls.Add(this.Sendbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewMAC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New MAC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewMAC_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sendbutton;
        private System.Windows.Forms.Label NewMACLabel;
        private System.Windows.Forms.TextBox MAC1;
        private System.Windows.Forms.TextBox MAC2;
        private System.Windows.Forms.TextBox MAC3;
        private System.Windows.Forms.TextBox MAC4;
        private System.Windows.Forms.TextBox MAC5;
        private System.Windows.Forms.TextBox MAC6;
    }
}