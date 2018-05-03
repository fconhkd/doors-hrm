using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for Empresa
/// </summary>
[WebService(Namespace = "http://cardexpressbrasil.web2302.uni5.net/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class Empresa : System.Web.Services.WebService
{
    public Empresa()
    {
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public DoorsExport.Model.Empresa Obter(int codigo)
    {
        using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
        {
            var arquivo = db.GetCollection<DoorsExport.Model.Empresa>("empresas");

            var result = arquivo.FindAll().Where(x => x.Codigo == codigo).FirstOrDefault();
            return result;
        }
    }

    [WebMethod]
    public List<DoorsExport.Model.Empresa> ObterTodos()
    {
        using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
        {
            var arquivo = db.GetCollection<DoorsExport.Model.Empresa>("empresas");

            var result = arquivo.FindAll().ToList();
            return result;
        }
    }

    [WebMethod]
    public void Inserir(DoorsExport.Model.Empresa empresa)
    {
        using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
        {
            var arquivo = db.GetCollection<DoorsExport.Model.Empresa>("empresas");
            var obj = arquivo.FindById(empresa.Codigo);

            if (obj != null)
            {
                arquivo.Update(empresa);
            }
            else
            {
                arquivo.Insert(empresa);
            }

        }
    }

    [WebMethod]
    public int InserirVarios(List<DoorsExport.Model.Empresa> colaborador)
    {
        using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
        {
            var arquivo = db.GetCollection<DoorsExport.Model.Empresa>("empresas");

            return arquivo.InsertBulk(colaborador);
        }
    }

    [WebMethod]
    public bool Atualizar(DoorsExport.Model.Empresa empresa)
    {
        using (var db = ConnectionDAO.GetInstancia().GetLiteConnection())
        {
            var arquivo = db.GetCollection<DoorsExport.Model.Empresa>("empresas");

            return arquivo.Update(empresa);
        }
    }

}
