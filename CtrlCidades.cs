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
        DaoCidades aDaoCidades;
        CtrlEstados aCtrlEstados;

        public CtrlCidades()
        {
            aColCidades = new ColCidades();
            aDaoCidades = new DaoCidades();
        }
        public override string Salvar(object obj)
        {
            //Cidades aCidade = (Cidades)obj;
            //List<Cidades> aux = aColCidades.RetornaLista();
            //if (aCidade.Codigo == 0)
            //{
            //    aCidade.Codigo = aColCidades.Tamanho() + 10;
            //    aColCidades.Incluir(aCidade.Clone());
            //    //oEstado.Codigo = aColEstados.Tamanho() + 10;
            //    return;
            //}
            //else if (aCidade.Codigo != aux[aux.Count - 1].Codigo)
            //{
            //    aColCidades.Incluir(aCidade.Clone());
            //    return;
            //}

            //foreach (Cidades c in aux)
            //{
            //    if (c.Codigo == aCidade.Codigo)
            //    {
            //        aColCidades.Atualizar(aColCidades.Buscar(c), aCidade.Clone());
            //        return;
            //    }
            //}
            return aDaoCidades.Salvar(obj);
        }
        public override string Excluir(object obj)
        {
            //Cidades aCidade = (Cidades)obj;
            //List<Cidades> lista = aColCidades.RetornaLista();
            //Cidades aux = lista.Find(c => c.Codigo == aCidade.Codigo);
            //if (aux != null)
            //  aColCidades.Excluir(aux);
            return aDaoCidades.Excluir(obj);    
        }
        public List<Cidades> TodasCidades()
        {
            return aDaoCidades.Listar();
        }
        public CtrlEstados ACtrlEstados
        {
            get => aCtrlEstados;
            set => aCtrlEstados = value;
        }
        public override string CarregaObj(object obj)
        {
            return aDaoCidades.CarregaObj(obj);
        }
        public override List<Object> Pesquisar(string obj)
        {
            return aDaoCidades.Pesquisar(obj).Cast<object>().ToList();
        }
    }
}
