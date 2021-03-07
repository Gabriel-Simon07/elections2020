using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eleições_2020.Views;

namespace Eleições_2020
{
    public partial class telaMenu : Form
    {
        public telaMenu()
        {
            InitializeComponent();
            btnCadastrarCandidatos.Click += cadastrar_candidatos;
            btnIniciarVotacao.Click += iniciar_votacao;
            btnVerResultados.Click += ver_resultados;
        }

        private void ver_resultados(object sender, EventArgs e)
        {
            Visible = false;
            new telaResultadoVotacao().Show();
        }

        private void iniciar_votacao(object sender, EventArgs e)
        {
            Visible = false;
            new telaVotacao().Show();
        }

        private void cadastrar_candidatos(object sender, EventArgs e)
        {
            Visible = false;
            new telaCadastroCandidato().Show();
        }
    }
}
