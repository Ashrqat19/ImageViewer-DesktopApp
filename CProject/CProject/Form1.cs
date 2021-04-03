using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CProject
{
        public partial class Form1 : Form
    {
        string path;

        OpenFileDialog p = new OpenFileDialog();

        List<string> AllListPicture = new List<string>();
        List<string> selectedList = new List<string>();
        //List<string> ListBox = new List<string>();
        private int Imagenumber = 0;
            private int PanelSize = 15;
            //Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();

            p.Title = "Please Select Images";
            p.Multiselect = true;
            p.Filter = "JPG|*.JPG|JPEG|*.JPeg|GIF|*.gif|PNG|*.png";
        }
            
            private void singlePictureToolStripMenuItem_Click(object sender, EventArgs e)
            {
            panel1.Visible = false;
                timer1.Stop();
                  pictureBox2.Controls.Clear();
            pictureBox2.Visible = true;
                if (listBox1.SelectedItems.Count == 1)
                {       putlistbox();

                    pictureBox2.Controls.Clear();
                for (int i = 0; i < AllListPicture.Count; i++)
                {
                    if (AllListPicture[i].Contains(listBox1.SelectedItem.ToString()))
                    {
                        path = AllListPicture[i].ToString();
                                    Image image = Image.FromFile(path);
                  this.pictureBox2.Image = image;
                    }
                }



                }
             
            }

            private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void multiPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            putlistbox();

            toolStripStatusLabel2.Visible = false;
            pictureBox2.Visible = false;
            timer1.Stop();
                panel1.Visible = true;
                if (listBox1.SelectedItems.Count == 1 || listBox1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please Select More Than one photo");

                }
                else
                {
                    if (listBox1.SelectedItems.Count > PanelSize)
                    {
                        MessageBox.Show("Number of selected photo more than 15");
                    }
                    else
                    {
                        panel1.Controls.Clear();
                        pictureBox2.Controls.Clear();
                    putlistbox();
              //    imgPic.ImageLocation = Path[ListBox.SelectedIndex];
                    for (int i = 0; i <AllListPicture.Count;i++)
                    {
                            for (int j = 0; j < listBox1.SelectedItems.Count; j++)
                            {    if (AllListPicture[i].Contains(listBox1.SelectedItems[j].ToString()))
                                {
                                 selectedList.Add(AllListPicture[j].ToString());
                                break;
                            }
                        }
                            
                        }
                        
                        int x = 40;
                        int y = 40;
                        int maxHeight = -1;

                        foreach (string img in selectedList)
                        {
                            PictureBox pic = new PictureBox();
                            pic.Image = Image.FromFile(img);
                            pic.Location = new Point(x, y);
                            pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        x += pic.Width + 20;
                            maxHeight = Math.Max(pic.Height, maxHeight);
                            if (x > this.panel1.Width)
                            {

                                x = 40;
                                y += maxHeight + 20;

                            }
                            this.panel1.Controls.Add(pic);


                        }
                    }

                }
            }
            private void putlistbox()
            {
                for (int i = 0; i < p.FileNames.Length; i++)
                {
                    AllListPicture.Add(p.FileNames[i].ToString());
                }
            }
        
            private void timer1_Tick(object sender, EventArgs e)
            {




           

            if (Imagenumber==AllListPicture.Count - 1)
            {
                Imagenumber = 0;
            }
            pictureBox2.Image = Image.FromFile(AllListPicture[Imagenumber]);
            toolStripStatusLabel2.Text = AllListPicture[Imagenumber].ToString();
            toolStripStatusLabel2.Visible = true;
            Imagenumber++;

        }

            private void slideShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            putlistbox();
            panel1.Visible = false;
            pictureBox2.Controls.Clear();
            pictureBox2.Visible = true;
            timer1.Start();

        }

       
         
            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
               
            }

            private void button1_Click(object sender, EventArgs e)
            {
               
             DialogResult f = p.ShowDialog();
            if (f == DialogResult.OK)
                {
                // putlistbox();
                putlistbox();

                for (int i = 0; i < p.FileNames.Length; i++)
                    {
                     listBox1.Items.Add(Path.GetFileName(p.FileNames[i]));
                }
               
                }
            }


     
    }
    }