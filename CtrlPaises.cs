using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace projetoFormsPaisEstadoCidade
{
    internal class CtrlPaises : Controller
    {
        DaoPaises aDaoPaises;
        ColPaises aColPaises;
        public CtrlPaises()
        {
            aColPaises = new ColPaises();
            aDaoPaises = new DaoPaises();
        }
        public override string Salvar(object obj)
        {
            //Paises oPais = (Paises)obj;
            //List<Paises> aux = aColPaises.RetornaLista();
            //if (oPais.Codigo == 0)
            //{
            //    oPais.Codigo = aColPaises.Tamanho() + 10;
            //    aColPaises.Incluir(oPais.Clone());
            //    return;
            //}
            //else if (oPais.Codigo != aux[aux.Count - 1].Codigo)
            //{
            //    aColPaises.Incluir(oPais.Clone());
            //    return;
            //}

            //foreach (Paises p in aux)
            //{
            //    if (p.Codigo == oPais.Codigo)
            //    {
            //        aColPaises.Atualizar(aColPaises.Buscar(p), oPais.Clone());
            //        return;
            //    }
            //}
            return aDaoPaises.Salvar(obj);
        }
        public override string Excluir(object obj)
        {
           // Paises oPais = (Paises)obj;
           // List<Paises> lista = aColPaises.RetornaLista();
           // Paises aux = lista.Find(p => p.Codigo == oPais.Codigo);
           // if (aux != null)
            //    aColPaises.Excluir(aux);
            return aDaoPaises.Excluir(obj);
        }
        public List<Paises> TodosPaises()
        {
          return aDaoPaises.Listar();
        }
        public override string CarregaObj(object obj)
        {
            return aDaoPaises.CarregaObj(obj);
        }
        public override List<Object> Pesquisar(string obj)
        {
           return aDaoPaises.Pesquisar(obj).Cast<object>().ToList();
        }
    }
}
