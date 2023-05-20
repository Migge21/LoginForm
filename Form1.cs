using System;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.BLL;
using Microsoft.VisualBasic.Logging;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        BLL_Login login = new BLL_Login();
        private void btnlogar_Click_1(object sender, EventArgs e)
        {
            /*Envia para uma nova tela ao clicar no botao entrar*/
            if (login.logar(txt_login.Text, txt_senha.Text) == "Usuario")
            {
                
                Iniciocs inicial = new Iniciocs();
                inicial.Show();
                
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!!");

            }
        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void llblcadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            
        }
    }
}
