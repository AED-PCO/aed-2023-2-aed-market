﻿using cadastronovo;
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

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Duas funções temporarias, depois fazer uma generica
        static void abrirjanela()
        {
            Application.Run(new Form1());
        }


        private void Logar()
        {
            Application.Run(new Menu());
        }

        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(EntradaUsuario.Text, EntradaSenha.Text);

            if (File.Exists("contas.txt"))
            {
                StreamReader estoqueReader = new StreamReader("contas.txt");
                string linha = estoqueReader.ReadLine();
                string[] dadosDoUsuario;

                while (linha != null)
                {
                    dadosDoUsuario = linha.Split(";");
                    if (usuario.username == dadosDoUsuario[0] && usuario.senha == dadosDoUsuario[1])
                    {

                        Thread t1;
                        this.Close();
                        t1 = new Thread(Logar);
                        t1.SetApartmentState(ApartmentState.STA);
                        t1.Start();

                        StreamWriter gravadorContas = new StreamWriter("acessoRapido.txt");

                        gravadorContas.WriteLine($"{dadosDoUsuario[0]};{dadosDoUsuario[1]};{dadosDoUsuario[0]}_estoque.txt");
                        gravadorContas.Close();

                        break;

                    }
                    linha = estoqueReader.ReadLine();

                }
                estoqueReader.Close();
            }
            else
            {
                MessageBox.Show("Erro A1");
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

        private void Cadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Thread t1;
            this.Close();
            t1 = new Thread(abrirjanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
    }
}
