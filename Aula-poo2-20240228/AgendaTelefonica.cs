using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_poo2_20240228
{
    internal class AgendaTelefonica
    {
        public string proprietario { get; set; }

        public List<Contato> contatos { get; set; }

        public AgendaTelefonica(string proprietario)
        {
            contatos = new List<Contato>();
            this.proprietario = proprietario;
        }

        public void Inserir (string nome, string telefone)
        {
            //Contato c = new Contato(nome, telefone);
            contatos.Add(new Contato(nome, telefone));
        }

        public Contato Buscar (string nome)
        {
            foreach(Contato c in contatos)
            {
                if (c.nome.Contains(nome))
                {
                    return c;
                }
            }
            return null;
        }

        public void Remover(string nome)
        {
            Contato C = Buscar(nome);
            if (contatos.Remove(C))
            {
                Console.WriteLine("Removido");
            }
            else
            {
                Console.WriteLine("Não existe este contato");
            }
        }

        public int Tamanho()
        {
            return contatos.Count;
        }
    }
}
