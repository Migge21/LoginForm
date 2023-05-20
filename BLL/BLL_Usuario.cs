using LoginForm.DAL;
using LoginForm.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoginForm.BLL
{
    internal class BLL_Usuario
    {
        ConexaoBD bd = new ConexaoBD();
        private string sql;
        public void Cad_Usuario(DTO_Usuario usuario)
        {
            try
            {
                string sql = string.Format("insert into usuario values(null,'{0}','{1}','{2}','{3}')", usuario.Nome1, usuario.Usuario, usuario.Email, usuario.Senha);
                bd.AlterarTabela(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Editar_Usuario(DTO_Usuario usuario)
        {
            try
            {
                string sql = string.Format("update usuario set nome='{0}',usuario='{1}',email='{2}',senha='{3}' where id='{4}')", usuario.Nome1, usuario.Usuario, usuario.Email, usuario.Senha, usuario.Id);
                bd.AlterarTabela(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Excluir_Usuario(DTO_Usuario usuario)
        {
            try
            {
                string sql = string.Format("delete from usuario where id=´{0}'", usuario.Id);
                bd.AlterarTabela(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Listar_Usuario()
        {
            try
            {
                return bd.ConsultarTabelas("select * from usuario");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
