namespace LoginForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            txt_senha = new TextBox();
            pictureBox1 = new PictureBox();
            lblsenha = new Label();
            lbllogin = new Label();
            llblcadastro = new LinkLabel();
            btnlogar = new Button();
            txt_login = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(txt_senha);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblsenha);
            panel1.Controls.Add(lbllogin);
            panel1.Controls.Add(llblcadastro);
            panel1.Controls.Add(btnlogar);
            panel1.Controls.Add(txt_login);
            panel1.Location = new Point(248, 62);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(50);
            panel1.Size = new Size(575, 486);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // txt_senha
            // 
            txt_senha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_senha.BorderStyle = BorderStyle.FixedSingle;
            txt_senha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senha.Location = new Point(53, 275);
            txt_senha.MinimumSize = new Size(0, 34);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(469, 34);
            txt_senha.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(239, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblsenha.Location = new Point(53, 244);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(65, 28);
            lblsenha.TabIndex = 11;
            lblsenha.Text = "Senha";
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbllogin.Location = new Point(53, 139);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(61, 28);
            lbllogin.TabIndex = 10;
            lbllogin.Text = "Login";
            // 
            // llblcadastro
            // 
            llblcadastro.AutoSize = true;
            llblcadastro.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            llblcadastro.LinkBehavior = LinkBehavior.NeverUnderline;
            llblcadastro.LinkColor = Color.Red;
            llblcadastro.Location = new Point(53, 381);
            llblcadastro.Name = "llblcadastro";
            llblcadastro.Size = new Size(151, 25);
            llblcadastro.TabIndex = 9;
            llblcadastro.TabStop = true;
            llblcadastro.Text = "Faça seu cadastro";
            llblcadastro.LinkClicked += llblcadastro_LinkClicked;
            // 
            // btnlogar
            // 
            btnlogar.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnlogar.Location = new Point(383, 370);
            btnlogar.Name = "btnlogar";
            btnlogar.Size = new Size(139, 45);
            btnlogar.TabIndex = 8;
            btnlogar.Text = "Entrar";
            btnlogar.UseVisualStyleBackColor = true;
            btnlogar.Click += btnlogar_Click_1;
            // 
            // txt_login
            // 
            txt_login.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_login.BorderStyle = BorderStyle.FixedSingle;
            txt_login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_login.Location = new Point(53, 173);
            txt_login.MinimumSize = new Size(0, 28);
            txt_login.Name = "txt_login";
            txt_login.Size = new Size(469, 34);
            txt_login.TabIndex = 6;
            txt_login.TextChanged += txt_login_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 632);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnlogar;
        private TextBox txt_login;
        private PictureBox pictureBox1;
        private Label lblsenha;
        private Label lbllogin;
        private LinkLabel llblcadastro;
        private TextBox txt_senha;
    }
}