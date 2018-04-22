using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
        private static readonly FirebirdDAO instancia = new FirebirdDAO();

        private FirebirdDAO() { }

        public static FirebirdDAO GetInstancia()
        {
            return instancia;
        }

        public IDbConnection GetConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["connectionStringFirebird"].ToString();
            return new FbConnection(conn);
        }
    }
}
