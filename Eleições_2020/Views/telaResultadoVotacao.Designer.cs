
namespace Eleições_2020.Views
{
    partial class telaResultadoVotacao
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
            this.btnVoltarTelaInicial2 = new System.Windows.Forms.Button();
            this.tbl_candidados = new System.Windows.Forms.TableLayoutPanel();
            this.tblCandidatos = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(168, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultado da eleição";
            // 
            // btnVoltarTelaInicial2
            // 
            this.btnVoltarTelaInicial2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltarTelaInicial2.ForeColor = System.Drawing.Color.Black;
            this.btnVoltarTelaInicial2.Location = new System.Drawing.Point(285, 406);
            this.btnVoltarTelaInicial2.Name = "btnVoltarTelaInicial2";
            this.btnVoltarTelaInicial2.Size = new System.Drawing.Size(220, 101);
            this.btnVoltarTelaInicial2.TabIndex = 1;
            this.btnVoltarTelaInicial2.Text = "Voltar para tela inicial";
            this.btnVoltarTelaInicial2.UseVisualStyleBackColor = true;
            // 
            // tbl_candidados
            // 
            this.tbl_candidados.ColumnCount = 1;
            this.tbl_candidados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl_candidados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbl_candidados.Location = new System.Drawing.Point(145, 88);
            this.tbl_candidados.Name = "tbl_candidados";
            this.tbl_candidados.RowCount = 10;
            this.tbl_candidados.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_candidados.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_candidados.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_candidados.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_candidados.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_candidados.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_candidados.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_candidados.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_candidados.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_candidados.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_candidados.Size = new System.Drawing.Size(0, 0);
            this.tbl_candidados.TabIndex = 3;
            // 
            // tblCandidatos
            // 
            this.tblCandidatos.ColumnCount = 2;
            this.tblCandidatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblCandidatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCandidatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tblCandidatos.Location = new System.Drawing.Point(214, 159);
            this.tblCandidatos.Name = "tblCandidatos";
            this.tblCandidatos.RowCount = 2;
            this.tblCandidatos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblCandidatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCandidatos.Size = new System.Drawing.Size(353, 167);
            this.tblCandidatos.TabIndex = 4;
            // 
            // telaResultadoVotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.tblCandidatos);
            this.Controls.Add(this.tbl_candidados);
            this.Controls.Add(this.btnVoltarTelaInicial2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "telaResultadoVotacao";
            this.Text = "telaResultadoVotacao";
            this.Load += new System.EventHandler(this.telaResultadoVotacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltarTelaInicial2;
        private System.Windows.Forms.TableLayoutPanel tbl_candidados;
        private System.Windows.Forms.TableLayoutPanel tblCandidatos;
    }
}