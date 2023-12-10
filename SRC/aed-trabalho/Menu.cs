using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aed_trabalho
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adicionartxt_Click(object sender, EventArgs e)
        {
            produto Produto = new produto();

            Produto.nome = nomeproduto.Text;
            Produto.preco = precoproduto.Text;
            Produto.codigo = codigoproduto.Text;

            using (StreamWriter sw = new StreamWriter("produtos.txt", true))
            {
                sw.WriteLine($"{Produto.nome},{Produto.preco},{Produto.codigo}");
                sw.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> linhas = File.ReadAllLines("produtos.txt").ToList();
            string codigoParaRemover = codigoremover.Text;

            string linhaParaRemover = linhas.FirstOrDefault(l => l.EndsWith($",{codigoParaRemover}"));

            if (linhaParaRemover != null)
            {
                string[] dadosProduto = linhaParaRemover.Split(',');
                string codigoDoProdutoNaLinha = dadosProduto.LastOrDefault();

                if (codigoDoProdutoNaLinha == codigoParaRemover)
                {
                    linhas.Remove(linhaParaRemover);
                    File.WriteAllLines("produtos.txt", linhas);
                    MessageBox.Show("Produto removido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Código do produto não encontrado!");
                }
            }
            else
            {
                MessageBox.Show("Produto não encontrado!");
            }
        }




        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lines = File.ReadAllLines("produtos.txt").ToList();
                StringBuilder content = new StringBuilder();

                foreach (var line in lines)
                {
                    content.AppendLine(line);
                }

                MessageBox.Show("Conteúdo do arquivo:\n" + content.ToString(), "Produtos Atuais");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Arquivo não encontrado. Nenhum produto cadastrado ainda.", "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar abrir o arquivo: {ex.Message}", "Erro");
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
    public class produto
    {
        public string nome;
        public string preco;
        public string codigo;
    }
}
