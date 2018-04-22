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
    /// Centralizar as regras de nagocio de <see cref="Sindicato"/>
    /// </summary>
    public class SindicatoBusiness : IDisposable
    {
        private SindicatoDAO dao = new SindicatoDAO();

        public void Dispose()
        {

        }

        /// <summary>
        /// Obter um registro pelo seu codigo
        /// </summary>
        /// <param name="codigo">codigo a ser pesquisado</param>
        /// <returns></returns>
        public Sindicato Get(int codigo)
        {
            return dao.Get(codigo);
        }

        /// <summary>
        /// Obter todos os registros
        /// </summary>
        /// <returns></returns>
        public IList<Sindicato> Get()
        {
            return dao.GetAll();
        }
    }
}
