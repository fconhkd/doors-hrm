using DoorsExport.Data.DAO;
using DoorsExport.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorsExport.Data.Business
{
    /// <summary>
    /// Centralizar as regras de nagocio de <see cref="Colaborador"/>
    /// </summary>
    public class ColaboradorBusiness : IDisposable
    {
        private ColaboradorDAO dao = new ColaboradorDAO();

        public void Dispose()
        {

        }

        /// <summary>
        /// Obter um cargo pelo seu codigo
        /// </summary>
        /// <param name="codigo">codigo a ser pesquisado</param>
        /// <param name="empresa">codigo da empresa</param>
        /// <returns></returns>
        public Colaborador Get(int empresa, int codigo)
        {
            try
            {
                return dao.Get(empresa, codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obter todos os colaboradores de uma empresa
        /// </summary>
        /// <param name="empresa">codigo da empresa</param>
        /// <returns></returns>
        public IList<Colaborador> Get(int empresa)
        {
            try
            {
                return dao.GetAll(empresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obter uma lista com os colaboradores admitidos em uma data especifica
        /// </summary>
        /// <param name="dataAdmissao">data de admissão a ser pesquisada</param>
        /// <returns></returns>
        public IList<Colaborador> GetAdmitidos(DateTime dataAdmissao)
        {
            try
            {
                return dao.GetByAdmissao(dataAdmissao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obter os colaboradores demitidos em uma data
        /// </summary>
        /// <param name="dataDemissao">data de demissão</param>
        /// <returns></returns>
        public IList<Colaborador> GetDemitidos(DateTime dataDemissao)
        {
            try
            {
                return dao.GetByDemissao(dataDemissao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
