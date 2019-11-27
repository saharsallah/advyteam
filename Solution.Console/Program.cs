using Solution.Data;
using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context();

            Conge conge = new Conge { CongeId = 1, DateDebut = new DateTime(), DateFin = new DateTime(), TypeConge = "maladie", JourRestant = 12 };
            ctx.conges.Add(conge);
            ctx.SaveChanges();
                      
        }
    }
}
