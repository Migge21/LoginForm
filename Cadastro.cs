
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.BLL;
using LoginForm.DTO;

namespace LoginForm
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        BLL_Usuario obj_bll_usuario = new BLL_Usuario();
        DTO_Usuario obj_dto_usuario = new DTO_Usuario();
        public void Limpar()
        {
            txt_nome.Clear();
            txt_usuario.Clear();
            txt_email.Clear();
            txt_senha.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                obj_dto_usuario.Nome1 = txt_nome.Text;
                obj_dto_usuario.Usuario = txt_usuario.Text;
                obj_dto_usuario.Email = txt_email.Text;
                obj_dto_usuario.Senha = txt_senha.Text;
                obj_bll_usuario.Cad_Usuario(obj_dto_usuario);
                MessageBox.Show("Cadastro efetuado com sucesso!!");
                Limpar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 inicio = new Form1();
            inicio.ShowDialog();
        }
    }
}
