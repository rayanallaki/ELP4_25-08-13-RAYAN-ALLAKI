using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetoFormsPaisEstadoCidade
{
    public partial class FrmCadEstados : projetoFormsPaisEstadoCidade.FrmCadastros
    {
        Estados oEstado;
        Controller aCtrl;
      //Paises oPais;
        public FrmCadEstados()
        {
            InitializeComponent();
        }

        protected override void Salvar()
        {
            oEstado.Codigo = Convert.ToInt32(txtcodigo.Text);
            oEstado.Estado = txtEstado.Text;
            oEstado.UF =     txtUf.Text;
        }
        protected override void CarregaTxt()
        {
            this.txtcodigo.Text = Convert.ToString(oEstado.Codigo);
            this.txtEstado.Text = oEstado.Estado;
            this.txtUf.Text =     oEstado.UF;
        }
        protected override void LimpaTxt()
        {
            this.txtcodigo.Text = "0";
            this.txtEstado.Clear();
            this.txtUf.Clear();
        }
        protected override void BloqueiaTxt()
        {
            this.txtEstado.Enabled = false;
            this.txtUf.Enabled =     false;
        }
        protected override void DesbloqueiaTxt()
        {
            this.txtEstado.Enabled = true;
            this.txtUf.Enabled =     true;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oEstado = (Estados)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
