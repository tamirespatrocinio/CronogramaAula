using System.Data;
using AppCronogramaAula.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppCronogramaAula.Controller
{
    class UcController
    {
        public void cadastroUC()
        {

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pCadastrarUC", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                MessageBox.Show(Uc.NomeUc + Uc.DescUc + Uc.NumAulasUc);
                comando.Parameters.AddWithValue("@nome", Uc.NomeUc);
                comando.Parameters.AddWithValue("@desc", Uc.DescUc);
                comando.Parameters.AddWithValue("@numAulas", Uc.NumAulasUc);


                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("UC cadastrada com sucesso! \n" +
                    "Deseja cadastrar outra UC?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Uc.Retorno = "False";
                    return;
                }
                else
                {
                    Uc.Retorno = "True";
                    return;
                }

            }
            catch
            {
                MessageBox.Show("UC não cadastrada", "Atenção");
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }


        }

        public void visuCodigoUC()
        {

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscaCodigoUC", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {

                comandos.Parameters.AddWithValue("@codigo", Uc.Codigo);
                conexao.Open();

                var tabelaDados = comandos.ExecuteReader();

                if (tabelaDados.Read())
                {
                    Uc.NomeUc= tabelaDados["nome"].ToString();
                    Uc.DescUc= tabelaDados["desc"].ToString();
                    Uc.NumAulasUc= tabelaDados["numAulas"].ToString();
                    Uc.Retorno = "True";

                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Uc.Retorno = "False";
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

        public static BindingSource visuNomeUC()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscaNomeUC", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            comandos.Parameters.AddWithValue("@nome", "%" + Uc.NomeUc + "%");
            conexao.Open();
            comandos.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;

        }

        public void alterarUC()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pAlterarUC", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@nome", Uc.NomeUc);
                comando.Parameters.AddWithValue("@desc", Uc.DescUc);
                comando.Parameters.AddWithValue("@numAulas", Uc.NumAulasUc);


                conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("UC alterada com sucesso!");
                Uc.Retorno = "True";
            }
            catch
            {
                MessageBox.Show("UC não alterada.");
                Uc.Retorno = "False";
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        public void deletarUC()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pDeletarUC", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", Uc.Codigo);
                conexao.Open();
                comandos.ExecuteNonQuery();
                Uc.Retorno = "True";
                MessageBox.Show("UC excluída com sucesso!");

            }
            catch
            {
                MessageBox.Show("UC não deletada.");
                Uc.Retorno = "False";
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
