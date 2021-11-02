using System.Data;
using AppCronogramaAula.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppCronogramaAula.Controller
{
    class CronoController
    {
        public void cadastroCrono()
        {

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pCadastrarCrono", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                MessageBox.Show(Crono.DataAula);
                comando.Parameters.AddWithValue("@dataAula", Crono.DataAula);
               

                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cronograma cadastrado com sucesso! \n" +
                    "Deseja cadastrar outro cronograma?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Crono.Retorno = "False";
                    return;
                }
                else
                {
                    Crono.Retorno = "True";
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Cronograma não cadastrado", "Atenção");
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }


        }

        public void visuCodigoCrono()
        {

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscaCodigoCrono", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {

                comandos.Parameters.AddWithValue("@codigo", Crono.Codigo);
                conexao.Open();

                var tabelaDados = comandos.ExecuteReader();

                if (tabelaDados.Read())
                {
                    Crono.DataAula = tabelaDados["dataAula"].ToString();
                    Crono.Retorno = "True";

                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Crono.Retorno = "False";
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

        public void alterarCrono()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pAlterarCrono", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@dataAula", Crono.DataAula);



                conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("Cronograma alterado com sucesso!");
                Crono.Retorno = "True";
            }
            catch
            {
                MessageBox.Show("Cronograma não alterado.");
                Crono.Retorno = "False";
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        public void deletarCrono()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pDeletarCrono", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", Crono.Codigo);
                conexao.Open();
                comandos.ExecuteNonQuery();
                Crono.Retorno = "True";
                MessageBox.Show("Cronograma excluído com sucesso!");

            }
            catch
            {
                MessageBox.Show("Cronograma não deletado.");
                Crono.Retorno = "False";
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
