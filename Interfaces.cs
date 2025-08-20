using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFormsPaisEstadoCidade
{
    internal class Interfaces
    {
        FrmConsPaises oFrmConsPaises;
        frmConsEstados oFrmConsEstados;
        frmConsultaCidade oFrmConsCidade;
        FrmCadPais oFrmCadPaises;
        FrmCadEstados oFrmCadEstados;
        FrmCadCidades oFrmCadCidades;

        public Interfaces()
        {
            oFrmConsPaises = new FrmConsPaises();
            oFrmConsEstados = new frmConsEstados();
            oFrmConsCidade = new frmConsultaCidade();
            oFrmCadPaises = new FrmCadPais();
            oFrmCadEstados = new FrmCadEstados();
            oFrmCadCidades = new FrmCadCidades();

            oFrmConsPaises.setFrmCdastro(oFrmCadPaises);
            oFrmConsEstados.setFrmCdastro(oFrmCadEstados);
            oFrmConsCidade.setFrmCdastro(oFrmCadCidades);
        }

        public void PecaPaises(object obj, object ctrl)
        {
            oFrmConsPaises.ConhecaObj(obj, ctrl);
            oFrmConsPaises.ShowDialog();
        }
        public void PecaEstados(object obj, object ctrl)
        {
            oFrmConsEstados.ConhecaObj(obj, ctrl);
            oFrmConsEstados.ShowDialog();
        }
        public void PecaCidade(object obj, object ctrl)
        {
            oFrmConsCidade.ConhecaObj(obj, ctrl);
            oFrmConsCidade.ShowDialog();
        }
    }
}
