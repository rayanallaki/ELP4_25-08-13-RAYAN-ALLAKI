using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetoFormsPaisEstadoCidade
{
    public partial class FrmCadPais : projetoFormsPaisEstadoCidade.FrmCadastros
    {
        Paises oPais;
        CtrlPaises aCtrlPaises;
        //Controller aCtrl;
        public FrmCadPais()
        {
            aCtrlPaises = new CtrlPaises();
            InitializeComponent();
        }
        public override void Salvar()
        {
            oPais.Codigo = Convert.ToInt32(txtcodigo.Text);
            oPais.Pais =   txtPais.Text;
            oPais.Sigla =  txtSigla.Text;
            oPais.Ddi =    txtDdi.Text;
            oPais.Moeda =  txtMoeda.Text;
            if (this.btnSalvar.Text == "Salvar")
                MessageBox.Show(aCtrlPaises.Salvar(oPais.Clone()));

            else if (this.btnSalvar.Text == "Excluir")
                MessageBox.Show(aCtrlPaises.Excluir(oPais.Clone()));

        }
        public override void CarregaTxt()
        {
            this.txtcodigo.Text = Convert.ToString(oPais.Codigo);
            this.txtPais.Text =   oPais.Pais;
            this.txtSigla.Text =  oPais.Sigla;
            this.txtDdi.Text =    oPais.Ddi;
            this.txtMoeda.Text =  oPais.Moeda;
        }
        public override void LimpaTxt()
        {
            this.txtcodigo.Text = "0";
            this.txtPais.Clear();
            this.txtSigla.Clear();
            this.txtDdi.Clear();
            this.txtMoeda.Clear();
        }
        public override void BloqueiaTxt()
        {
            this.txtPais.Enabled =   false;
            this.txtSigla.Enabled =  false;
            this.txtDdi.Enabled =    false;
            this.txtMoeda.Enabled =  false;
            this.txtcodigo.Enabled = false;
        }
        public override void DesbloqueiaTxt()
        {
            this.txtPais.Enabled =  true;
            this.txtSigla.Enabled = true;
            this.txtDdi.Enabled =   true;
            this.txtMoeda.Enabled = true;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null) 
                oPais = (Paises)obj;
            if (ctrl != null)
                aCtrlPaises = (CtrlPaises)ctrl;
        }
    }
}
