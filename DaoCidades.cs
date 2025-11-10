using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFormsPaisEstadoCidade
{
    internal class DaoCidades : DAO<Cidades>
    {
        public override string Salvar(object obj)
        {
            Cidades aCidade = (Cidades)obj;
            string mSql = "", mOk = "";

            if (aCidade.Codigo == 0)
            {
                mSql = "insert into cidades(idEstados, Cidades, DDD, DatCad, UltAlt) values(@idestados, @cidades, @ddd, @datcad, @ultalt)";
            }
            else
            {
                mSql = "update cidades set idestados = @idestados, cidades = @cidades, ddd = @ddd, datcad = @datcad, ultalt = @ultalt where id = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@idestados", aCidade.OEstado.Codigo);
                cmd.Parameters.AddWithValue("@cidades", aCidade.Cidade);
                cmd.Parameters.AddWithValue("@ddd", aCidade.DDD);

                cmd.Parameters.AddWithValue("@datcad", aCidade.DatCad);
                cmd.Parameters.AddWithValue("@ultalt", aCidade.ultAlt);
                cmd.Parameters.AddWithValue("@codigo", aCidade.Codigo);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "Select @@IDENTITY";
                mOk = cmd.ExecuteScalar().ToString();
            }
            return mOk;
        }
        public override string Excluir(object obj)
        {
            Cidades oCidade = (Cidades)obj;
            string mSql = "", mOk = "";

            mSql = "delete from cidades where id = @codigo";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", oCidade.Codigo);
                cmd.ExecuteNonQuery();
                mOk = "Registro excluído com sucesso!";
            }

            return mOk;
        }
        public override List<Cidades> Listar()
        {
            string mSql = @"
        select 
            c.id,
            c.cidades,
            c.ddd,
            c.datcad,
            c.ultalt,
            e.id as idestados,
            e.estados,
            e.uf,
            e.idpais,
            e.datcad as edatcad,
            e.ultalt as eultalt,
            p.id as idpais,
            p.paises,
            p.sigla,
            p.ddi,
            p.moeda,
            p.datcad as pdatcad,
            p.ultalt as pultalt
        from cidades c
        inner join estados e on c.idestados = e.id
        inner join paises p on e.idpais = p.id
        order by c.id";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<Cidades> lista = new List<Cidades>();

                while (reader.Read())
                {
                    Paises oPais = new Paises(
                        Convert.ToInt32(reader["idpais"]),
                        Convert.ToDateTime(reader["pdatcad"]),
                        Convert.ToDateTime(reader["pultalt"]),
                        reader["paises"].ToString(),
                        reader["sigla"].ToString(),
                        reader["ddi"].ToString(),
                        reader["moeda"].ToString()
                    );

                    Estados oEstado = new Estados(
                        Convert.ToInt32(reader["idestados"]),
                        Convert.ToDateTime(reader["edatcad"]),
                        Convert.ToDateTime(reader["eultalt"]),
                        reader["estados"].ToString(),
                        reader["uf"].ToString(),
                        oPais
                    );

                    Cidades aCidade = new Cidades(
                        Convert.ToInt32(reader["id"]),
                        Convert.ToDateTime(reader["datCad"]),
                        Convert.ToDateTime(reader["ultAlt"]),
                        reader["cidades"].ToString(),
                        reader["ddd"].ToString(),
                        oEstado
                    );

                    lista.Add(aCidade);
                }

                reader.Close();
                return lista;
            }
        }
        public override string CarregaObj(object obj)
        {
            Cidades aCidade = (Cidades)obj;
            string mSql = "select * from estados where id = @codigo";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", aCidade.Codigo);
                SqlDataReader reader = cmd.ExecuteReader();
                //Paises oPais = new Paises();
                while (reader.Read())
                {
                    //Paises oPais = new Paises();
                    aCidade.Codigo = Convert.ToInt32(reader["id"]);
                    aCidade.DatCad = Convert.ToDateTime(reader["datCad"]);
                    aCidade.ultAlt = Convert.ToDateTime(reader["ultAlt"]);
                    aCidade.Cidade = reader["Cidade"].ToString();
                    aCidade.DDD = reader["DDD"].ToString();
                    aCidade.OEstado.Codigo = Convert.ToInt32(reader["idEstado"]);
                    aCidade.OEstado.Estado = reader["Estado"].ToString();
                    //lista.Add(oPais);
                }
                reader.Close();
                return "";
            }
        }
        public override List<Cidades> Pesquisar(string obj)
        {
            string mSql = $@"
        SELECT 
            c.id, c.datCad, c.ultAlt, c.cidades, c.ddd, c.idestados,
            e.id AS idestado, e.estados, e.uf, e.idpais, 
            e.datCad AS edatCad, e.ultAlt AS eultAlt,
            p.id AS idpais, p.paises, p.sigla, p.ddi, p.moeda,
            p.datCad AS pdatCad, p.ultAlt AS pultAlt
        FROM cidades c
        INNER JOIN estados e ON c.idestados = e.id
        INNER JOIN paises p ON e.idpais = p.id
        WHERE c.cidades LIKE '%{obj}%'
           OR c.ddd LIKE '%{obj}%'
           OR e.estados LIKE '%{obj}%'
           OR e.uf LIKE '%{obj}%'
           OR p.paises LIKE '%{obj}%'
        ORDER BY c.id";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                List<Cidades> lista = new List<Cidades>();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Paises oPais = new Paises(
                        Convert.ToInt32(reader["idpais"]),
                        Convert.ToDateTime(reader["pdatcad"]),
                        Convert.ToDateTime(reader["pultalt"]),
                        reader["paises"].ToString(),
                        reader["sigla"].ToString(),
                        reader["ddi"].ToString(),
                        reader["moeda"].ToString()
                    );

                    Estados oEstado = new Estados(
                        Convert.ToInt32(reader["idestados"]),
                        Convert.ToDateTime(reader["edatcad"]),
                        Convert.ToDateTime(reader["eultalt"]),
                        reader["estados"].ToString(),
                        reader["uf"].ToString(),
                        oPais
                    );

                    Cidades aCidade = new Cidades(
                        Convert.ToInt32(reader["id"]),
                        Convert.ToDateTime(reader["datCad"]),
                        Convert.ToDateTime(reader["ultAlt"]),
                        reader["cidades"].ToString(),
                        reader["ddd"].ToString(),
                        oEstado
                    );

                    lista.Add(aCidade);
                }

                reader.Close();
                return lista;
            }
        }
    }
}
