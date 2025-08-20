using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetoFormsPaisEstadoCidade
{
    public partial class FrmCadCidades : projetoFormsPaisEstadoCidade.FrmCadastros
    {
        Cidades oCidade;
        Controller aCtrl;
        public FrmCadCidades()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        protected override void Salvar()
        {
            oCidade.Codigo = Convert.ToInt32(txtcodigo.Text);
            oCidade.Cidade = txtCidade.Text;
            oCidade.DDD =    txtDdd.Text;
        }
        protected override void CarregaTxt()
        {
            this.txtCidade.Text = oCidade.Cidade;
            this.txtDdd.Text =    oCidade.DDD;
            this.txtcodigo.Text = Convert.ToString(oCidade.Codigo);
        }
        protected override void LimpaTxt()
        {
            this.txtcodigo.Text = "0";
            this.txtCidade.Clear();
            this.txtDdd.Clear();
        }
        protected override void BloqueiaTxt()
        {
            this.txtCidade.Enabled = false;
            this.txtDdd.Enabled =    false;
        }
        protected override void DesbloqueiaTxt()
        {
            this.txtCidade.Enabled = true;
            this.txtDdd.Enabled =    true;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if(obj != null)
                oCidade = (Cidades)obj;
            if (ctrl != null)
                aCtrl = (Controller)obj;
        }
    }
}
