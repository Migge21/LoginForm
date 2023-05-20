namespace LoginForm
{
    partial class Iniciocs
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
            cxb_Adicionar = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            SuspendLayout();
            // 
            // cxb_Adicionar
            // 
            cxb_Adicionar.AutoSize = true;
            cxb_Adicionar.Location = new Point(625, 98);
            cxb_Adicionar.Name = "cxb_Adicionar";
            cxb_Adicionar.Size = new Size(95, 24);
            cxb_Adicionar.TabIndex = 0;
            cxb_Adicionar.Text = "Adicionar";
            cxb_Adicionar.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(625, 128);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(90, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Remover";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(625, 158);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(70, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Editar";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(625, 188);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(65, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Tudo";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // Iniciocs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(cxb_Adicionar);
            Name = "Iniciocs";
            Text = "Iniciocs";
            Load += Iniciocs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cxb_Adicionar;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
    }
}