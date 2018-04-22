using DoorsExport.Data.DAO;
using DoorsExport.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorsExport.Data.Business
{
    public class EmpresaBusiness : IDisposable
    {
        private EmpresaDAO dao = new EmpresaDAO();

        public void Dispose()
        {

        }

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
        public IList<Empresa> GetLocal()
        {
            return dao.GetLocalAll();
        }

        private Empresa GetLocal(int codigo)
        {
            return dao.GetLocal(codigo);
        }

        /// <summary>
        /// Salva o registro  no banco local
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public void Savelocal(int codigo)
        {
            var e = GetLocal(codigo);
            if (e != null)
            {
                e = Get(codigo);
                dao.UpdateLocal(e);
            }
            else
            {
                e = Get(codigo);
                if (e != null) dao.InsertLocal(e);
            }
        }

    }
}
