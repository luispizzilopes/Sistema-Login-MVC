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
            conexao.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DbLogin;Data Source=DESKTOP-CK95DQO\SQLEXPRESS01";
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
