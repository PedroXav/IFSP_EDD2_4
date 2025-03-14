using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursos
{
   internal class Curso
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public Disciplina[] Disciplinas { get; set; } = new Disciplina[12];

        public bool AdicionarDisciplina(Disciplina disciplina)
        {
            for (int i = 0; i < Disciplinas.Length; i++)
            {
                if (Disciplinas[i] == null)
                {
                    Disciplinas[i] = disciplina;
                    return true;
                }
            }
            return false;
        }

        public Disciplina PesquisarDisciplina(int idDisciplina)
        {
            return Array.Find(Disciplinas, d => d != null && d.id == idDisciplina);
        }

        public bool RemoverDisciplina(int idDisciplina)
        {
            for (int i = 0; i < Disciplinas.Length; i++)
            {
                if (Disciplinas[i]?.id == idDisciplina && Disciplinas[i].Alunos[0] == null)
                {
                    Disciplinas[i] = null;
                    return true;
                }
            }
            return false;
        }
    }    
}