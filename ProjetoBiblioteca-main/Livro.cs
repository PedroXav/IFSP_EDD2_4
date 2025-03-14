using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoBiblioteca
{
    public class Livro
    {
        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        private List<Exemplar> exemplares;

        public int Isbn
        {
            get => isbn;
            set => isbn = value;
        }

        public string Titulo
        {
            get => titulo;
            set => titulo = value;
        }

        public string Autor
        {
            get => autor;
            set => autor = value;
        }

        public string Editora
        {
            get => editora;
            set => editora = value;
        }

        public List<Exemplar> Exemplares
        {
            get => exemplares;
            set => exemplares = value;
        }

        public Livro()
        {
            exemplares = new List<Exemplar>();
        }

        public void AdicionarExemplar(Exemplar exemplar)
        {
            Exemplares.Add(exemplar);
        }

        public int QtdeExemplares()
        {
            return Exemplares.Count;
        }

        public int QtdeDisponiveis()
        {
            int i = 0;
            foreach (Exemplar exemplar in Exemplares)
            {
                if (exemplar.Disponivel())
                {
                    i++;
                }
            }
            return i;
        }

        public int QtdeEmprestimo()
        {
            int i = 0;
            foreach (Exemplar exemplar in Exemplares)
            {
                if (!exemplar.Disponivel())
                {
                    i++;
                }
            }
            return i;
        }

        public double PercDisponibilidade()
        {
            int total = QtdeExemplares();
            int disponivel = QtdeDisponiveis();

            if (total == 0)
            {
                return 0;
            }
            else
            {
                return (double)disponivel / total * 100;
            }
        }
    }
}
