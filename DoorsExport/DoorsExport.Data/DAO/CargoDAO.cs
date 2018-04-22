using Dapper;
using DoorsExport.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorsExport.Data.DAO
{
    /// <summary>
    /// Centralizar o acesso a dados de <see cref="Cargo"/>
    /// </summary>
    internal class CargoDAO
    {
        /// <summary>
        /// Obter um registro pelo seu codigo
        /// </summary>
        /// <param name="codigo">codigo a ser pesquisado</param>
        /// <returns></returns>
        internal Cargo Get(int codigo)
        {
            var query = @"SELECT 
                              TABFPCARG.CODIG_CARG as Codigo,
                              TABFPCARG.DESCR_CARG as Descricao,
                              TABFPCARG.NOCBO_CARG as CBO
                        FROM
                              TABFPCARG
                        WHERE
                              TABFPCARG.CODIG_CARG = @Codigo";

            using (var db = ConnectionDAO.GetInstancia().GetFirebirdConnection())
            {
                return db.Query<Cargo>(query, new { @Codigo = codigo }).FirstOrDefault();
            }
        }

        /// <summary>
        /// Obter todos os registros
        /// </summary>
        /// <returns></returns>
        internal IList<Cargo> GetAll()
        {
            var query = @"SELECT 
                              TABFPCARG.CODIG_CARG as Codigo,
                              TABFPCARG.DESCR_CARG as Descricao,
                              TABFPCARG.NOCBO_CARG as CBO
                        FROM
                              TABFPCARG";

            using (var db = ConnectionDAO.GetInstancia().GetFirebirdConnection())
            {
                return db.Query<Cargo>(query).ToList();
            }
        }
    }
}
