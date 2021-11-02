using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCronogramaAula.Model
{
    class Crono
    {
        private static int codigo;
        private static int codigoUcFk;
        private static int codigoTurmaFk;
        private static int codigoSalaFk;
        private static int codigoProfFK;
        private static DateTime dataAula;
        private static string retorno;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static int CodigoUcFk { get => codigoUcFk; set => codigoUcFk = value; }
        public static int CodigoTurmaFk { get => codigoTurmaFk; set => codigoTurmaFk = value; }
        public static int CodigoSalaFk { get => codigoSalaFk; set => codigoSalaFk = value; }
        public static int CodigoProfFK { get => codigoProfFK; set => codigoProfFK = value; }
        public static DateTime DataAula { get => dataAula; set => dataAula = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
