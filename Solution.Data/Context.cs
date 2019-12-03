namespace Solution.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Solution.Domain.Entities;
    using Solution.Data.Configurations;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<attestationtest> attestationtests { get; set; }
        public virtual DbSet<autotest> autotests { get; set; }
        public virtual DbSet<categorie> categories { get; set; }
        public virtual DbSet<commentaire> commentaires { get; set; }
        public virtual DbSet<commentairepub> commentairepubs { get; set; }
        public virtual DbSet<competence> competences { get; set; }
        public virtual DbSet<contrat> contrats { get; set; }
        public virtual DbSet<cour> cours { get; set; }
        public virtual DbSet<coursformateur> coursformateurs { get; set; }
        public virtual DbSet<demandemission> demandemissions { get; set; }
        public virtual DbSet<empcomp> empcomps { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<evaluation> evaluations { get; set; }
        public virtual DbSet<evaluationfile> evaluationfiles { get; set; }
        public virtual DbSet<examan> examen { get; set; }
        public virtual DbSet<formation> formations { get; set; }
        public virtual DbSet<mission> missions { get; set; }
        public virtual DbSet<note> notes { get; set; }
        public virtual DbSet<notefrai> notefrais { get; set; }
        public virtual DbSet<objectif> objectifs { get; set; }
        public virtual DbSet<participant> participants { get; set; }
        public virtual DbSet<projet> projets { get; set; }
        public virtual DbSet<publication> publications { get; set; }
        public virtual DbSet<question> questions { get; set; }
        public virtual DbSet<questiontest> questiontests { get; set; }
        public virtual DbSet<quiz> quizs { get; set; }
        public virtual DbSet<reponse> reponses { get; set; }
        public virtual DbSet<tache> taches { get; set; }
        public virtual DbSet<timesheet> timesheets { get; set; }
        public virtual DbSet<typeformation> typeformations { get; set; }
        public virtual DbSet<avis> avis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<attestationtest>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<attestationtest>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<autotest>()
                .Property(e => e.StatusTest)
                .IsUnicode(false);

            modelBuilder.Entity<autotest>()
                .Property(e => e.TestName)
                .IsUnicode(false);

            
           

         
            modelBuilder.Entity<commentaire>()
                .Property(e => e.type_com)
                .IsUnicode(false);

            modelBuilder.Entity<commentaire>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<commentairepub>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<competence>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<competence>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<contrat>()
                .Property(e => e.typeContrat)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.Type_emp)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.adresse)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.etatcivil)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.image)
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
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.sexe)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.e_type)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation>()
                .Property(e => e.objectif)
                .IsUnicode(false);

            modelBuilder.Entity<evaluationfile>()
                .Property(e => e.objec)
                .IsUnicode(false);

            modelBuilder.Entity<evaluationfile>()
                .Property(e => e.result)
                .IsUnicode(false);

            modelBuilder.Entity<examan>()
                .Property(e => e.catExam)
                .IsUnicode(false);

            modelBuilder.Entity<examan>()
                .Property(e => e.formation)
                .IsUnicode(false);

            modelBuilder.Entity<examan>()
                .Property(e => e.nomExamen)
                .IsUnicode(false);

            modelBuilder.Entity<examan>()
                .Property(e => e.participant)
                .IsUnicode(false);

            modelBuilder.Entity<examan>()
                .Property(e => e.typeExam)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.refnamepar)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<mission>()
                .Property(e => e.Mission1)
                .IsUnicode(false);

            modelBuilder.Entity<mission>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<mission>()
                .Property(e => e.libelle)
                .IsUnicode(false);

            modelBuilder.Entity<notefrai>()
                .Property(e => e.libelle)
                .IsUnicode(false);

            modelBuilder.Entity<objectif>()
                .Property(e => e.obj1)
                .IsUnicode(false);

            modelBuilder.Entity<objectif>()
                .Property(e => e.obj2)
                .IsUnicode(false);

            modelBuilder.Entity<objectif>()
                .Property(e => e.obj3)
                .IsUnicode(false);

            modelBuilder.Entity<participant>()
                .Property(e => e.Refname)
                .IsUnicode(false);

            modelBuilder.Entity<participant>()
                .Property(e => e.adresse)
                .IsUnicode(false);

            modelBuilder.Entity<participant>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<participant>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<participant>()
                .Property(e => e.sexe)
                .IsUnicode(false);

            modelBuilder.Entity<participant>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<projet>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<projet>()
                .Property(e => e.titre)
                .IsUnicode(false);

            modelBuilder.Entity<publication>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<questiontest>()
                .Property(e => e.Rep1)
                .IsUnicode(false);

            modelBuilder.Entity<questiontest>()
                .Property(e => e.Rep2)
                .IsUnicode(false);

            modelBuilder.Entity<questiontest>()
                .Property(e => e.Rep3)
                .IsUnicode(false);

            modelBuilder.Entity<questiontest>()
                .Property(e => e.Rep4)
                .IsUnicode(false);

            modelBuilder.Entity<questiontest>()
                .Property(e => e.ReponseCorrect)
                .IsUnicode(false);

            modelBuilder.Entity<questiontest>()
                .Property(e => e.question1)
                .IsUnicode(false);

            modelBuilder.Entity<timesheet>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<timesheet>()
                .Property(e => e.timesheetEtat)
                .IsUnicode(false);

            modelBuilder.Entity<timesheet>()
                .Property(e => e.titre)
                .IsUnicode(false);

            modelBuilder.Entity<typeformation>()
                .Property(e => e.type)
                .IsUnicode(false);
            modelBuilder.Configurations.Add(new AvisConfiguration());
        }
    }
}
