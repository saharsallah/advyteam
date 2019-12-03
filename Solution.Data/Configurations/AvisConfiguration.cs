using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Data.Configurations
{
    public class AvisConfiguration:EntityTypeConfiguration<avis>
    {
        public AvisConfiguration() {

            ToTable("avis");
            HasKey(v => v.id);



            HasRequired(c => c.employe)
                         .WithMany(cat1 => cat1.aviss)
                         .HasForeignKey(c => c.idEmplye)
                         .WillCascadeOnDelete(true);

        }
        
    }
}
