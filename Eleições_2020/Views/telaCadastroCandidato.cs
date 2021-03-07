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
    public partial class telaCadastroCandidato : Form
    {
        string[] partidos = { "---", "PSDP", "PT", "MDB", "PATRIOTA", "PSOL" };
        public telaCadastroCandidato()
        {
            InitializeComponent();
            btnVoltarTelaMenu.Click += volta_tela_menu;
            btnSalvarCadastroCandidato.Click += salvar_cadastro_candidato;
            cmbPartido.DataSource = partidos;
        }

        private void salvar_cadastro_candidato(object sender, EventArgs e)
        {

            try
            {
                Candidato candidato = new Candidato()
                {
                    Nome = txtNome.Text,
                    Numero = int.Parse(txtNumero.Text),
                    partido = cmbPartido.SelectedItem.ToString(),
                    qtdVotos = 0,
                };

                Program.candidatosList.Add(candidato);
                MessageBox.Show("Salvo com sucesso!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void volta_tela_menu(object sender, EventArgs e)
        {
            Visible = false;
            new telaMenu().Show();
        }

    }
}
