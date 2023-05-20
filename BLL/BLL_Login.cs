using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginForm.DAL;

namespace LoginForm.BLL
{
    internal class BLL_Login
    {
        private static string tipo_usuario;
        private static string nome;
        private static int id;


        public string logar(string Usuario, string Senha)
        {
            ConexaoBD bd = new ConexaoBD();
            string sql;
            DataTable dt;

            sql = string.Format("select * from usuario where usuario='{0}' and senha ='{1}'",Usuario,Senha);
            dt = bd.ConsultarTabelas(sql);
            if(dt.Rows.Count > 0 )
            {
                tipo_usuario = "Usuario";
                nome = dt.Rows[0]["nome"].ToString();
                id = int.Parse(dt.Rows[0]["id"].ToString());
                return "Usuario";
            }
            return "";
        }
        public string Tipo_Usuario()
        {
            return tipo_usuario;
        }
        public string Nome_Usuario()
        {
            return nome;
        }
        public int Id_Usuario()
        {
            return id;
        }
    }
}
