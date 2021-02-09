using System;
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
        public FormPrincipal()
        {
            InitializeComponent();
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
    }
}
