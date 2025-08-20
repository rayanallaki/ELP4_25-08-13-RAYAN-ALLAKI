using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetoFormsPaisEstadoCidade
{
    public partial class frmConsEstados : projetoFormsPaisEstadoCidade.frmConsultas
    {
        FrmCadEstados oFrmCadEstados;
        Estados oEstado;
        Controller aCtrl;
        public frmConsEstados()
        {
            InitializeComponent();
        }

        private void frmConsEstados_Load(object sender, EventArgs e)
        {
        }
        protected override void Incluir()
        {
            oFrmCadEstados.ShowDialog();
        }
        protected override void Excluir()
        {
            oFrmCadEstados.ShowDialog();
        }
        protected override void Alterar()
        {
            oFrmCadEstados.ShowDialog();
        }
        protected override void Pesquisar()
        {
        }
        public override void setFrmCdastro(object obj)
        {
            if (obj != null)
            {
                oFrmCadEstados = (FrmCadEstados)obj;
            }
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oEstado = (Estados)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }
    }
}
