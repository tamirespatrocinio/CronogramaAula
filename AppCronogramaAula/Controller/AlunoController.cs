using System.Data;
using AppCronogramaAula.Model;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace AppCronogramaAula.Controller
{
    class AlunoController
    {

        public void cadastroAluno()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pInserirAluno", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                MessageBox.Show(Aluno.NomeAluno + Aluno.EmailAluno + Aluno.FoneAluno);
                comando.Parameters.AddWithValue("@nome", Aluno.NomeAluno);
                comando.Parameters.AddWithValue("@email", Aluno.EmailAluno);
                comando.Parameters.AddWithValue("@telefone", Aluno.FoneAluno);

                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Aluno cadastrado com sucesso! \n" +
                    "Deseja cadastrar outro Aluno ?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Aluno.Retorno = "False";
                    return;
                }
                else
                {
                    Aluno.Retorno = "True";
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Aluno não cadastrado", "Atenção");
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }


        }

        public void visuCodigoAluno()
        {

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscaCodigoAluno", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {

                comandos.Parameters.AddWithValue("@codigo", Aluno.Codigo);
                conexao.Open();

                var tabelaDados = comandos.ExecuteReader();

                if (tabelaDados.Read())
                {
                    Aluno.NomeAluno = tabelaDados["Nome"].ToString();
                    Aluno.EmailAluno = tabelaDados["Email"].ToString();
                    Aluno.FoneAluno = tabelaDados["Telefone"].ToString();
                    Aluno.Retorno = "True";

                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Aluno.Retorno = "False";
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

        public static BindingSource visuNomeAluno()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscaNomeAluno", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            comandos.Parameters.AddWithValue("@nome", "%" + Aluno.NomeAluno + "%");
            conexao.Open();
            comandos.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;

        }

        public void alterarAluno()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pAlterarAluno", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", Aluno.Codigo);
                comandos.Parameters.AddWithValue("@nome", Aluno.NomeAluno);
                comandos.Parameters.AddWithValue("@email", Aluno.EmailAluno);
                comandos.Parameters.AddWithValue("@telefone", Aluno.FoneAluno);

                conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("Aluno Alterado com sucesso!");
                Aluno.Retorno = "True";
            }
            catch
            {
                MessageBox.Show("Aluno não alterado.");
                Aluno.Retorno = "False";
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        public void deletarAluno()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pDeletarAluno", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", Aluno.Codigo);
                conexao.Open();
                comandos.ExecuteNonQuery();
                Aluno.Retorno = "True";
                MessageBox.Show("Funcionário Excluido com sucesso!");

            }
            catch
            {
                MessageBox.Show("Funcionário não Excluido.");
                Aluno.Retorno = "False";
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