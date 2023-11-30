using System.ComponentModel.Design.Serialization;
using System.Reflection.Metadata;
using static aed_trabalho.Início;

namespace aed_trabalho
{
    public partial class Início : Form
    {

        public List<account> acc = new List<account>();
        public Início()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtSenha.Text))
                {
                    if (UserExists(txtUsuario.Text))
                    {
                        MessageBox.Show("Usuário já existe. Escolha outro nome de usuário.");
                        txtUsuario.Focus();
                        return;
                    }

                    account Acc = new account();
                    Acc.name = txtUsuario.Text;
                    Acc.password = txtSenha.Text;

                    acc.Add(Acc);

                   

                    var menu = new Menu();
                    menu.Show();

                    this.Visible = false;
                }
                else 
                {
                    MessageBox.Show("Preencha todas as informações!");
                    txtUsuario.Focus();
                    txtSenha.Text = "";
                }
            }

          
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar: " + ex.Message);
            }
        }

        private bool UserExists(string text)
        {
            for (int i = 0; i < acc.Count; i++)
            {
                if (acc[i].name == text)
                {
                    return true;
                }
            }
            return false;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

       


        public class account
        {
            public string name = "";
            public string password = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}