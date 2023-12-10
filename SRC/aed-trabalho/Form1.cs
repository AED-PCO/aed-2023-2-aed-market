namespace cadastronovo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            this.Close();
        }

        public void button3_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario(txtusuario.Text, txtsenha.Text);

            using (StreamWriter sw = new StreamWriter("contas.txt", true))
            {
                sw.WriteLine($"{usuario.username};{usuario.senha};{usuario.username}_estoque.txt");
            }

        }
    }
}


//Mudança geral na classe em processo, ela vai ser utilizada em quase todas as janelas, por isso esta sendo modificada - Yago
public class listaUsuarios
{
    public Usuario ultimo;

    public listaUsuarios()
    {
        ultimo = null;
    }

    public void adicionar(string EntradaUsername, string EntradaSenha)
    {
        Usuario novoUsuario = new Usuario(EntradaUsername, EntradaSenha);

        if(ultimo == null)
        {
            ultimo = novoUsuario;
        }
        else
        {
            ultimo.proximo = novoUsuario;
            ultimo = novoUsuario;
        }
    }

    public void salvarUsuarios()
    {

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
        senha = EntradaSenha;
    }
}