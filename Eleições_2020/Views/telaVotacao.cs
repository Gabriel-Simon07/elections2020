using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Eleições_2020.Views;
using Eleições_2020.Models;

namespace Eleições_2020.Views
{
    public partial class telaVotacao : Form
    {       
        public telaVotacao()
        {
            InitializeComponent();
            btnVoltarTelaInicial.Click += Voltar_tela_menu;
            btnVotar.Click += salvar_voto;            
            carregaCandidatos();
        }

        private void carregaCandidatos()
        {
            cmbCandidato.DataSource = Program.candidatosList;
        }

        private void salvar_voto(object sender, EventArgs e)
        {
            Candidato selecionado = (Candidato)cmbCandidato.SelectedItem;
            selecionado.qtdVotos++;
        }
        
        private void Voltar_tela_menu(object sender, EventArgs e)
        {
            Visible = false;
            new telaMenu().Show();
        }
    }
}
