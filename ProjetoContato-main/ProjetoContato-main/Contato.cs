using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoContato
{
    public class Contato
    {
        private string email;
        private string nome;
        private Data dtNasc;
        private List<Telefone> telefones;

        // Construtor que inicializa a lista de telefones
        public Contato()
        {
            telefones = new List<Telefone>();
        }

        // Propriedades públicas para acessar os atributos privados
        public string Email 
        { 
            get => email; 
            set => email = value; 
        }

        public string Nome 
        { 
            get => nome; 
            set => nome = value; 
        }

        public Data DtNasc 
        { 
            get => dtNasc; 
            set => dtNasc = value; 
        }

        public List<Telefone> Telefones 
        { 
            get => telefones; 
            set => telefones = value; 
        }

        // Calcula a idade com base na data de nascimento
        public int GetIdade()
        {
            int idade = DateTime.Now.Year - DtNasc.Ano;
            if (DateTime.Now.Month < DtNasc.Mes || 
                (DateTime.Now.Month == DtNasc.Mes && DateTime.Now.Day < DtNasc.Dia))
            {
                idade--;
            }
            return idade;
        }

        // Adiciona um telefone à lista de telefones
        public void AddTelefone(Telefone t)
        {
            telefones.Add(t);
        }

        // Retorna o número do telefone principal, se houver
        public string? GetTelefonePrincipal()
        {
            foreach (Telefone t in telefones)
            {
                if (t.Principal)
                {
                    return t.Numero;
                }
            }
            return null;
        }

        // Retorna as informações do contato em formato de string
        public override string ToString()
        {
            return $"{Nome} - {Email} - {DtNasc} - {GetTelefonePrincipal()}";
        }

        // Compara dois contatos pelo email
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }
            Contato c = (Contato)obj;
            return email.Equals(c.email);
        }
    }
}