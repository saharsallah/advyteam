using Service.Pattern;
using Solution.Data.Infrastructure;
using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Service
{
    public class NoteDeFraisService : Service<notefrai>, INoteDeFraisService
    {
        static IDataBaseFactory dbfactor = new DataBaseFactory();
        static IUnitOfWork wow = new UnitOfWork(dbfactor);
        // IDataBaseFactory dbfactory = null;
        public NoteDeFraisService() : base(wow)
        {


        }

      public IEnumerable<notefrai> GetAll()
        {
            return wow.GetRepositoryBase<notefrai>().GetAll();
        }
    }
}
