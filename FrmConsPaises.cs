using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetoFormsPaisEstadoCidade
{
    public partial class FrmConsPaises : projetoFormsPaisEstadoCidade.frmConsultas
    {
        FrmCadPais oFrmCadPais;
        Paises oPais;
        Controller oCtrl;
        public FrmConsPaises()
        {
            InitializeComponent();
        }
        protected override void Incluir()
        {
            oFrmCadPais.ConhecaObj(oPais, oCtrl);
            oFrmCadPais.ShowDialog();
        }
        protected override void Excluir()
        {
            oFrmCadPais.ConhecaObj(oPais, oCtrl);
            oFrmCadPais.ShowDialog();
        }
        protected override void Alterar()
        {
            oFrmCadPais.ConhecaObj(oPais, oCtrl);
            oFrmCadPais.ShowDialog(); 
        }
        protected override void Pesquisar()
        {
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
                oCtrl = (Controller)ctrl;
            }
        }

        private void FrmConsPaises_Load(object sender, EventArgs e)
        {

        }
    }
}
