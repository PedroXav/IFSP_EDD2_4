using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursos
{
    internal class Escola
    {
        public Curso[] Cursos { get; set; } = new Curso[5];

        public bool AdicionarCurso(Curso curso)
        {
            for (int i = 0; i < Cursos.Length; i++)
            {
                if (Cursos[i] == null)
                {
                    Cursos[i] = curso;
                    return true;
                }
            }
            return false;
        }

        public Curso PesquisarCurso(int idCurso)
        {
            return Array.Find(Cursos, c => c != null && c.id == idCurso);
        }

        public bool RemoverCurso(int idCurso)
        {
            for (int i = 0; i < Cursos.Length; i++)
            {
                if (Cursos[i]?.id == idCurso && !Cursos[i].Disciplinas.Any(d => d != null))
                {
                    Cursos[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void PesquisarAluno(string nomeAluno)
        {
            bool alunoEncontrado = false;

            foreach (var curso in Cursos)
            {
                if (curso != null)
                {
                    foreach (var disciplina in curso.Disciplinas)
                    {
                        if (disciplina != null)
                        {
                            foreach (var aluno in disciplina.Alunos)
                            {
                                if (aluno?.nome == nomeAluno)
                                {
                                    Console.WriteLine($"\nAluno {nomeAluno} está matriculado na disciplina {disciplina.descricao}.");
                                    alunoEncontrado = true;
                                }
                            }
                        }
                    }
                }
            }

            if (!alunoEncontrado)
            {
                Console.WriteLine($"\nAluno {nomeAluno} não encontrado em nenhuma disciplina.");
            }
        }
    }    
}