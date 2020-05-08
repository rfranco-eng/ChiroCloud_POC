using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace ChiroCloud_POC.Models
{
    public partial class chirocloudContext : DbContext
    {
        public chirocloudContext()
        {
        }

        public chirocloudContext(DbContextOptions<chirocloudContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Patient> Patient { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Using dependency injection in Startup to handle conn string
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("patient");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CommLanguage)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DoctorName)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DriversLicense)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DriversLicenseState)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.EmployerId).HasColumnType("int(11)");

                entity.Property(e => e.Ethnicity)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Gender)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.MaritalStatus)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NameFirst)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NameLast)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NameMiddle)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NamePreferred)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NamePrefix)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NameSuffix)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PreferredComm)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PreferredPronouns)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Race)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Sex)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.SexualOrientation)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.SocialSecurityNo)
                    .HasColumnType("varchar(9)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
