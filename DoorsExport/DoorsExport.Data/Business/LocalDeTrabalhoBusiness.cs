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
    /// Centralizar as regras de nagocio de <see cref="LocalDeTrabalho"/>
    /// </summary>
    public class LocalDeTrabalhoBusiness : IDisposable
    {
        private LocalDeTrabalhoDAO dao = new LocalDeTrabalhoDAO();

        public void Dispose()
        {

        }

        /// <summary>
        /// Obter um registro pelo seu codigo
        /// </summary>
        /// <param name="codigo">codigo a ser pesquisado</param>
        /// <param name="empresa">codigo da empresa vinculada</param>
        /// <returns></returns>
        public LocalDeTrabalho Get(int codigo, int empresa)
        {
            return dao.Get(codigo, empresa);
        }

        /// <summary>
        /// Obter os locais de uma empresa
        /// </summary>
        /// <param name="empresa">codigo a ser pesquisado</param>
        /// <returns></returns>
        public IList<LocalDeTrabalho> Get(int empresa)
        {
            return dao.GetAll(empresa);
        }
    }
}
