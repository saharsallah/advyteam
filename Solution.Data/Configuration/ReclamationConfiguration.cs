using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Data.Configuration
{
    class ReclamationConfiguration : EntityTypeConfiguration<reclamation>
    {
        public ReclamationConfiguration()
        {
            HasOptional(r => r.employee)
            .WithMany(u => u.Reclamations)
            .HasForeignKey(r => r.EmployeeId)
            .WillCascadeOnDelete(true);
        }
    }
}
