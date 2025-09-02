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
        frmConsEstados ofrmConsEstados;
        public FrmCadCidades()
        {
            InitializeComponent();
            ofrmConsEstados = new frmConsEstados();
            oCidade = new Cidades();
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        } 
        public override void Salvar()
        {
            oCidade.Codigo = Convert.ToInt32(txtcodigo.Text);
            oCidade.Cidade = txtCidade.Text;
            oCidade.DDD =    txtDdd.Text;
        }
        public override void CarregaTxt()
        {
            this.txtCidade.Text = oCidade.Cidade;
            this.txtDdd.Text =    oCidade.DDD;
            this.txtcodigo.Text = Convert.ToString(oCidade.Codigo);
        }
        public override void LimpaTxt()
        {
            this.txtcodigo.Text = "0";
            this.txtCidade.Clear();
            this.txtDdd.Clear();
        }
        public override void BloqueiaTxt()
        {
            this.txtCidade.Enabled =       false;
            this.txtDdd.Enabled =          false;
            this.txtCodigoEstado.Enabled = false;
            this.txtcodigo.Enabled =       false;
            this.txtEstado.Enabled =       false;
        }
        public override void DesbloqueiaTxt()
        {
            this.txtCidade.Enabled = true;
            this.txtDdd.Enabled =    true;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if(obj != null)
                oCidade = (Cidades)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }
        public void setFrmConsEstados(Object obj)
        {
            if (obj != null)
            {
                ofrmConsEstados = (frmConsEstados)obj;
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string btnSair = ofrmConsEstados.btnSair.Text;
            ofrmConsEstados.btnSair.Text = "Selecionar";
            ofrmConsEstados.ConhecaObj(oCidade.OEstado, aCtrl);
            ofrmConsEstados.ShowDialog();
            this.txtCodigoEstado.Text = Convert.ToString(oCidade.OEstado.Codigo);
            this.txtEstado.Text = oCidade.OEstado.Estado.ToString();
            ofrmConsEstados.btnSair.Text = btnSair;
        }
    }
}
