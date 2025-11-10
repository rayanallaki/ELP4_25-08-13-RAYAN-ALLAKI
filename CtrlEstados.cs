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
        DaoEstados aDaoEstados;
        CtrlPaises aCtrlPaises;
        public CtrlEstados()
        {
            aColEstados = new ColEstado();
            aDaoEstados = new DaoEstados();
            aCtrlPaises = new CtrlPaises();
        }
        public override string Salvar(object obj)
        {
            //Estados oEstado = (Estados)obj;
            //List<Estados> aux = aColEstados.RetornaLista();
            //if (oEstado.Codigo == 0)
            //{
            //    oEstado.Codigo = aColEstados.Tamanho() + 10;
            //    aColEstados.Incluir(oEstado.Clone());
            //    //oEstado.Codigo = aColEstados.Tamanho() + 10;
            //    return;
            //}
            //else if (oEstado.Codigo != aux[aux.Count - 1].Codigo)
            //{
            //    aColEstados.Incluir(oEstado.Clone());
            //    return;
            //}

            //foreach (Estados e in aux)
            //{
            //    if (e.Codigo == oEstado.Codigo)
            //    {
            //        aColEstados.Atualizar(aColEstados.Buscar(e), oEstado.Clone());
            //        return;
            //    }
            //}
            return aDaoEstados.Salvar(obj);
        }
        public override string Excluir(object obj)
        {
            // Estados oEstado = (Estados)obj;
            // List<Estados> lista = aColEstados.RetornaLista();
            // Estados aux = lista.Find(e => e.Codigo == oEstado.Codigo);
            // if (aux != null)
            //   aColEstados.Excluir(aux);
            return aDaoEstados.Excluir(obj);
        }
        public List<Estados> TodosEstados()
        {
            return aDaoEstados.Listar();
        }
        public override string CarregaObj(object obj)
        {
            return aDaoEstados.CarregaObj(obj);
        }
        public CtrlPaises ACtrlPaises 
        {
            get => aCtrlPaises;
            set => aCtrlPaises = value;
        }
        public override List<Object> Pesquisar(string obj)
        {
            return aDaoEstados.Pesquisar(obj).Cast<object>().ToList();
        }
    }
}
