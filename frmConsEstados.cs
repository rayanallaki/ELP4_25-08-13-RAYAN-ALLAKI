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
            oFrmCadEstados.ConhecaObj(oEstado, aCtrl);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
        }
        protected override void Excluir()
        {
            string aux;
            oFrmCadEstados.ConhecaObj(oEstado, aCtrl);

            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.BloqueiaTxt();
            aux = oFrmCadEstados.btnSalvar.Text;
            oFrmCadEstados.btnSalvar.Text = "Excluir";
            oFrmCadEstados.ShowDialog();
            oFrmCadEstados.DesbloqueiaTxt();
            oFrmCadEstados.btnSalvar.Text = aux;
        }
        protected override void Alterar()
        {
            oFrmCadEstados.ConhecaObj(oEstado, aCtrl);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
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
