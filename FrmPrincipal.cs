using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoFormsPaisEstadoCidade
{
    public partial class FrmPrincipal : Form
    {
        Interfaces aInter = new Interfaces();
        Paises oPais = new Paises();
        Paises oPais1 = new Paises();
        Estados oEstado = new Estados();
        Estados oEstado1 = new Estados();
        Cidades oCidade = new Cidades();
        Cidades oCidade1 = new Cidades();
        Controller aCtrl = new Controller();

        public FrmPrincipal()
        {
            InitializeComponent();

        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaPaises(oPais, aCtrl);
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaEstados(oEstado, aCtrl);
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaCidade(oCidade, aCtrl);
        }
    }
}
