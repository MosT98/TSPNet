using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            MyPhotos.Photo newPhoto = MyPhotos.Photo.CreatePhoto(textName.Text, textLocation.Text, textDescription.Text, textPath.Text, datePicker.Value, Login.IDUSER);
            MyPhotos.Model1Container context = new MyPhotos.Model1Container();
            context.Photos.Add(newPhoto);
            context.SaveChanges();
        }

    }
}
