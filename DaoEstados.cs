using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFormsPaisEstadoCidade
{
    internal class DaoEstados : DAO<Estados>
    {
        public override string Salvar(object obj)
        {
            Estados oEstado = (Estados)obj;
            string mSql = "", mOk = "";

            if (oEstado.Codigo == 0)
            {
                mSql = "insert into estados(idPais, Estados, Uf, DatCad, UltAlt) values(@idpais, @estados, @uf, @datcad, @ultalt)";
            }
            else
            {
                mSql = "update estados set idpais = @idpais, estados = @estados, uf = @uf, datcad = @datcad, ultalt = @ultalt where id = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@idpais", oEstado.OPais.Codigo);
                cmd.Parameters.AddWithValue("@estados", oEstado.Estado);
                cmd.Parameters.AddWithValue("@uf", oEstado.UF);
              
                cmd.Parameters.AddWithValue("@datcad", oEstado.DatCad);
                cmd.Parameters.AddWithValue("@ultalt", oEstado.ultAlt);
                cmd.Parameters.AddWithValue("@codigo", oEstado.Codigo);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "Select @@IDENTITY";
                mOk = cmd.ExecuteScalar().ToString();
            }
            return mOk;
        }
        public override string Excluir(object obj)
        {
            Estados oEstado = (Estados)obj;
            string mSql = "", mOk = "";

            mSql = "delete from estados where id = @codigo";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", oEstado.Codigo);
                cmd.ExecuteNonQuery();
                mOk = "Registro excluído com sucesso!";
            }

            return mOk;
        }
        public override List<Estados> Listar()
        {
            string mSql = "select * from estados as e inner join paises as p on p.id = e.idpais order by e.id";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<Estados> lista = new List<Estados>();
                while (reader.Read())
                {
                    
                    //Estados oEstado = new Estados();
                    Paises oPais = new Paises(
                        Convert.ToInt32(reader["idpais"]),
                        Convert.ToDateTime(reader["datCad"]),
                        Convert.ToDateTime(reader["ultAlt"]),
                        reader["paises"].ToString(),
                        reader["sigla"].ToString(),
                        reader["ddi"].ToString(),
                        reader["moeda"].ToString()
                    );
                    Estados oEstado = new Estados(
                        Convert.ToInt32(reader["id"]),
                        Convert.ToDateTime(reader["datCad"]),
                        Convert.ToDateTime(reader["ultAlt"]),
                        reader["estados"].ToString(),
                        reader["uf"].ToString(),
                        oPais
                    );
                    lista.Add(oEstado);
                }
                reader.Close();
                return lista;
            }
        }
        public override string CarregaObj(object obj)
        {
            Estados oEstado = (Estados)obj;
            string mSql = "select * from estados where id = @codigo";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", oEstado.Codigo);
                SqlDataReader reader = cmd.ExecuteReader();
                //Paises oPais = new Paises();
                while (reader.Read())
                {
                    //Paises oPais = new Paises();
                    oEstado.Codigo = Convert.ToInt32(reader["id"]);
                    oEstado.DatCad = Convert.ToDateTime(reader["datCad"]);
                    oEstado.ultAlt = Convert.ToDateTime(reader["ultAlt"]);
                    oEstado.Estado = reader["Estado "].ToString();
                    oEstado.UF = reader["UF"].ToString();
                    oEstado.OPais.Codigo = Convert.ToInt32(reader["idPais"]);
                    oEstado.OPais.Pais = reader["Pais"].ToString();
                    //lista.Add(oPais);
                }
                reader.Close();
                return "";
            }
        }
        public override List<Estados> Pesquisar(string obj)
        {
            string mSql = $@"
        SELECT e.*, 
               p.paises, p.sigla, p.ddi, p.moeda, 
               p.datCad AS datCadPais, 
               p.ultAlt AS ultAltPais
        FROM estados e
        INNER JOIN paises p ON e.idpais = p.id
        WHERE e.estados LIKE '%{obj}%' 
           OR e.uf LIKE '%{obj}%'
           OR e.id LIKE '%{obj}%'
           OR p.paises LIKE '%{obj}%'
        ORDER BY e.id";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                List<Estados> lista = new List<Estados>();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Paises oPais = new Paises(
                        Convert.ToInt32(reader["idpais"]),
                        Convert.ToDateTime(reader["datCadPais"]),
                        Convert.ToDateTime(reader["ultAltPais"]),
                        reader["paises"].ToString(),
                        reader["sigla"].ToString(),
                        reader["ddi"].ToString(),
                        reader["moeda"].ToString()
                    );

                    Estados estado = new Estados(
                        Convert.ToInt32(reader["id"]),
                        Convert.ToDateTime(reader["datCad"]),
                        Convert.ToDateTime(reader["ultAlt"]),
                        reader["estados"].ToString(),
                        reader["uf"].ToString(),
                        oPais
                    );

                    lista.Add(estado);
                }

                reader.Close();
                return lista;
            }
        }
    }
}
