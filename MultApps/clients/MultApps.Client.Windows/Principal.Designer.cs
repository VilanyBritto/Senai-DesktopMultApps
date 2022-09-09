namespace MultApps.Client.Windows
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnAbrirFormMatriculaAluno = new System.Windows.Forms.Button();
            this.btnAbrirFormPesoIdeal = new System.Windows.Forms.Button();
            this.btnAbrirFormReajusteSalarial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirFormMatriculaAluno
            // 
            this.btnAbrirFormMatriculaAluno.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAbrirFormMatriculaAluno.FlatAppearance.BorderSize = 0;
            this.btnAbrirFormMatriculaAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirFormMatriculaAluno.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirFormMatriculaAluno.Image = global::MultApps.Client.Windows.Properties.Resources._3099383_student_man_icon;
            this.btnAbrirFormMatriculaAluno.Location = new System.Drawing.Point(287, 76);
            this.btnAbrirFormMatriculaAluno.Name = "btnAbrirFormMatriculaAluno";
            this.btnAbrirFormMatriculaAluno.Size = new System.Drawing.Size(182, 135);
            this.btnAbrirFormMatriculaAluno.TabIndex = 0;
            this.btnAbrirFormMatriculaAluno.Text = "Matricula Aluno";
            this.btnAbrirFormMatriculaAluno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirFormMatriculaAluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrirFormMatriculaAluno.UseVisualStyleBackColor = false;
            this.btnAbrirFormMatriculaAluno.Click += new System.EventHandler(this.btnAbrirFormMatriculaAluno_Click);
            // 
            // btnAbrirFormPesoIdeal
            // 
            this.btnAbrirFormPesoIdeal.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAbrirFormPesoIdeal.FlatAppearance.BorderSize = 0;
            this.btnAbrirFormPesoIdeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirFormPesoIdeal.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirFormPesoIdeal.Image = global::MultApps.Client.Windows.Properties.Resources._532643_balance_compare_equal_finance_measure_icon;
            this.btnAbrirFormPesoIdeal.Location = new System.Drawing.Point(71, 76);
            this.btnAbrirFormPesoIdeal.Name = "btnAbrirFormPesoIdeal";
            this.btnAbrirFormPesoIdeal.Size = new System.Drawing.Size(173, 135);
            this.btnAbrirFormPesoIdeal.TabIndex = 1;
            this.btnAbrirFormPesoIdeal.Text = "Peso Ideal";
            this.btnAbrirFormPesoIdeal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrirFormPesoIdeal.UseVisualStyleBackColor = false;
            this.btnAbrirFormPesoIdeal.Click += new System.EventHandler(this.btnAbrirFormPesoIdeal_Click);
            // 
            // btnAbrirFormReajusteSalarial
            // 
            this.btnAbrirFormReajusteSalarial.BackColor = System.Drawing.Color.LightGreen;
            this.btnAbrirFormReajusteSalarial.FlatAppearance.BorderSize = 0;
            this.btnAbrirFormReajusteSalarial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirFormReajusteSalarial.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirFormReajusteSalarial.Image = global::MultApps.Client.Windows.Properties.Resources._3319609_cash_dollar_paper_money_payment_icon;
            this.btnAbrirFormReajusteSalarial.Location = new System.Drawing.Point(534, 76);
            this.btnAbrirFormReajusteSalarial.Name = "btnAbrirFormReajusteSalarial";
            this.btnAbrirFormReajusteSalarial.Size = new System.Drawing.Size(182, 135);
            this.btnAbrirFormReajusteSalarial.TabIndex = 2;
            this.btnAbrirFormReajusteSalarial.Text = "Reajuste Salarial";
            this.btnAbrirFormReajusteSalarial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirFormReajusteSalarial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrirFormReajusteSalarial.UseVisualStyleBackColor = false;
            this.btnAbrirFormReajusteSalarial.Click += new System.EventHandler(this.btnAbrirFormReajusteSalarial_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.btnAbrirFormReajusteSalarial);
            this.Controls.Add(this.btnAbrirFormPesoIdeal);
            this.Controls.Add(this.btnAbrirFormMatriculaAluno);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultApps";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAbrirFormMatriculaAluno;
        private Button btnAbrirFormPesoIdeal;
        private Button btnAbrirFormReajusteSalarial;
    }
}