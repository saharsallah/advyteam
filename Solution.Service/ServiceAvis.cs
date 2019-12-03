using Service.Pattern;
using Solution.Data.Infrastructure;
using Solution.Domain;
using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Service
{
   public class ServiceAvis:Service<avis>, IServiceAvis
    {
        static IDataBaseFactory factory = new DataBaseFactory();
        static IUnitOfWork utk = new UnitOfWork(factory);
        public ServiceAvis() : base(utk)
        {
           
        }

        public IEnumerable<avis> GetAvisById(int id)
        {
            return GetMany(p => p.id == id);
        }

    }
}
