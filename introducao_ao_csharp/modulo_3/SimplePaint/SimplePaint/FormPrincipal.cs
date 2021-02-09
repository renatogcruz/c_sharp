﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public FormPrincipal()
        {
            InitializeComponent();

            for (int i=2; i <= 100; i += 2) // Irá preencher a comboBox de 2 até 100 contando de 2 em 2
            {
                comboBoxEspessuraDaCaneta.Items.Add(i); // Adiciona o valor da espessura
            }

            comboBoxEspessuraDaCaneta.Text = "10"; // Texto irá aparecer inicialmente na comboBox
            comboBoxEspessuraDaCaneta.MaxDropDownItems = 5; // Necessários para que seja definido a quatiadde de itens a ser mostrado na comboBox
            comboBoxEspessuraDaCaneta.IntegralHeight = false; // Define o núm. de itens a ser exibido na comboBox

            graphicsPainelPintura = panelPintura.CreateGraphics(); // O graphics permite o desenho sobre o controle
            espessuraCaneta = float.Parse(comboBoxEspessuraDaCaneta.Text); // Converte o texto da comboBox para um float
        }

        private void buttonBorracha_Click(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {

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
                graphicsPainelPintura.DrawEllipse(new Pen(buttonCorDaCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
            }
        }
    }
}