using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoContato
{
    public class Contatos
    {
         private List<Contato> agenda;

        // Propriedade pública para acessar a lista de contatos (agenda)
        public List<Contato> Agenda 
        { 
            get => agenda; 
            set => agenda = value; 
        }

        // Construtor que inicializa a agenda
        public Contatos()
        {
            Agenda = new List<Contato>();
        }

        // Adiciona um contato à agenda, se ainda não estiver nela
        public bool Adicionar(Contato c)
        {
            if (c != null && !Agenda.Contains(c))
            {
                agenda.Add(c);
                return true;
            }
            return false;
        }

        // Pesquisa um contato pelo email
        public Contato? Pesquisar(string email)
        {
            foreach (Contato c in Agenda)
            {
                if (c.Email.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    return c;
                }
            }
            return null;
        }

        // Altera as informações de um contato existente
        public bool Alterar(Contato c)
        {
            var contatoExistente = Pesquisar(c.Email);
            if (contatoExistente != null)
            {
                contatoExistente.Nome = c.Nome;
                contatoExistente.DtNasc = c.DtNasc;
                contatoExistente.Telefones = c.Telefones;
                return true;
            }
            return false;
        }

        // Remove um contato da agenda
        public bool Remover(Contato c)
        {
            return agenda.Remove(c);
        }
    }
}