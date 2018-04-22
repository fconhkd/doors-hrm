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
    /// Centralizar as regras de nagocio de <see cref="Cargo"/>
    /// </summary>
    public class CargoBusiness : IDisposable
    {
        private CargoDAO dao = new CargoDAO();

        public void Dispose()
        {

        }

        /// <summary>
        /// Obter um registro pelo seu codigo
        /// </summary>
        /// <param name="codigo">codigo a ser pesquisado</param>
        /// <returns></returns>
        public Cargo Get(int codigo)
        {
            return dao.Get(codigo);
        }

        /// <summary>
        /// Obter todos os registros
        /// </summary>
        /// <returns></returns>
        public IList<Cargo> Get()
        {
            return dao.GetAll();
        }
    }
}
