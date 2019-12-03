﻿using Service.Pattern;
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
    public class EvaluationService:Service<evaluation>, IEvaluationService
    {
        static IDataBaseFactory factory = new DataBaseFactory();
        static IUnitOfWork utk = new UnitOfWork(factory);
        public EvaluationService(): base(utk)
        {

        }

    }
}
