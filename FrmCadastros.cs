using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetoFormsPaisEstadoCidade
{
    public partial class FrmCadastros : projetoFormsPaisEstadoCidade.Frm
    {
        public FrmCadastros()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        protected virtual void Salvar()
        { 
        }
        protected virtual void CarregaTxt()
        { 
        }
        protected virtual void LimpaTxt()
        { 
        }
        protected virtual void BloqueiaTxt()
        { 
        }
        protected virtual void DesbloqueiaTxt()
        { 
        }

    }
}
