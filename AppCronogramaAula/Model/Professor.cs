using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCronogramaAula.Model
{
    class Professor
    {
        private static int codigo;
        private static string nomeProf;
        private static string emailProf;
        private static string foneProf;
        private static string retorno;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string NomeProf { get => nomeProf; set => nomeProf = value; }
        public static string EmailProf { get => emailProf; set => emailProf = value; }
        public static string FoneProf { get => foneProf; set => foneProf = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
