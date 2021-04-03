using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{ public partial class Form1 : Form
        {                OpenFileDialog f = new OpenFileDialog();

            public Form1()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                f.Title = " you can select one or multi images ";

                f.Multiselect = true;
                DialogResult dr = f.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string[] files = f.FileNames;
                    foreach (string image in files)
                    {
                        listBox1.Items.Add(image);

                    }
                }
           // pic.Image = Image.FromFile(imag.ToString());

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }




            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void slideShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            pictureBox23.Visible = true;

            timer1.Start();

            }

            private void singleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox23.Visible = true;

            panel1.Visible = false;
            timer1.Stop();
            // pictureBox1.Visible = true;
            // panel1.Visible = false;
            pictureBox23.ImageLocation = listBox1.SelectedItem.ToString();
            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {

            }

            private void multyToolStripMenuItem_Click(object sender, EventArgs e)
            {

            timer1.Stop();
            pictureBox23.Visible = false;
                    panel1.Visible = true;
                    int x = 40;
                    int y = 40;
                    int maxHhight = -1;
                    foreach (string imag in listBox1.SelectedItems)
                    {
                        PictureBox pic = new PictureBox();
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Image = Image.FromFile(imag.ToString());
                        pic.Location = new Point(x, y);
                        x += pic.Width + 10;
                        maxHhight = Math.Max(pic.Height, maxHhight);
                        if (x > panel1.Width - 100)
                        {
                            x = 40;
                            y += maxHhight + 20;
                        }
                        panel1.Controls.Add(pic);

                    }



              
            }

            int count = 0;
            private void timer1_Tick(object sender, EventArgs e)
            {
                if (count >=listBox1.SelectedItems.Count)
                {
                    count = 0;
                }

            if (listBox1.SelectedItems.Count>0)
            {

                pictureBox23.ImageLocation = listBox1.SelectedItems[count].ToString();
                count++;
            }


            }

            private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Close();
            }
        }
    }