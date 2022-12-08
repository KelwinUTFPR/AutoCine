using AutoCine.conexao;
using AutoCine.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCine.dao
{
    public class SessaoDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();

        public SessaoDAO()
        {
            conexao.Open();
        }
        public void cadastrar(Sessao obj)
        {
            try
            {
                string sql = @"insert into sessao (numero_sala, horario, id_filme) 
             values (@sala, @horario, @filme)";
                MySqlCommand comandosql = new MySqlCommand(sql, conexao);
                comandosql.Parameters.AddWithValue("@sala", obj.sala);
                comandosql.Parameters.AddWithValue("@horario", obj.horario);
                comandosql.Parameters.AddWithValue("@filme", obj.filme);

                comandosql.ExecuteNonQuery();

                conexao.Close();

                MessageBox.Show("Cadastro efetuado com sucesso", "", MessageBoxButtons.OK);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao inserir: " + erro);
            }
        }

        public DataTable listarSessao(int id_filme)
        {
            string sql = @"select * from sessao where id_filme= " + id_filme + "";

            MySqlCommand comandosql = new MySqlCommand(sql, conexao);

            comandosql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(comandosql);

            DataTable tabelaSessao = new DataTable();
            da.Fill(tabelaSessao);

            conexao.Close();

            return tabelaSessao;
        }

        public Sessao listarSessaoBtn(int id_filme, int sala, string horario)
        {
            string sql = @"select * from sessao where id_filme= " + id_filme + " AND horario = '" + horario + "' AND numero_sala = " + sala + "";

            MySqlCommand comandosql = new MySqlCommand(sql, conexao);

            comandosql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(comandosql);

            DataTable tabelaSessao = new DataTable();
            da.Fill(tabelaSessao);

            Sessao s = new Sessao(tabelaSessao.Rows[0]["id_sessao"].ToString(), tabelaSessao.Rows[0]["numero_sala"].ToString(), tabelaSessao.Rows[0]["horario"].ToString(),
                    tabelaSessao.Rows[0]["id_filme"].ToString());

            return s;
        }
    }
}

