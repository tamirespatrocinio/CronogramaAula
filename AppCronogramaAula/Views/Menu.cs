using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CronogramaAula;
using CronogramaAula.Views;

namespace AppCronogramaAula.Views
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadAluno cadAluno = new TelaCadAluno();
            cadAluno.Show();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadProf cadProf = new TelaCadProf();
            cadProf.Show();
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadSala cadSala = new TelaCadSala();
            cadSala.Show();
        }

        private void turmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadTurma cadTurma = new TelaCadTurma();
            cadTurma.Show();
        }

        private void unidadeCurricularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadUc cadUc = new TelaCadUc();
            cadUc.Show();
        }

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaBuscaAluno telaBuscaAluno = new TelaBuscaAluno();
            telaBuscaAluno.Show();
        }
    }
}
