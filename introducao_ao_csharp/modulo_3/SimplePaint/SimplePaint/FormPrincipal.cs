using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class FormPrincipal : Form // parcial pq parte dela está definida em outro local
    {

        private bool flagPintar = false; // Variável define quando se deve desenhar
        private Graphics graphicsPainelPintura;
        private float espessuraCaneta;
        private Color corBorracha;
        private bool flagApagar = false; // Para controlar quando se deve apagar com a borracha
        private Image imagemASalvar;
        private Graphics graphicsImagemASalvar;
        private ImageFormat ImageFormat;

        public FormPrincipal()
        {
            InitializeComponent();

            // As propriedades abaixo só fazem efeito quando o botão está com a propriedade FlatStyle
            // setada em Flat
            // Autera a cor do botão quando o mouse está seobre ele
            buttonBorracha.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            buttonLimpar.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            buttonSalvar.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;

            for (int i=2; i <= 100; i += 2) // Irá preencher a comboBox de 2 até 100 contando de 2 em 2
            {
                comboBoxEspessuraDaCaneta.Items.Add(i); // Adiciona o valor da espessura
            }

            comboBoxEspessuraDaCaneta.Text = "10"; // Texto irá aparecer inicialmente na comboBox
            comboBoxEspessuraDaCaneta.MaxDropDownItems = 5; // Necessários para que seja definido a quatiadde de itens a ser mostrado na comboBox
            comboBoxEspessuraDaCaneta.IntegralHeight = false; // Define o núm. de itens a ser exibido na comboBox

            graphicsPainelPintura = panelPintura.CreateGraphics(); // O graphics permite o desenho sobre o controle
            espessuraCaneta = float.Parse(comboBoxEspessuraDaCaneta.Text); // Converte o texto da comboBox para um float
            corBorracha = panelPintura.BackColor; // Especifica a cor padrão da borracha como a cor de fundo do papel

            imagemASalvar = new Bitmap(panelPintura.Width, panelPintura.Height); // Imagem para salvar
            graphicsImagemASalvar = Graphics.FromImage(imagemASalvar); // extraindo graphics da imagem para salvar de forma a poder desenhar nela
            graphicsImagemASalvar.Clear(panelPintura.BackColor); // Preenchemos a imagem com a cor do fundo do painel
        }

        private void buttonBorracha_Click(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza disso?", "Apagar desenho", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                graphicsPainelPintura.Clear(Color.White); // Limpa o papel e preenche novamente o fundo de branco
                imagemASalvar = new Bitmap(panelPintura.Width, panelPintura.Height); // Imagem para salvar
                graphicsImagemASalvar = Graphics.FromImage(imagemASalvar); // extraindo graphics da imagem para salvar de forma a poder desenhar nela
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        // Handler do evento de click do botão
        // é disparado quando o botão é clicado
        // Serve para manipularmos o que acontece quando o botão é clicado
        private void buttonCorDaCaneta_Click(object sender, EventArgs e) 
        {
            var colorDialog = new ColorDialog(); // ColorDialog é uma caixa de seleção de cores
            var corEscolhida = colorDialog.ShowDialog(); // Exibe na forma modal - aplicação fica travada enquando o dialogo não é resolvido
            if (corEscolhida == DialogResult.OK) // Verifica se usuário clicou mesmo em ok 
            {
                buttonCorDaCaneta.BackColor = colorDialog.Color; // Alteramos a cor do botão para a cor escolhida
            }
        }

        private void panelPintura_MouseDown(object sender, MouseEventArgs e)
        {
            flagPintar = true;
        }

        private void panelPintura_MouseUp(object sender, MouseEventArgs e)
        {
            flagPintar = false;
        }

        private void panelPintura_MouseMove(object sender, MouseEventArgs e)
        {
            if (flagPintar) 
            {
                if (!flagApagar)
                {
                    // Desenhando uma elipse de cor e espessura definida pelo usuário
                    graphicsPainelPintura.DrawEllipse(new Pen(buttonCorDaCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                    // Desenhando na imagem para salvar
                    graphicsImagemASalvar.DrawEllipse(new Pen(buttonCorDaCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                }
                else
                {
                    graphicsPainelPintura.DrawRectangle(new Pen(corBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta)); // transformamos uma variável tipo float para inteiro
                    // 
                    graphicsImagemASalvar.DrawRectangle(new Pen(corBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta));
                }

                
            }
        }
        
        // SelectedIndexChanged ocorro quando é feita uma escolha de item pelo usuário na comboBox
        // 
        private void comboBoxEspessuraDaCaneta_SelectedIndexChanged(object sender, EventArgs e)
        {
            espessuraCaneta = float.Parse(comboBoxEspessuraDaCaneta.SelectedItem.ToString());
        }


        private void buttonBorracha_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right) // Se usuário clicar com o botão direito do mouse
            {
                var colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    corBorracha = colorDialog.Color; // Seleciona a cor da borracha de acordo com a escolha do usuário
                }
                else
                {
                    if (!flagApagar) // O operador ! antes irá virar o valor da flagApagar ao contrário, ou seja, se é true ficará false
                    {
                        flagApagar = true;
                        buttonBorracha.BackColor = corBorracha; // Cor do botão será a mesma da borracha
                    }
                    else
                    {
                        flagApagar = false;
                        buttonBorracha.BackColor = Color.Gray; // cor do botão voltará ao padrão (possível erro - aparencia está setado como button.Shad..)
                    }
                    
                }
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Portable Networl Graphics | .png|Arquivo JPEG| .jpeg";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Definindo a extensão da imagem que queremos salvar
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        imagemASalvar.Save(saveFileDialog.FileName, ImageFormat.Png);
                        break;
                    case 2:
                        imagemASalvar.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        break;
                }
            }
        }
        // Evento disparado sempre que o painel é redimensionado
        private void panelPintura_Resize(object sender, EventArgs e) 
        {
            graphicsPainelPintura = panelPintura.CreateGraphics(); // Atualiza a refer~enia do objeto graphics do painel
            var imagTemp = new Bitmap(panelPintura.Width, panelPintura.Height); // Criamos uma imagem temporária
            var graphicsImagTemp = Graphics.FromImage(imagTemp);
            graphicsImagTemp.DrawImage(imagemASalvar, 0, 0);
            imagemASalvar = imagTemp;
            graphicsImagemASalvar = graphicsImagTemp;

        }
    }
}
