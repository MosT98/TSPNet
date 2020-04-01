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
            string inputEmail = email.Text;
            string inputPassword = password.Text;
            MyPhotos.Model1Container context = new MyPhotos.Model1Container();
            var user = context.Users.FirstOrDefault(a => a.Email == inputEmail && a.Password == inputPassword);
            if (user != null)
            {
                Login.IDUSER = user.UserId;
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
