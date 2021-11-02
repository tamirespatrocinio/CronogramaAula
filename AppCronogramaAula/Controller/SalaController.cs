using System.Data;
using AppCronogramaAula.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppCronogramaAula.Controller
{
    class SalaController
    {
        public void cadastroSala()
        {

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pInserirSala", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                MessageBox.Show(Sala.NomeSala + Sala.TipoSala);
                comando.Parameters.AddWithValue("@nome", Sala.NomeSala);
                comando.Parameters.AddWithValue("@email", Sala.TipoSala);

                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Sala cadastrada com sucesso! \n" +
                    "Deseja cadastrar outra Sala?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Sala.Retorno = "False";
                    return;
                }
                else
                {
                    Sala.Retorno = "True";
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Sala não cadastrada", "Atenção");
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }


        }

        public void visuCodigoSala()
        {

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscaCodigoSala", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {

                comandos.Parameters.AddWithValue("@codigo", Sala.Codigo);
                conexao.Open();

                var tabelaDados = comandos.ExecuteReader();

                if (tabelaDados.Read())
                {
                    Sala.NomeSala = tabelaDados["Nome"].ToString();
                    Sala.TipoSala = tabelaDados["Tipo"].ToString();
                    Sala.Retorno = "True";

                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Sala.Retorno = "False";
                }

            }
            catch
            {
                MessageBox.Show("Não conseguimos localizar os dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        public static BindingSource visuNomeSala()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscaNomeSala", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            comandos.Parameters.AddWithValue("@nome", "%" + Sala.NomeSala + "%");
            conexao.Open();
            comandos.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;

        }

        public void alterarSala()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pAlterarSala", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", Sala.Codigo);
                comandos.Parameters.AddWithValue("@nome", Sala.NomeSala);
                comandos.Parameters.AddWithValue("@tipo", Sala.TipoSala);


                conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("Sala alterada com sucesso!");
                Sala.Retorno = "True";
            }
            catch
            {
                MessageBox.Show("Sala não alterada.");
                Sala.Retorno = "False";
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        public void deletarSala()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pDeletarSala", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", Sala.Codigo);
                conexao.Open();
                comandos.ExecuteNonQuery();
                Sala.Retorno = "True";
                MessageBox.Show("Sala excluída com sucesso!");

            }
            catch
            {
                MessageBox.Show("Sala não deletada.");
                Sala.Retorno = "False";
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }

        }
    }
}