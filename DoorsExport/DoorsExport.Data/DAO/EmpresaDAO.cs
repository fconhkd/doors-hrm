using Dapper;
using DoorsExport.Model;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorsExport.Data.DAO
{
    /// <summary>
    /// Centralizar o acesso a dados de <see cref="Empresa"/>
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

        #region Local
        /// <summary>
        /// Obter uma empresa armazenda locamente pelo seu codigo
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        internal Empresa GetLocal(int codigo)
        {
            using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
            {
                var arquivo = db.GetCollection<Empresa>("empresas");

                var result = arquivo.FindById(codigo);
                return result;
            }
        }

        /// <summary>
        /// Obter todas as empresas cadastradas localmente
        /// </summary>
        /// <returns></returns>
        internal IList<Empresa> GetLocalAll()
        {
            using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
            {
                var arquivo = db.GetCollection<Empresa>("empresas");

                var result = arquivo.FindAll().ToList();
                return result;
            }
        }

        /// <summary>
        /// Inserindo no banco local uma empresa
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        internal BsonValue InsertLocal(Empresa e)
        {
            using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
            {
                var arquivo = db.GetCollection<Empresa>("empresas");

                return arquivo.Insert(e);
            }
        }

        /// <summary>
        /// Atualiza um registro local
        /// </summary>
        /// <param name="e"></param>
        internal void UpdateLocal(Empresa e)
        {
            using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
            {
                var arquivo = db.GetCollection<Empresa>("empresas");

                arquivo.Update(e);
            }
        }

        /// <summary>
        /// Excluir um registro local
        /// </summary>
        /// <param name="codigo"></param>
        internal void DeleteLocal(int codigo)
        {
            using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
            {
                var arquivo = db.GetCollection<Empresa>("empresas");

                arquivo.Delete(codigo);
            }
        }
        #endregion
    }
}
