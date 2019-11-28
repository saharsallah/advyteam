using Service.Pattern;
using Solution.Data;
using Solution.Data.Infrastructure;
using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Service
{
    public class CongeService : Service<conge>, ICongeService
    {

        static IDataBaseFactory factory = new DataBaseFactory();
        static IUnitOfWork utk = new UnitOfWork(factory);

        public CongeService():base(utk)
        {

        }

        public void Add(conge entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(conge entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(System.Linq.Expressions.Expression<Func<conge, bool>> where)
        {
            throw new NotImplementedException();
        }

        public conge Get(System.Linq.Expressions.Expression<Func<conge, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<conge> GetMany(System.Linq.Expressions.Expression<Func<conge, bool>> where = null, System.Linq.Expressions.Expression<Func<conge, bool>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public void Update(conge entity)
        {
            throw new NotImplementedException();
        }

        conge IService<conge>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        conge IService<conge>.GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
