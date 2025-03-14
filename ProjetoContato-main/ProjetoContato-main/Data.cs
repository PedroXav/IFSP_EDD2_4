using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoContato
{
    public class Data
    {
        private int dia;
        private int mes;
        private int ano;

        // Propriedades públicas para acessar os atributos privados
        public int Dia 
        { 
            get => dia; 
            set => dia = value; 
        }

        public int Mes 
        { 
            get => mes; 
            set => mes = value; 
        }

        public int Ano 
        { 
            get => ano; 
            set => ano = value; 
        }

        // Método público para definir a data
        public void SetData(int dia, int mes, int ano)
        {
            Dia = dia;
            Mes = mes;
            Ano = ano;
        }

        // Retorna a data formatada como string
        public override string ToString()
        {
            return $"{Dia:D2}/{Mes:D2}/{Ano}";
        }
    }
}