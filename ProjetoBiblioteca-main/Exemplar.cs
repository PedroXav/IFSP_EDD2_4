using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoBiblioteca
{
    public class Exemplar
    {
        private int tombo;
        private List<Emprestimo> emprestimos;

        public int Tombo
        {
            get => tombo;
            set => tombo = value;
        }

        public List<Emprestimo> Emprestimos
        {
            get => emprestimos;
        }

        public Exemplar()
        {
            emprestimos = new List<Emprestimo>();
        }

       public bool Emprestar()
       {
            if (Disponivel())
            {
                emprestimos.Add(new Emprestimo { DtEmprestimo = DateTime.Now, DtDevolucao = DateTime.Now.AddMonths(1) });
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool Devolver()
        {
            var ultimoEmprestimo = emprestimos.LastOrDefault();
            if (ultimoEmprestimo != null && ultimoEmprestimo.DtDevolucao == DateTime.MinValue)
            {
                ultimoEmprestimo.DtDevolucao = DateTime.Now;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Disponivel()
        {
            var ultimoEmprestimo = emprestimos.LastOrDefault();
            if (ultimoEmprestimo == null)
            {
                return true;
            }
            if (ultimoEmprestimo.DtDevolucao != DateTime.MinValue)
            {
                return true;
            }
            return false;
        }

        public int QtdeEmprestimos()
        {
            return emprestimos.Count;
        }
    }
}