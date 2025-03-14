# Projeto Bilheteria

Este projeto simula uma bilheteria com 600 poltronas distribuídas em 15 fileiras, com 40 poltronas em cada fileira. O objetivo é permitir a reserva de poltronas, controlar os lugares ocupados, calcular o valor da bilheteria, e exibir essas informações na interface gráfica. O projeto foi desenvolvido utilizando **Windows Forms Application** em C#.

## Funcionalidades

- **Criação Dinâmica de Poltronas**: Cada poltrona é representada por um componente **CheckBox**, que pode ser marcado ou desmarcado para indicar se a poltrona está ocupada.
- **Reserva de Poltronas**: O usuário pode selecionar uma poltrona digitando a fileira (letras de A a O) e o número da poltrona (1 a 40). O sistema verifica se a poltrona está disponível para reserva e marca automaticamente o **CheckBox** correspondente.
- **Validação**: Ao tentar reservar uma poltrona, o sistema valida a entrada para garantir que o número da fileira e da poltrona sejam válidos.
- **Lugares Ocupados e Valor da Bilheteria**: O sistema mantém um contador dos lugares ocupados e calcula o valor total da bilheteria com base nas seguintes faixas de preço:
  - **Fileiras A a E**: R$ 50,00 por poltrona
  - **Fileiras F a J**: R$ 30,00 por poltrona
  - **Fileiras K a O**: R$ 15,00 por poltrona

## Estrutura do Projeto

### Poltronas

- As poltronas são dispostas em uma matriz de **CheckBoxes** de 15 fileiras e 40 colunas.
- As fileiras são numeradas de **A a O** e as poltronas de **1 a 40**.

### Interface Gráfica

- A interface contém as poltronas dispostas visualmente em uma grade, onde o usuário pode visualizar e reservar os lugares.
- Labels indicam o número de lugares ocupados e o valor acumulado da bilheteria.
- Um botão "Reservar Poltrona" permite ao usuário reservar uma poltrona informando a fileira e o número da poltrona.

### Lógica de Negócio

- O sistema controla se uma poltrona está ocupada ou não, e só permite a reserva de poltronas disponíveis.
- A cada reserva, o valor da bilheteria é atualizado de acordo com a fileira escolhida.

## Como Usar

1. Execute o programa.
2. Escolha uma fileira (A a O) e uma poltrona (1 a 40) para reservar.
3. Clique no botão **Reservar Poltrona**.
4. O sistema verificará se a poltrona está disponível:
   - Se a poltrona estiver vaga, ela será reservada e o **CheckBox** será marcado.
   - Se a poltrona já estiver ocupada, uma mensagem de alerta será exibida.
5. O número de lugares ocupados e o valor total da bilheteria são atualizados automaticamente.

## Tecnologias Utilizadas

- **C#** com **Windows Forms Application** para a criação da interface gráfica e controle de eventos.
- **Matriz de CheckBoxes** para representar as poltronas.
- **Labels dinâmicos** para exibição de informações como lugares ocupados e valor da bilheteria.

## Conclusão

Este projeto simula uma bilheteria que gerencia a ocupação de 600 poltronas em uma interface amigável. Além de controlar as reservas, o sistema calcula o valor arrecadado de acordo com os preços definidos para as diferentes fileiras.

 
