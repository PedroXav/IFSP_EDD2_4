using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilheteriaForms
{
    public partial class Form1 : Form
    {
        // Matriz para armazenar o estado de ocupação das poltronas (vago = false, ocupado = true)
        bool[,] poltronasOcupadas = new bool[15, 40];  // 15 fileiras (A-O) e 40 poltronas por fileira (1-40)
        CheckBox[,] checkBoxes = new CheckBox[15, 40];  // Matriz para armazenar os CheckBoxes
        char[] fileiras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O' }; // Fileiras de A a O
        decimal valorBilheteria = 0; // Valor total da bilheteria
        int lugaresOcupados = 0;  // Quantidade de lugares ocupados

        // Labels para exibir os dados
        Label lblLugaresOcupados;
        Label lblValorBilheteria;

        public Form1()
        {
            InitializeComponent();
            CriarPoltronas();
            CriarLabelsInformacoes();
        }

        private void CriarPoltronas()
        {
            int totalPoltronas = 600;
            int poltronasPorFileira = 40;
            int espacoEntrePoltronas = 22; // Espaço entre poltronas ajustado
            int espacoEntreFileiras = 25;  // Espaço entre fileiras ajustado
            int inicioX = 50;              // Posição X inicial (ajustada para caber os números das colunas)
            int inicioY = 50;              // Posição Y inicial (ajustada para caber as letras das fileiras)

            // Adicionar números das colunas (1 a 40)
            for (int i = 0; i < poltronasPorFileira; i++)
            {
                Label colunaLabel = new Label();
                colunaLabel.Text = (i + 1).ToString();
                colunaLabel.Width = 20;
                colunaLabel.Height = 20;
                colunaLabel.Left = inicioX + (i * espacoEntrePoltronas);
                colunaLabel.Top = inicioY - 20;  // Posicionar acima das poltronas
                this.Controls.Add(colunaLabel);
            }

            for (int i = 0; i < totalPoltronas; i++)
            {
                CheckBox poltrona = new CheckBox();
                poltrona.Width = 20;
                poltrona.Height = 20;
                poltrona.Text = "";  // Sem texto visível
                poltrona.Name = "Poltrona" + (i + 1);

                int fileira = i / poltronasPorFileira;
                int posicaoNaFileira = i % poltronasPorFileira;

                poltrona.Left = inicioX + (posicaoNaFileira * espacoEntrePoltronas);
                poltrona.Top = inicioY + (fileira * espacoEntreFileiras);

                // Adicionar o CheckBox na matriz
                checkBoxes[fileira, posicaoNaFileira] = poltrona;

                // Adicionar o CheckBox ao formulário
                this.Controls.Add(poltrona);
            }

            // Adicionar letras das fileiras (A a O)
            for (int j = 0; j < fileiras.Length; j++)
            {
                Label fileiraLabel = new Label();
                fileiraLabel.Text = fileiras[j].ToString();
                fileiraLabel.Width = 20;
                fileiraLabel.Height = 20;
                fileiraLabel.Left = inicioX - 30;  // Posicionar à esquerda das poltronas
                fileiraLabel.Top = inicioY + (j * espacoEntreFileiras);
                this.Controls.Add(fileiraLabel);
            }

            // Adicionar um botão para iniciar a reserva
            Button btnReservar = new Button();
            btnReservar.Text = "Reservar Poltrona";
            btnReservar.Top = inicioY + 16 * espacoEntreFileiras;  // Posicionar abaixo das fileiras
            btnReservar.Left = inicioX;
            btnReservar.Click += new EventHandler(this.ReservarPoltrona);
            this.Controls.Add(btnReservar);
        }

        private void CriarLabelsInformacoes()
        {
            // Label para exibir a quantidade de lugares ocupados
            lblLugaresOcupados = new Label();
            lblLugaresOcupados.Text = "Qtde de lugares ocupados: 0";
            lblLugaresOcupados.Width = 200;
            lblLugaresOcupados.Top = 450;
            lblLugaresOcupados.Left = 600;
            this.Controls.Add(lblLugaresOcupados);

            // Label para exibir o valor total da bilheteria
            lblValorBilheteria = new Label();
            lblValorBilheteria.Text = "Valor da bilheteria: R$ 0,00";
            lblValorBilheteria.Width = 200;
            lblValorBilheteria.Top = 480;
            lblValorBilheteria.Left = 600;
            this.Controls.Add(lblValorBilheteria);
        }

        private void ReservarPoltrona(object sender, EventArgs e)
        {
            // Solicitar o número da fileira e da poltrona ao usuário
            string inputFileira = Prompt.ShowDialog("Digite a letra da fileira (A-O):", "Reserva de Poltrona");
            string inputPoltrona = Prompt.ShowDialog("Digite o número da poltrona (1-40):", "Reserva de Poltrona");

            // Verificar se os valores são válidos
            if (char.TryParse(inputFileira.ToUpper(), out char fileiraChar) && int.TryParse(inputPoltrona, out int poltrona))
            {
                int fileira = Array.IndexOf(fileiras, fileiraChar);  // Converter a letra da fileira em índice
                poltrona -= 1;  // Ajustar para índice zero

                if (fileira >= 0 && fileira < 15 && poltrona >= 0 && poltrona < 40)
                {
                    if (!poltronasOcupadas[fileira, poltrona])
                    {
                        // Marcar a poltrona como ocupada
                        poltronasOcupadas[fileira, poltrona] = true;
                        lugaresOcupados++;

                        // Marcar o CheckBox correspondente
                        checkBoxes[fileira, poltrona].Checked = true;

                        // Atualizar o valor total da bilheteria
                        AtualizarBilheteria(fileira);

                        // Informar sucesso
                        MessageBox.Show($"Reserva da poltrona {poltrona + 1} na fileira {fileiraChar} realizada com sucesso!", "Reserva Efetuada");
                    }
                    else
                    {
                        // Informar que a poltrona já está ocupada
                        MessageBox.Show($"A poltrona {poltrona + 1} na fileira {fileiraChar} já está ocupada.", "Poltrona Ocupada");
                    }
                }
                else
                {
                    MessageBox.Show("Número da fileira ou poltrona inválido.", "Erro de Entrada");
                }
            }
            else
            {
                MessageBox.Show("Entrada inválida. Digite uma letra para a fileira e um número para a poltrona.", "Erro de Entrada");
            }
        }

        private void AtualizarBilheteria(int fileira)
        {
            // Definir o valor do ingresso com base na fileira
            decimal valorIngresso = 0;

            if (fileira >= 0 && fileira <= 4)
            {
                valorIngresso = 50;
            }
            else if (fileira >= 5 && fileira <= 9)
            {
                valorIngresso = 30;
            }
            else if (fileira >= 10 && fileira <= 14)
            {
                valorIngresso = 15;
            }

            // Atualizar o valor total da bilheteria
            valorBilheteria += valorIngresso;

            // Atualizar os labels
            lblLugaresOcupados.Text = $"Qtde de lugares ocupados: {lugaresOcupados}";
            lblValorBilheteria.Text = $"Valor da bilheteria: R$ {valorBilheteria:F2}";
        }
    }

    // Classe auxiliar para a caixa de diálogo personalizada
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 200,
                Text = caption
            };

            Label textLabel = new Label() { Left = 50, Top = 20, Text = text, Width = 200 };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
            Button confirmation = new Button() { Text = "OK", Left = 100, Top = 100, Width = 80 };

            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            prompt.ShowDialog();
            return textBox.Text;
        }
    }
}
