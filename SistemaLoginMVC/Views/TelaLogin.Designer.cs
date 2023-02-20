namespace SistemaLoginMVC.Views
{
    partial class TelaLogin
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
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Location = new System.Drawing.Point(17, 97);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.PasswordChar = '*';
            this.txtBoxSenha.Size = new System.Drawing.Size(241, 27);
            this.txtBoxSenha.TabIndex = 5;
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Location = new System.Drawing.Point(17, 39);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(241, 27);
            this.txtBoxUsuario.TabIndex = 4;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(164, 130);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(94, 29);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(14, 16);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 20);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(14, 74);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(52, 20);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "Senha:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(64, 130);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 29);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 174);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtBoxSenha);
            this.Controls.Add(this.txtBoxUsuario);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxSenha;
        private TextBox txtBoxUsuario;
        private Button btnConfirmar;
        private Label lblUsuario;
        private Label lblSenha;
        private Button btnCadastrar;
    }
}