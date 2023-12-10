using cadastronovo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace aed_trabalho
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Quando o tamanho da janela muda
        private void Login_ClientSizeChanged(object sender, EventArgs e)
        {
            /*
            int newButtonX = this.ClientSize.Width - BotaoCancelar.Width - 10; // 10 pixels de margem
            int newButtonY = this.ClientSize.Height - BotaoCancelar.Height - 10; // 10 pixels de margem

            BotaoCancelar.Location = new System.Drawing.Point(newButtonX, newButtonY);
            */
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            Thread t1;
            this.Close();
            t1 = new Thread(abrirjanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirjanela()
        {
            Application.Run(new Form1());
        }

    }
}
