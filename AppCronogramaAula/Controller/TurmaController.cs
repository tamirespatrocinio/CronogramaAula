using System.Data;
using AppCronogramaAula.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppCronogramaAula.Controller
{
    class TurmaController
    {
        public void cadastroTurma()
        {

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pInserirTurma", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                MessageBox.Show(Turma.NomeTurma + Turma.DataInicioTurma + Turma.DataFimTurma + Turma.PeriodoTurma);
                comando.Parameters.AddWithValue("@nome", Turma.NomeTurma);
                comando.Parameters.AddWithValue("@inicio", Turma.DataInicioTurma);
                comando.Parameters.AddWithValue("@fim", Turma.DataFimTurma);
                comando.Parameters.AddWithValue("@periodo", Turma.PeriodoTurma);

                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Turma cadastrada com sucesso! \n" +
                    "Deseja cadastrar outra Turma?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Turma.Retorno = "False";
                    return;
                }
                else
                {
                    Turma.Retorno = "True";
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Turma não cadastrada", "Atenção");
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }


        }

        public void visuCodigoTurma()
        {

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscaCodigoTurma", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {

                comandos.Parameters.AddWithValue("@codigo", Turma.Codigo);
                conexao.Open();

                var tabelaDados = comandos.ExecuteReader();

                if (tabelaDados.Read())
                {
                    Turma.NomeTurma = tabelaDados["Nome"].ToString();
                    Turma.DataInicioTurma = tabelaDados["inicio"].ToString();
                    Turma.DataFimTurma = tabelaDados["fim"].ToString();
                    Turma.PeriodoTurma = tabelaDados["periodo"].ToString();
                    Turma.Retorno = "True";

                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Turma.Retorno = "False";
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

        public static BindingSource visuNomeTurma()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscaNomeTurma", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            comandos.Parameters.AddWithValue("@nome", "%" + Turma.NomeTurma + "%");
            conexao.Open();
            comandos.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;

        }

        public void alterarTurma()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pAlterarTurma", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", Turma.Codigo);
                comandos.Parameters.AddWithValue("@nome", Turma.NomeTurma);
                comandos.Parameters.AddWithValue("@inicio", Turma.DataInicioTurma);
                comandos.Parameters.AddWithValue("@fim", Turma.DataFimTurma);
                comandos.Parameters.AddWithValue("@periodo", Turma.PeriodoTurma);


                conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("Turma alterada com sucesso!");
                Turma.Retorno = "True";
            }
            catch
            {
                MessageBox.Show("Turma não alterada.");
                Turma.Retorno = "False";
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        public void deletarTurma()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pDeletarTurma", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", Turma.Codigo);
                conexao.Open();
                comandos.ExecuteNonQuery();
                Turma.Retorno = "True";
                MessageBox.Show("Turma excluída com sucesso!");

            }
            catch
            {
                MessageBox.Show("Turma não deletada.");
                Turma.Retorno = "False";
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