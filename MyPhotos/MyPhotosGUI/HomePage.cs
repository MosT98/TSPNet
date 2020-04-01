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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void addPhotoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddPhoto().ShowDialog();
            this.Close();
        }

        private void addFolderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddFolder().ShowDialog();
            this.Close();
        }

        private void viewPhotosButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewPhotos().ShowDialog();
            this.Close();
        }

        private void updatePhotosButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdatePhotos().ShowDialog();
            this.Close();
        }
    }
}
