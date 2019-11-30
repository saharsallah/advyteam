﻿using Service.Pattern;
using Solution.Data.Infrastructure;
using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Service
{
   public class ReclamationService : Service<reclamation>, IReclamationService
    {
        private static DataBaseFactory dbf = new DataBaseFactory();
        private static UnitOfWork unt = new UnitOfWork(dbf);

        public ReclamationService() : base(unt)
        {
        }


    }
}

    
    