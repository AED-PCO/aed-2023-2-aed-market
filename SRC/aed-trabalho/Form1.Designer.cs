namespace aed_trabalho
{
    partial class Início
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
            checkBox1 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            txtSenha = new TextBox();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            aEDMarketToolStripMenuItem = new ToolStripMenuItem();
            ds = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            txtUsuario = new TextBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(47, 174);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Deixar logado";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 46);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome do usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 112);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(109, 250);
            button1.Name = "button1";
            button1.Size = new Size(107, 29);
            button1.TabIndex = 3;
            button1.Text = "Cadastrar-se";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(46, 141);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(125, 27);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += textBox2_TextChanged;
            // 
            // backgroundWorker2
            // 
            backgroundWorker2.DoWork += backgroundWorker2_DoWork;
            // 
            // aEDMarketToolStripMenuItem
            // 
            aEDMarketToolStripMenuItem.Name = "aEDMarketToolStripMenuItem";
            aEDMarketToolStripMenuItem.Size = new Size(108, 24);
            aEDMarketToolStripMenuItem.Text = "AED- Market";
            // 
            // ds
            // 
            ds.Name = "ds";
            ds.Size = new Size(14, 24);
            ds.Click += toolStripMenuItem2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aEDMarketToolStripMenuItem, ds });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(778, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(46, 82);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 4;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDarkDark;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(298, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 316);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulário:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(6, 250);
            button2.Name = "button2";
            button2.Size = new Size(97, 29);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Início
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(778, 482);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Início";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Início";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox txtSenha;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private ToolStripMenuItem aEDMarketToolStripMenuItem;
        private ToolStripMenuItem ds;
        private MenuStrip menuStrip1;
        private TextBox txtUsuario;
        private GroupBox groupBox1;
        private Button button2;
    }
}