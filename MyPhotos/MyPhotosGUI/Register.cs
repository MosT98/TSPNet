using MyPhotos;
using System;
using System.Windows.Forms;

namespace MyPhotosGUI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            new User().Register(firstName.Text, lastName.Text, email.Text, password.Text);

            this.Hide();
            new Login().ShowDialog();
            this.Close();

        }
    }
}
