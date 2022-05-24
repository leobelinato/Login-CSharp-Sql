using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem ="";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool VerificarLogin(string login, string senha)
        {
            //Comandos Sql para verificar se tem no banco
            cmd.CommandText = "select *from usuarios where nome = @login and senha = @senha";  //manda o comando escrito aqui direto pro banco
            cmd.Parameters.AddWithValue("@login", login);  //vinculo com o login do formulario com o login do banco
            cmd.Parameters.AddWithValue("@senha", senha);  //vinculo da senha com senha do banco

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();   //todos login e senha que foram passados, estarao no dr
                if (dr.HasRows)  //se foi encontrado
                {
                    tem = true;
                }
            }

            catch  //caso nao consiga o try, o bool tem continua falso, retornando erro
            {
                this.mensagem = "Erro com Banco de dados!";
            }

            return tem;
        }
        

        
    }
}
