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
            listView1.Items.Clear();
            MyPhotos.Model1Container context = new MyPhotos.Model1Container();
            var allPhotos = context.Photos;
            foreach (var photo in allPhotos)
            {
                ListViewItem item = new ListViewItem(photo.Name);
                item.SubItems.Add(photo.Description);
                item.SubItems.Add(photo.Date.ToString());
                item.SubItems.Add(photo.Path);

                listView1.Items.Add(item);
            }
        }
    }
}
