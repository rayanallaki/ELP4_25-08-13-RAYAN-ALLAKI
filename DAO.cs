using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFormsPaisEstadoCidade
{
    internal class DAO<T>
    {
        protected SqlConnection cnn;

        public DAO()
        {
            cnn = Banco.Abrir();
        }
        public virtual string Salvar(object obj)
        {
            return null;
        }
        public virtual string Excluir(object obj)
        {
            return null;
        }
        public virtual List<T> Listar()
        {
            return null;
        }
        public virtual string CarregaObj(object obj)
        {
            return null;
        }
        public virtual List<T> Pesquisar(string obj)
        {
            return null;
        }
    }
}
