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
        CtrlCidades aCtrlCidades;
        public frmConsultaCidade()
        {
            InitializeComponent();
        }
        private void frmConsEstados_Load(object sender, EventArgs e)
        {

        }
        protected override void Incluir()
        {
            oFrmCadCidades.ConhecaObj(oCidade, aCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.ShowDialog();
            this.CarregaLV();
        }
        protected override void Excluir()
        {
            string aux;
            oFrmCadCidades.ConhecaObj(oCidade, aCtrlCidades);

            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.BloqueiaTxt();
            aux = oFrmCadCidades.btnSalvar.Text;
            oFrmCadCidades.btnSalvar.Text = "Excluir";
            oFrmCadCidades.ShowDialog();
            oFrmCadCidades.DesbloqueiaTxt();
            oFrmCadCidades.btnSalvar.Text = aux;
            this.CarregaLV();
        }
        protected override void Alterar()
        {
            oFrmCadCidades.ConhecaObj(oCidade, aCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.ShowDialog();
            this.CarregaLV();
        }
        protected override void CarregaLV()
        {
            ListV.Items.Clear();
            List<Cidades> aux = aCtrlCidades.TodasCidades();
            foreach (Cidades cidade in aux)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(cidade.Codigo));
                item.SubItems.Add(cidade.Cidade);
                item.SubItems.Add(cidade.DDD);
                item.SubItems.Add(Convert.ToString(cidade.OEstado.Codigo));
                item.SubItems.Add(cidade.OEstado.Estado);
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
                aCtrlCidades = (CtrlCidades)ctrl;
            }

        }
    }
}
