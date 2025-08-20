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
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }
        protected virtual void Sair()
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void Frm_Load(object sender, EventArgs e)
        {

        }
        public virtual void ConhecaObj(object obj, object ctrl)
        {

        }        
    }
}
