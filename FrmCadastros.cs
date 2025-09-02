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
            Sair();
        }
        public virtual void Salvar()
        { 
        }
        public virtual void CarregaTxt()
        { 
        }
        public virtual void LimpaTxt()
        { 
        }
        public virtual void BloqueiaTxt()
        { 
        }
        public virtual void DesbloqueiaTxt()
        { 
        }

    }
}
