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
            oFrmCadPais.LimpaTxt();
            //oFrmCadPais.CarregaTxt();
            oFrmCadPais.ShowDialog();
            this.CarregaLV();
        }
        protected override void Excluir()
        {
            string aux;
            oFrmCadPais.ConhecaObj(oPais, oCtrl);

            oFrmCadPais.LimpaTxt();
            oFrmCadPais.CarregaTxt();
            oFrmCadPais.BloqueiaTxt();
            aux = oFrmCadPais.btnSalvar.Text;
            oFrmCadPais.btnSalvar.Text = "Excluir";
            oFrmCadPais.ShowDialog();
            oFrmCadPais.DesbloqueiaTxt();
            oFrmCadPais.btnSalvar.Text = aux;
        }
        protected override void Alterar()
        {
            
            oFrmCadPais.ConhecaObj(oPais, oCtrl);
            oFrmCadPais.LimpaTxt();
            oFrmCadPais.CarregaTxt();
            oFrmCadPais.ShowDialog(); 
        }
        protected override void CarregaLV()
        {
            ListViewItem item = new ListViewItem(Convert.ToString(oPais.Codigo));
            item.SubItems.Add(oPais.Pais);
            item.SubItems.Add(oPais.Sigla);
            item.SubItems.Add(oPais.Ddi);
            item.SubItems.Add(oPais.Moeda);
            ListV.Items.Add(item);
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
    }
}
