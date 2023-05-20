namespace LoginForm
{
    partial class Cadastro
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
            groupBox1 = new GroupBox();
            txt_nome = new MaskedTextBox();
            groupBox2 = new GroupBox();
            txt_usuario = new MaskedTextBox();
            groupBox3 = new GroupBox();
            txt_email = new MaskedTextBox();
            groupBox4 = new GroupBox();
            txt_senha = new MaskedTextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_nome);
            groupBox1.Location = new Point(147, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 63);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nome";
            // 
            // txt_nome
            // 
            txt_nome.BorderStyle = BorderStyle.FixedSingle;
            txt_nome.Location = new Point(6, 26);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(258, 27);
            txt_nome.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_usuario);
            groupBox2.Location = new Point(432, 133);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(253, 63);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Usuário";
            // 
            // txt_usuario
            // 
            txt_usuario.BorderStyle = BorderStyle.FixedSingle;
            txt_usuario.Location = new Point(6, 26);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(241, 27);
            txt_usuario.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_email);
            groupBox3.Location = new Point(153, 224);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(264, 63);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "E-mail";
            // 
            // txt_email
            // 
            txt_email.BorderStyle = BorderStyle.FixedSingle;
            txt_email.Location = new Point(6, 26);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(252, 27);
            txt_email.TabIndex = 6;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txt_senha);
            groupBox4.Location = new Point(438, 224);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(247, 63);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Senha";
            // 
            // txt_senha
            // 
            txt_senha.BorderStyle = BorderStyle.FixedSingle;
            txt_senha.Location = new Point(6, 26);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(235, 27);
            txt_senha.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(518, 319);
            button1.Name = "button1";
            button1.Size = new Size(151, 48);
            button1.TabIndex = 4;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.Location = new Point(173, 339);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(58, 25);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Voltar";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox4);
            panel1.Location = new Point(189, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 470);
            panel1.TabIndex = 6;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 726);
            Controls.Add(panel1);
            Name = "Cadastro";
            Text = "Cadastro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox txt_nome;
        private GroupBox groupBox2;
        private MaskedTextBox txt_usuario;
        private GroupBox groupBox3;
        private MaskedTextBox txt_email;
        private Panel panel1;
        private GroupBox groupBox4;
        private MaskedTextBox txt_senha;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}