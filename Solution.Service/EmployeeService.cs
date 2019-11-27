using Service.Pattern;
using Solution.Data;
using Solution.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Service
{
    public class EmployeeService : Service<employee>, IEmployeeService
    {
        private static DataBaseFactory dbf = new DataBaseFactory();
        private static UnitOfWork unt = new UnitOfWork(dbf);

        public EmployeeService() : base(unt)
        {
        }


    }
}
