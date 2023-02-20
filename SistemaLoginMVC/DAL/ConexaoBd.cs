using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoginMVC.DAL
{
    internal class ConexaoBd
    {
        SqlConnection conexao = new SqlConnection();
        public string? StrSql { get; set; }

        public ConexaoBd() 
        {
            conexao.ConnectionString = LocalConexao(); 
        }

        public string LocalConexao()
        {
            using(StreamReader reader = new StreamReader("LocalBd.dll"))
            {
                return reader.ReadToEnd();
            }
        }

        public SqlConnection Conectar()
        {
            conexao.Open();
            return conexao; 
        }

        public void Desconectar()
        {
            conexao.Close();
        }
    }
}
