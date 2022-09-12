﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Client.Windows.Funcionalidades
{
    public partial class frmMatriculaAluno : Form
    {
        public frmMatriculaAluno()
        {
            InitializeComponent();
        }
        private void txtAnoUltimoAniversario_Enter(object sender, EventArgs e)
        {
            if (txtAnoNascimento.Text.Trim().Length < 4)
            {
                MessageBox.Show("É preciso informar o ANO DE " + "NASCIMENTO com 4 digitos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnoNascimento.Focus();
            }
        }        
        private void txtAnoUltimoAniversario_Validating(object sender, CancelEventArgs e)
        {
        }
        //Código página 42 começa aqui
        //if (Convert.ToInt32(txtAnoUltimoAniversario.Text) <= Convert.ToInt32(txtAnoNascimento.Text))
        //{
        //    MessageBox.Show("O ANO DO ÚLTIMO ANIVERSÁRIO " + "deve ser superior ao do ANO DE NASCIMENTO.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    e.Cancel = true;
        //}
        //Termina aqui.
        private void btnIdentificarCategoria_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty || txtAnoNascimento.Text == String.Empty || txtAnoUltimoAniversario.Text == String.Empty)
            {
                MessageBox.Show("Todos os dados " + "solicitados devem ser informados.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                else
                {
                int idade = Convert.ToInt32(txtAnoUltimoAniversario.Text) - Convert.ToInt32(txtAnoNascimento.Text);
                if (idade > 17)
                {
                    lblCategoria.Text = "Adulto";
                }
                else if (idade > 13) 
                { lblCategoria.Text = "Juvenil B";
                }
                else if (idade > 10) 
                { lblCategoria.Text = "Juvenil A"; 
                }
                else if (idade > 7) 
                { lblCategoria.Text = "Infantil B"; 
                }
                else if (idade >= 5) 
                { lblCategoria.Text = "Infantil A"; 
                }
                else 
                { lblCategoria.Text = "Não existe categoria"; 
                }
                }
        }

        private void lblHoje_ValueChanged(object sender, EventArgs e)
        {                   
         //public FormCategoriaPorIdadeV2()
         {
            InitializeComponent();
            lblHoje.Text = "Hoje é " +
            DateTime.Now.ToShortDateString();
         }

        }
    }
}

