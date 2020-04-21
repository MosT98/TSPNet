using MyPhotos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MyPhotosGUI
{
    public partial class ViewPhotos : Form
    {
        public ViewPhotos()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomePage().ShowDialog();
            this.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            photosCombo.Items.Clear();
            var photos = new MyPhotosClient().GetPhotos();
            foreach (var photo in photos)
            {
                photosCombo.Items.Add(photo.Name);
            }
        }

        private void ViewPhotos_Load(object sender, EventArgs e)
        {
            var photos = new MyPhotosClient().GetPhotos();
            foreach (var photo in photos)
            {
                photosCombo.Items.Add(photo.Name);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string photoToDelete = photosCombo.Text;
            var photoId = new MyPhotosClient().GetGuidByName(photoToDelete);
            new MyPhotosClient().DeletePhoto(photoId);

        }
    }
}
