namespace aed_trabalho
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            adicionar = new Button();
            button1 = new Button();
            label1 = new Label();
            nomeproduto = new TextBox();
            precoproduto = new TextBox();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            codigoproduto = new TextBox();
            codigoremover = new TextBox();
            SuspendLayout();
            // 
            // adicionar
            // 
            adicionar.Location = new Point(42, 354);
            adicionar.Margin = new Padding(2);
            adicionar.Name = "adicionar";
            adicionar.Size = new Size(79, 23);
            adicionar.TabIndex = 0;
            adicionar.Text = "Adicionar";
            adicionar.UseVisualStyleBackColor = true;
            adicionar.Click += adicionartxt_Click;
            // 
            // button1
            // 
            button1.Location = new Point(464, 355);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(127, 22);
            button1.TabIndex = 1;
            button1.Text = "Mostrar produtos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 73);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome do produto:";
            label1.Click += label1_Click;
            // 
            // nomeproduto
            // 
            nomeproduto.Location = new Point(42, 100);
            nomeproduto.Margin = new Padding(2);
            nomeproduto.Name = "nomeproduto";
            nomeproduto.Size = new Size(109, 23);
            nomeproduto.TabIndex = 3;
            // 
            // precoproduto
            // 
            precoproduto.Location = new Point(42, 232);
            precoproduto.Margin = new Padding(2);
            precoproduto.Name = "precoproduto";
            precoproduto.Size = new Size(109, 23);
            precoproduto.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 195);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 5;
            label2.Text = "Preço do produto:";
            // 
            // button2
            // 
            button2.Location = new Point(218, 354);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 6;
            button2.Text = "Remover produto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 73);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 7;
            label3.Text = "Código do produto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 136);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 9;
            label4.Text = "Código do produto";
            label4.Click += label4_Click;
            // 
            // codigoproduto
            // 
            codigoproduto.Location = new Point(42, 153);
            codigoproduto.Margin = new Padding(2);
            codigoproduto.Name = "codigoproduto";
            codigoproduto.Size = new Size(109, 23);
            codigoproduto.TabIndex = 10;
            // 
            // codigoremover
            // 
            codigoremover.Location = new Point(245, 100);
            codigoremover.Margin = new Padding(2);
            codigoremover.Name = "codigoremover";
            codigoremover.Size = new Size(116, 23);
            codigoremover.TabIndex = 8;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(codigoproduto);
            Controls.Add(label4);
            Controls.Add(codigoremover);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(precoproduto);
            Controls.Add(nomeproduto);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(adicionar);
            Margin = new Padding(2);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button adicionar;
        private Button button1;
        private Label label1;
        private TextBox nomeproduto;
        private TextBox precoproduto;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label label4;
        private TextBox codigoproduto;
        private TextBox codigoremover;
    }
}