using SistemaLoginMVC.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoginMVC.Models
{
    internal class LoginModel
    {
        ConexaoBd conexao = new ConexaoBd();
        SqlCommand comandos = new SqlCommand();

        public bool Acessar(string usuario, string senha)
        {
            conexao.StrSql = "select * from TabelaLogin where usuario = @usuario and senha = @senha"; 
            comandos.CommandText = conexao.StrSql;
            comandos.Connection = conexao.Conectar();
            comandos.Parameters.AddWithValue("@usuario", usuario);
            comandos.Parameters.AddWithValue("@senha", senha); 
            try
            {
                using(SqlDataReader reader = comandos.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString(), "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally { conexao.Desconectar(); }
        }

        public bool Cadastrar(string usuario, string senha)
        {
            conexao.StrSql = "select * from TabelaLogin where usuario = @usuario";
            comandos.CommandText = conexao.StrSql;
            comandos.Connection = conexao.Conectar();
            comandos.Parameters.AddWithValue("@usuario", usuario);
            try
            {
                using(SqlDataReader data = comandos.ExecuteReader())
                {
                    if(data.HasRows != true)
                    {
                        conexao.StrSql = "insert into TabelaLogin values (@usuario, @senha)"; 
                        comandos.CommandText = conexao.StrSql;
                        comandos.Parameters.AddWithValue("@usuario", usuario);
                        comandos.Parameters.AddWithValue("@senha", senha);
                        try
                        {
                            comandos.ExecuteNonQuery(); 
                            return true; 
                        }
                        catch (SqlException e)
                        {
                            MessageBox.Show(e.ToString(), "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false; 
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString(), "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally { conexao.Desconectar(); }
        }
    }
}
