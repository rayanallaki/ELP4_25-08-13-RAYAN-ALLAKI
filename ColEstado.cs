using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFormsPaisEstadoCidade
{
    class ColEstado : Colecoes<Estados>
    {
        public Estados BuscaPorEstado(string estado)
        {
            foreach (var oestado in aLista)
            {
                if (oestado.Estado.Equals(estado, StringComparison.OrdinalIgnoreCase))
                {
                    return oestado;
                }
            }
            return null;
        }
        public Estados BuscaPorUf(string uf)
        {
            foreach (var oestado in aLista)
            {
                if (oestado.UF.Equals(uf, StringComparison.OrdinalIgnoreCase))
                {
                    return oestado;
                }
            }
            return null;
        }
        public Estados BuscaPorPais(string pais)
        {
            foreach (var oestado in aLista)
            {
                if (oestado.OPais != null && oestado.OPais.Pais.Equals(pais, StringComparison.OrdinalIgnoreCase))
                {
                    return oestado;
                }
            }
            return null;
        } 
    }
}
