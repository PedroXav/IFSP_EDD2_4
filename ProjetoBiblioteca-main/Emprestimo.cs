using System;

namespace ProjetoBiblioteca
{
    public class Emprestimo
    {
        private DateTime dtEmprestimo;
        private DateTime dtDevolucao;

        public DateTime DtEmprestimo
        {
            get => dtEmprestimo;
            set => dtEmprestimo = value;
        }

        public DateTime DtDevolucao
        {
            get => dtDevolucao;
            set => dtDevolucao = value;
        }
    }
}