using MyPhotos;
using System;
using System.Windows.Forms;

namespace MyPhotosGUI
{
    public partial class UpdatePhotos : Form
    {
        public UpdatePhotos()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Folder[] folders = new Folder[1];
            var photo = new MyPhotosClient().GetPhotoByName(comboBox1.Text);
            new MyPhotosClient().UpdatePhoto(photo.PhotoId,textName.Text, textLocation.Text, textDescription.Text, textPath.Text, datePicker.Value, folders);
            //TODO: Testat, nu stiu daca mergee
        }

        private void UpdatePhotos_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedText = "Please select a photo to update";
            var photos = new MyPhotosClient().GetPhotos();
            foreach (var photo in photos)
            {
                comboBox1.Items.Add(photo.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueSelected = comboBox1.Text;
            var photo = new MyPhotosClient().GetPhotoByName(valueSelected);
            textName.Text = photo.Name;
            textLocation.Text = photo.Location;
            textDescription.Text = photo.Description;
            textPath.Text = photo.Path;
            datePicker.Value = photo.Date;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomePage().ShowDialog();
            this.Close();
        }
    }
}
