using System.ComponentModel.Design.Serialization;
using System.Reflection.Metadata;
using static aed_trabalho.Início;

namespace aed_trabalho
{
    public partial class Início : Form
    {

       public account[] acc = new account[100];
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
                if (txtUsuario.Text!=null && txtSenha.Text!=null)
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
                    

                    var menu=  new Menu();
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
            for (int i=0;i<acc.Length;i++)
            {
                if (acc[i].name != null && acc[i].name == text)
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
    }
}