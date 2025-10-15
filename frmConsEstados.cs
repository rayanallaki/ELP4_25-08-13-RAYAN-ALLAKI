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
        CtrlEstados aCtrlEstados;
        //Controller aCtrl;
        public frmConsEstados()
        {
            aCtrlEstados = new CtrlEstados();
            InitializeComponent();
        }

        private void frmConsEstados_Load(object sender, EventArgs e)
        {
        }
        protected override void Incluir()
        {
            oFrmCadEstados.ConhecaObj(oEstado, aCtrlEstados);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.ShowDialog();
            this.CarregaLV();
        }
        protected override void Excluir()
        {
            string aux;
            oFrmCadEstados.ConhecaObj(oEstado, aCtrlEstados);

            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.BloqueiaTxt();
            aux = oFrmCadEstados.btnSalvar.Text;
            oFrmCadEstados.btnSalvar.Text = "Excluir";
            oFrmCadEstados.ShowDialog();
            oFrmCadEstados.DesbloqueiaTxt();
            oFrmCadEstados.btnSalvar.Text = aux;
            this.CarregaLV();
        }
        protected override void Alterar()
        {
            oFrmCadEstados.ConhecaObj(oEstado, aCtrlEstados);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
            this.CarregaLV();
        }
        protected override void CarregaLV()
        {
            ListV.Items.Clear();
            List<Estados> aux = aCtrlEstados.TodosEstados();
            foreach (Estados estado in aux)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(estado.Codigo));
                item.SubItems.Add(estado.Estado);
                item.SubItems.Add(estado.UF);
                item.SubItems.Add(Convert.ToString(estado.OPais.Codigo));
                item.SubItems.Add(estado.OPais.Pais);
                ListV.Items.Add(item);
            }
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
                aCtrlEstados = (CtrlEstados)ctrl;
        }
    }
}
