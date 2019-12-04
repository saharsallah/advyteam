using Microsoft.Owin;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Owin;
using Solution.Data;
using Solution.Data.Infrastructure;
using System;
using System.Linq;
using System.Net.Http.Headers;

[assembly: OwinStartupAttribute(typeof(Solution.Web.Startup))]
namespace Solution.Web
{
    public partial class Startup
    {
        public IDataBaseFactory dbFactory;
        public static IUnitOfWork myUnit;
        public void Configuration(IAppBuilder app)
        {
            dbFactory = new DataBaseFactory();
            myUnit = new UnitOfWork(dbFactory);
            bool condition = myUnit.GetRepositoryBase<employee>().GetAll().ToList().Count() < 2;
            if (condition)
            { 
            employee e1 = new employee();
                e1.id = 1;
            e1.sexe = "homme";
                e1.nom = "Nada";
                e1.prenom = "Nada";
                e1.isActif = true;
                e1.datenaissance = DateTime.Now;
                e1.etatcivil = Etatcivil.célibataire;
                e1.Type_emp = "admin";
                e1.sexe = "femme";
                e1.password = "123";
                e1.email = "nada@esprit.tn";
                e1.cin = 965788;
                myUnit.GetRepositoryBase<employee>().Add(e1);
                myUnit.commit();
                employee e = new employee();
                e.id = 2;
                e.sexe = "homme";
                e.nom = "salma";
                e.prenom = "salma";
                e.isActif = true;
                e1.cin = 965788555;
                e.datenaissance = DateTime.Now;
                e.etatcivil = Etatcivil.célibataire;
                e.Type_emp = "employee";
                e.password = "123";
                e.email = "salma@esprit.tn";
                e.sexe = "femme";
                myUnit.GetRepositoryBase<employee>().Add(e);
                myUnit.commit();
            }
            ConfigureAuth(app);
        }
    }

}
