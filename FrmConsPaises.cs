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
    public partial class FrmConsPaises : projetoFormsPaisEstadoCidade.frmConsultas
    {
        FrmCadPais oFrmCadPais;
        Paises oPais;
        //Controller aCtrl;
        CtrlPaises aCtrlPaises;
        public FrmConsPaises()
        {
            aCtrlPaises = new CtrlPaises();
            InitializeComponent();
        }
        protected override void Incluir()
        {
            oFrmCadPais.LimpaTxt();
            oFrmCadPais.ConhecaObj(oPais, aCtrlPaises);
            oFrmCadPais.ShowDialog();
            this.CarregaLV();
        }
        protected override void Excluir()
        {
            ListV_SelectedIndexChanged(oPais, null);



            string aux;
            oFrmCadPais.ConhecaObj(oPais, aCtrlPaises);

            oFrmCadPais.LimpaTxt();
            oFrmCadPais.CarregaTxt();
            oFrmCadPais.BloqueiaTxt();
            aux = oFrmCadPais.btnSalvar.Text;
            oFrmCadPais.btnSalvar.Text = "Excluir";
            oFrmCadPais.ShowDialog();
            oFrmCadPais.DesbloqueiaTxt();
            oFrmCadPais.btnSalvar.Text = aux;
            this.CarregaLV();
        }
        protected override void Alterar()
        {
            ListV_SelectedIndexChanged(oPais, null);

            //aCtrlPaises.CarregaObj(oPais);
            oFrmCadPais.ConhecaObj(oPais, aCtrlPaises);
            oFrmCadPais.LimpaTxt();
            oFrmCadPais.CarregaTxt();
            oFrmCadPais.ShowDialog();
            this.CarregaLV();
        }
        protected override void CarregaLV()
        {
            ListV.Items.Clear();
            List<Paises> aux = aCtrlPaises.TodosPaises();
            foreach (Paises pais in aux) 
            {
                ListViewItem item = new ListViewItem(Convert.ToString(pais.Codigo));
                item.SubItems.Add(pais.Pais);
                item.SubItems.Add(pais.Sigla);
                item.SubItems.Add(pais.Ddi);
                item.SubItems.Add(pais.Moeda);
                item.Tag = pais;
                ListV.Items.Add(item);
            }
        }
        protected override void Pesquisar()
        {
            if(txtcodigo.Text != string.Empty)
            { 
                ListV.Items.Clear();
                foreach (var oPais in aCtrlPaises.Pesquisar(txtcodigo.Text).Cast<Paises>().ToList())
                { 
                    ListViewItem item = new ListViewItem(Convert.ToString(oPais.Codigo));
                    item.SubItems.Add(oPais.Pais);
                    item.SubItems.Add(oPais.Sigla);
                    item.SubItems.Add(oPais.Ddi);
                    item.SubItems.Add(oPais.Moeda);
                    ListV.Items.Add(item);
                }
            }
        }
        public override void setFrmCdastro(object obj)
        {
            if (obj != null) 
            {
                oFrmCadPais = (FrmCadPais)obj;    
            }
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
            {
                oPais = (Paises)obj;
            }
            if (ctrl != null) 
            { 
                aCtrlPaises = (CtrlPaises)ctrl;
            }
            this.CarregaLV();
        }

        private void ListV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ListV.SelectedItems.Count > 0)
            {
                ListViewItem item = this.ListV.SelectedItems[0];

                // Agora pegamos o país armazenado no Tag
                Paises paisSelecionado = (Paises)item.Tag;

                // Atualiza o objeto oPais passado pelo outro formulário
                oPais.Codigo = paisSelecionado.Codigo;
                oPais.Pais = paisSelecionado.Pais;
                oPais.Sigla = paisSelecionado.Sigla;
                oPais.Ddi = paisSelecionado.Ddi;
                oPais.Moeda = paisSelecionado.Moeda;
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
