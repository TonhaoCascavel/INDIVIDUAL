using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDIVIDUAL
{
    public class conexao
    {

            //variaveis de conexao
            static private string servidor = "localhost";
            static private string banco = "gerenciamento";
            static private string usuario = "root";
            static private string senha = "";
            //variavel de conexao mysql
            public MySqlConnection conexaoProjeto = null;
            //string com os paramentros do banco
            static private string conexaobd = "server=" + servidor +
            ";database="
            + banco + ";user id=" + usuario + ";password=" + senha;
            /// <summary>
            /// Metodo de conexao comm o banco de dados
            /// </summary>
            /// <returns>conexao do sistema</returns>
            public MySqlConnection getConexao()
            {
                conexaoProjeto = new MySqlConnection(conexaobd);
                return conexaoProjeto;
            }
            public DataTable obterdados(string sql)
            {
                //criando a tabela
                DataTable dt = new DataTable();
                //abrindo o banco de dados
                conexaoProjeto.Open();
                //montando o sql para executar
                MySqlCommand cmd = new MySqlCommand(sql, conexaoProjeto);
                //monta a consulta oos dados
                MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
                adpter.Fill(dt);
                conexaoProjeto.Close();
                return dt;
            }
            public int cadastrar(string[] campos, object[] valores, string
            sql)
            {
                int registro;
                try
                {
                    conexaoProjeto.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conexaoProjeto);
                    //montar as informaçoes passadas
                    for (int i = 0; i < valores.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(campos[i], valores[i]);
                    }
                    registro = cmd.ExecuteNonQuery();
                    conexaoProjeto.Close();
                    return registro;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }
      
    }

}