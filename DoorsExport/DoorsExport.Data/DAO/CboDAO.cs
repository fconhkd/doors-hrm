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
    /// Centralizar o acesso a dados de <see cref="CBO"/>
    /// </summary>
    internal class CboDAO
    {
        /// <summary>
        /// Obter um registro pelo seu codigo
        /// </summary>
        /// <param name="codigo">codigo a ser pesquisado</param>
        /// <returns></returns>
        internal CBO Get(int codigo)
        {
            var query = @"SELECT 
                              TABFPCBO.CODIG_CBO as Codigo,
                              TABFPCBO.DESCR_CBO as Descricao,
                        FROM
                              TABFPCBO
                        WHERE
                              TABFPCBO.CODIG_CARG = @Codigo";

            using (var db = ConnectionDAO.GetInstancia().GetFirebirdConnection())
            {
                return db.Query<CBO>(query, new { @Codigo = codigo }).FirstOrDefault();
            }
        }

        /// <summary>
        /// Obter todos os registros
        /// </summary>
        /// <returns></returns>
        internal IList<CBO> GetAll()
        {
            var query = @"SELECT 
                              TABFPCBO.CODIG_CBO as Codigo,
                              TABFPCBO.DESCR_CBO as Descricao,
                        FROM
                              TABFPCBO";

            using (var db = ConnectionDAO.GetInstancia().GetFirebirdConnection())
            {
                return db.Query<CBO>(query).ToList();
            }
        }
    }
}
