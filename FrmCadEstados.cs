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
        FrmConsPaises oFrmConsPaises;
        public FrmCadEstados()
        {
            InitializeComponent();
            oEstado = new Estados();
            oFrmConsPaises = new FrmConsPaises();
        }
        public void setFrmConsPaises(object obj)
        {
            if (obj != null)
            {
                oFrmConsPaises = (FrmConsPaises)obj;
            }
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
            {
                oEstado = (Estados)obj;
            }
            if (ctrl != null)
            {
                aCtrl = (Controller)ctrl;
            }
        }
        public override void Salvar()
        {
            oEstado.Codigo = Convert.ToInt32(txtcodigo.Text);
            oEstado.Estado =     txtEstado.Text;
            oEstado.OPais.Pais = txtPais.Text;
            oEstado.UF =         txtUf.Text;
        }
        public override void CarregaTxt()
        {
            this.txtcodigo.Text = Convert.ToString(oEstado.Codigo);
            this.txtEstado.Text = oEstado.Estado;
            this.txtPais.Text =   oEstado.OPais.Pais;
            this.txtUf.Text =     oEstado.UF;
        }
        public override void LimpaTxt()
        {
            this.txtcodigo.Text = "0";
            this.txtPais.Clear();
            this.txtEstado.Clear();
            this.txtUf.Clear();
        }
        public override void BloqueiaTxt()
        {
            this.txtPais.Enabled = false;
            this.txtEstado.Enabled = false;
            this.txtUf.Enabled =     false;
            this.txtCodigoPais.Enabled = false;
            this.txtcodigo.Enabled = false;
        }
        public override void DesbloqueiaTxt()
        {
            this.txtPais.Enabled = true;
            this.txtEstado.Enabled = true;
            this.txtUf.Enabled =     true;
        }
        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string btnSair = oFrmConsPaises.btnSair.Text;
            oFrmConsPaises.btnSair.Text = "Selecionar";
            oFrmConsPaises.ConhecaObj(oEstado.OPais, aCtrl);
            oFrmConsPaises.ShowDialog();
            this.txtCodigoPais.Text = Convert.ToString(oEstado.OPais.Codigo);
            this.txtPais.Text = oEstado.OPais.Pais.ToString();
            oFrmConsPaises.btnSair.Text = btnSair; 
        }
    }
}
