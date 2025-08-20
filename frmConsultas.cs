using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetoFormsPaisEstadoCidade
{
    public partial class frmConsultas : projetoFormsPaisEstadoCidade.Frm
    {
        public frmConsultas()
        {
            InitializeComponent();
        }
        protected virtual void Incluir()
        { 

        }
        protected virtual void Excluir()
        { 
        
        }
        protected virtual void Alterar()
        { 
        }
        protected virtual void Pesquisar()
        { 
        }
        private void Incluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }
       
        public virtual void setFrmCdastro(object obj)
        { 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }
    }
}
