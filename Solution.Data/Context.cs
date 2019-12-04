namespace Solution.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<categorie> categorie { get; set; }
        public virtual DbSet<commentaire> commentaire { get; set; }
        public virtual DbSet<commentairepub> commentairepub { get; set; }
        public virtual DbSet<competence> competence { get; set; }
        public virtual DbSet<contrat> contrat { get; set; }
        public virtual DbSet<cour> cour { get; set; }
        public virtual DbSet<coursformateur> coursformateur { get; set; }
        public virtual DbSet<demandemission> demandemission { get; set; }
        public virtual DbSet<empcomp> empcomp { get; set; }
        public virtual DbSet<employee> employee { get; set; }
        public virtual DbSet<evaluation> evaluation { get; set; }
        public virtual DbSet<evaluationfile> evaluationfile { get; set; }
        public virtual DbSet<examan> examen { get; set; }
        public virtual DbSet<formation> formation { get; set; }
        public virtual DbSet<mission> mission { get; set; }
        public virtual DbSet<objectif> objectif { get; set; }
        public virtual DbSet<participant> participant { get; set; }
        public virtual DbSet<projet> projet { get; set; }
        public virtual DbSet<publication> publication { get; set; }
        public virtual DbSet<question> question { get; set; }
        public virtual DbSet<quiz> quiz { get; set; }
        public virtual DbSet<reponse> reponse { get; set; }
        public virtual DbSet<tache> tache { get; set; }
        public virtual DbSet<timesheet> timesheet { get; set; }
        public virtual DbSet<typeformation> typeformation { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
      
            base.OnModelCreating(modelBuilder);

        }
    }
}
