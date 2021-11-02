using System;
using System.Windows.Forms;
using AppCronogramaAula.Model;
using AppCronogramaAula.Controller;

namespace CronogramaAula.Views
{
    public partial class TelaCadProf : Form
    {
        public TelaCadProf()
        {
            InitializeComponent();
        }
            private void btnCadProf_Click(object sender, EventArgs e)
            {
                Professor.NomeProf = tbNomeProf.Text;
                Professor.EmailProf = tbEmailProf.Text;
                Professor.FoneProf = tbFoneProf.Text;

                ProfessorController professorController = new ProfessorController();
                professorController.cadastroProfessor();

                tbNomeProf.Clear();
                tbEmailProf.Clear();
                tbFoneProf.Clear();

                if (Professor.Retorno == "True")
                {
                    this.Close();
                }
            }
        }
    }

