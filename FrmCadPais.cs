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
        Controller aCtrl;
        public FrmCadPais()
        {
            InitializeComponent();
        }
        protected override void Salvar()
        {
            //if (MessageDlg("Confirma? S/N") == "S")
            {
                oPais.Codigo = Convert.ToInt32(txtcodigo.Text);
                oPais.Pais =   txtPais.Text;
                oPais.Sigla =  txtSigla.Text;
                oPais.Ddi =    txtDdi.Text;
                oPais.Moeda =  txtMoeda.Text;
            }
            
        }
        protected override void CarregaTxt()
        {
            this.txtcodigo.Text = Convert.ToString(oPais.Codigo);
            this.txtPais.Text =   oPais.Pais;
            this.txtSigla.Text =  oPais.Sigla;
            this.txtDdi.Text =    oPais.Ddi;
            this.txtMoeda.Text =  oPais.Moeda;
        }
        protected override void LimpaTxt()
        {
            this.txtcodigo.Text = "0";
            this.txtPais.Clear();
            this.txtSigla.Clear();
            this.txtDdi.Clear();
            this.txtMoeda.Clear();
        }
        protected override void BloqueiaTxt()
        {
            this.txtPais.Enabled =  false;
            this.txtSigla.Enabled = false;
            this.txtDdi.Enabled =   false;
            this.txtMoeda.Enabled = false;
        }
        protected override void DesbloqueiaTxt()
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
                aCtrl = (Controller)ctrl;
        }
    }
}
