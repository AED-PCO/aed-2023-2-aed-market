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
            TabView = new TabControl();
            tabPage1 = new TabPage();
            CancelarAdicionar = new Button();
            Editar = new TabPage();
            CancelarEdicao = new Button();
            ConfirmarEdicao = new Button();
            label5 = new Label();
            label8 = new Label();
            QuantidadeEdicao = new TextBox();
            PrecoEdicao = new TextBox();
            CodigoEdicao = new TextBox();
            label7 = new Label();
            NomeEdicao = new TextBox();
            label6 = new Label();
            Remover = new TabPage();
            TextoAviso = new Label();
            RemoverProduto = new Button();
            button4 = new Button();
            label11 = new Label();
            textBox3 = new TextBox();
            ListaProdutos = new ListView();
            TabView.SuspendLayout();
            tabPage1.SuspendLayout();
            Editar.SuspendLayout();
            Remover.SuspendLayout();
            SuspendLayout();
            // 
            // adicionar
            // 
            adicionar.Location = new Point(136, 249);
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
            label1.Location = new Point(5, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // nomeproduto
            // 
            nomeproduto.Location = new Point(5, 34);
            nomeproduto.Margin = new Padding(2);
            nomeproduto.Name = "nomeproduto";
            nomeproduto.Size = new Size(109, 23);
            nomeproduto.TabIndex = 3;
            // 
            // precoproduto
            // 
            precoproduto.Location = new Point(5, 139);
            precoproduto.Margin = new Padding(2);
            precoproduto.Name = "precoproduto";
            precoproduto.Size = new Size(109, 23);
            precoproduto.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 122);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Preço:";
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
            label3.Location = new Point(5, 174);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 7;
            label3.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 69);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 9;
            label4.Text = "Código:";
            label4.Click += label4_Click;
            // 
            // codigoproduto
            // 
            codigoproduto.Location = new Point(5, 86);
            codigoproduto.Margin = new Padding(2);
            codigoproduto.Name = "codigoproduto";
            codigoproduto.Size = new Size(109, 23);
            codigoproduto.TabIndex = 10;
            // 
            // codigoremover
            // 
            codigoremover.Location = new Point(5, 191);
            codigoremover.Margin = new Padding(2);
            codigoremover.Name = "codigoremover";
            codigoremover.Size = new Size(109, 23);
            codigoremover.TabIndex = 8;
            // 
            // TabView
            // 
            TabView.Controls.Add(tabPage1);
            TabView.Controls.Add(Editar);
            TabView.Controls.Add(Remover);
            TabView.Location = new Point(447, 32);
            TabView.Name = "TabView";
            TabView.SelectedIndex = 0;
            TabView.Size = new Size(241, 318);
            TabView.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(CancelarAdicionar);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(codigoremover);
            tabPage1.Controls.Add(codigoproduto);
            tabPage1.Controls.Add(adicionar);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(nomeproduto);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(precoproduto);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(233, 290);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Adicionar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // CancelarAdicionar
            // 
            CancelarAdicionar.Location = new Point(25, 249);
            CancelarAdicionar.Margin = new Padding(2);
            CancelarAdicionar.Name = "CancelarAdicionar";
            CancelarAdicionar.Size = new Size(79, 23);
            CancelarAdicionar.TabIndex = 11;
            CancelarAdicionar.Text = "Cancelar";
            CancelarAdicionar.UseVisualStyleBackColor = true;
            CancelarAdicionar.Click += CancelarAdicionar_Click;
            // 
            // Editar
            // 
            Editar.Controls.Add(CancelarEdicao);
            Editar.Controls.Add(ConfirmarEdicao);
            Editar.Controls.Add(label5);
            Editar.Controls.Add(label8);
            Editar.Controls.Add(QuantidadeEdicao);
            Editar.Controls.Add(PrecoEdicao);
            Editar.Controls.Add(CodigoEdicao);
            Editar.Controls.Add(label7);
            Editar.Controls.Add(NomeEdicao);
            Editar.Controls.Add(label6);
            Editar.Location = new Point(4, 24);
            Editar.Name = "Editar";
            Editar.Padding = new Padding(3);
            Editar.Size = new Size(233, 290);
            Editar.TabIndex = 1;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = true;
            // 
            // CancelarEdicao
            // 
            CancelarEdicao.Location = new Point(35, 233);
            CancelarEdicao.Margin = new Padding(2);
            CancelarEdicao.Name = "CancelarEdicao";
            CancelarEdicao.Size = new Size(79, 23);
            CancelarEdicao.TabIndex = 21;
            CancelarEdicao.Text = "Cancelar";
            CancelarEdicao.UseVisualStyleBackColor = true;
            // 
            // ConfirmarEdicao
            // 
            ConfirmarEdicao.Location = new Point(137, 233);
            ConfirmarEdicao.Margin = new Padding(2);
            ConfirmarEdicao.Name = "ConfirmarEdicao";
            ConfirmarEdicao.Size = new Size(79, 23);
            ConfirmarEdicao.TabIndex = 12;
            ConfirmarEdicao.Text = "Editar";
            ConfirmarEdicao.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 17);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 13;
            label5.Text = "Nome:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 122);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 16;
            label8.Text = "Preço:";
            // 
            // QuantidadeEdicao
            // 
            QuantidadeEdicao.Location = new Point(5, 191);
            QuantidadeEdicao.Margin = new Padding(2);
            QuantidadeEdicao.Name = "QuantidadeEdicao";
            QuantidadeEdicao.Size = new Size(109, 23);
            QuantidadeEdicao.TabIndex = 18;
            // 
            // PrecoEdicao
            // 
            PrecoEdicao.Location = new Point(5, 139);
            PrecoEdicao.Margin = new Padding(2);
            PrecoEdicao.Name = "PrecoEdicao";
            PrecoEdicao.Size = new Size(109, 23);
            PrecoEdicao.TabIndex = 15;
            // 
            // CodigoEdicao
            // 
            CodigoEdicao.Location = new Point(5, 86);
            CodigoEdicao.Margin = new Padding(2);
            CodigoEdicao.Name = "CodigoEdicao";
            CodigoEdicao.Size = new Size(109, 23);
            CodigoEdicao.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 69);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 19;
            label7.Text = "Código:";
            // 
            // NomeEdicao
            // 
            NomeEdicao.Location = new Point(5, 34);
            NomeEdicao.Margin = new Padding(2);
            NomeEdicao.Name = "NomeEdicao";
            NomeEdicao.Size = new Size(109, 23);
            NomeEdicao.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 174);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 17;
            label6.Text = "Quantidade:";
            // 
            // Remover
            // 
            Remover.Controls.Add(TextoAviso);
            Remover.Controls.Add(RemoverProduto);
            Remover.Controls.Add(button4);
            Remover.Controls.Add(label11);
            Remover.Controls.Add(textBox3);
            Remover.Location = new Point(4, 24);
            Remover.Name = "Remover";
            Remover.Padding = new Padding(3);
            Remover.Size = new Size(233, 290);
            Remover.TabIndex = 2;
            Remover.Text = "Remover";
            Remover.UseVisualStyleBackColor = true;
            // 
            // TextoAviso
            // 
            TextoAviso.AutoSize = true;
            TextoAviso.Location = new Point(7, 58);
            TextoAviso.Name = "TextoAviso";
            TextoAviso.Size = new Size(208, 15);
            TextoAviso.TabIndex = 34;
            TextoAviso.Text = "O processo de remover é permanente.";
            TextoAviso.Click += TextoAviso_Click;
            // 
            // RemoverProduto
            // 
            RemoverProduto.Location = new Point(133, 238);
            RemoverProduto.Margin = new Padding(2);
            RemoverProduto.Name = "RemoverProduto";
            RemoverProduto.Size = new Size(79, 23);
            RemoverProduto.TabIndex = 33;
            RemoverProduto.Text = "Remover";
            RemoverProduto.UseVisualStyleBackColor = true;
            RemoverProduto.Click += RemoverProduto_Click;
            // 
            // button4
            // 
            button4.Location = new Point(35, 238);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(79, 23);
            button4.TabIndex = 32;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 120);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 30;
            label11.Text = "Código:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(13, 137);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(109, 23);
            textBox3.TabIndex = 31;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // ListaProdutos
            // 
            ListaProdutos.Location = new Point(28, 32);
            ListaProdutos.Name = "ListaProdutos";
            ListaProdutos.Size = new Size(382, 318);
            ListaProdutos.TabIndex = 12;
            ListaProdutos.UseCompatibleStateImageBehavior = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(ListaProdutos);
            Controls.Add(TabView);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosing += Menu_FormClosing;
            Load += Menu_Load;
            TabView.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            Editar.ResumeLayout(false);
            Editar.PerformLayout();
            Remover.ResumeLayout(false);
            Remover.PerformLayout();
            ResumeLayout(false);
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
        private TabControl TabView;
        private TabPage tabPage1;
        private TabPage Editar;
        private TabPage Remover;
        private Button CancelarAdicionar;
        private Button CancelarEdicao;
        private Button ConfirmarEdicao;
        private Label label5;
        private Label label8;
        private TextBox QuantidadeEdicao;
        private TextBox PrecoEdicao;
        private TextBox CodigoEdicao;
        private Label label7;
        private TextBox NomeEdicao;
        private Label label6;
        private ListView ListaProdutos;
        private Label TextoAviso;
        private Button RemoverProduto;
        private Button button4;
        private Label label11;
        private TextBox textBox3;
    }
}