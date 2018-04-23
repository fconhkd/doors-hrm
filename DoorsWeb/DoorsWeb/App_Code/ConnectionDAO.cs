using LiteDB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ConnectionDAO
/// </summary>
public class ConnectionDAO
{
    public ConnectionDAO()
    {
    }
    private static readonly ConnectionDAO instancia = new ConnectionDAO();

    public static ConnectionDAO GetInstancia()
    {
        return instancia;
    }

    public IDbConnection GetMysqlConnection()
    {
        string conn = ConfigurationManager.ConnectionStrings["Firebird"].ToString();
        return null;
    }

    public LiteDatabase GetLiteConnection()
    {
        string conn = ConfigurationManager.ConnectionStrings["LiteDB"].ToString();
        return new LiteDatabase(conn);
    }
}