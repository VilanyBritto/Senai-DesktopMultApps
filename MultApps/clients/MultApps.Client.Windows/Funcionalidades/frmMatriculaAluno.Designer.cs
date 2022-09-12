namespace MultApps.Client.Windows.Funcionalidades
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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnIdentificarCategoria = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.txtAnoUltimoAniversario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoje = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "&Nome:";
            // 
            // lblAnoNascimento
            // 
            this.lblAnoNascimento.AutoSize = true;
            this.lblAnoNascimento.Location = new System.Drawing.Point(12, 84);
            this.lblAnoNascimento.Name = "lblAnoNascimento";
            this.lblAnoNascimento.Size = new System.Drawing.Size(119, 20);
            this.lblAnoNascimento.TabIndex = 1;
            this.lblAnoNascimento.Text = "&Ano nascimento:";
            // 
            // lblAnoUltimoAniversario
            // 
            this.lblAnoUltimoAniversario.AutoSize = true;
            this.lblAnoUltimoAniversario.Location = new System.Drawing.Point(222, 84);
            this.lblAnoUltimoAniversario.Name = "lblAnoUltimoAniversario";
            this.lblAnoUltimoAniversario.Size = new System.Drawing.Size(162, 20);
            this.lblAnoUltimoAniversario.TabIndex = 2;
            this.lblAnoUltimoAniversario.Text = "&Ano último aniversário:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.Color.Yellow;
            this.lblCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategoria.Location = new System.Drawing.Point(313, 185);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(190, 40);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIdentificarCategoria
            // 
            this.btnIdentificarCategoria.Location = new System.Drawing.Point(23, 175);
            this.btnIdentificarCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIdentificarCategoria.Name = "btnIdentificarCategoria";
            this.btnIdentificarCategoria.Size = new System.Drawing.Size(149, 60);
            this.btnIdentificarCategoria.TabIndex = 4;
            this.btnIdentificarCategoria.Text = "Identificar Categoria";
            this.btnIdentificarCategoria.UseVisualStyleBackColor = true;
            this.btnIdentificarCategoria.Click += new System.EventHandler(this.btnIdentificarCategoria_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 32);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(432, 27);
            this.txtNome.TabIndex = 5;
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(137, 81);
            this.txtAnoNascimento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnoNascimento.MaxLength = 4;
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(83, 27);
            this.txtAnoNascimento.TabIndex = 6;
            this.txtAnoNascimento.Validating += new System.ComponentModel.CancelEventHandler(this.txtAnoUltimoAniversario_Validating);
            // 
            // txtAnoUltimoAniversario
            // 
            this.txtAnoUltimoAniversario.Location = new System.Drawing.Point(389, 77);
            this.txtAnoUltimoAniversario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnoUltimoAniversario.Name = "txtAnoUltimoAniversario";
            this.txtAnoUltimoAniversario.Size = new System.Drawing.Size(114, 27);
            this.txtAnoUltimoAniversario.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Categoria:";
            // 
            // lblHoje
            // 
            this.lblHoje.Location = new System.Drawing.Point(173, 127);
            this.lblHoje.Name = "lblHoje";
            this.lblHoje.Size = new System.Drawing.Size(330, 27);
            this.lblHoje.TabIndex = 9;
            this.lblHoje.ValueChanged += new System.EventHandler(this.lblHoje_ValueChanged);
            // 
            // frmMatriculaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 282);
            this.Controls.Add(this.lblHoje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnoUltimoAniversario);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnIdentificarCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblAnoUltimoAniversario);
            this.Controls.Add(this.lblAnoNascimento);
            this.Controls.Add(this.lblNome);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMatriculaAluno";
            this.Text = "frmMatriculaAluno:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private Label lblAnoNascimento;
        private Label lblAnoUltimoAniversario;
        private Button btnIdentificarCategoria;
        private TextBox txtNome;
        private TextBox txtAnoNascimento;
        private TextBox txtAnoUltimoAniversario;
        private Label lblCategoria;
        private Label label1;
        private DateTimePicker lblHoje;
    }
}