using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
namespace Desktop_App
{

    public partial class Form1 : Form
    {
        List<PictureBox> viewedPicBoxInMultiple = new List<PictureBox>();

        List<string> AllPath = new List<string>();
        List<string> selectedPath = new List<string>();
        int imgNum = 0;
        void colorBtn(Button send, Color setColor, Color setTextColor)
        {
            send.BackColor = setColor;
            send.ForeColor = setTextColor;
            send.TabStop = false;
            send.FlatStyle = FlatStyle.Flat;
            send.FlatAppearance.BorderSize = 0;

        }
        int indxOfNext = 0;
        public Form1()
        {
            InitializeComponent();
        // background: rgba
       // background: rgba

            //     Color mainText = Color.FromArgb(33, 30, 50);
            Color mainText = Color.FromArgb(173, 111, 253);
            Color mainBack = Color.FromArgb(57, 60, 85);
            Color secondryBtnColor = Color.FromArgb(254, 118, 60);
            Color whiteTxt = Color.FromKnownColor(KnownColor.White);

            this.BackColor = Color.FromArgb(30, 40, 50);
            colorBtn(MulitpleBtn, mainText, whiteTxt);

            colorBtn(singleBtn, secondryBtnColor, BackColor);
            colorBtn(slideBtn, secondryBtnColor, BackColor);
            colorBtn(multiBtn, secondryBtnColor, BackColor);
       // background: rgba(123, 72, 189, 1);

            colorBtn(next, Color.FromArgb(123, 72, 189), BackColor);
            colorBtn(prev, Color.FromArgb(123, 72, 189), BackColor);
            next.Text = "";
            prev.Text = "";
            prev.Image = Image.FromFile("C:/Users/Electronica Care/Source/Repos/ImageViewer-DesktopApp-/Desktop App/grommet-icons_next.png");
            // Align the image and text on the button.
            prev.ImageAlign = ContentAlignment.MiddleCenter;
            next.Image = Image.FromFile("C:/Users/Electronica Care/Source/Repos/ImageViewer-DesktopApp-/Desktop App/grommet-icons_pre.png");
            // Align the image and text on the button.
            next.ImageAlign = ContentAlignment.MiddleCenter;


            colorBtn(uploadBtn, mainText, whiteTxt);
            colorBtn(startBtn, secondryBtnColor, whiteTxt);
            colorBtn(stopBtn, secondryBtnColor, whiteTxt);

            label1.ForeColor = mainText;
            label2.ForeColor = mainText;
            label3.ForeColor = mainText;

            panel1.BackColor = mainBack;
            panel2.BackColor = mainBack;
            panel3.BackColor = Color.FromArgb(30, 40, 50);
            toolStripLabel1.BackColor = Color.FromArgb(30, 40, 50);
            nameStatusStrip.BackColor = Color.FromArgb(30, 40, 50);
            toolStripLabel1.ForeColor = mainText;
            exitToolStripMenuItem.BackColor = Color.FromArgb(255, 86, 86);
            exitToolStripMenuItem.ForeColor = whiteTxt;

        }

