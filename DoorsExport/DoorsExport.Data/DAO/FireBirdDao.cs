using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;

namespace DoorsExport
{
    /// <summary>
	/// Usa padrão Singleton para obter uma instancia do FireBird
	/// </summary>
    public class FirebirdDAO
    {
        private static readonly FirebirdDAO instanciaFireBird = new FirebirdDAO();

        private FirebirdDAO() { }

        public static FirebirdDAO getInstancia()
        {
            return instanciaFireBird;
        }

        public FbConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["connectionStringFirebird"].ToString();
            return new FbConnection(conn);
        }
    }
}
