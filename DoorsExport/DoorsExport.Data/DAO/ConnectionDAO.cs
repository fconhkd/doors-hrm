using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using LiteDB;

namespace DoorsExport
{
    /// <summary>
	/// Usa padrão Singleton para obter uma instancia do FireBird
	/// </summary>
    public class ConnectionDAO
    {
        private static readonly ConnectionDAO instancia = new ConnectionDAO();

        private ConnectionDAO() { }

        public static ConnectionDAO GetInstancia()
        {
            return instancia;
        }

        public IDbConnection GetFirebirdConnection()
        {
            string conn = ConfigurationManager.ConnectionStrings["Firebird"].ToString();
            return new FbConnection(conn);
        }

        public LiteDatabase GetLiteConnection()
        {
            string conn = ConfigurationManager.ConnectionStrings["LiteDB"].ToString();
            return new LiteDatabase(conn);
        }

    }
}
