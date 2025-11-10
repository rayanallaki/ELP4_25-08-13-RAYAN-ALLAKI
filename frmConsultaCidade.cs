using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.ConhecaObj(oCidade, aCtrlCidades);        
            oFrmCadCidades.ShowDialog();
            this.CarregaLV();
        }
        protected override void Excluir()
        {
            ListV_SelectedIndexChanged(oCidade, null);


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
            ListV_SelectedIndexChanged(oCidade, null);
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
                item.Tag = cidade;
                ListV.Items.Add(item);
            }
        }
        protected override void Pesquisar()
        {
            if (txtcodigo.Text != string.Empty)
            {
                ListV.Items.Clear();
                foreach (var oCidade in aCtrlCidades.Pesquisar(txtcodigo.Text).Cast<Cidades>().ToList())
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(oCidade.Codigo));
                    item.SubItems.Add(oCidade.Cidade);
                    item.SubItems.Add(oCidade.DDD);
                    item.SubItems.Add(oCidade.OEstado.Codigo.ToString());
                    item.SubItems.Add(oCidade.OEstado.Estado);
                    ListV.Items.Add(item);
                }
            }
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
            this.CarregaLV();

        }

        private void ListV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ListV.SelectedItems.Count > 0)
            {
                ListViewItem item = this.ListV.SelectedItems[0];

                
                Cidades cidadeSelecionada = (Cidades)item.Tag;

                oCidade.Codigo = cidadeSelecionada.Codigo;
                oCidade.Cidade = cidadeSelecionada.Cidade;
                oCidade.DDD = cidadeSelecionada.DDD;
                oCidade.OEstado.Codigo = cidadeSelecionada.OEstado.Codigo;
                oCidade.OEstado.Estado = cidadeSelecionada.OEstado.Estado;
            }
        }
    }
}
