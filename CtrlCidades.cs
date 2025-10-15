using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFormsPaisEstadoCidade
{
    internal class CtrlCidades : Controller
    {
        ColCidades aColCidades;
        public CtrlCidades()
        {
            aColCidades = new ColCidades();
        }
        public override void Salvar(object obj)
        {
            Cidades aCidade = (Cidades)obj;
            List<Cidades> aux = aColCidades.RetornaLista();
            if (aCidade.Codigo == 0)
            {
                aCidade.Codigo = aColCidades.Tamanho() + 10;
                aColCidades.Incluir(aCidade.Clone());
                //oEstado.Codigo = aColEstados.Tamanho() + 10;
                return;
            }
            else if (aCidade.Codigo != aux[aux.Count - 1].Codigo)
            {
                aColCidades.Incluir(aCidade.Clone());
                return;
            }

            foreach (Cidades c in aux)
            {
                if (c.Codigo == aCidade.Codigo)
                {
                    aColCidades.Atualizar(aColCidades.Buscar(c), aCidade.Clone());
                    return;
                }
            }
        }
        public override void Excluir(object obj)
        {
            Cidades aCidade = (Cidades)obj;
            List<Cidades> lista = aColCidades.RetornaLista();
            Cidades aux = lista.Find(c => c.Codigo == aCidade.Codigo);
            if (aux != null)
                aColCidades.Excluir(aux);
        }
        public List<Cidades> TodasCidades()
        {
            return aColCidades.RetornaLista();
        }
    }
}
