namespace aed_trabalho
{
    partial class Login
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
            BotaoCancelar = new Button();
            EntradaUsuario = new TextBox();
            EntradaSenha = new TextBox();
            BotaoConfirmar = new Button();
            label1 = new Label();
            label2 = new Label();
            TextoPaginaLogin = new Label();
            Cadastrar = new LinkLabel();
            SuspendLayout();
            // 
            // BotaoCancelar
            // 
            BotaoCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BotaoCancelar.Location = new Point(62, 227);
            BotaoCancelar.Name = "BotaoCancelar";
            BotaoCancelar.Size = new Size(71, 22);
            BotaoCancelar.TabIndex = 0;
            BotaoCancelar.Text = "Sair";
            BotaoCancelar.UseVisualStyleBackColor = true;
            BotaoCancelar.Click += BotaoCancelar_Click;
            // 
            // EntradaUsuario
            // 
            EntradaUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EntradaUsuario.Location = new Point(83, 87);
            EntradaUsuario.MaximumSize = new Size(200, 23);
            EntradaUsuario.Name = "EntradaUsuario";
            EntradaUsuario.Size = new Size(116, 23);
            EntradaUsuario.TabIndex = 1;
            // 
            // EntradaSenha
            // 
            EntradaSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EntradaSenha.Location = new Point(83, 154);
            EntradaSenha.MaximumSize = new Size(200, 23);
            EntradaSenha.Name = "EntradaSenha";
            EntradaSenha.Size = new Size(116, 23);
            EntradaSenha.TabIndex = 2;
            // 
            // BotaoConfirmar
            // 
            BotaoConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BotaoConfirmar.Location = new Point(165, 227);
            BotaoConfirmar.Name = "BotaoConfirmar";
            BotaoConfirmar.Size = new Size(71, 22);
            BotaoConfirmar.TabIndex = 3;
            BotaoConfirmar.Text = "Confirmar";
            BotaoConfirmar.UseVisualStyleBackColor = true;
            BotaoConfirmar.Click += BotaoConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 69);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 4;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 136);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Senha";
            // 
            // TextoPaginaLogin
            // 
            TextoPaginaLogin.AutoSize = true;
            TextoPaginaLogin.Location = new Point(27, 26);
            TextoPaginaLogin.Name = "TextoPaginaLogin";
            TextoPaginaLogin.Size = new Size(142, 15);
            TextoPaginaLogin.TabIndex = 6;
            TextoPaginaLogin.Text = "Insira seus dados de login";
            // 
            // Cadastrar
            // 
            Cadastrar.AutoSize = true;
            Cadastrar.Location = new Point(83, 194);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(73, 15);
            Cadastrar.TabIndex = 7;
            Cadastrar.TabStop = true;
            Cadastrar.Text = "Cadastrar-se";
            Cadastrar.LinkClicked += Cadastrar_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 261);
            Controls.Add(Cadastrar);
            Controls.Add(TextoPaginaLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BotaoConfirmar);
            Controls.Add(EntradaSenha);
            Controls.Add(EntradaUsuario);
            Controls.Add(BotaoCancelar);
            MaximumSize = new Size(400, 300);
            MinimumSize = new Size(279, 261);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AED Market: Entrar ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotaoCancelar;
        private TextBox EntradaUsuario;
        private TextBox EntradaSenha;
        private Button BotaoConfirmar;
        private Label label1;
        private Label label2;
        private Label TextoPaginaLogin;
        private LinkLabel Cadastrar;
    }
}