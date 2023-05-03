namespace LoginForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnlogar = new Button();
            loginlbl = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            senhalbl = new Label();
            SuspendLayout();
            // 
            // btnlogar
            // 
            btnlogar.Location = new Point(239, 280);
            btnlogar.Name = "btnlogar";
            btnlogar.Size = new Size(208, 44);
            btnlogar.TabIndex = 0;
            btnlogar.Text = "Entrar";
            btnlogar.UseVisualStyleBackColor = true;
            btnlogar.Click += btnlogar_Click;
            // 
            // loginlbl
            // 
            loginlbl.AutoSize = true;
            loginlbl.Location = new Point(312, 79);
            loginlbl.Name = "loginlbl";
            loginlbl.Size = new Size(49, 20);
            loginlbl.TabIndex = 1;
            loginlbl.Text = "Login:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(281, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(281, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // senhalbl
            // 
            senhalbl.AutoSize = true;
            senhalbl.Location = new Point(312, 176);
            senhalbl.Name = "senhalbl";
            senhalbl.Size = new Size(52, 20);
            senhalbl.TabIndex = 4;
            senhalbl.Text = "Senha:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 424);
            Controls.Add(senhalbl);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(loginlbl);
            Controls.Add(btnlogar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlogar;
        private Label loginlbl;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label senhalbl;
    }
}