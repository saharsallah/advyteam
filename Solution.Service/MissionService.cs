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
   public class MissionService : Service<mission>,IMissionService
    {

        static IDataBaseFactory dbfactor = new DataBaseFactory();
        static IUnitOfWork wow = new UnitOfWork(dbfactor);
        // IDataBaseFactory dbfactory = null;
        public MissionService() : base(wow)
        {


        }
        public IEnumerable<mission> GetAll()
        {
            return wow.GetRepositoryBase<mission>().GetAll();
        }
    }
}
