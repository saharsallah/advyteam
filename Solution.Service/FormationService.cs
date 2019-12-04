using Solution.Data;
using Solution.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using Service.Pattern;
using System.Threading.Tasks;

namespace Solution.Service
{
    public class FormationService : Service<formation>
    {
        public static IDataBaseFactory dbFactory;
        public static IUnitOfWork myUnit;

        public FormationService() : base(myUnit)
        {
            dbFactory = new DataBaseFactory();
            myUnit = new UnitOfWork(dbFactory);
        }

        public employee login(string email , string password)
        {
            return myUnit.GetRepositoryBase<employee>().GetMany(employee => employee.email.Equals(email) && employee.password.Equals(password) ).FirstOrDefault();
        }

    }
}
