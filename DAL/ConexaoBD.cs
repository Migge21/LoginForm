using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace LoginForm.DAL
{
    internal class ConexaoBD
    {
        private string string_conexao = "persist security info = false; server = localhost; database = loginform; uid = root; pwd = ;SslMode = none";
        private MySqlConnection conexao;

        public void Conectar()
        {
            try 
            { 
              conexao = new MySqlConnection(string_conexao);
              conexao.Open();
            }
            catch(MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarTabela(string sql)
        {
            try
            {
                Conectar();
                MySqlCommand comandos = new MySqlCommand(sql, conexao);
                comandos.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally 
            { 
                conexao.Close(); 
            }
        }

        public DataTable ConsultarTabelas(string sql)
        {
            try
            {
                Conectar();
                MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
                DataTable dados = new DataTable();
                consulta.Fill(dados);
                return dados;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
    
}
