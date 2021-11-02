using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCronogramaAula.Model
{
    class Turma
    {
        private static int codigo;
        private static string nomeTurma;
        private static DateTime dataInicioTurma;
        private static DateTime dataFimTurma;
        private static string periodoTurma;
        private static string retorno;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string NomeTurma { get => nomeTurma; set => nomeTurma = value; }
        public static DateTime DataInicioTurma { get => dataInicioTurma; set => dataInicioTurma = value; }
        public static DateTime DataFimTurma { get => dataFimTurma; set => dataFimTurma = value; }
        public static string PeriodoTurma { get => periodoTurma; set => periodoTurma = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
