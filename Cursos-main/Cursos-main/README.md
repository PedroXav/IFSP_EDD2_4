# Sistema de Gerenciamento de Cursos

Este projeto é uma aplicação simples em C# que simula o gerenciamento de cursos, disciplinas e alunos em uma escola. Ele permite realizar operações como adicionar e remover cursos, gerenciar disciplinas e matricular ou desmatricular alunos.

## Funcionalidades

A aplicação oferece as seguintes funcionalidades:

### 1. **Adicionar Curso**
   - Permite ao usuário adicionar um novo curso à escola, informando o ID e a descrição do curso.
   - Limite de 5 cursos.

### 2. **Pesquisar Curso**
   - Busca um curso pelo seu ID.
   - Exibe a descrição do curso e uma lista de suas disciplinas associadas.

### 3. **Remover Curso**
   - Remove um curso da escola pelo seu ID, desde que não haja disciplinas associadas ao curso (sem disciplinas ou com todas as disciplinas removidas).

### 4. **Adicionar Disciplina ao Curso**
   - Permite adicionar uma disciplina a um curso existente.
   - Limite de 12 disciplinas por curso.

### 5. **Pesquisar Disciplina**
   - Busca uma disciplina pelo ID dentro de um curso específico.
   - Exibe informações sobre a disciplina e os alunos matriculados.

### 6. **Remover Disciplina do Curso**
   - Remove uma disciplina de um curso, desde que não haja alunos matriculados na disciplina.
   - O método verifica se a disciplina está vazia antes de permitir a remoção.

### 7. **Matricular Aluno em Disciplina**
   - Matricula um aluno em uma disciplina específica, verificando se há vagas disponíveis (máximo de 15 alunos por disciplina).
   - O método também verifica se o aluno já está matriculado em 6 disciplinas ou mais antes de permitir a matrícula.

### 8. **Desmatricular Aluno de Disciplina**
   - Remove um aluno de uma disciplina com base no ID do aluno.
   - O aluno será removido da lista de matriculados, liberando uma vaga na disciplina.

### 9. **Pesquisar Aluno**
   - Permite buscar por um aluno pelo nome em todas as disciplinas de todos os cursos.
   - Exibe em qual disciplina o aluno está matriculado, caso encontrado.
   - Se o aluno não for encontrado, o sistema exibe uma mensagem indicando isso.

## Estrutura do Projeto

O projeto contém as seguintes classes principais:

### 1. **Escola**
   - Gerencia os cursos da escola (até 5 cursos).
   - Contém métodos para adicionar, pesquisar e remover cursos, além de um método para pesquisar alunos em todas as disciplinas de todos os cursos.

### 2. **Curso**
   - Representa um curso com até 12 disciplinas.
   - Contém métodos para adicionar, pesquisar e remover disciplinas. Também possui um método para verificar se o curso está vazio de disciplinas.

### 3. **Disciplina**
   - Representa uma disciplina com até 15 alunos.
   - Contém métodos para matricular e desmatricular alunos.
   - Possui um método para verificar quais alunos estão matriculados na disciplina.

### 4. **Aluno**
   - Representa um aluno com um ID e nome.
   - Inclui um método para verificar se o aluno pode se matricular em mais disciplinas (máximo de 6 disciplinas por aluno).


