using DoorsExport.Data.DAO;
using DoorsExport.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorsExport.Data.Business
{
    public class EmpresaBusiness
    {
        private EmpresaDAO dao = new EmpresaDAO();

        /// <summary>
        /// Obter uma lista com todas as empresas cadastradas
        /// </summary>
        /// <returns></returns>
        public IList<Empresa> Get()
        {
            return dao.GetAll();
        }

        /// <summary>
        /// Obter a empresa do sistema doors
        /// </summary>
        /// <param name="codigo">codigo da empresa a ser pesquisado</param>
        /// <returns></returns>
        public Empresa Get(int codigo)
        {
            var empresa = dao.Get(codigo);
            return empresa;
        }

        /// <summary>
        /// Obter a lista de empresas já cadastradas localmente
        /// </summary>
        /// <returns></returns>
        public IList<Empresa> GetLocalAll()
        {
            throw new NotImplementedException();
        }
    }
}
