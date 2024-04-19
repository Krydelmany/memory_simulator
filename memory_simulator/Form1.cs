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
    public partial class frmMemorySimulator : Form
    {
        private const int Linhas = 8;
        private const int Colunas = 16;

        private const int CLinhas = 4;
        private const int CColunas = 4;

        private Label[,] memoriaPrincipal;
        private Label[,] memoriaCache;
        public frmMemorySimulator()
        {
            InitializeComponent();
            MemoriaPrincipal();
            MemoriaCache();
            btnAlternarVerificacao.Enabled = false;
            button1.Enabled = false;
            btnResetar.Click += new EventHandler(btnResetar_Click);
        }


        private List<int> valoresAleatorios = new List<int>();
        private void btnGerarNumeros_Click(object sender, EventArgs e)
        {
            btnAlternarVerificacao.Enabled = true;
            Random random = new Random();

            for (int i = 0; i < Linhas; i++)
            {
                for (int j = 0; j < Colunas; j++)
                {
                    int valorAleatorio;
                    // Gera um número aleatório único que não está na lista
                    do
                    {
                        valorAleatorio = random.Next(1000);
                    } while (valoresAleatorios.Contains(valorAleatorio));

                    memoriaPrincipal[i, j].Text = valorAleatorio.ToString(); // Atribui o valor aleatório ao Texto do Label
                    valoresAleatorios.Add(valorAleatorio);
                }
            }
        }


        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            btnAlternarVerificacao.Enabled = false;
            for (int i = 0; i < Linhas; i++)
            {
                for (int j = 0; j < Colunas; j++)
                {
                    memoriaPrincipal[i, j].Text = " "; // Atribui o valor aleatório ao Texto do Label
                }
            }
        }
        private void btnLimparMP_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            valoresAleatorios.Clear();

        }
        private void btnListaAcesso_Click(object sender, EventArgs e)
        {
            // Chame a função para gerar os valores se ainda não foram gerados
            if (valoresAleatorios.Count == 0)
            {
                btnGerarNumeros_Click(sender, e);
            }

            // Limpa os itens existentes na CheckedListBox
            checkedListBox1.Items.Clear();

            Random random = new Random();
            HashSet<int> valoresSelecionados = new HashSet<int>(); // Usando HashSet para garantir que os valores sejam únicos

            // Enquanto o número de itens na CheckedListBox for menor que 16, adicione novos valores
            while (valoresSelecionados.Count < 16)
            {
                int indiceAleatorio = random.Next(valoresAleatorios.Count);
                int valorSelecionado = valoresAleatorios[indiceAleatorio];

                // Verifica se o valor já está na lista de valores selecionados
                if (!valoresSelecionados.Contains(valorSelecionado))
                {
                    valoresSelecionados.Add(valorSelecionado);
                    checkedListBox1.Items.Add(valorSelecionado);
                }
            }
        }

        //caso sem utilizar remover
        private void VerificarListaAcesso()
        {
            // Itera sobre os itens da CheckedListBox
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                // Obtém o valor do item atual
                int valorItem = (int)checkedListBox1.Items[i];

                // Verifica se o valor está na lista de acesso
                if (valoresAleatorios.Contains(valorItem))
                {
                    // Marca a caixa de seleção correspondente
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
        }




        private int ultimaColunaVerificada = -1; // Armazena a última coluna verificada

        // Evento de clique do botão para alternar a verificação dos Labels

        private async void btnAlternarVerificacao_Click(object sender, EventArgs e)
        {
            button1.Enabled = Enabled;
            await VerificarValoresNaMemoriaPrincipal();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            VerificarValoresNaMemoria_Cache();
        }

        private async Task VerificarValoresNaMemoria_Cache()
        {
            int TimeStep = 100;
            if (int.TryParse(tbTimeStep.Text, out int valorTempo))
            {
                TimeStep = valorTempo;
            }

            // Itera sobre os itens da CheckedListBox
            for (int indiceItem = 0; indiceItem < checkedListBox1.Items.Count; indiceItem++)
            {
                int valorProcurado = Convert.ToInt32(checkedListBox1.Items[indiceItem]);

                // Itera sobre todas as colunas
                for (int j = 0; j < Linhas; j++)
                {
                    // Itera sobre todas as linhas
                    for (int i = 0; i < Colunas; i++)
                    {
                        if (memoriaPrincipal[j, i].BackColor != Color.LimeGreen) // Verifica se a célula não está marcada como vermelha
                        {
                            memoriaPrincipal[j, i].BackColor = Color.Yellow;
                        }
                        await Task.Delay(TimeStep); // Aguarda um atraso de 100 milissegundos antes de limpar as cores
                        LimparCoresDeFundo(); // Limpa a cor de fundo após o atraso

                        // Verifica se o item na primeira CheckedListBox corresponde ao valor atual
                        int valorAtual = Convert.ToInt32(memoriaPrincipal[j, i].Text);
                        if (valorProcurado == valorAtual)
                        {
                            checkedListBox1.SetSelected(1, true);
                            checkedListBox1.SetSelected(indiceItem, true);
                            if (memoriaPrincipal[j, i].Text == valorProcurado.ToString())
                            {
                                // Obtém o índice do item na CheckedListBox correspondente ao valor procurado
                                int indiceItemCorrespondente = checkedListBox1.Items.IndexOf(valorProcurado);

                                // Marca o item na CheckedListBox como selecionado

                                // Marca o item na CheckedListBox como checado
                                checkedListBox1.SetItemChecked(indiceItemCorrespondente, true);
                            }
                            //checkedListBox1.SetItemChecked(indiceItem + 1, true);

                                memoriaPrincipal[j, i].BackColor = Color.LimeGreen; // Define a cor verde
                      

                            // Verifica se o valor está presente na memória cache
                            bool valorEncontrado = false;
                            for (int k = 0; k < CLinhas; k++)
                            {
                                for (int l = 0; l < CColunas; l++)
                                {
                                    memoriaCache[k, l].BackColor = Color.Yellow;
                                    await Task.Delay(TimeStep); // Aguarda um atraso de 100 milissegundos antes de limpar as cores
                                    memoriaCache[k, l].BackColor = Color.LimeGreen;
                                    //LimparCoresDeFundoCache(); // Limpa a cor de fundo após o atraso
                                    if (Convert.ToInt32(memoriaCache[k, l].Text) == valorAtual) // Verifica se o valor está presente na memória cache
                                    {
                                        memoriaCache[k, l].BackColor = Color.LimeGreen; // Define a cor verde

                                        valorEncontrado = true;
                                        break;
                                    }
                                }
                                if (valorEncontrado)
                                    break;
                            }
                        }
                    }
                }
            }
        }


        private async Task VerificarValoresNaMemoriaPrincipal()
        {
            int TimeStep = 100;
            if (int.TryParse(tbTimeStep.Text, out int valorTempo))
            {
                TimeStep = valorTempo;
            }

            // Itera sobre os itens da CheckedListBox
            for (int indiceItem = 0; indiceItem < checkedListBox1.Items.Count; indiceItem++)
            {
                int valorProcurado = Convert.ToInt32(checkedListBox1.Items[indiceItem]);

                // Itera sobre todas as colunas
                for (int j = 0; j < Linhas; j++)
                {
                    // Itera sobre todas as linhas
                    for (int i = 0; i < Colunas; i++)
                    {
                        // Define a cor amarela para todas as células
                        if (memoriaPrincipal[j, i].BackColor != Color.Red) // Verifica se a célula não está marcada como vermelha
                        {
                            memoriaPrincipal[j, i].BackColor = Color.Yellow;
                        }

                        await Task.Delay(TimeStep); // Aguarda um atraso de 100 milissegundos antes de limpar as cores
                        LimparCoresDeFundo(); // Limpa a cor de fundo após o atraso

                        // Verifica se o item na primeira CheckedListBox corresponde ao valor atual
                        int valorAtual = Convert.ToInt32(memoriaPrincipal[j, i].Text);
                        if (valorProcurado == valorAtual)
                        {
                            // Define a cor vermelha para a célula atual
                            
                            memoriaPrincipal[j, i].BackColor = Color.Red; // Define a cor vermelha
                            if (checkedListBox1.SelectedIndex < checkedListBox1.Items.Count - 1)
                            {
                                checkedListBox1.SetSelected(indiceItem + 1, true);
                            }
                            await Task.Delay(100); // Aguarda meio segundo para a mudança de cor ser visível

                            // Encontra a próxima posição disponível na memória cache
                            bool posicaoEncontrada = false;
                            for (int k = 0; k < CLinhas; k++)
                            {
                                for (int l = 0; l < CColunas; l++)
                                {
                                    memoriaCache[k, l].BackColor = Color.Yellow;
                                    await Task.Delay(TimeStep);
                                    memoriaCache[k, l].BackColor = Color.Red;
                                    // LimparCoresDeFundoCache(); // Limpa a cor de fundo após o atraso
                                    if (memoriaCache[k, l].Text == "0") // Verifica se a posição está vazia
                                    {
                                        // Marca a célula correspondente na memória cache como vermelha
                                        memoriaCache[k, l].BackColor = Color.Red; // Marca o label na matriz memoriaCache com a cor vermelha

                                        // Armazena o valor na posição disponível
                                        memoriaCache[k, l].Text = valorAtual.ToString();
                                        posicaoEncontrada = true;
                                        break;
                                    }
                                }
                                if (posicaoEncontrada)
                                    break;
                            }
                        }
                    }
                }
            }
        }



        //Não finalizado
        bool loop_verif = false; // Inicialmente, o loop não está ativo
        private bool botaoClicado = false;
        private bool acessoConstanteAtivo = false;
        private async void Acesso_Constante_Click(object sender, EventArgs e)
        {
            acessoConstanteAtivo = !acessoConstanteAtivo; // Inverte o estado do acesso constante

            if (acessoConstanteAtivo)
            {
                // Inicia o loop de acesso constante em uma thread separada para não travar a interface do usuário
                Task.Run(() => RealizarAcessoConstante());
            }
        }
        private async Task RealizarAcessoConstante()
        {
            Random random = new Random();

            while (acessoConstanteAtivo)
            {
                // Adiciona um item aleatório ao CheckedListBox
                int novoItem = random.Next(100); 
                checkedListBox1.Items.Add(novoItem);

                // Realiza a verificação na memória principal e na memória cache para o novo item
                await VerificarValoresNaMemoriaPrincipal();
                await VerificarValoresNaMemoria_Cache();

                // Aguarda um tempo antes de continuar para não sobrecarregar o sistema
                await Task.Delay(1000); // Por exemplo, aguarda 1 segundo
            }
        }
        // Método para limpar a cor de fundo de todos os Labels
        private void LimparCoresDeFundo()
        {
            for (int i = 0; i < Colunas; i++)
            {
                for (int j = 0; j < Linhas; j++)
                {
                    if (memoriaPrincipal[j, i].BackColor == Color.Yellow)
                    {
                     memoriaPrincipal[j, i].BackColor = Color.Transparent;
                    }
                }
            }
        }
        //talvez inutilizavel
        private void LimparCoresDeFundoCache()
        {
            for (int i = 0; i < CColunas; i++)
            {
                for (int j = 0; j < CLinhas; j++)
                {
                    memoriaCache[j, i].BackColor = Color.Transparent;
                }
            }
        }


        //btn Resetar
        private void btnResetar_Click(object sender, EventArgs e)
        {
            // Limpa os valores aleatórios
            valoresAleatorios.Clear();

            // Limpa os valores e as cores de fundo da memória principal
            for (int i = 0; i < Linhas; i++)
            {
                for (int j = 0; j < Colunas; j++)
                {
                    memoriaPrincipal[i, j].Text = "";
                    memoriaPrincipal[i, j].BackColor = Color.Transparent;
                }
            }

            // Limpa os valores e as cores de fundo da memória cache
            for (int i = 0; i < CLinhas; i++)
            {
                for (int j = 0; j < CColunas; j++)
                {
                    memoriaCache[i, j].Text = "0";
                    memoriaCache[i, j].BackColor = Color.Transparent;
                }
            }

            // Desmarca todos os itens da CheckedListBox
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            // Desmarca a seleção atual na CheckedListBox
            checkedListBox1.ClearSelected();
            checkedListBox1.Items.Clear();
            valoresAleatorios.Clear();
        }


        private void MemoriaPrincipal()
        {
            // Inicializar a matriz de labels com o tamanho correto
            memoriaPrincipal = new Label[Linhas, Colunas];

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
                    label.AutoSize = false;
                    label.Size = new Size(30, 20);
                    label.Left = left;
                    label.Top = top;
                    label.BorderStyle = BorderStyle.Fixed3D;
                    label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    label.Text = $""; // Texto inicial, pode ser alterado conforme necessário
                    
                    // Adicionar o label ao formulário  
                    Controls.Add(label);
                    // Adicionar o label à matriz
                    memoriaPrincipal[i, j] = label;
                    // Ajustar a posição para o próximo label
                    left += label.Width + 10; // Adicione uma margem de 5 pixels entre os labels
                    gbMemoriaPrincipal.Controls.Add(label);
                    label.Top += deslocamentoVertical;
                }
                // Resetar a posição horizontal para a próxima linha
                left = 10;
                // Ajustar a posição vertical para a próxima linha
                top += memoriaPrincipal[0, 0].Height + 5; // Adicione uma margem de 5 pixels entre as linhas
            }
        }
        private void MemoriaCache()
        {
            // Inicializar a matriz de labels com o tamanho correto
            memoriaCache = new Label[CLinhas, CColunas];

            // Posicionamento inicial dos labels
            int left = 10;
            int top = 10;
            int deslocamentoVertical = 20; // Valor de deslocamento vertical
            // Criar e posicionar cada label na matriz
            for (int i = 0; i < CLinhas; i++)
            {
                for (int j = 0; j < CColunas; j++)
                {
                    // Criar um novo label
                    Label label = new Label();
                    label.AutoSize = false;
                    label.Size = new Size(35, 20);
                    label.Left = left;
                    label.Top = top;
                    label.BorderStyle = BorderStyle.Fixed3D;
                    label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    label.Text = $"0"; // Texto inicial, pode ser alterado conforme necessário

                    // Adicionar o label ao formulário  
                    Controls.Add(label);
                    // Adicionar o label à matriz
                    memoriaCache[i, j] = label;
                    // Ajustar a posição para o próximo label
                    left += label.Width + 10; // Adicione uma margem de 5 pixels entre os labels
                    gbMemoriaCache.Controls.Add(label);
                    label.Top += deslocamentoVertical;
                }
                // Resetar a posição horizontal para a próxima linha
                left = 10;
                // Ajustar a posição vertical para a próxima linha
                top += memoriaPrincipal[0, 0].Height + 5; // Adicione uma margem de 5 pixels entre as linhas
            }
        }
    }   
}
