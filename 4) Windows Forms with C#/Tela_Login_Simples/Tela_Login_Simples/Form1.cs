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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (UserBox.Text == "admin" && SenhaBox.Text == "ds@etefmc")
            {
                MessageBox.Show("Você acabou de hackear a ETE FMC");
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos");
            }
        }
    }
}
