using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    internal class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-MH32JLG\MSSQLSERVER2;Initial Catalog=Banco1;Integrated Security=True";
        }

        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconeectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
