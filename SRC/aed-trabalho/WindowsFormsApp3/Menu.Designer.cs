namespace WindowsFormsApp3
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
            this.adicionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeproduto = new System.Windows.Forms.TextBox();
            this.precoproduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.codigoproduto = new System.Windows.Forms.TextBox();
            this.codigoremover = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(36, 307);
            this.adicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(68, 20);
            this.adicionar.TabIndex = 0;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionartxt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 308);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mostrar produtos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do produto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nomeproduto
            // 
            this.nomeproduto.Location = new System.Drawing.Point(36, 87);
            this.nomeproduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nomeproduto.Name = "nomeproduto";
            this.nomeproduto.Size = new System.Drawing.Size(94, 20);
            this.nomeproduto.TabIndex = 3;
            // 
            // precoproduto
            // 
            this.precoproduto.Location = new System.Drawing.Point(36, 201);
            this.precoproduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.precoproduto.Name = "precoproduto";
            this.precoproduto.Size = new System.Drawing.Size(94, 20);
            this.precoproduto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preço do produto:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 307);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 20);
            this.button2.TabIndex = 6;
            this.button2.Text = "Remover produto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Código do produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código do produto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // codigoproduto
            // 
            this.codigoproduto.Location = new System.Drawing.Point(36, 133);
            this.codigoproduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codigoproduto.Name = "codigoproduto";
            this.codigoproduto.Size = new System.Drawing.Size(94, 20);
            this.codigoproduto.TabIndex = 10;
            // 
            // codigoremover
            // 
            this.codigoremover.Location = new System.Drawing.Point(210, 87);
            this.codigoremover.Margin = new System.Windows.Forms.Padding(2);
            this.codigoremover.Name = "codigoremover";
            this.codigoremover.Size = new System.Drawing.Size(100, 20);
            this.codigoremover.TabIndex = 8;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.codigoproduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.codigoremover);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.precoproduto);
            this.Controls.Add(this.nomeproduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adicionar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeproduto;
        private System.Windows.Forms.TextBox precoproduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codigoproduto;
        private System.Windows.Forms.TextBox codigoremover;
    }
}

