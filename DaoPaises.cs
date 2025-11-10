using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoFormsPaisEstadoCidade
{
    internal class DaoPaises : DAO<Paises>
    {
        public override string Salvar(object obj)
        {
            Paises oPais = (Paises)obj;
            string mSql = "", mOk = "";

            if (oPais.Codigo == 0)
            {
                mSql = "insert into paises(Paises, Sigla, DDI, Moeda, datCad, UltAlt) values(@paises, @sigla, @ddi, @moeda, @datcad, @ultalt)";
            }
            else 
            {
                mSql = "update paises set paises = @paises, sigla = @sigla, ddi = @ddi, moeda = @moeda, datcad = @datcad, ultalt = @ultalt where id = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            { 
                cmd.Parameters.AddWithValue("@paises", oPais.Pais);
                cmd.Parameters.AddWithValue("@sigla", oPais.Sigla);
                cmd.Parameters.AddWithValue("@ddi", oPais.Ddi);
                cmd.Parameters.AddWithValue("@moeda", oPais.Moeda);
                cmd.Parameters.AddWithValue("@datcad", oPais.DatCad);
                cmd.Parameters.AddWithValue("@ultalt", oPais.ultAlt);
                cmd.Parameters.AddWithValue("@codigo", oPais.Codigo);
                cmd.ExecuteNonQuery();
                
                cmd.CommandText = "Select @@IDENTITY";
                mOk = cmd.ExecuteScalar().ToString();
            }
            return mOk;
        }
        public override string Excluir(object obj)
        {
            Paises oPais = (Paises)obj;
            string mSql = "", mOk = "";

            mSql = "delete from paises where id = @codigo";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", oPais.Codigo);
                cmd.ExecuteNonQuery();
                mOk = "Registro excluído com sucesso!";
            }

            return mOk;
        }
        public override List<Paises> Listar()
        {
            string mSql = "select * from paises order by id";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            { 
                SqlDataReader reader = cmd.ExecuteReader();
                List<Paises> lista = new List<Paises>();
                while (reader.Read())
                {
                    Paises oPais = new Paises();
                    oPais.Codigo = Convert.ToInt32(reader["id"]);
                    oPais.DatCad = Convert.ToDateTime(reader["datCad"]);
                    oPais.ultAlt = Convert.ToDateTime(reader["ultAlt"]);
                    oPais.Pais = reader["Paises"].ToString();
                    oPais.Sigla = reader["Sigla"].ToString();
                    oPais.Ddi = reader["DDI"].ToString();
                    oPais.Moeda = reader["Moeda"].ToString();
                    lista.Add(oPais);
                }
                reader.Close();
                return lista;
            }
        }
        public override string CarregaObj(object obj)
        {
            Paises oPais = (Paises)obj;
            string mSql = "select * from paises where id = @codigo";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", oPais.Codigo);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {   
                    oPais.Codigo = Convert.ToInt32(reader["id"]);
                    oPais.DatCad = Convert.ToDateTime(reader["datCad"]);
                    oPais.ultAlt = Convert.ToDateTime(reader["ultAlt"]);
                    oPais.Pais = reader["Paises"].ToString();
                    oPais.Sigla = reader["Sigla"].ToString();
                    oPais.Ddi = reader["DDI"].ToString();
                    oPais.Moeda = reader["Moeda"].ToString();
                    //lista.Add(oPais);
                }
                reader.Close();
                return "";
            }
        }
        public override List<Paises> Pesquisar(string obj)
        {
            string mSql = $"select * from paises where paises like '%{obj}%' or id like '%{obj}%' or ddi like '%{obj}%' or sigla like '%{obj}%' or  moeda like '%{obj}%'";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {

                List<Paises> lista = new List<Paises>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Paises pais = new Paises(
                        Convert.ToInt32(reader["id"]),
                        Convert.ToDateTime(reader["datCad"]),
                        Convert.ToDateTime(reader["ultAlt"]),
                        reader["paises"].ToString(),
                        reader["sigla"].ToString(),
                        reader["ddi"].ToString(),
                        reader["moeda"].ToString()
                    );

                    lista.Add(pais);
                }

                reader.Close();
                return lista;
            }
        }
    }
}
