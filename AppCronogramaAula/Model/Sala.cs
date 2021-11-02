using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCronogramaAula.Model
{
    class Sala
    {
        private static int codigo;
        private static string nomeSala;
        private static string tipoSala;
        private static string retorno;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string NomeSala { get => nomeSala; set => nomeSala = value; }
        public static string TipoSala { get => tipoSala; set => tipoSala = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
