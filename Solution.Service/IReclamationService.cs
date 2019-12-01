﻿using Service.Pattern;
using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Service
{
    public interface IReclamationService : IService<reclamation>
    {
          int Getreclamationnontraite();
          IEnumerable<reclamation> GetMesrec(int idemp);
         IEnumerable<reclamation> Getrec();
    }
}
