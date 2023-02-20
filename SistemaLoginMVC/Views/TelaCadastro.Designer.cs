namespace SistemaLoginMVC.Views
{
    partial class TelaCadastro
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
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(12, 67);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(52, 20);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 20);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "Usuário:";
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Location = new System.Drawing.Point(15, 90);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.PasswordChar = '*';
            this.txtBoxSenha.Size = new System.Drawing.Size(241, 27);
            this.txtBoxSenha.TabIndex = 9;
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Location = new System.Drawing.Point(15, 32);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(241, 27);
            this.txtBoxUsuario.TabIndex = 8;
            // 
            // txtBoxConfirmarSenha
            // 
            this.txtBoxConfirmarSenha.Location = new System.Drawing.Point(15, 152);
            this.txtBoxConfirmarSenha.Name = "txtBoxConfirmarSenha";
            this.txtBoxConfirmarSenha.PasswordChar = '*';
            this.txtBoxConfirmarSenha.Size = new System.Drawing.Size(241, 27);
            this.txtBoxConfirmarSenha.TabIndex = 13;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(12, 129);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(122, 20);
            this.lblConfirmarSenha.TabIndex = 15;
            this.lblConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(162, 185);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(94, 29);
            this.btnConfirmar.TabIndex = 16;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 227);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.txtBoxConfirmarSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtBoxSenha);
            this.Controls.Add(this.txtBoxUsuario);
            this.Name = "TelaCadastro";
            this.Text = "Tela Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSenha;
        private Label lblUsuario;
        private TextBox txtBoxSenha;
        private TextBox txtBoxUsuario;
        private TextBox txtBoxConfirmarSenha;
        private Label lblConfirmarSenha;
        private Button btnConfirmar;
    }
}