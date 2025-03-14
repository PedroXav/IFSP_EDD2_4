# Sistema de Gerenciamento de Vendedores

Este é um projeto desenvolvido em C# para gerenciar uma equipe de vendedores e registrar as vendas realizadas diariamente por cada um deles. O sistema permite cadastrar vendedores, registrar vendas, calcular o valor total das vendas, calcular as comissões e realizar consultas de vendedores.

## Estrutura do Projeto

O projeto é composto pelas seguintes classes:

### 1. `Venda`
Representa uma venda feita por um vendedor. Cada venda possui:
- **Quantidade de itens vendidos** (`qtde`)
- **Valor total da venda** (`valor`)

Métodos principais:
- `valorMedio()`: Calcula o valor médio da venda por item.

### 2. `Vendedor`
Representa um vendedor. Cada vendedor possui:
- **ID** (`id`)
- **Nome** (`nome`)
- **Percentual de Comissão** (`percComissao`)
- **Lista de Vendas** (`asVendas`): Um array que armazena as vendas diárias, no máximo 31 dias.

Métodos principais:
- `registrarVenda(dia, venda)`: Registra uma venda em um dia específico.
- `valorVendas()`: Retorna o valor total das vendas do vendedor.
- `valorComissao()`: Retorna o valor da comissão do vendedor com base nas vendas realizadas.

### 3. `Vendedores`
Gerencia uma equipe de vendedores. Esta classe possui:
- **Quantidade máxima de vendedores** (`max`)
- **Lista de Vendedores** (`osVendedores`)

Métodos principais:
- `addVendedor(v)`: Adiciona um vendedor à equipe.
- `delVendedor(id)`: Remove um vendedor da equipe com base no ID.
- `searchVendedor(id)`: Busca e retorna um vendedor pelo ID.
- `valorVendas()`: Retorna o valor total de vendas da equipe.
- `valorComissao()`: Retorna o valor total das comissões da equipe.
- `listarVendedores()`: Lista todos os vendedores cadastrados com suas informações.

## Funcionalidades

O sistema possui as seguintes opções:

1. **Cadastrar vendedor**: Adiciona um novo vendedor à equipe.
2. **Consultar vendedor**: Exibe as informações de um vendedor, incluindo o valor total de vendas e o valor da comissão.
3. **Excluir vendedor**: Remove um vendedor da equipe.
4. **Registrar venda**: Registra uma venda feita por um vendedor em um dia específico.
5. **Listar vendedores**: Exibe a lista de todos os vendedores cadastrados com o total de vendas e comissões.
6. **Sair**: Encerra o sistema.

## Exemplo de Execução

```plaintext
0. Sair
1. Cadastrar vendedor
2. Consultar vendedor
3. Excluir vendedor
4. Registrar venda
5. Listar vendedores
Escolha uma opção: 1
ID: 101
Nome: João
Percentual de Comissão: 10
Vendedor cadastrado com sucesso.

Escolha uma opção: 4
ID do vendedor: 101
Dia da venda (1-31): 10
Quantidade de produtos vendidos: 5
Valor total da venda: 1000
Venda registrada com sucesso.

Escolha uma opção: 2
ID do vendedor a consultar: 101
Nome: João
Valor total de vendas: R$1.000,00
Valor da comissão: R$100,00
 
