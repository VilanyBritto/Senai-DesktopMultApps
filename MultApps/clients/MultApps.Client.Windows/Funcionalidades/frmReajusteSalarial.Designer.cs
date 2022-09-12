namespace MultApps.Client.Windows.Funcionalidades
{
    partial class frmReajusteSalarial
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxCategoria = new System.Windows.Forms.GroupBox();
            this.rbnVeterano = new System.Windows.Forms.RadioButton();
            this.rbnCalouro = new System.Windows.Forms.RadioButton();
            this.gbxTurno = new System.Windows.Forms.GroupBox();
            this.rbnNoturno = new System.Windows.Forms.RadioButton();
            this.rbnVespertino = new System.Windows.Forms.RadioButton();
            this.rbnMatutino = new System.Windows.Forms.RadioButton();
            this.btnCalcular_Click = new System.Windows.Forms.Button();
            this.lbxResumo = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.gbxCategoria.SuspendLayout();
            this.gbxTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário mínimo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas trabalhadas:";
            // 
            // gbxCategoria
            // 
            this.gbxCategoria.Controls.Add(this.rbnVeterano);
            this.gbxCategoria.Controls.Add(this.rbnCalouro);
            this.gbxCategoria.Location = new System.Drawing.Point(26, 100);
            this.gbxCategoria.Name = "gbxCategoria";
            this.gbxCategoria.Size = new System.Drawing.Size(261, 61);
            this.gbxCategoria.TabIndex = 2;
            this.gbxCategoria.TabStop = false;
            this.gbxCategoria.Text = "Categoria";
            // 
            // rbnVeterano
            // 
            this.rbnVeterano.AutoSize = true;
            this.rbnVeterano.Checked = true;
            this.rbnVeterano.Location = new System.Drawing.Point(138, 26);
            this.rbnVeterano.Name = "rbnVeterano";
            this.rbnVeterano.Size = new System.Drawing.Size(89, 24);
            this.rbnVeterano.TabIndex = 1;
            this.rbnVeterano.TabStop = true;
            this.rbnVeterano.Text = "Veterano";
            this.rbnVeterano.UseVisualStyleBackColor = true;
            // 
            // rbnCalouro
            // 
            this.rbnCalouro.AutoSize = true;
            this.rbnCalouro.Location = new System.Drawing.Point(31, 26);
            this.rbnCalouro.Name = "rbnCalouro";
            this.rbnCalouro.Size = new System.Drawing.Size(82, 24);
            this.rbnCalouro.TabIndex = 0;
            this.rbnCalouro.Text = "Calouro";
            this.rbnCalouro.UseVisualStyleBackColor = true;
            // 
            // gbxTurno
            // 
            this.gbxTurno.Controls.Add(this.rbnNoturno);
            this.gbxTurno.Controls.Add(this.rbnVespertino);
            this.gbxTurno.Controls.Add(this.rbnMatutino);
            this.gbxTurno.Location = new System.Drawing.Point(305, 31);
            this.gbxTurno.Name = "gbxTurno";
            this.gbxTurno.Size = new System.Drawing.Size(152, 130);
            this.gbxTurno.TabIndex = 3;
            this.gbxTurno.TabStop = false;
            this.gbxTurno.Text = "Turno";
            // 
            // rbnNoturno
            // 
            this.rbnNoturno.AutoSize = true;
            this.rbnNoturno.Checked = true;
            this.rbnNoturno.Location = new System.Drawing.Point(6, 95);
            this.rbnNoturno.Name = "rbnNoturno";
            this.rbnNoturno.Size = new System.Drawing.Size(85, 24);
            this.rbnNoturno.TabIndex = 4;
            this.rbnNoturno.TabStop = true;
            this.rbnNoturno.Text = "Noturno";
            this.rbnNoturno.UseVisualStyleBackColor = true;
            // 
            // rbnVespertino
            // 
            this.rbnVespertino.AutoSize = true;
            this.rbnVespertino.Location = new System.Drawing.Point(6, 56);
            this.rbnVespertino.Name = "rbnVespertino";
            this.rbnVespertino.Size = new System.Drawing.Size(100, 24);
            this.rbnVespertino.TabIndex = 3;
            this.rbnVespertino.Text = "Vespertino";
            this.rbnVespertino.UseVisualStyleBackColor = true;
            // 
            // rbnMatutino
            // 
            this.rbnMatutino.AutoSize = true;
            this.rbnMatutino.Location = new System.Drawing.Point(6, 26);
            this.rbnMatutino.Name = "rbnMatutino";
            this.rbnMatutino.Size = new System.Drawing.Size(90, 24);
            this.rbnMatutino.TabIndex = 2;
            this.rbnMatutino.Text = "Matutino";
            this.rbnMatutino.UseVisualStyleBackColor = true;
            // 
            // btnCalcular_Click
            // 
            this.btnCalcular_Click.Location = new System.Drawing.Point(363, 251);
            this.btnCalcular_Click.Name = "btnCalcular_Click";
            this.btnCalcular_Click.Size = new System.Drawing.Size(94, 29);
            this.btnCalcular_Click.TabIndex = 4;
            this.btnCalcular_Click.Text = "Calcular";
            this.btnCalcular_Click.UseVisualStyleBackColor = true;
            this.btnCalcular_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxResumo
            // 
            this.lbxResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxResumo.FormattingEnabled = true;
            this.lbxResumo.ItemHeight = 17;
            this.lbxResumo.Location = new System.Drawing.Point(26, 166);
            this.lbxResumo.MultiColumn = true;
            this.lbxResumo.Name = "lbxResumo";
            this.lbxResumo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxResumo.Size = new System.Drawing.Size(431, 72);
            this.lbxResumo.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(26, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 24);
            this.textBox1.TabIndex = 6;
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Location = new System.Drawing.Point(164, 31);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(135, 27);
            this.txtSalarioMinimo.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtSalarioMinimo, "teste");
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(165, 68);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(134, 27);
            this.txtHorasTrabalhadas.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtHorasTrabalhadas, "teste 2");
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ajuda";
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Informe as horas trabalhadas!";
            // 
            // frmReajusteSalarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 305);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbxResumo);
            this.Controls.Add(this.btnCalcular_Click);
            this.Controls.Add(this.gbxTurno);
            this.Controls.Add(this.gbxCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmReajusteSalarial";
            this.Text = "frmReajusteSalarial";
            this.gbxCategoria.ResumeLayout(false);
            this.gbxCategoria.PerformLayout();
            this.gbxTurno.ResumeLayout(false);
            this.gbxTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox gbxCategoria;
        private RadioButton rbnVeterano;
        private RadioButton rbnCalouro;
        private GroupBox gbxTurno;
        private RadioButton rbnNoturno;
        private RadioButton rbnVespertino;
        private RadioButton rbnMatutino;
        private Button btnCalcular_Click;
        private ListBox lbxResumo;
        private TextBox textBox1;
        private TextBox txtSalarioMinimo;
        private ToolTip toolTip1;
        private TextBox txtHorasTrabalhadas;
        private ToolTip toolTip2;
    }
}