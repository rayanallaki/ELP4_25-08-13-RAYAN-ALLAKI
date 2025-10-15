using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFormsPaisEstadoCidade
{
    internal class DaoPaises : DAO
    {
        public override string Salvar(object obj)
        {
            Paises oPais = (Paises)obj;
            string mSql = "", mOk = "";

            if (oPais.Codigo == 0)
            {
                mSql = "insert into paises(Pais, Sigla, DDI, Moeda, datCad, UltAlt) values(@pais, @sigla, @ddi, @moeda, @datcad, @ultalt)";
            }
            else 
            {
                mSql = "update paises set pais = @pais, sigla = @sigla, ddi = @ddi, moeda = @moeda, datcad = @datcad, ultalt = @ultalt where codigo = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            { 
                cmd.Parameters.AddWithValue("@pais", oPais.Pais);
                cmd.Parameters.AddWithValue("@sigla", oPais.Sigla);
                cmd.Parameters.AddWithValue("@ddi", oPais.Ddi);
                cmd.Parameters.AddWithValue("@moeda", oPais.Moeda);
                cmd.Parameters.AddWithValue("@datcad", oPais.DatCad);
                cmd.Parameters.AddWithValue("@ultalt", oPais.ultAlt);
                cmd.Parameters.AddWithValue("@codigo", oPais.Codigo);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "Select @IDENTITY";
                mOk = cmd.ExecuteScalar().ToString();
            }
            return mOk;
        }
        public override string Excluir(object obj)
        {
            return null;    
        }
        public override List<Object> Listar()
        {
            return null;
        }
        public override Object CarregaObj(int chave)
        {
            return null;
        }
        public override List<Object> Pesquisar(string chave)
        {
            return null;
        }
    }
}
