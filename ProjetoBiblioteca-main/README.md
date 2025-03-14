# 📝 Biblioteca de Gestão de Empréstimos

Este projeto é uma aplicação de console em C# para gerenciar o empréstimo e devolução de livros em uma biblioteca.

## 🚀 Funcionalidades

A aplicação permite as seguintes operações:

1. **Adicionar Livro**
   - Permite adicionar um novo livro ao acervo da biblioteca, incluindo informações como ISBN, título, autor e editora.
   
2. **Pesquisar Livro (Sintético)**
   - Fornece uma visão resumida das informações do livro, incluindo total de exemplares, exemplares disponíveis, exemplares em empréstimo e percentual de disponibilidade.
   
3. **Pesquisar Livro (Analítico)**
   - Fornece uma visão detalhada das informações do livro, incluindo informações individuais de cada exemplar, histórico de empréstimos e disponibilidade.
   
4. **Adicionar Exemplar**
   - Permite adicionar um novo exemplar a um livro existente na biblioteca, registrando o número do tombo.
   
5. **Registrar Empréstimo**
   - Registra o empréstimo de um exemplar específico de um livro, definindo a data de devolução automaticamente para um mês após a data do empréstimo.
   
6. **Registrar Devolução**
   - Registra a devolução de um exemplar específico de um livro.

## 📂 Estrutura do Projeto

O projeto é composto pelas seguintes classes:

- `Program`
  - Classe principal que contém o método `Main` e os métodos para interagir com o usuário.
  
- `Livros`
  - Classe responsável por gerenciar o acervo de livros da biblioteca.
  
- `Livro`
  - Classe que representa um livro, contendo informações como ISBN, título, autor, editora e a lista de exemplares.
  
- `Exemplar`
  - Classe que representa um exemplar de um livro, incluindo informações como número do tombo e histórico de empréstimos.
  
- `Emprestimo`
  - Classe que representa um empréstimo, incluindo as datas de empréstimo e devolução.

## 👨‍💻 Autor
- **Pedro Xavier Oliveira** - CB3027376

 
