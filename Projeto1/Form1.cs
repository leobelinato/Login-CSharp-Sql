using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient; // usara conexao com banco sql
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projeto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = txt_login; // FOCA NO CAMPO TXTBOX LOGIN

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
            
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Teste");

            /* try             //TENTARÁ FAZER CONEXAO COM BANCO, CASO CONSIGA CONECTAR MOSTRA CONEXAO BEM SUCEDIDA SE NAO O ERRO 
                           //EM SQL E A TRATATIVA
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=DESKTOP-MH32JLG\MSSQLSERVER2;Initial Catalog=Banco1;User ID=sa;Password=000593656";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                MessageBox.Show("Conexão bem sucedida! !");
                cnn.Close();
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" +
                "Verifique os dados informados" + erro);
            } 
            */

            Controle controle = new Controle();  //começa por aqui
            controle.Acessar(txt_login.Text, txt_senha.Text);           
            if (controle.tem)
            {
                // MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information); //SUCESSO AO LOGAR

                

                Home home = new Home();
                this.Hide();
                home.Show();

               

                //this.Hide(); //Esconde a tela

                // Application.Exit(); //encerra a aplicacao
            }

            else
            {
                MessageBox.Show("Usuário não encontrado, verifique login ou senha", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            


        }
    }
}
