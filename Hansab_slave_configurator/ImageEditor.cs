using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hansab_slave_configurator
{
    public partial class ImageEditor : Form
    {
        Bitmap Canvas;
        String FileName = "PlanImage.jpg";
        String ItemText = "";
        Image PlanImage;
        readonly Font fnt = new Font("Arial", 10);
        int currentItem = 9;
        readonly int headRoom = 20;
        bool newItemAdded = false;
        Point point;
        float stretch_X;
        float stretch_Y;


        public ImageEditor()
        {
            InitializeComponent();
            SaveBtn.Enabled = false;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                PlanImage = Image.FromFile(openFileDialog1.FileName);
                Canvas = new Bitmap(PlanImage);
                PictureBox.Image = Canvas;
                PictureBox.Height = ImageGroupBox.Height;
                PictureBox.Width = ImageGroupBox.Width;
                stretch_X = PlanImage.Width / (float)PictureBox.Width;
                stretch_Y = PlanImage.Height / (float)PictureBox.Height;
                SaveBtn.Enabled = true;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString();
            try
            {
                saveFileDialog1.ShowDialog();
                FileName = saveFileDialog1.FileName;
                PictureBox.Image.Save(FileName);
            }
            catch (Exception)
            {
            }
        }

        private void PictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                point.X = e.X;
                point.Y = e.Y;
                Graphics g;
                g = Graphics.FromImage(Canvas);
                if (currentItem == 0)
                {
                    g.DrawImage(imageList1.Images[currentItem], (point.X * stretch_X), (point.Y * stretch_Y));
                    g.DrawString("[PC]", fnt, System.Drawing.Brushes.Blue, (point.X * stretch_X), (point.Y * stretch_Y) - headRoom);
                }
                else if (currentItem == 1)
                {
                    g.DrawImage(imageList1.Images[currentItem], (point.X * stretch_X), (point.Y * stretch_Y));
                    g.DrawString("[INTERFACE]", fnt, System.Drawing.Brushes.Blue, (point.X * stretch_X), (point.Y * stretch_Y) - headRoom);
                }
                else if (currentItem == 2)
                {
                    g.DrawImage(imageList1.Images[currentItem], (point.X * stretch_X), (point.Y * stretch_Y));
                    g.DrawString("[SLAVE]", fnt, System.Drawing.Brushes.Blue, (point.X * stretch_X), (point.Y * stretch_Y) - headRoom);
                }
                else if (currentItem == 3)
                {
                    g.DrawImage(imageList1.Images[currentItem], (point.X * stretch_X), (point.Y * stretch_Y));
                    g.DrawString("[DISPLAY]", fnt, System.Drawing.Brushes.Blue, (point.X * stretch_X), (point.Y * stretch_Y) - headRoom);
                }
                else if (currentItem == 4)
                {
                    g.DrawImage(imageList1.Images[currentItem], (point.X * stretch_X), (point.Y * stretch_Y));
                    g.DrawString("[LOOP]", fnt, System.Drawing.Brushes.Blue, (point.X * stretch_X), (point.Y * stretch_Y) - headRoom);
                }
                else if (currentItem == 5)
                {
                    g.DrawString(ItemText, fnt, Brushes.Blue, (point.X * stretch_X), (point.Y * stretch_Y));
                }
                newItemAdded = false;
                PictureBox.Image = Canvas;
                g.Dispose();

                newItemAdded = true;
            }
            catch (Exception)
            {
            }
        }


        private void PC_Btn_Click(object sender, EventArgs e)
        {
            currentItem = 0;
            PC_Btn.Enabled = false;
            Interface_Btn.Enabled = true;
            Slave_Btn.Enabled = true;
            Display_Btn.Enabled = true;
            Loop_Btn.Enabled = true;
            Text_Btn.Enabled = true;
        }

        private void Interface_Btn_Click(object sender, EventArgs e)
        {
            currentItem = 1;
            Interface_Btn.Enabled = false;
            PC_Btn.Enabled = true;
            Slave_Btn.Enabled = true;
            Display_Btn.Enabled = true;
            Loop_Btn.Enabled = true;
            Text_Btn.Enabled = true;
        }

        private void Slave_Btn_Click(object sender, EventArgs e)
        {
            currentItem = 2;
            Slave_Btn.Enabled = false;
            PC_Btn.Enabled = true;
            Interface_Btn.Enabled = true;
            Display_Btn.Enabled = true;
            Loop_Btn.Enabled = true;
            Text_Btn.Enabled = true;
        }

        private void Display_Btn_Click(object sender, EventArgs e)
        {
            currentItem = 3;
            Display_Btn.Enabled = false;
            PC_Btn.Enabled = true;
            Interface_Btn.Enabled = true;
            Slave_Btn.Enabled = true;
            Loop_Btn.Enabled = true;
            Text_Btn.Enabled = true;
        }

        private void Loop_Btn_Click(object sender, EventArgs e)
        {
            currentItem = 4;
            Loop_Btn.Enabled = false;
            PC_Btn.Enabled = true;
            Interface_Btn.Enabled = true;
            Slave_Btn.Enabled = true;
            Display_Btn.Enabled = true;
            Text_Btn.Enabled = true;
        }
        private void Text_Btn_Click(object sender, EventArgs e)
        {
            currentItem = 5;
            Text_Btn.Enabled = false;
            Loop_Btn.Enabled = true;
            PC_Btn.Enabled = true;
            Interface_Btn.Enabled = true;
            Slave_Btn.Enabled = true;
            Display_Btn.Enabled = true;
        }

        private void ImageEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.NewImageEditorLimiter = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ItemText = textBox1.Text;
        }
    }
}
