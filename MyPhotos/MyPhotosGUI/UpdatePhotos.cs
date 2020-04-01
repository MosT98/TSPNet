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
    public partial class UpdatePhotos : Form
    {
        public UpdatePhotos()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MyPhotos.Model1Container context = new MyPhotos.Model1Container();
            var photo = context.Photos.FirstOrDefault(p => p.Name == comboBox1.Text);
            photo.UpdatePhoto(textName.Text, textLocation.Text, textDescription.Text, textPath.Text, datePicker.Value);
            context.SaveChanges();
        }

        private void UpdatePhotos_Load(object sender, EventArgs e)
        {
            MyPhotos.Model1Container context = new MyPhotos.Model1Container();
            var photos = context.Photos;
            comboBox1.SelectedText = "Please select a photo to update";
            foreach (var photo in photos)
            {
                comboBox1.Items.Add(photo.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueSelected = comboBox1.Text;
            MyPhotos.Model1Container context = new MyPhotos.Model1Container();
            var photo = context.Photos.FirstOrDefault(p => p.Name == valueSelected);
            textName.Text = photo.Name;
            textLocation.Text = photo.Location;
            textDescription.Text = photo.Description;
            textPath.Text = photo.Path;
            datePicker.Value = photo.Date;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomePage().Show();
            this.Close();
        }
    }
}
