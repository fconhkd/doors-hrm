using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for Colaborador
/// </summary>
[WebService(Namespace = "http://cardexpressbrasil.web2302.uni5.net/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class Colaborador : System.Web.Services.WebService
{

    public Colaborador()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public DoorsExport.Model.Colaborador Obter(int empresa, int codigo)
    {
        using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
        {
            var arquivo = db.GetCollection<DoorsExport.Model.Colaborador>("colaboradores");

            var result = arquivo.FindAll().Where(x => x.EMPRESA == empresa && x.CODIGO == codigo).FirstOrDefault();
            return result;
        }
    }

    [WebMethod]
    public List<DoorsExport.Model.Colaborador> ObterTodos(int empresa)
    {
        using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
        {
            var arquivo = db.GetCollection<DoorsExport.Model.Colaborador>("colaboradores");

            var result = arquivo.FindAll().Where(x => x.EMPRESA == empresa).ToList();
            return result;
        }
    }

    [WebMethod]
    public void Inserir(DoorsExport.Model.Colaborador colaborador)
    {
        using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
        {
            var arquivo = db.GetCollection<DoorsExport.Model.Colaborador>("colaboradores");

            var col = arquivo.FindById(colaborador.Id);
            if (col != null)
            {
                arquivo.Update(colaborador);
            }
            else
            {
                arquivo.Insert(colaborador);
            }

        }
    }

    [WebMethod]
    public int InserirVarios(List<DoorsExport.Model.Colaborador> colaborador)
    {
        using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
        {
            var arquivo = db.GetCollection<DoorsExport.Model.Colaborador>("colaboradores");

            return arquivo.InsertBulk(colaborador);
        }
    }

    [WebMethod]
    public bool Atualizar(DoorsExport.Model.Colaborador colaborador)
    {
        using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
        {
            var arquivo = db.GetCollection<DoorsExport.Model.Colaborador>("colaboradores");

            return arquivo.Update(colaborador);
        }
    }
}
