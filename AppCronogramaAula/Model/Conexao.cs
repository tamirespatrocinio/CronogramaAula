using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCronogramaAula.Model

{
    class Conexao
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tamires\source\repos\AppCronogramaAula\AppCronogramaAula\bdcronograma_aula.mdf;Integrated Security=True";
        }
    }
}
