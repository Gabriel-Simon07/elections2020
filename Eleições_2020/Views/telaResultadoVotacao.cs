using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Eleições_2020.Models;


namespace Eleições_2020.Views
{
    public partial class telaResultadoVotacao : Form
    {
        public telaResultadoVotacao()
        {
            InitializeComponent();
            btnVoltarTelaInicial2.Click += voltar_tela_menu_principal;
            ResultadoVotacao();
        }

        private void ResultadoVotacao()
        {
            int linha = 0;
            

            Program.candidatosList.ForEach(novoCandidato =>
            {
                Label nomeCandidato = new Label();
                nomeCandidato.Text = novoCandidato.Nome;
                tblCandidatos.Controls.Add(nomeCandidato, 0, linha);

                Label qtdVotos = new Label();
                qtdVotos.Text = novoCandidato.qtdVotos.ToString();
                tblCandidatos.Controls.Add(qtdVotos, 1, linha);
                linha++;
            });
        }

        private void voltar_tela_menu_principal(object sender, EventArgs e)
        {
            Visible = false;
            new telaMenu().Show();
        }

        private void telaResultadoVotacao_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
