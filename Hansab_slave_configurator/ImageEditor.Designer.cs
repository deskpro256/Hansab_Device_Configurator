namespace Hansab_slave_configurator
{
    partial class ImageEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageEditor));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.LoadSaveBox = new System.Windows.Forms.GroupBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.AddItemsBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Text_Btn = new System.Windows.Forms.Button();
            this.Loop_Btn = new System.Windows.Forms.Button();
            this.Display_Btn = new System.Windows.Forms.Button();
            this.Slave_Btn = new System.Windows.Forms.Button();
            this.Interface_Btn = new System.Windows.Forms.Button();
            this.PC_Btn = new System.Windows.Forms.Button();
            this.ImageGroupBox = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.LoadSaveBox.SuspendLayout();
            this.AddItemsBox.SuspendLayout();
            this.ImageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "ParkingPlanImage.jpg";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            // 
            // PictureBox
            // 
            this.PictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(3, 16);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(820, 568);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDoubleClick);
            // 
            // LoadSaveBox
            // 
            this.LoadSaveBox.Controls.Add(this.SaveBtn);
            this.LoadSaveBox.Controls.Add(this.LoadBtn);
            this.LoadSaveBox.Location = new System.Drawing.Point(12, 12);
            this.LoadSaveBox.Name = "LoadSaveBox";
            this.LoadSaveBox.Size = new System.Drawing.Size(128, 87);
            this.LoadSaveBox.TabIndex = 1;
            this.LoadSaveBox.TabStop = false;
            this.LoadSaveBox.Text = "Load/save image";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(25, 48);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(25, 19);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 2;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // AddItemsBox
            // 
            this.AddItemsBox.Controls.Add(this.textBox1);
            this.AddItemsBox.Controls.Add(this.Text_Btn);
            this.AddItemsBox.Controls.Add(this.Loop_Btn);
            this.AddItemsBox.Controls.Add(this.Display_Btn);
            this.AddItemsBox.Controls.Add(this.Slave_Btn);
            this.AddItemsBox.Controls.Add(this.Interface_Btn);
            this.AddItemsBox.Controls.Add(this.PC_Btn);
            this.AddItemsBox.Location = new System.Drawing.Point(12, 126);
            this.AddItemsBox.Name = "AddItemsBox";
            this.AddItemsBox.Size = new System.Drawing.Size(128, 233);
            this.AddItemsBox.TabIndex = 4;
            this.AddItemsBox.TabStop = false;
            this.AddItemsBox.Text = "Add items";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Text_Btn
            // 
            this.Text_Btn.Location = new System.Drawing.Point(25, 174);
            this.Text_Btn.Name = "Text_Btn";
            this.Text_Btn.Size = new System.Drawing.Size(75, 23);
            this.Text_Btn.TabIndex = 5;
            this.Text_Btn.Text = "Text";
            this.Text_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Text_Btn.UseVisualStyleBackColor = true;
            this.Text_Btn.Click += new System.EventHandler(this.Text_Btn_Click);
            // 
            // Loop_Btn
            // 
            this.Loop_Btn.Location = new System.Drawing.Point(25, 145);
            this.Loop_Btn.Name = "Loop_Btn";
            this.Loop_Btn.Size = new System.Drawing.Size(75, 23);
            this.Loop_Btn.TabIndex = 4;
            this.Loop_Btn.Text = "Loop";
            this.Loop_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Loop_Btn.UseVisualStyleBackColor = true;
            this.Loop_Btn.Click += new System.EventHandler(this.Loop_Btn_Click);
            // 
            // Display_Btn
            // 
            this.Display_Btn.Location = new System.Drawing.Point(25, 116);
            this.Display_Btn.Name = "Display_Btn";
            this.Display_Btn.Size = new System.Drawing.Size(75, 23);
            this.Display_Btn.TabIndex = 3;
            this.Display_Btn.Text = "Display";
            this.Display_Btn.UseVisualStyleBackColor = true;
            this.Display_Btn.Click += new System.EventHandler(this.Display_Btn_Click);
            // 
            // Slave_Btn
            // 
            this.Slave_Btn.Location = new System.Drawing.Point(25, 87);
            this.Slave_Btn.Name = "Slave_Btn";
            this.Slave_Btn.Size = new System.Drawing.Size(75, 23);
            this.Slave_Btn.TabIndex = 2;
            this.Slave_Btn.Text = "Slave";
            this.Slave_Btn.UseVisualStyleBackColor = true;
            this.Slave_Btn.Click += new System.EventHandler(this.Slave_Btn_Click);
            // 
            // Interface_Btn
            // 
            this.Interface_Btn.Location = new System.Drawing.Point(25, 58);
            this.Interface_Btn.Name = "Interface_Btn";
            this.Interface_Btn.Size = new System.Drawing.Size(75, 23);
            this.Interface_Btn.TabIndex = 1;
            this.Interface_Btn.Text = "Interface";
            this.Interface_Btn.UseVisualStyleBackColor = true;
            this.Interface_Btn.Click += new System.EventHandler(this.Interface_Btn_Click);
            // 
            // PC_Btn
            // 
            this.PC_Btn.Location = new System.Drawing.Point(25, 29);
            this.PC_Btn.Name = "PC_Btn";
            this.PC_Btn.Size = new System.Drawing.Size(75, 23);
            this.PC_Btn.TabIndex = 0;
            this.PC_Btn.Text = "PC";
            this.PC_Btn.UseVisualStyleBackColor = true;
            this.PC_Btn.Click += new System.EventHandler(this.PC_Btn_Click);
            // 
            // ImageGroupBox
            // 
            this.ImageGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ImageGroupBox.Controls.Add(this.PictureBox);
            this.ImageGroupBox.Location = new System.Drawing.Point(146, 12);
            this.ImageGroupBox.Name = "ImageGroupBox";
            this.ImageGroupBox.Size = new System.Drawing.Size(826, 587);
            this.ImageGroupBox.TabIndex = 3;
            this.ImageGroupBox.TabStop = false;
            this.ImageGroupBox.Text = "Image";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pc.png");
            this.imageList1.Images.SetKeyName(1, "interface.png");
            this.imageList1.Images.SetKeyName(2, "slave.png");
            this.imageList1.Images.SetKeyName(3, "display.png");
            this.imageList1.Images.SetKeyName(4, "loop.png");
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "ParkingPlanImage.jpg";
            this.saveFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            // 
            // ImageEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.ImageGroupBox);
            this.Controls.Add(this.AddItemsBox);
            this.Controls.Add(this.LoadSaveBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "ImageEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageEditor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.LoadSaveBox.ResumeLayout(false);
            this.AddItemsBox.ResumeLayout(false);
            this.AddItemsBox.PerformLayout();
            this.ImageGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.GroupBox LoadSaveBox;
        private System.Windows.Forms.GroupBox AddItemsBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.GroupBox ImageGroupBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button PC_Btn;
        private System.Windows.Forms.Button Loop_Btn;
        private System.Windows.Forms.Button Display_Btn;
        private System.Windows.Forms.Button Slave_Btn;
        private System.Windows.Forms.Button Interface_Btn;
        private System.Windows.Forms.Button Text_Btn;
        private System.Windows.Forms.TextBox textBox1;
    }
}