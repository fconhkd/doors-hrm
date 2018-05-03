using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for LocalDeTrabalho
/// </summary>
[WebService(Namespace = "http://cardexpressbrasil.web2302.uni5.net/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class LocalDeTrabalho : System.Web.Services.WebService
{

    public LocalDeTrabalho()
    {
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public DoorsExport.Model.LocalDeTrabalho Obter(int empresa, int codigo)
    {
        using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
        {
            var arquivo = db.GetCollection<DoorsExport.Model.LocalDeTrabalho>("locais_trabalho");

            var result = arquivo.FindAll().Where(x => x.Empresa == empresa && x.Codigo.Equals(codigo)).FirstOrDefault();
            return result;
        }
    }

    [WebMethod]
    public List<DoorsExport.Model.LocalDeTrabalho> ObterTodos(int empresa)
    {
        using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
        {
            var arquivo = db.GetCollection<DoorsExport.Model.LocalDeTrabalho>("locais_trabalho");

            var result = arquivo.FindAll().Where(x => x.Empresa == empresa).ToList();
            return result;
        }
    }

    [WebMethod]
    public void Inserir(DoorsExport.Model.LocalDeTrabalho local)
    {
        using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
        {
            var arquivo = db.GetCollection<DoorsExport.Model.LocalDeTrabalho>("locais_trabalho");
            var obj = arquivo.FindById(local.Id);

            if (obj != null)
            {
                arquivo.Update(local);
            }
            else
            {
                arquivo.Insert(local);
            }

        }
    }

    [WebMethod]
    public int InserirVarios(List<DoorsExport.Model.LocalDeTrabalho> colaborador)
    {
        using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
        {
            var arquivo = db.GetCollection<DoorsExport.Model.LocalDeTrabalho>("locais_trabalho");

            return arquivo.InsertBulk(colaborador);
        }
    }

    [WebMethod]
    public bool Atualizar(DoorsExport.Model.LocalDeTrabalho colaborador)
    {
        using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
        {
            var arquivo = db.GetCollection<DoorsExport.Model.LocalDeTrabalho>("locais_trabalho");

            return arquivo.Update(colaborador);
        }
    }


}
