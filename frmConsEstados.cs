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
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.ConhecaObj(oEstado, aCtrlEstados);           
            oFrmCadEstados.ShowDialog();
            this.CarregaLV();
        }
        protected override void Excluir()
        {
            ListV_SelectedIndexChanged(oEstado, null);



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
            ListV_SelectedIndexChanged(oEstado, null);
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
                item.Tag = estado;
                ListV.Items.Add(item);
            }
        }
        protected override void Pesquisar()
        {
            if (txtcodigo.Text != string.Empty)
            {
                ListV.Items.Clear();
                foreach (var oEstado in aCtrlEstados.Pesquisar(txtcodigo.Text).Cast<Estados>().ToList())
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(oEstado.Codigo));
                    item.SubItems.Add(oEstado.Estado);
                    item.SubItems.Add(oEstado.UF);
                    item.SubItems.Add(oEstado.OPais.Codigo.ToString());
                    item.SubItems.Add(oEstado.OPais.Pais);
                    ListV.Items.Add(item);
                }
            }
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
            this.CarregaLV();
        }

        private void ListV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ListV.SelectedItems.Count > 0)
            {
                ListViewItem item = this.ListV.SelectedItems[0];

                // Agora pegamos o país armazenado no Tag
                Estados estadoSelecionado = (Estados)item.Tag;

                // Atualiza o objeto oPais passado pelo outro formulário
                oEstado.Codigo = estadoSelecionado.Codigo;
                oEstado.Estado = estadoSelecionado.Estado;
                oEstado.UF = estadoSelecionado.UF;
                oEstado.OPais.Codigo = estadoSelecionado.OPais.Codigo;
                oEstado.OPais.Pais = estadoSelecionado.OPais.Pais;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (ListV.SelectedItems.Count > 0)
                {
                    // Confirma a seleção e fecha o formulário
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um país na lista antes de confirmar.");
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
