using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFormsPaisEstadoCidade
{
    class ColCidades : Colecoes<Cidades>
    {
        public Cidades BuscaPorCidade(string cidade)
        {
            foreach (var acidade in aLista)
            {
                if (acidade.Cidade.Equals(cidade, StringComparison.OrdinalIgnoreCase))
                {
                    return acidade;
                }
            }
            return null;
        }
        public Cidades BuscaPorDDD(string ddd)
        {
            foreach (var acidade in aLista)
            {
                if (acidade.DDD.Equals(ddd, StringComparison.OrdinalIgnoreCase))
                {
                    return acidade;
                }
            }
            return null;
        }
        public Cidades BuscaPorEstados(string estado)
        {
            foreach (var acidade in aLista)
            {
                if (acidade.OEstado != null && acidade.OEstado.Estado.Equals(estado, StringComparison.OrdinalIgnoreCase))
                {
                    return acidade;
                }
            }
            return null;
        }
    }
}
