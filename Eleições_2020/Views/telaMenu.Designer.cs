
namespace Eleições_2020
{
    partial class telaMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarCandidatos = new System.Windows.Forms.Button();
            this.btnIniciarVotacao = new System.Windows.Forms.Button();
            this.btnVerResultados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(162, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eleições 2020";
            // 
            // btnCadastrarCandidatos
            // 
            this.btnCadastrarCandidatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarCandidatos.Location = new System.Drawing.Point(78, 309);
            this.btnCadastrarCandidatos.Name = "btnCadastrarCandidatos";
            this.btnCadastrarCandidatos.Size = new System.Drawing.Size(177, 85);
            this.btnCadastrarCandidatos.TabIndex = 1;
            this.btnCadastrarCandidatos.Text = "Cadastrar Candidatos";
            this.btnCadastrarCandidatos.UseVisualStyleBackColor = true;
            // 
            // btnIniciarVotacao
            // 
            this.btnIniciarVotacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIniciarVotacao.Location = new System.Drawing.Point(303, 309);
            this.btnIniciarVotacao.Name = "btnIniciarVotacao";
            this.btnIniciarVotacao.Size = new System.Drawing.Size(178, 85);
            this.btnIniciarVotacao.TabIndex = 2;
            this.btnIniciarVotacao.Text = "Iniciar Votação";
            this.btnIniciarVotacao.UseVisualStyleBackColor = true;
            // 
            // btnVerResultados
            // 
            this.btnVerResultados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerResultados.Location = new System.Drawing.Point(529, 309);
            this.btnVerResultados.Name = "btnVerResultados";
            this.btnVerResultados.Size = new System.Drawing.Size(177, 85);
            this.btnVerResultados.TabIndex = 3;
            this.btnVerResultados.Text = "Ver Resultados";
            this.btnVerResultados.UseVisualStyleBackColor = true;
            // 
            // telaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerResultados);
            this.Controls.Add(this.btnIniciarVotacao);
            this.Controls.Add(this.btnCadastrarCandidatos);
            this.Controls.Add(this.label1);
            this.Name = "telaMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarCandidatos;
        public System.Windows.Forms.Button btnIniciarVotacao;
        private System.Windows.Forms.Button btnVerResultados;
    }
}

