namespace Tela_Login_Simples
{
    partial class LoginBox
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
            this.SenhaBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SenhaBox
            // 
            this.SenhaBox.HideSelection = false;
            this.SenhaBox.Location = new System.Drawing.Point(210, 145);
            this.SenhaBox.Name = "SenhaBox";
            this.SenhaBox.PasswordChar = '♬';
            this.SenhaBox.Size = new System.Drawing.Size(100, 20);
            this.SenhaBox.TabIndex = 0;
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(210, 116);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(100, 20);
            this.UserBox.TabIndex = 1;
            this.UserBox.TextChanged += new System.EventHandler(this.UserBox_TextChanged);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Login.Location = new System.Drawing.Point(158, 120);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(46, 13);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login:";
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Senha.Location = new System.Drawing.Point(158, 149);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(51, 13);
            this.Senha.TabIndex = 3;
            this.Senha.Text = "Senha:";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnEnter.Location = new System.Drawing.Point(223, 205);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Entrar";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // LoginBox
            // 
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(488, 311);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.SenhaBox);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LoginBox";
            this.Text = "Clique Aqui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Button btnEnter;
        protected System.Windows.Forms.TextBox SenhaBox;
    }
}

