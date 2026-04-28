using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_Login_Simples
{
    public partial class LoginBox : Form
    {
        public LoginBox()
        {
            InitializeComponent();
        }

        private void UserBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SenhaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (UserBox.Text == "admin" && PsswrdBox.Text == "ds@etefmc")
            {
                MessageBox.Show("Correct login and password!");
            }
            else
            {
                MessageBox.Show("Incorrect login or password.");
            }
        }
    }
}
