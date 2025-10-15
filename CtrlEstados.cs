using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFormsPaisEstadoCidade
{
    internal class CtrlEstados : Controller
    {
        ColEstado aColEstados;
        public CtrlEstados()
        {
            aColEstados = new ColEstado();
        }
        public override void Salvar(object obj)
        {
            Estados oEstado = (Estados)obj;
            List<Estados> aux = aColEstados.RetornaLista();
            if (oEstado.Codigo == 0)
            {
                oEstado.Codigo = aColEstados.Tamanho() + 10;
                aColEstados.Incluir(oEstado.Clone());
                //oEstado.Codigo = aColEstados.Tamanho() + 10;
                return;
            }
            else if (oEstado.Codigo != aux[aux.Count - 1].Codigo)
            {
                aColEstados.Incluir(oEstado.Clone());
                return;
            }

            foreach (Estados e in aux)
            {
                if (e.Codigo == oEstado.Codigo)
                {
                    aColEstados.Atualizar(aColEstados.Buscar(e), oEstado.Clone());
                    return;
                }
            }
        }
        public override void Excluir(object obj)
        {
            Estados oEstado = (Estados)obj;     
            List<Estados> lista = aColEstados.RetornaLista();
            Estados aux = lista.Find(e => e.Codigo == oEstado.Codigo);
            if (aux != null)
                aColEstados.Excluir(aux);
        }
        public List<Estados> TodosEstados()
        {
            return aColEstados.RetornaLista();
        }
    }
}
