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
    /// 
    /// </summary>
    internal class EmpresaDAO
    {

        /// <summary>
        /// Obter uma empresa do sistema doors
        /// </summary>
        /// <param name="codigo">codigo da empresa a ser pesquisado</param>
        /// <returns></returns>
        internal Empresa Get(int codigo)
        {
            var query = @"SELECT 
                            TABGREMPR.CODIG_EMPR AS Codigo,
                            TABGREMPR.RAZAO_EMPR AS Descricao,
                            TABGREMPR.NOCGC_EMPR AS CNPJ,
                            TABGREMPR.NOIES_EMPR AS IE
                        FROM
                            TABGREMPR
                        WHERE
                            TABGREMPR.CODIG_EMPR = @Codigo";


            using (var db = ConnectionDAO.GetInstancia().GetFirebirdConnection())
            {
                var result = db.Query<Empresa>(query, new { @Codigo = codigo }).FirstOrDefault();
                return result;
            }

        }

        /// <summary>
        /// Obter a lista de todas as empresas
        /// </summary>
        /// <returns></returns>
        internal IList<Empresa> GetAll()
        {
            var query = @"SELECT 
                            TABGREMPR.CODIG_EMPR AS Codigo,
                            TABGREMPR.RAZAO_EMPR AS Descricao,
                            TABGREMPR.NOCGC_EMPR AS CNPJ,
                            TABGREMPR.NOIES_EMPR AS IE
                        FROM
                            TABGREMPR";

            using (var db = ConnectionDAO.GetInstancia().GetFirebirdConnection())
            {
                var result = db.Query<Empresa>(query).ToList();
                return result;
            }
        }
    }
}
