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
            oFrmCadCidades.ConhecaObj(oCidade, aCtrl);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.ShowDialog();
        }
        protected override void Excluir()
        {
            string aux;
            oFrmCadCidades.ConhecaObj(oCidade, aCtrl);

            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.BloqueiaTxt();
            aux = oFrmCadCidades.btnSalvar.Text;
            oFrmCadCidades.btnSalvar.Text = "Excluir";
            oFrmCadCidades.ShowDialog();
            oFrmCadCidades.DesbloqueiaTxt();
            oFrmCadCidades.btnSalvar.Text = aux;
        }
        protected override void Alterar()
        {
            oFrmCadCidades.ConhecaObj(oCidade, aCtrl);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
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
