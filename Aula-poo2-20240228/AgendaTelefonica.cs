using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_poo2_20240228
{
    internal class AgendaTelefonica
    {
        List<Contato> listaContatos = new List<Contato>();

        public AgendaTelefonica(List<Contato> listaContatos)
        {
            listaContatos = new List<Contato>();
            this.listaContatos = listaContatos;
        }

        public void Inserir (string nome, string telefone)
        {
            //Contato c = new Contato(nome, telefone);
            listaContatos.Add(new Contato(nome, telefone));
        }

        public Contato Buscar (string nome)
        {
            Contato c;

            foreach(Contato x in listaContatos)
            {
                if (x.nome.Contains(nome))
                {
                    return x;
                }
            }
            return null;
        }
    }
}
