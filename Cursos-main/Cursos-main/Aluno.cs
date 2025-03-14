using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursos
{
    internal class Aluno
    {
        public int id { get; set; }
        public string nome { get; set; }

        public bool PodeMatricular(Curso curso)
        {
            int disciplinasMatriculadas = 0;

            foreach (var disciplina in curso.Disciplinas)
            {
                if (disciplina != null && disciplina.Alunos.Contains(this))
                {
                    disciplinasMatriculadas++;
                }
            }

            return disciplinasMatriculadas < 6;
        }
    }

    
}