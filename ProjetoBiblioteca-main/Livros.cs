using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoBiblioteca
{
    public class Livros
    {
        private List<Livro> acervo;

        public List<Livro> Acervo
        {
            get => acervo;
        }

        public Livros()
        {
            acervo = new List<Livro>();
        }

        public void Adicionar(Livro livro)
        {
            if (livro != null && !Acervo.Contains(livro))
            {
                acervo.Add(livro);
            }
        }

        public Livro Pesquisar(Livro livro)
        {
            return acervo.FirstOrDefault(l => l.Isbn == livro.Isbn);
        }
    }
}
