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
    /// Centralizar o acesso a dados de e<see cref="LocalDeTrabalho"/>
    /// </summary>
    internal class LocalDeTrabalhoDAO
    {
        /// <summary>
        /// Obter um local de uma empresa
        /// </summary>
        /// <param name="codigo">codigo do local a ser pesquisado</param>
        /// <param name="empresa">codigo da empresa vinculada</param>
        /// <returns></returns>
        internal LocalDeTrabalho Get(int codigo, int empresa)
        {
            var query = @"SELECT 
                            TABFPLOCA.CODIG_LOCA as Codigo,
                            TABFPLOCA.DESCR_LOCA as Descricao,
                            TABFPLOCA.EMPRE_LOCA AS Empresa
                        FROM
                            TABFPLOCA
                        WHERE
                            TABFPLOCA.CODIG_LOCA = @Codigo and
                            TABFPLOCA.EMPRE_LOCA = @Empresa";

            using (var db = ConnectionDAO.GetInstancia().GetFirebirdConnection())
            {
                return db.Query<LocalDeTrabalho>(query, new { @Codigo = codigo, @Empresa = empresa }).FirstOrDefault();
            }
        }

        /// <summary>
        /// Obter todos os locais de uma empresa
        /// </summary>
        /// <param name="empresa">codigo da empresa</param>
        /// <returns></returns>
        internal IList<LocalDeTrabalho> GetAll(int empresa)
        {
            var query = @"SELECT 
                            TABFPLOCA.CODIG_LOCA as Codigo,
                            TABFPLOCA.DESCR_LOCA as Descricao,
                            TABFPLOCA.EMPRE_LOCA AS Empresa
                        FROM
                            TABFPLOCA
                        WHERE
                            TABFPLOCA.EMPRE_LOCA = @Empresa";

            using (var db = ConnectionDAO.GetInstancia().GetFirebirdConnection())
            {
                return db.Query<LocalDeTrabalho>(query, new { @Empresa = empresa }).ToList();
            }
        }
    }
}
