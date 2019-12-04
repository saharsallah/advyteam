using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Data.Configurations
{
    class NotefraiConfiguration : EntityTypeConfiguration<notefrai>
    {
        public NotefraiConfiguration()
        {
            ToTable("notefrai");
            HasKey(v => v.id);
            HasOptional(f => f.Mission).
                WithMany(p => p.notes).
                HasForeignKey(f => f.MissionId).
                WillCascadeOnDelete(false);
        }
    }
}