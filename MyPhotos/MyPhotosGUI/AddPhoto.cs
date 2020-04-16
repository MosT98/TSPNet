using MyPhotos;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyPhotosGUI
{
    public partial class AddPhoto : Form
    {
        public AddPhoto()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomePage().ShowDialog();
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new Photo().AddPhoto(textName.Text, textLocation.Text, textDescription.Text, textPath.Text, datePicker.Value, Login.IDUSER);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                InitialDirectory = @"C:\Users\andre\Desktop\Poze",
                RestoreDirectory = true,
                Title = "Browse Photos",
                DefaultExt = "jpg",

                CheckFileExists = true,
                CheckPathExists = true,
            };
            
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textPath.Text = openFileDialog1.FileName;
                string path = openFileDialog1.FileName;
                string name = path.Split('\\').Last();
                textName.Text = name;
                photoPreviewBox.Image = Image.FromFile(path);
                photoPreviewBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }


        }
    }
}

