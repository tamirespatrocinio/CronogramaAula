using System.Data;
using AppCronogramaAula.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppCronogramaAula.Controller
{
    class ProfessorController
    {
        public void cadastroProfessor()
        {

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pCadastrarProfessor", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                MessageBox.Show(Professor.NomeProf + Professor.EmailProf + Professor.FoneProf);
                comando.Parameters.AddWithValue("@nome", Professor.NomeProf);
                comando.Parameters.AddWithValue("@email", Professor.EmailProf);
                comando.Parameters.AddWithValue("@telefone", Professor.FoneProf);

                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Professor cadastrado com sucesso! \n" +
                    "Deseja cadastrar outro Professor?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Professor.Retorno = "False";
                    return;
                }
                else
                {
                    Professor.Retorno = "True";
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Professor não cadastrado", "Atenção");
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }


        }

        public void visuCodigoProfessor()
        {

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscaCodigoProfessor", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {

                comandos.Parameters.AddWithValue("@codigo", Professor.Codigo);
                conexao.Open();

                var tabelaDados = comandos.ExecuteReader();

                if (tabelaDados.Read())
                {
                    Professor.NomeProf = tabelaDados["Nome"].ToString();
                    Professor.EmailProf = tabelaDados["Email"].ToString();
                    Professor.FoneProf = tabelaDados["Telefone"].ToString();
                    Professor.Retorno = "True";

                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Professor.Retorno = "False";
                }

            }
            catch
            {
                MessageBox.Show("Não foi possível localizar os dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        public static BindingSource visuNomeProfessor()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscaNomeProfessor", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            comandos.Parameters.AddWithValue("@nome", "%" + Professor.NomeProf + "%");
            conexao.Open();
            comandos.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;

        }

        public void alterarProfessor()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pAlterarAluno", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", Professor.Codigo);
                comandos.Parameters.AddWithValue("@nome", Professor.NomeProf);
                comandos.Parameters.AddWithValue("@email", Professor.EmailProf);
                comandos.Parameters.AddWithValue("@telefone", Professor.FoneProf);

                conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("Professor alterado com sucesso!");
                Professor.Retorno = "True";
            }
            catch
            {
                MessageBox.Show("Professor não alterado.");
                Professor.Retorno = "False";
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        public void deletarProfessor()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pDeletarProfessor", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", Professor.Codigo);
                conexao.Open();
                comandos.ExecuteNonQuery();
                Professor.Retorno = "True";
                MessageBox.Show("Professor excluido com sucesso!");

            }
            catch
            {
                MessageBox.Show("Professor não Excluido.");
                Professor.Retorno = "False";
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
