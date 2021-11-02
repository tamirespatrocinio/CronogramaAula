using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCronogramaAula.Model
{
    class Uc
    {
        private static int codigo;
        private static string nomeUc;
        private static string descUc;
        private static string numAulasUc;
        private static string retorno;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string NomeUc { get => nomeUc; set => nomeUc = value; }
        public static string DescUc { get => descUc; set => descUc = value; }
        public static string NumAulasUc { get => numAulasUc; set => numAulasUc = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
