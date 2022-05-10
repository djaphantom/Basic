using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    readonly SqlTransaction tt = null;
    readonly SqlConnection cn = null;

    public class Banco
    {
        public Banco()

        {

            t = cn.BeginTransaction(IsolationLevel.Serializable);
            cn = new SqlConnection("");
        }
        public bool ExecutarComando(List<ComandoSQL> cmd)
        {

            foreach (var item in cmd)
            {
                item.Comando.Transaction = t;
                foreach (var p in item.Parametros)
                {
                    item.Comando.Parameters.AddWithValue(p.Parametro, p.Valor);
                }
                item.Comando.ExecuteNonQuery();

            }

            t.Commit();
            return true;
        }
    } 
        
}

