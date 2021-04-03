using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public struct typeSelect
    {
        public string name, path;
       
        public typeSelect(string path)
        {
            this.path = path;
            name = Path.GetFileName(path.ToString());
        }
    }
    public partial class Form1 : Form
    {
        List<typeSelect> AllPics = new List<typeSelect>();
 
        public Form1()
        {
            InitializeComponent();
            OFDimgUpload.Multiselect = true;
            OFDimgUpload.Title = "Choose Images";
            OFDimgUpload.Filter = "Image Files(*.jpg; *.jpeg; *.gif;)|*.jpg; *.jpeg; *.gif; ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OFDimgUpload.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < OFDimgUpload.FileNames.Length; i++)
                {
                    //AllPathPics.Add(OFDimgUpload.FileNames[i].ToString());
                    //   AllNamesPics.Add(Path.GetFileNameWithoutExtension(OFDimgUpload.FileNames[i].ToString()));
                    var cd = new typeSelect();
                    cd.path = OFDimgUpload.FileNames[i].ToString();
                    cd.name = Path.GetFileName(OFDimgUpload.FileNames[i].ToString());
                    AllPics.Add(cd);

                    //AllPics.Add.path = 
                    //AllPics[i].name = 
                    imgListBox.Items.Add(cd.name); //imgListBox.Items.va
                }
            }
        }

        private void imgListBox_SelectedIndexChanged(object sender, EventArgs e)
        { AllPics[8].name.Where(x => AllPics[2].path.Contains(this.imgListBox.SelectedItem.ToString()));
            AllPics.Where(x => AllPics[2].path.Contains( this.imgListBox.SelectedItem.ToString() )) ;
            //this.imgListBox.SelectedItem = AllPics.Find(AllPics.Contains(imgListBox.SelectedItem))
            //this.imgListBox.SelectedItem.ToString().
            var sd = (string)AllPics[0].name.Where(x => AllPics[0].path.Contains(this.imgListBox.SelectedItem.ToString()));
            for (int i =0; i< AllPics.Count;i++)
            {
                 sd = (string) AllPics[i].name.Where(x => AllPics[i].path.Contains(this.imgListBox.SelectedItem.ToString()));
                break;
            }
         //   var sd= AllPics[x].name.Where(x => AllPics[2].path.Contains(this.imgListBox.SelectedItem.ToString()));
            pictureBox.ImageLocation= sd.ToString();
        }
    }
}
