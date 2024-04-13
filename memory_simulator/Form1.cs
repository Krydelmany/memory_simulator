using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memory_simulator
{
    public partial class Form1 : Form
    {
        private const int Linhas = 8;
        private const int Colunas = 16;
        private Label[,] matrizLabels;
        public Form1()
        {
            InitializeComponent();
            MatrizLabels();
        }


        private List<int> valoresAleatorios = new List<int>();
        private void btnGerarNumeros_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i < Linhas; i++)
            {
                for (int j = 0; j < Colunas; j++)
                {
                    int valorAleatorio = random.Next(1000); // Gera um número aleatório entre 0 e 999
                    matrizLabels[i, j].Text = valorAleatorio.ToString(); // Atribui o valor aleatório ao Texto do Label
                    valoresAleatorios.Add(valorAleatorio);
                }
            }
        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Linhas; i++)
            {
                for (int j = 0; j < Colunas; j++)
                {
                    matrizLabels[i, j].Text = "       "; // Atribui o valor aleatório ao Texto do Label
                }
            }
        }


        private void btnListaAcesso_Click(object sender, EventArgs e)
        {
            // Limpa os itens existentes na CheckedListBox
            checkedListBox1.Items.Clear();
            valoresAleatorios.Clear();
            // Chame a função para gerar os valores
            btnGerarNumeros_Click(sender, e);

            Random random = new Random();
            List<int> valoresSelecionados = new List<int>();

            while (valoresSelecionados.Count < 16)
            {
                int indiceAleatorio = random.Next(valoresAleatorios.Count);
                int valorSelecionado = valoresAleatorios[indiceAleatorio];

                // Verifica se o valor já foi selecionado antes de adicionar
                if (!valoresSelecionados.Contains(valorSelecionado))
                {
                    valoresSelecionados.Add(valorSelecionado);
                    checkedListBox1.Items.Add(valorSelecionado);
                }
            }
        }


        private int ultimaColunaVerificada = -1; // Armazena a última coluna verificada

        // Evento de clique do botão para alternar a verificação dos Labels

        private async void btnAlternarVerificacao_Click(object sender, EventArgs e)
        {
            // Define o índice selecionado da CheckedListBox como 0
            checkedListBox1.SelectedIndex = 0;

            int TimeStep = 100;
            if (int.TryParse(tbTimeStep.Text, out int valorTempo))
            {
                TimeStep = valorTempo;
            }

            // Limpa a cor de fundo de todos os Labels
            int proximaColunaVerificada = (ultimaColunaVerificada + 1) % Linhas;
            // Itera sobre todas as colunas
            for (int j = 0; j < Linhas; j++)
            {
                // Define a cor de fundo do próximo Label em cada coluna como verde
                for (int i = 0; i < Colunas; i++)
                {
                    matrizLabels[j, i].BackColor = Color.Yellow;
                    await Task.Delay(TimeStep); // Aguarda um atraso de 100 milissegundos antes de limpar as cores
                    matrizLabels[j, proximaColunaVerificada].BackColor = Color.Transparent; // Limpa a cor de fundo após o atraso
                    LimparCoresDeFundo(); // Limpa a cor de fundo após o atraso

                    // Verifica se o item na primeira CheckedListBox corresponde ao valor atual
                    if (checkedListBox1.Items.Count > 0 && Convert.ToInt32(checkedListBox1.Items[0]) == proximaColunaVerificada)
                    {
                        matrizLabels[j, proximaColunaVerificada].BackColor = Color.Red; // Define a cor vermelha se corresponder
                    }
                }
            }
            ultimaColunaVerificada = proximaColunaVerificada;
        }



        bool loop_verif = false; // Inicialmente, o loop não está ativo
        private bool botaoClicado = false;
        private async void Acesso_Constante_Click(object sender, EventArgs e)
        {
            // Alterna o estado do botão
            botaoClicado = !botaoClicado;

            // Define a cor do botão com base no estado atual
            if (botaoClicado)
            {
                Acesso_Constante.BackColor = Color.LightGreen; // Define a cor para verde
            }
            else
            {
                Acesso_Constante.BackColor = SystemColors.Control; // Retorna a cor ao normal
            }

            // Inverte o valor de loop_verif
            loop_verif = !loop_verif;

            // Se loop_verif agora for falso, significa que o usuário deseja parar o loop
            if (!loop_verif)
            {
                return;
            }

            int TimeStep = 100; // Tempo de atraso padrão
            if (int.TryParse(tbTimeStep.Text, out int valorTempo))
            {
                TimeStep = valorTempo;
            }

            // Limpa a cor de fundo de todos os Labels
            LimparCoresDeFundo();

            int proximaColunaVerificada = (ultimaColunaVerificada + 1) % Colunas;
            while (loop_verif)
            {
                for (int j = 0; j < Linhas; j++)
                {
                    // Define a cor de fundo do próximo Label em cada coluna como verde
                    for (int i = 0; i < Colunas; i++)
                    {
                        matrizLabels[j, i].BackColor = Color.LightGreen;
                        await Task.Delay(TimeStep); // Aguarda um atraso de acordo com o valor de TimeStep
                        matrizLabels[j, i].BackColor = Color.Transparent;
                    }
                }
            }
        }




        // Método para limpar a cor de fundo de todos os Labels
        private void LimparCoresDeFundo()
        {
            for (int i = 0; i < Colunas; i++)
            {
                for (int j = 0; j < Linhas; j++)
                {
                    matrizLabels[j, i].BackColor = Color.Transparent;
                }
            }
        }

        private void MatrizLabels()
        {
            // Inicializar a matriz de labels com o tamanho correto
            matrizLabels = new Label[Linhas, Colunas];

            // Posicionamento inicial dos labels
            int left = 10;
            int top = 10;
            int deslocamentoVertical = 20; // Valor de deslocamento vertical
            // Criar e posicionar cada label na matriz
            for (int i = 0; i < Linhas; i++)
            {
                for (int j = 0; j < Colunas; j++)
                {
                    // Criar um novo label
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Left = left;
                    label.Top = top;
                    label.BorderStyle = BorderStyle.Fixed3D;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Text = $"       "; // Texto inicial, pode ser alterado conforme necessário
                    // Adicionar o label ao formulário  
                    Controls.Add(label);
                    // Adicionar o label à matriz
                    matrizLabels[i, j] = label;
                    // Ajustar a posição para o próximo label
                    left += label.Width + 10; // Adicione uma margem de 5 pixels entre os labels
                    gbMemoriaPrincipal.Controls.Add(label);
                    label.Top += deslocamentoVertical;
                }
                // Resetar a posição horizontal para a próxima linha
                left = 10;
                // Ajustar a posição vertical para a próxima linha
                top += matrizLabels[0, 0].Height + 10; // Adicione uma margem de 5 pixels entre as linhas
            }
        }
    }
}
