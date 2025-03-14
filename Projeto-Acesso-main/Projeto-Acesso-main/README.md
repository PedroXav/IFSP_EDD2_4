# Controle de Acessos

Este projeto implementa um sistema de controle de acessos para uma empresa que possui diversos ambientes. O sistema verifica as permissões dos usuários e registra todas as ações de acesso e tentativas de acesso em logs, mantendo um histórico de, no máximo, 100 registros por ambiente.

## Estrutura do Projeto

### 1. Classe `Usuario`

A classe `Usuario` representa um usuário do sistema.

- **Atributos:**
  - `id`: Identificador único do usuário (int).
  - `nome`: Nome do usuário (string).
  - `ambientes`: Lista de ambientes aos quais o usuário tem permissão de acesso (`List<Ambiente>`).

- **Métodos:**
  - `concederPermissao(Ambiente ambiente)`: Concede permissão ao usuário para acessar o ambiente especificado.
  - `revogarPermissao(Ambiente ambiente)`: Revoga a permissão do usuário para acessar o ambiente especificado.

### 2. Classe `Ambiente`

A classe `Ambiente` representa um ambiente controlado.

- **Atributos:**
  - `id`: Identificador único do ambiente (int).
  - `nome`: Nome do ambiente (string).
  - `logs`: Fila de logs de acesso (`Queue<Log>`).

- **Métodos:**
  - `registrarLog(Log log)`: Registra um novo log de acesso. Se houver mais de 100 logs, o log mais antigo é removido.

### 3. Classe `Log`

A classe `Log` representa um registro de acesso.

- **Atributos:**
  - `dtAcesso`: Data e hora do acesso (DateTime).
  - `usuario`: Usuário que tentou acessar o ambiente (`Usuario`).
  - `tipoAcesso`: Tipo de acesso (boolean; `true` para autorizado, `false` para negado).

### 4. Classe `Cadastro`

A classe `Cadastro` gerencia os usuários e ambientes do sistema.

- **Atributos:**
  - `usuarios`: Lista de usuários (`List<Usuario>`).
  - `ambientes`: Lista de ambientes (`List<Ambiente>`).

- **Métodos:**
  - `adicionarUsuario(Usuario usuario)`: Adiciona um novo usuário.
  - `removerUsuario(Usuario usuario)`: Remove um usuário, se ele não tiver permissões.
  - `pesquisarUsuario(int id)`: Pesquisa um usuário pelo ID.
  - `adicionarAmbiente(Ambiente ambiente)`: Adiciona um novo ambiente.
  - `removerAmbiente(Ambiente ambiente)`: Remove um ambiente.
  - `pesquisarAmbiente(int id)`: Pesquisa um ambiente pelo ID.
  - `upload()`: Salva os dados do sistema em um arquivo XML.
  - `download()`: Carrega os dados do sistema a partir de um arquivo XML.

### 5. Programa Principal

O programa principal fornece uma interface de linha de comando para interagir com o sistema.

- **Opções:**
  - `0. Sair`: Encerra o programa e salva os dados.
  - `1. Cadastrar ambiente`: Adiciona um novo ambiente.
  - `2. Consultar ambiente`: Exibe as informações de um ambiente.
  - `3. Excluir ambiente`: Remove um ambiente.
  - `4. Cadastrar usuario`: Adiciona um novo usuário.
  - `5. Consultar usuario`: Exibe as informações de um usuário.
  - `6. Excluir usuario`: Remove um usuário.
  - `7. Conceder permissão de acesso ao usuario`: Concede permissão de acesso a um ambiente para um usuário.
  - `8. Revogar permissão de acesso ao usuario`: Revoga permissão de acesso a um ambiente para um usuário.
  - `9. Registrar acesso`: Registra um log de acesso.
  - `10. Consultar logs de acesso`: Exibe os logs de acesso de um ambiente.


  ### Autor:
-  **Pedro Xavier Oliveira**


 
