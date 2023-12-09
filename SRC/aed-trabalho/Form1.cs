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

            Usuario usuario = new Usuario();


            string usuarionome = txtusuario.Text;
            string senha1 = txtsenha.Text;


            usuario.username = usuarionome;
            usuario.senha = senha1;



            using (StreamWriter sw = new StreamWriter("arquivo.txt", true))
            {
                sw.WriteLine($"{usuario.username}, {usuario.senha}");
            }

        }
    }
}

public class Usuario
{
    public string username { get; set; }
    public string senha { get; set; }

}