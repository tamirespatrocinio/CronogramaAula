using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCronogramaAula.Model;
using AppCronogramaAula.Controller;

namespace AppCronogramaAula.Views
{
    public partial class TelaBuscaAluno : Form
    {
        public TelaBuscaAluno()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbBuscaNome.Text == "")
            {
                MessageBox.Show("Digite um nome para a busca", "Atenção");
                tbBuscaNome.Focus();
           
                return;
            }

            Aluno.NomeAluno = tbBuscaNome.Text;
            AlunoController aluno = new();
            dataGridViewNomeAluno.DataSource = AlunoController.visuNomeAluno();
          
            dataGridViewNomeAluno.Columns[0].Visible = false;
            dataGridViewNomeAluno.Columns[1].Visible = false;
            dataGridViewNomeAluno.Columns[2].Visible = false;
            dataGridViewNomeAluno.Columns[3].Visible = false;
            dataGridViewNomeAluno.Columns[4].HeaderCell.Value = "Código";
            //dataGridViewNomeAluno.Columns[5].HeaderCell.Value = "Aluno";
            //dataGridViewNomeAluno.Columns[6].HeaderCell.Value = "E-mail";
            //dataGridViewNomeAluno.Columns[3].HeaderCell.Value = "Fone";


            if (dataGridViewNomeAluno.Rows.Count == 1)
            {
                MessageBox.Show("Não existe este Nome","Atenção");
            }
          

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbDigiteCodigo.Text == "")
            {
                MessageBox.Show("Digite um código para a busca", "Atenção");
                tbDigiteCodigo.Focus();
                tbMostraCodigo.Clear();
                tbNome.Clear();
                tbEmail.Clear();
                tbFone.Clear();
                return;
            }
            else
            {
                Aluno.Codigo = Convert.ToInt32(tbDigiteCodigo.Text);
                AlunoController aluno = new AlunoController();
                aluno.visuCodigoAluno();
                tbNome.Text = Aluno.NomeAluno;
                tbEmail.Text = Aluno.EmailAluno;
                tbFone.Text = Aluno.FoneAluno;
                tbMostraCodigo.Text = Aluno.Codigo.ToString();
                btnApagar.Enabled = true;
                btnAlterar.Enabled = true;
            }

            if (Aluno.Retorno == "False")
            {
                
                limpaTudo();
            }
            

        }

        private void TelaBuscaAluno_Load(object sender, EventArgs e)
        {
            btnApagar.Enabled = false;
            btnAlterar.Enabled = false;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
   
            Aluno.Codigo = Convert.ToInt32(tbMostraCodigo.Text);

            AlunoController alunoController = new AlunoController();
            alunoController.deletarAluno();

            limpaTudo();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Aluno.Codigo = Convert.ToInt32(tbMostraCodigo.Text);
            Aluno.NomeAluno = tbNome.Text;
            Aluno.EmailAluno = tbEmail.Text;
            Aluno.FoneAluno = tbFone.Text;

            AlunoController alunoController = new AlunoController();
            alunoController.alterarAluno();

            limpaTudo();

        }

        private void limpaTudo()
        {
         
                Aluno.Codigo = 0;
                Aluno.NomeAluno = "";
                Aluno.EmailAluno = "";
                Aluno.FoneAluno = "";
                tbNome.Clear();
                tbEmail.Clear();
                tbFone.Clear();
                tbMostraCodigo.Clear();

            btnApagar.Enabled = false;
            btnAlterar.Enabled = false;

        }
    }
}