        private void loadSelectPath()
        {
            if (!checkBoxSelectAll.Checked)
            {
                foreach (string pathName in imgList.SelectedItems)
                {
                    for (int i = 0; i < AllPath.Count; i++)
                    {
                        if (AllPath[i].Contains(pathName))
                        {
                            selectedPath.Add(AllPath[i]);
                            break;
                        }
                    }

                }
            }
            else
            {
                foreach (string path in AllPath)
                {
                    selectedPath.Add(path);
                }

            }

        }
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            if (openFileBrowser.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileBrowser.FileNames.Length; i++)
                {
                    AllPath.Add(openFileBrowser.FileNames[i].ToString());
                    imgList.Items.Add(Path.GetFileNameWithoutExtension(openFileBrowser.FileNames[i].ToString()));
                }


            }
        }

        private void loadImgtimer_Tick(object sender, EventArgs e)
        {
            if (imgNum == AllPath.Count - 1 || AllPath.Count == 1)
                imgNum = 0;
            if (AllPath.Count != 0)
            {

                imgBox.ImageLocation = AllPath[imgNum];
                //  nameStatusStrip.Visible = true;
                toolStripLabel1.Text = AllPath[imgNum++].ToString();
                toolStripLabel1.Visible = true;
                nameStatusStrip.Visible = true;
            }

        }

        private void singleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nameStatusStrip.Visible = false;

            loadImgtimer.Stop();
            panelMulti.Visible = false;
            imgBox.Visible = true;
            if (imgList.SelectedItems.Count == 1)
            {
                for (int i = 0; i < AllPath.Count; i++)
                {
                    imgBox.Controls.Clear();
                    if (AllPath[i].Contains(imgList.SelectedItem.ToString()))
                    {
                        imgBox.ImageLocation = AllPath[i];
                    }
                }
                indxOfNext = imgList.Items.IndexOf(imgList.SelectedItem);

            }
            else
            {
                MessageBox.Show("Please, Selcet ONE image");
            }
        }

        private void slideShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMulti.Visible = false;
            imgBox.Visible = true;
            loadImgtimer.Start();

        }
        private void multipleShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Button btnSender = (Button)sender;
                if (btnSender == MulitpleBtn)
                {
                    checkBoxSelectAll.Checked = true;
                }
            }
            catch (Exception exp) { }

            panelMulti.Controls.Clear();
            selectedPath.Clear();
            loadSelectPath();
            nameStatusStrip.Visible = false;
            loadImgtimer.Stop();
            imgBox.Visible = false;
            panelMulti.Visible = true;

            int maxHeight = -1;
            int x = 0, y = 0;
            for (int i = 0; i < selectedPath.Count; i++)
            {
                PictureBox pic = new PictureBox();
           
                pic.ImageLocation = selectedPath[i];
                pic.Location = new Point(x, y);
                pic.SizeMode = PictureBoxSizeMode.Zoom;

                    x += pic.Width + 30;
                maxHeight = Math.Max(pic.Height, maxHeight);
                if (x > panelMulti.Width - pic.Width)
                {
                    x = 0;
                    y += maxHeight + 30;
                }
                viewedPicBoxInMultiple.Add(pic);

                viewedPicBoxInMultiple[viewedPicBoxInMultiple.Count - 1].Click += new System.EventHandler(picClick);

                panelMulti.Controls.Add(viewedPicBoxInMultiple[viewedPicBoxInMultiple.Count - 1]);
            }

        }
        private void picClick(object sender, EventArgs e)
        {
            PictureBox picSent =(PictureBox) sender;
            imgBox.Visible = true;
            panelMulti.Visible = false;
            imgBox.Image = picSent.Image;
            indxOfNext = imgList.SelectedIndex;
        }
        private void clearCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (clearCheck.CheckState == CheckState.Checked)
            {
                AllPath.Clear();
                selectedPath.Clear();
                imgList.Items.Clear();

            }
        }

        private void ClearPanelCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (clearPanelCheck.Checked)
            {
                panelMulti.Controls.Clear();

            }

        }


        private void next_Click(object sender, EventArgs e)
        {
            nameStatusStrip.Visible = false;

            Button btnSender = (Button)sender;
            if (btnSender == next)
            {
                //  int indxOfNext = imgList.Items.IndexOf(imgList.SelectedItem)+1;
                indxOfNext++;
                if (indxOfNext >= imgList.Items.Count || indxOfNext < 0)
                {
                    indxOfNext = 0;

                }
                for (int i = 0; i < AllPath.Count; i++)
                {
                    imgBox.Controls.Clear();
                    if (AllPath[i].Contains(imgList.Items[indxOfNext].ToString()))
                    {
                        imgBox.ImageLocation = AllPath[i];
                    }
                }
            }
            else if (btnSender == prev)
            {
                indxOfNext--;
                if (indxOfNext >= imgList.Items.Count || indxOfNext < 0)
                {
                    indxOfNext = imgList.Items.Count - 1;

                }
                for (int i = 0; i < AllPath.Count; i++)
                {
                    imgBox.Controls.Clear();
                    if (AllPath[i].Contains(imgList.Items[indxOfNext].ToString()))
                    {
                        imgBox.ImageLocation = AllPath[i];
                    }
                }
            }
 
        }

        private void onOffSlider_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            panelMulti.Visible = false;
            imgBox.Visible = true;
            if (btnSender == startBtn)
            {
                loadImgtimer.Start();
            }
            else if (btnSender == stopBtn)
            {
                loadImgtimer.Stop();
            }


        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
