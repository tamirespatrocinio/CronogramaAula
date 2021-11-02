using System;
using System.Windows.Forms;
using AppCronogramaAula.Model;
using AppCronogramaAula.Controller;

namespace AppCronogramaAula.Views
{
    public partial class TelaCadAluno : Form
    {
        public TelaCadAluno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno.NomeAluno = tbNomeAluno.Text;
            Aluno.EmailAluno = tbEmailAluno.Text;
            Aluno.FoneAluno = tbContatoAluno.Text;

            AlunoController alunoController = new AlunoController();
            alunoController.cadastroAluno();

            tbNomeAluno.Clear();
            tbEmailAluno.Clear();
            tbContatoAluno.Clear();

            if(Aluno.Retorno == "True")
            {
                this.Close();
            }
        }
    }
}
