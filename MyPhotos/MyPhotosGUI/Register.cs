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
            MyPhotos.User newUser = MyPhotos.User.CreateUser(firstName.Text, lastName.Text, email.Text, password.Text);
            MyPhotos.Model1Container context = new MyPhotos.Model1Container();
            context.Users.Add(newUser);
            context.SaveChanges();

            this.Hide();
            new Login().ShowDialog();
            this.Close();

        }
    }
}
