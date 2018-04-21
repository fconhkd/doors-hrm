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
    public class FireBirdDao
    {
        private static readonly FireBirdDao instanciaFireBird = new FireBirdDao();

        private FireBirdDao() { }

        public static FireBirdDao getInstancia()
        {
            return instanciaFireBird;
        }

        public FbConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
            return new FbConnection(conn);
        }
    }
}
