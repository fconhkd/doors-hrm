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
        /// <returns></returns>
        public Colaborador Get(int codigo)
        {
            return null;
        }
    }
}
