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
            oFrmCadCidades.ShowDialog();
            this.CarregaLV();
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
        protected override void CarregaLV()
        {
            ListViewItem item = new ListViewItem(Convert.ToString(oCidade.Codigo));
            item.SubItems.Add(oCidade.Cidade);
            item.SubItems.Add(oCidade.DDD);
            item.SubItems.Add(Convert.ToString(oCidade.OEstado.Codigo));
            item.SubItems.Add(oCidade.OEstado.Estado);
            ListV.Items.Add(item);
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
