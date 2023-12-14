using aed_trabalho;
using System.Security.Cryptography.X509Certificates;
using static aed_trabalho.Login;
using System.Text;


namespace cadastronovo
{
    public partial class Form1 : Form
    {
        listaUsuarios lista = new listaUsuarios();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Se não existir o arquivo quando a pagina carregar ele vai ser criado
            if (!File.Exists("contas.txt"))
            {
                using (StreamWriter sw = new StreamWriter("contas.txt", true))
                {
                    sw.WriteLine("0");
                }
            }
            //Le os usuarios ja salvos no arquivo
            lista.lerUsuarios();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            voltarParaOLogin();
        }

        private void voltarParaOLogin()
        {
            Thread t1;
            this.Close();
            t1 = new Thread(voltarLogin);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void voltarLogin()
        {

            Application.Run(new Login());
        }

        private void autoLogar()
        {
            Thread t1;
            this.Close();
            t1 = new Thread(novomenu);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void novomenu()
        {
            Application.Run(new Menu());
        }



        public void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtusuario.Text) || string.IsNullOrEmpty(txtsenha.Text))
            {
                MessageBox.Show("Preencha todas as informações antes de cadastrar um usuário.");
                return;
            }

            //Adiciona na lista o novo usuario (so salva quando a janela for fechada)
            lista.adicionar(txtusuario.Text, txtsenha.Text);
            //MessageBox.Show($"Usuário -{txtusuario.Text}- cadastrado com sucesso");
            StreamWriter gravadorContas = new StreamWriter("acessoRapido.txt");

            gravadorContas.WriteLine($"{txtusuario.Text};{lista.ultimo.senha};{txtusuario.Text}_estoque.txt");
            gravadorContas.Close();

            autoLogar();
            //Retorna o retorno de uma função
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Quando a janela for fechada salva os dados
            lista.salvarUsuarios();
        }
    }
}


//Mudança geral na classe em processo, ela vai ser utilizada em quase todas as janelas, por isso esta sendo modificada - Yago
public class listaUsuarios
{
    public int quantidadeSalva;
    public Usuario primeiro;
    public Usuario ultimo;

    public listaUsuarios()
    {
        quantidadeSalva = 0;
        primeiro = null;
        ultimo = null;
    }

    //Adiciona um novo usuario a lista
    public void adicionar(string EntradaUsername, string EntradaSenha)
    {
        Usuario novoUsuario = new Usuario(EntradaUsername, EntradaSenha);

        if (primeiro == null)
        {
            primeiro = novoUsuario;
            ultimo = novoUsuario;
        }
        else
        {
            ultimo.proximo = novoUsuario;
            ultimo = novoUsuario;
        }
        quantidadeSalva++;
    }

    //Le todos os usuario salvos no arquivo

    public void lerUsuarios()
    {
        StreamReader estoqueReader = new StreamReader("contas.txt");
        int quantidadeASerLida = int.Parse(estoqueReader.ReadLine());

        while (quantidadeSalva < quantidadeASerLida)
        {
            string[] linha = estoqueReader.ReadLine().Split(";");
            adicionar(linha[0], linha[1]);
        }

        estoqueReader.Close();
    }

    //Salva todos os usuarios no arquivo
    public void salvarUsuarios()
    {
        StreamWriter gravadorContas = new StreamWriter("contas.txt");

        gravadorContas.WriteLine($"{quantidadeSalva}");

        Usuario usuarioAtual = primeiro;

        for (int i = 0; i < quantidadeSalva; i++)
        {
            gravadorContas.WriteLine($"{usuarioAtual.username};{usuarioAtual.senha};{usuarioAtual.username}_estoque.txt");
            usuarioAtual = usuarioAtual.proximo;
        }

        gravadorContas.Close();
    }

   


}

public class Usuario
{
    public string username;
    public string senha;

    public Usuario proximo = null;

    public Usuario(string EntradaUsername, string EntradaSenha)
    {
        username = EntradaUsername;
        senha = Criptografa(EntradaSenha);

    }
    public static string Criptografa(string senha)
    {
        int deslocamento = 3; // Valor de deslocamento da cifra de César
        StringBuilder senhaCriptografada = new StringBuilder(senha.Length); //Serve para manipular a string senha mais facilmente

        for (int i = 0; i < senha.Length; i++)
        {
            int caractereCriptografado = senha[i] + deslocamento;
            senhaCriptografada.Append((char)caractereCriptografado);
        } //For colocando cada dígito +3 pra frente

        return senhaCriptografada.ToString();
    }
}

