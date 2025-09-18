using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFormsPaisEstadoCidade
{
     class ColPaises : Colecoes<Paises>
     {
        public Paises BuscaPorPaises(string pais)
        {
            foreach (var opais in aLista)
            {
                if (opais.Pais.Equals(pais, StringComparison.OrdinalIgnoreCase))
                {
                    return opais;
                }
            }
            return null;
        }
        public Paises BuscarPorSigla(string sigla)
        {
            foreach (var opais in aLista)
            {
                if (opais.Sigla.Equals(sigla, StringComparison.OrdinalIgnoreCase))
                {
                    return opais;
                }
            }
            return null;
        }
        public Paises BuscarPorDdi(string ddi)
        {
            foreach (var opais in aLista)
            {
                if (opais.Ddi.Equals(ddi, StringComparison.OrdinalIgnoreCase))
                {
                    return opais;
                }
            }
            return null;
        }
        public Paises BuscaPorMoeda(string moeda)
        {
            foreach (var opais in aLista)
            {
                if (opais.Moeda.Equals(moeda, StringComparison.OrdinalIgnoreCase))
                {
                    return opais;
                }
            }
            return null;
        }
    }
}
