using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_poo2_20240228
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgendaTelefonica a = new AgendaTelefonica("Daniel");

            a.Inserir("Daniel", "00009999");
        }
    }
}
