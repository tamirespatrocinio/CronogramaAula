using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCronogramaAula.Model
{
    class Aluno
    {
        private static int codigo; //quando coloca a visibilidade (private) a var passa para atributo;
        private static string nomeAluno; // private só quem é dono da classe Aluno tem acesso;
        private static string emailAluno; // protected outras classes consegue utilizar, desde que receba herança usando extend;
        private static string foneAluno; //punlic todas as classes tem acesso;
        private static string retorno;

        //O encapsulamento get e set torna possível o acesso da procedure
        public static int Codigo { get => codigo; set => codigo = value; }
        public static string NomeAluno { get => nomeAluno; set => nomeAluno = value; }
        public static string EmailAluno { get => emailAluno; set => emailAluno = value; }
        public static string FoneAluno { get => foneAluno; set => foneAluno = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
