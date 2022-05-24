using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class Controle
    {

        public bool tem;
        public String mensagem = "";

        public bool Acessar (String login, String senha) {


            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.VerificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
                
                 }   


    }


}
