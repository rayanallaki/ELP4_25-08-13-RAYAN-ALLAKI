using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFormsPaisEstadoCidade
{
    public class Colecoes<T>
    {
        protected List<T> aLista;

        public Colecoes()
        {
            aLista = new List<T>();
        }

        public virtual void Incluir(T item)
        { 
            aLista.Add(item);
        }
        public virtual bool Excluir(T item)
        { 
            return aLista.Remove(item);
        }
        public virtual int Buscar(T item)
        { 
            return aLista.IndexOf(item);
        }
        public virtual T Acessar(int ind)
        {
            if (ind >= 0 && ind < aLista.Count)
            { 
                return aLista[ind];
            }
            throw new IndexOutOfRangeException("Indice fora do intervalo da lista");
        }
        public virtual void Atualizar(int ind, T item)
        {
            if (ind >= 0 && ind < aLista.Count)
            {
                aLista[ind] = item;
            }
            else
            {
                throw new IndexOutOfRangeException("Indice fora do intervalo da lista");
            }
        }
        public virtual int Tamanho()
        {
            return aLista.Count;
        }
        public virtual void Imprimir()
        {
            foreach (var item in aLista)
                Console.WriteLine(item);
        }
        public virtual void Ordenar()
        {
            aLista.Sort();
        }
    }
}
