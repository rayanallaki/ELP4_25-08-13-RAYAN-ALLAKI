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
        //Controller aCtrl;
        CtrlPaises aCtrlPaises;
        public FrmConsPaises()
        {
            aCtrlPaises = new CtrlPaises();
            InitializeComponent();
        }
        protected override void Incluir()
        {
            oFrmCadPais.ConhecaObj(oPais, aCtrlPaises);
            oFrmCadPais.LimpaTxt();
            // oFrmCadPais.CarregaTxt();
            oFrmCadPais.ShowDialog();
            this.CarregaLV();
        }
        protected override void Excluir()
        {
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
                ListV.Items.Add(item);
            }
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
                aCtrlPaises = (CtrlPaises)ctrl;
            } 
        }
    }
}
