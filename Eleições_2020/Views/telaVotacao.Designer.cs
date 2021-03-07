
namespace Eleições_2020.Views
{
    partial class telaVotacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCandidato = new System.Windows.Forms.ComboBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.btnVoltarTelaInicial = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(319, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votação";
            // 
            // cmbCandidato
            // 
            this.cmbCandidato.FormattingEnabled = true;
            this.cmbCandidato.Location = new System.Drawing.Point(237, 161);
            this.cmbCandidato.Name = "cmbCandidato";
            this.cmbCandidato.Size = new System.Drawing.Size(187, 23);
            this.cmbCandidato.TabIndex = 1;
            // 
            // btnVotar
            // 
            this.btnVotar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVotar.Location = new System.Drawing.Point(190, 326);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(182, 112);
            this.btnVotar.TabIndex = 2;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            // 
            // btnVoltarTelaInicial
            // 
            this.btnVoltarTelaInicial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltarTelaInicial.Location = new System.Drawing.Point(410, 326);
            this.btnVoltarTelaInicial.Name = "btnVoltarTelaInicial";
            this.btnVoltarTelaInicial.Size = new System.Drawing.Size(182, 112);
            this.btnVoltarTelaInicial.TabIndex = 3;
            this.btnVoltarTelaInicial.Text = "Voltar para tela inicial";
            this.btnVoltarTelaInicial.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(132, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Candidato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(445, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Deve selecionar um da lista";
            // 
            // telaVotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVoltarTelaInicial);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.cmbCandidato);
            this.Controls.Add(this.label1);
            this.Name = "telaVotacao";
            this.Text = "telaVotacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCandidato;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Button btnVoltarTelaInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}