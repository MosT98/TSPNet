using System;
using System.Windows.Forms;

namespace MyPhotosGUI
{
    public partial class Login : Form
    {
        public static Guid IDUSER;
        public Login()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Register().ShowDialog();
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var checkUser = new MyPhotosClient().Login(email.Text, password.Text);
            if (checkUser != default(Guid))
            {
                Login.IDUSER = checkUser;
                this.Hide();
                new HomePage().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Introduceti din nou datele de logare", "EROARE", MessageBoxButtons.OKCancel);
            }
        }
    }
}
