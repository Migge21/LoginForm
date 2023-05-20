namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogar_Click(object sender, EventArgs e)
            /*Envia para uma nova tela ao clicar no botao entrar*/
        {
            Iniciocs inicio = new Iniciocs();
            inicio.ShowDialog();
        }
    }
}