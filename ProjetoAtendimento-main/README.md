# Sistema de Atendimento - Windows Forms

Este é um sistema de gerenciamento de senhas para atendimento em guichês, desenvolvido em C# utilizando a biblioteca Windows Forms. Ele simula a organização de filas em um ambiente de atendimento, permitindo a geração de senhas, controle de guichês e o monitoramento de atendimentos realizados.

---

## Funcionalidades Principais

### Gerar Senhas
- Cria senhas sequenciais que são adicionadas à fila de atendimento.

### Adicionar Guichês
- Permite criar novos guichês para atendimento.
- Cada guichê possui um identificador único.

### Chamar Senhas
- Um guichê pode chamar a próxima senha disponível na fila.
- A senha chamada é movida da fila de senhas para o histórico de atendimentos do guichê.

### Listar Senhas
- Exibe todas as senhas pendentes na fila de atendimento.

### Listar Atendimentos
- Mostra o histórico de senhas atendidas por um guichê específico.

---

## Estrutura do Projeto

### Classes Principais

#### **Form1**
- Interface gráfica que permite interação com o sistema, implementando botões, listas e campos de texto para realizar as operações.

#### **Senha**
- Representa uma senha de atendimento, contendo informações como ID, data e hora de geração e atendimento.

#### **Senhas**
- Gerencia a fila de senhas, incluindo a geração de novas senhas.

#### **Guiche**
- Representa um guichê de atendimento, com um ID único e uma lista de senhas atendidas.

#### **Guiches**
- Controla a lista de guichês disponíveis no sistema.

---

## Como Utilizar o Sistema

### Iniciar o Sistema
- O sistema inicia com 0 guichês e uma fila de senhas vazia.

### Gerar Senhas
- Clique no botão **"Gerar"** para adicionar senhas à fila.

### Adicionar Guichês
- Clique em **"Adicionar Guichê"** para criar novos guichês.

### Chamar Senhas
- Insira o número do guichê no campo de texto e clique em **"Chamar"** para chamar a próxima senha.

### Listar Senhas
- Clique em **"Listar Senhas"** para visualizar as senhas pendentes.

### Listar Atendimentos
- Insira o número do guichê e clique em **"Listar Atendimentos"** para exibir o histórico de senhas atendidas.

---

## Tecnologias Utilizadas
- **C#**
- **Windows Forms**

---

## Desenvolvedor
**Pedro Xavier Oliveira**

 
