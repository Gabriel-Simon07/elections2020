
namespace Eleições_2020.Views
{
    partial class telaCadastroCandidato
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbPartido = new System.Windows.Forms.ComboBox();
            this.btnSalvarCadastroCandidato = new System.Windows.Forms.Button();
            this.btnVoltarTelaMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Candidato";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(253, 194);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(139, 23);
            this.txtNome.TabIndex = 2;
            // 
            // cmbPartido
            // 
            this.cmbPartido.FormattingEnabled = true;
            this.cmbPartido.Location = new System.Drawing.Point(253, 243);
            this.cmbPartido.Name = "cmbPartido";
            this.cmbPartido.Size = new System.Drawing.Size(139, 23);
            this.cmbPartido.TabIndex = 3;
            // 
            // btnSalvarCadastroCandidato
            // 
            this.btnSalvarCadastroCandidato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarCadastroCandidato.Location = new System.Drawing.Point(147, 331);
            this.btnSalvarCadastroCandidato.Name = "btnSalvarCadastroCandidato";
            this.btnSalvarCadastroCandidato.Size = new System.Drawing.Size(185, 93);
            this.btnSalvarCadastroCandidato.TabIndex = 4;
            this.btnSalvarCadastroCandidato.Text = "Salvar";
            this.btnSalvarCadastroCandidato.UseVisualStyleBackColor = true;
            // 
            // btnVoltarTelaMenu
            // 
            this.btnVoltarTelaMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltarTelaMenu.Location = new System.Drawing.Point(429, 331);
            this.btnVoltarTelaMenu.Name = "btnVoltarTelaMenu";
            this.btnVoltarTelaMenu.Size = new System.Drawing.Size(186, 93);
            this.btnVoltarTelaMenu.TabIndex = 5;
            this.btnVoltarTelaMenu.Text = "Voltar para a tela principal";
            this.btnVoltarTelaMenu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(170, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(170, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(170, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Partido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(420, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Um valor entre 1 e 99";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(420, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Deve ter pelo menos 3  caracteres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(420, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Deve selecionar um partido da lista";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(253, 141);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(147, 23);
            this.txtNumero.TabIndex = 12;
            // 
            // telaCadastroCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVoltarTelaMenu);
            this.Controls.Add(this.btnSalvarCadastroCandidato);
            this.Controls.Add(this.cmbPartido);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "telaCadastroCandidato";
            this.Text = "telaCadastroCandidato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbPartido;
        private System.Windows.Forms.Button btnSalvarCadastroCandidato;
        private System.Windows.Forms.Button btnVoltarTelaMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumero;
    }
}