namespace Solution.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<commentaire> commentaires { get; set; }
        public virtual DbSet<contrat> contrats { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<evaluation> evaluations { get; set; }
        public virtual DbSet<projet> projets { get; set; }
        public virtual DbSet<tache> taches { get; set; }
        public virtual DbSet<timesheet> timesheets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<commentaire>()
                .Property(e => e.type_com)
                .IsUnicode(false);

            modelBuilder.Entity<commentaire>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<contrat>()
                .HasMany(e => e.employees)
                .WithOptional(e => e.contrat)
                .HasForeignKey(e => e.contrat_reference);

            modelBuilder.Entity<employee>()
                .Property(e => e.type_emp)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.adresse)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.sexe)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .HasMany(e => e.projets)
                .WithOptional(e => e.employee)
                .HasForeignKey(e => e.createdBy_id);

            modelBuilder.Entity<employee>()
                .HasMany(e => e.timesheets)
                .WithRequired(e => e.employee)
                .HasForeignKey(e => e.idDeveloppeur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<evaluation>()
                .HasMany(e => e.commentaires)
                .WithOptional(e => e.evaluation)
                .HasForeignKey(e => e.evaluation_id);

            modelBuilder.Entity<projet>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<projet>()
                .Property(e => e.titre)
                .IsUnicode(false);

            modelBuilder.Entity<projet>()
                .HasMany(e => e.commentaires)
                .WithOptional(e => e.projet)
                .HasForeignKey(e => e.projet_id);

            modelBuilder.Entity<projet>()
                .HasMany(e => e.timesheets)
                .WithRequired(e => e.projet)
                .HasForeignKey(e => e.idProjet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<timesheet>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<timesheet>()
                .Property(e => e.timesheetEtat)
                .IsUnicode(false);

            modelBuilder.Entity<timesheet>()
                .Property(e => e.titre)
                .IsUnicode(false);

            modelBuilder.Entity<timesheet>()
                .HasMany(e => e.commentaires)
                .WithOptional(e => e.timesheet)
                .HasForeignKey(e => e.timesheet_id);

            modelBuilder.Entity<timesheet>()
                .HasMany(e => e.taches)
                .WithOptional(e => e.timesheet)
                .HasForeignKey(e => e.timesheet_id);
        }
    }
}
