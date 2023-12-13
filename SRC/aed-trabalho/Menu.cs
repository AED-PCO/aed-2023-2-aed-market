using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static aed_trabalho.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace aed_trabalho
{
    public partial class Menu : Form
    {
        estoque produtos = new estoque();
        string[] caminhoDoArquivo;

        public Menu()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adicionartxt_Click(object sender, EventArgs e)
        {
            /*
            produto Produto = new produto(int.Parse(codigoproduto.Text), nomeproduto.Text, int.Parse(precoproduto.Text), int.Parse(codigoremover.Text));

            using (StreamWriter sw = new StreamWriter("produtos.txt", true))
            {
                sw.WriteLine($"{Produto.codigo}{Produto.nome};{Produto.preco};{Produto.quantidade};");
                sw.Close();
                MessageBox.Show("Produto cadastrado");
            }
            */

            produtos.Adicionar(int.Parse(codigoproduto.Text), nomeproduto.Text, int.Parse(precoproduto.Text), int.Parse(codigoremover.Text));
            produtos.AtualizarTabela(ListaProdutos);

            nomeproduto.Text = "";
            codigoproduto.Text = "";
            precoproduto.Text = "";
            codigoremover.Text = "";
        }

        //tem que ser atualizado, não tive tempo - yago
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

        //tem que ser atualizado, não tive tempo - yago
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
            StreamReader leitor = new StreamReader("acessoRapido.txt");
            caminhoDoArquivo = leitor.ReadLine().Split(";");
            leitor.Close();

            if (!File.Exists(caminhoDoArquivo[2]))
            {
                // Cria o arquivo
                StreamWriter estoqueWriter = new StreamWriter(caminhoDoArquivo[2]);

                estoqueWriter.WriteLine("0");
                estoqueWriter.Close();

            }

            ListaProdutos.View = View.Details;
            ListaProdutos.GridLines = true;
            ListaProdutos.FullRowSelect = true;

            int tamanho = 80;
            ListaProdutos.Columns.Add("Codigo", tamanho);
            ListaProdutos.Columns.Add("Nome", tamanho);
            ListaProdutos.Columns.Add("Preço", tamanho);
            ListaProdutos.Columns.Add("Quantidade", tamanho);

            produtos.Ler(caminhoDoArquivo[2]);
            produtos.AtualizarTabela(ListaProdutos);

        }

        private void CancelarAdicionar_Click(object sender, EventArgs e)
        {
            nomeproduto.Text = "";
            codigoproduto.Text = "";
            precoproduto.Text = "";
            codigoremover.Text = "";

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            produtos.Salvar(caminhoDoArquivo[2]);
        }
    }
    public class produto
    {
        public produto proximo;
        public produto anterior;

        public int codigo;
        public string nome;
        public double preco;
        public int quantidade;

        public produto(int codigoInput, string nomeInput, double precoInput, int quantidadeInput)
        {
            anterior = null;
            proximo = null;

            codigo = codigoInput;
            nome = nomeInput;
            preco = precoInput;
            quantidade = quantidadeInput;
        }
    }

    public class estoque
    {
        public produto primeiro;
        public produto ultimo;

        public int quantidadeEmEstoque;

        public estoque()
        {
            primeiro = null;
            ultimo = null;
            quantidadeEmEstoque = 0;
        }

        public void Adicionar(int codigoInput, string nomeInput, double precoInput, int quantidadeInput)
        {
            produto novoProduto = new produto(codigoInput, nomeInput, precoInput, quantidadeInput);

            if (ultimo == null)
            {
                primeiro = novoProduto;
                ultimo = novoProduto;
            }
            else
            {
                novoProduto.anterior = ultimo;
                ultimo.proximo = novoProduto;
                ultimo = novoProduto;
            }
            quantidadeEmEstoque++;
        }

        public void Remover(produto produtoASerRemovido)
        {
            produto aux = produtoASerRemovido;

            produto auxProximo = produtoASerRemovido.proximo;
            produto auxAnterior = produtoASerRemovido.anterior;

            auxAnterior.proximo = auxProximo;
            auxProximo.anterior = auxAnterior;

            aux.anterior = null;
            aux.proximo = null;

            quantidadeEmEstoque--;
        }

        public produto EncontrarProduto(int codigo)
        {
            produto atual = primeiro;

            while (atual != null)
            {
                if (atual.codigo == codigo)
                {
                    return atual;
                }
                atual = atual.proximo;
            }
            return null;
        }

        public void Salvar(string caminhoDoArquivo)
        {

            produto atual = primeiro;

            StreamWriter estoqueG = new StreamWriter(caminhoDoArquivo);

            estoqueG.WriteLine(quantidadeEmEstoque.ToString());

            while (atual != null)
            {
                estoqueG.WriteLine($"{atual.codigo};{atual.nome};{atual.preco};{atual.quantidade}");
                atual = atual.proximo;
            }

            estoqueG.Close();

        }

        public void Ler(string caminhoDoArquivo)
        {

            StreamReader estoqueReader = new StreamReader(caminhoDoArquivo);

            int N = int.Parse(estoqueReader.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] linha = estoqueReader.ReadLine().Split(';');
                Adicionar(int.Parse(linha[0]), linha[1], double.Parse(linha[2]), int.Parse(linha[3]));
            }

            estoqueReader.Close();

            quantidadeEmEstoque = N;

        }

        public void AtualizarTabela(System.Windows.Forms.ListView listView1)
        {
            listView1.Items.Clear();

            produto atual = primeiro;

            while (atual != null)
            {
                string temp = $"{atual.codigo}";
                ListViewItem item = new ListViewItem(temp);

                item.SubItems.Add($"{atual.nome}");
                item.SubItems.Add($"R$ {atual.preco}");
                item.SubItems.Add($"{atual.quantidade}");

                listView1.Items.Add(item);
                atual = atual.proximo;
            }

        }
    }
}
