using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetoFormsPaisEstadoCidade
{
    public partial class frmConsultaCidade : projetoFormsPaisEstadoCidade.frmConsultas
    {
        FrmCadCidades oFrmCadCidades;
        Cidades oCidade;
        Controller aCtrl;
        public frmConsultaCidade()
        {
            InitializeComponent();
        }
        private void frmConsEstados_Load(object sender, EventArgs e)
        {

        }
        protected override void Incluir()
        {
            oFrmCadCidades.ShowDialog();
        }
        protected override void Excluir()
        {
            oFrmCadCidades.ShowDialog();
        }
        protected override void Alterar()
        {
            oFrmCadCidades.ShowDialog();
        }
        protected override void Pesquisar()
        {
        }
        public override void setFrmCdastro(object obj)
        {
            if (obj != null)
            {
                oFrmCadCidades = (FrmCadCidades)obj;
            } 
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
            {
                oCidade = (Cidades)obj;
            }
            if (ctrl != null)
            {
                aCtrl = (Controller)ctrl;
            }

        }
    }
}
