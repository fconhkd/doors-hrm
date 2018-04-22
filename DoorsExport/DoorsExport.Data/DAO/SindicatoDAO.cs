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
    /// Centralizar o acesso a dados de <see cref="Sindicato"/>
    /// </summary>
    internal class SindicatoDAO
    {
        /// <summary>
        /// Obter um registro pelo seu codigo
        /// </summary>
        /// <param name="codigo">codigo a ser pesquisado</param>
        /// <returns></returns>
        internal Sindicato Get(int codigo)
        {
            var query = @"SELECT 
                              TABFPSIND.CODIG_SIND as Codigo,
                              TABFPSIND.DESCR_SIND as Descricao,
                              TABFPSIND.NOCGC_SIND as CNPJ
                              TABFPSIND.NODDD_SIND as Ddd,
                              TABFPSIND.NOTEL_SIND as Telefone,
                              TABFPSIND.TPEND_SIND as TipoEndereco,
                              TABFPSIND.ENDER_SIND as Endereco,
                              TABFPSIND.NUMER_SIND as Numero,
                              TABFPSIND.COMPL_SIND as Complemento,
                              TABFPSIND.BAIRR_SIND as Bairro,
                              TABFPSIND.MUNIC_SIND as Municipio,
                              TABFPSIND.NOCEP_SIND as CEP,
                        FROM
                              TABFPSIND
                        WHERE
                              TABFPSIND.CODIG_SIND = @Codigo";

            using (var db = ConnectionDAO.GetInstancia().GetFirebirdConnection())
            {
                return db.Query<Sindicato>(query, new { @Codigo = codigo }).FirstOrDefault();
            }
        }

        /// <summary>
        /// Obter todos os registros
        /// </summary>
        /// <returns></returns>
        internal IList<Sindicato> GetAll()
        {
            var query = @"SELECT 
                              TABFPSIND.CODIG_SIND as Codigo,
                              TABFPSIND.DESCR_SIND as Descricao,
                              TABFPSIND.NOCGC_SIND as CNPJ
                              TABFPSIND.NODDD_SIND as Ddd,
                              TABFPSIND.NOTEL_SIND as Telefone,
                              TABFPSIND.TPEND_SIND as TipoEndereco,
                              TABFPSIND.ENDER_SIND as Endereco,
                              TABFPSIND.NUMER_SIND as Numero,
                              TABFPSIND.COMPL_SIND as Complemento,
                              TABFPSIND.BAIRR_SIND as Bairro,
                              TABFPSIND.MUNIC_SIND as Municipio,
                              TABFPSIND.NOCEP_SIND as CEP,
                        FROM
                              TABFPSIND";

            using (var db = ConnectionDAO.GetInstancia().GetFirebirdConnection())
            {
                return db.Query<Sindicato>(query).ToList();
            }
        }
    }
}
