namespace Hansab_slave_configurator
{
    partial class ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            this.Contacts_label = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NewPassLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.RepPasswordBox = new System.Windows.Forms.TextBox();
            this.RepeatPassLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Contacts_label
            // 
            this.Contacts_label.AutoSize = true;
            this.Contacts_label.Location = new System.Drawing.Point(23, 217);
            this.Contacts_label.Name = "Contacts_label";
            this.Contacts_label.Size = new System.Drawing.Size(52, 13);
            this.Contacts_label.TabIndex = 0;
            this.Contacts_label.Text = "Contacts:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(12, 233);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(264, 66);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "+37127845921 - Jānis Jānis - janisj@hansab.lv\n+37128355928 - Brālis Jānis - brali" +
    "sj@hansab.lv\n+37127845929 - Andris Jānis - andrisj@hansab.lv\n+37127845923 - Baņa" +
    " Jānis - banaj@hansab.lv";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 306);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // NewPassLabel
            // 
            this.NewPassLabel.AutoSize = true;
            this.NewPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.NewPassLabel.Location = new System.Drawing.Point(54, 66);
            this.NewPassLabel.Name = "NewPassLabel";
            this.NewPassLabel.Size = new System.Drawing.Size(191, 20);
            this.NewPassLabel.TabIndex = 5;
            this.NewPassLabel.Text = "Enter your new password:";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PasswordBox.Location = new System.Drawing.Point(76, 89);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(131, 26);
            this.PasswordBox.TabIndex = 6;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(102, 192);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 7;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.UsernameBox.Location = new System.Drawing.Point(76, 37);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(131, 26);
            this.UsernameBox.TabIndex = 9;
            this.UsernameBox.TextChanged += new System.EventHandler(this.UsernameBox_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.usernameLabel.Location = new System.Drawing.Point(98, 14);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(87, 20);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Username:";
            // 
            // RepPasswordBox
            // 
            this.RepPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.RepPasswordBox.Location = new System.Drawing.Point(76, 141);
            this.RepPasswordBox.Name = "RepPasswordBox";
            this.RepPasswordBox.PasswordChar = '*';
            this.RepPasswordBox.Size = new System.Drawing.Size(131, 26);
            this.RepPasswordBox.TabIndex = 11;
            this.RepPasswordBox.TextChanged += new System.EventHandler(this.RepPasswordBox_TextChanged);
            // 
            // RepeatPassLabel
            // 
            this.RepeatPassLabel.AutoSize = true;
            this.RepeatPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.RepeatPassLabel.Location = new System.Drawing.Point(54, 118);
            this.RepeatPassLabel.Name = "RepeatPassLabel";
            this.RepeatPassLabel.Size = new System.Drawing.Size(171, 20);
            this.RepeatPassLabel.TabIndex = 10;
            this.RepeatPassLabel.Text = "Repeat new password:";
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 359);
            this.Controls.Add(this.RepPasswordBox);
            this.Controls.Add(this.RepeatPassLabel);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.NewPassLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Contacts_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ForgotPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPass";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForgotPass_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Contacts_label;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NewPassLabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox RepPasswordBox;
        private System.Windows.Forms.Label RepeatPassLabel;
    }
}