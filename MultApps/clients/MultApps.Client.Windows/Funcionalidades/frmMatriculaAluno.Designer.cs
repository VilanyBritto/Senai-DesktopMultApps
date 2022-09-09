﻿namespace MultApps.Client.Windows.Funcionalidades
{
    partial class frmMatriculaAluno
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblAnoNascimento = new System.Windows.Forms.Label();
            this.lblAnoUltimoAniversario = new System.Windows.Forms.Label();
            this.lblCaixaCategoria = new System.Windows.Forms.Label();
            this.btnIdentificarCategoria = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.txtAnoUltimoAniversario = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(23, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "&Nome:";
            // 
            // lblAnoNascimento
            // 
            this.lblAnoNascimento.AutoSize = true;
            this.lblAnoNascimento.Location = new System.Drawing.Point(23, 63);
            this.lblAnoNascimento.Name = "lblAnoNascimento";
            this.lblAnoNascimento.Size = new System.Drawing.Size(97, 15);
            this.lblAnoNascimento.TabIndex = 1;
            this.lblAnoNascimento.Text = "&Ano nascimento:";
            // 
            // lblAnoUltimoAniversario
            // 
            this.lblAnoUltimoAniversario.AutoSize = true;
            this.lblAnoUltimoAniversario.Location = new System.Drawing.Point(205, 63);
            this.lblAnoUltimoAniversario.Name = "lblAnoUltimoAniversario";
            this.lblAnoUltimoAniversario.Size = new System.Drawing.Size(130, 15);
            this.lblAnoUltimoAniversario.TabIndex = 2;
            this.lblAnoUltimoAniversario.Text = "&Ano último aniversário:";
            // 
            // lblCaixaCategoria
            // 
            this.lblCaixaCategoria.BackColor = System.Drawing.Color.Yellow;
            this.lblCaixaCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCaixaCategoria.Location = new System.Drawing.Point(275, 107);
            this.lblCaixaCategoria.Name = "lblCaixaCategoria";
            this.lblCaixaCategoria.Size = new System.Drawing.Size(166, 30);
            this.lblCaixaCategoria.TabIndex = 3;
            this.lblCaixaCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIdentificarCategoria
            // 
            this.btnIdentificarCategoria.Location = new System.Drawing.Point(23, 100);
            this.btnIdentificarCategoria.Name = "btnIdentificarCategoria";
            this.btnIdentificarCategoria.Size = new System.Drawing.Size(130, 45);
            this.btnIdentificarCategoria.TabIndex = 4;
            this.btnIdentificarCategoria.Text = "Identificar Categoria";
            this.btnIdentificarCategoria.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(369, 23);
            this.textBox1.TabIndex = 5;
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(126, 53);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(73, 23);
            this.txtAnoNascimento.TabIndex = 6;
            // 
            // txtAnoUltimoAniversario
            // 
            this.txtAnoUltimoAniversario.Location = new System.Drawing.Point(341, 53);
            this.txtAnoUltimoAniversario.Name = "txtAnoUltimoAniversario";
            this.txtAnoUltimoAniversario.Size = new System.Drawing.Size(100, 23);
            this.txtAnoUltimoAniversario.TabIndex = 7;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Location = new System.Drawing.Point(169, 122);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(100, 23);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoria:";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMatriculaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 161);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtAnoUltimoAniversario);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnIdentificarCategoria);
            this.Controls.Add(this.lblCaixaCategoria);
            this.Controls.Add(this.lblAnoUltimoAniversario);
            this.Controls.Add(this.lblAnoNascimento);
            this.Controls.Add(this.lblNome);
            this.Name = "frmMatriculaAluno";
            this.Text = "frmMatriculaAluno:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private Label lblAnoNascimento;
        private Label lblAnoUltimoAniversario;
        private Label lblCaixaCategoria;
        private Button btnIdentificarCategoria;
        private TextBox textBox1;
        private TextBox txtAnoNascimento;
        private TextBox txtAnoUltimoAniversario;
        private Label lblCategoria;
    }
}