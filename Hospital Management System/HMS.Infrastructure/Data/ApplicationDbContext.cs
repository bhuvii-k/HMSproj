using HMS.Domain.Entities.Patient;
using HMS.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace HMS.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<PatientAddress> PatientAddresses => Set<PatientAddress>();
        public DbSet<PatientAllergy> PatientAllergies => Set<PatientAllergy>();
        public DbSet<PatientDocument> PatientDocuments => Set<PatientDocument>();
        public DbSet<PatientEmergencyContact> PatientEmergencyContacts => Set<PatientEmergencyContact>();
        public DbSet<PatientMedicalHistory> PatientMedicalHistories => Set<PatientMedicalHistory>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // =========================================================
            // PATIENT
            // =========================================================

            modelBuilder.Entity<Patient>(b =>
            {
                b.ToTable("Patient");

                b.HasKey(x => x.Id);

                b.Property(x => x.FirstName)
                    .HasMaxLength(100)
                    .IsRequired();

                b.Property(x => x.MiddleName)
                    .HasMaxLength(100);

                b.Property(x => x.LastName)
                    .HasMaxLength(100)
                    .IsRequired();

                b.Property(x => x.Gender)
                    .HasConversion<string>()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property(x => x.BloodGroup)
                    .HasConversion<string>()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property(x => x.MaritalStatus)
                    .HasConversion<string>()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property(x => x.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsRequired();

                b.Property(x => x.AlternatePhone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                b.Property(x => x.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                b.Property(x => x.PhotoUrl)
                    .HasMaxLength(500);

                b.Property(x => x.Nationality)
                    .HasMaxLength(100);

                b.Property(x => x.PreferredLanguage)
                    .HasMaxLength(50);

                b.Property(x => x.Occupation)
                    .HasMaxLength(100);

                b.Property(x => x.GovtIdType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                b.Property(x => x.GovtIdNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                b.Property(x => x.RegistrationSource)
                    .HasConversion<string>()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                b.Property(x => x.Status)
                    .HasConversion<string>()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.HasIndex(x => x.Phone);

                b.HasIndex(x => x.Email);

                //b.HasIndex(x => x.UserId)
                //    .IsUnique()
                //    .HasFilter("[UserId] IS NOT NULL");

                b.HasQueryFilter(x => !x.IsDeleted);
            });


            // =========================================================
            // PATIENT ADDRESS
            // =========================================================

            modelBuilder.Entity<PatientAddress>(b =>
            {
                b.ToTable("PatientAddress");

                b.HasKey(x => x.Id);

                b.Property(x => x.AddressType)
                    .HasConversion<string>()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property(x => x.AddressLine1)
                    .HasMaxLength(250)
                    .IsRequired();

                b.Property(x => x.AddressLine2)
                    .HasMaxLength(250);

                b.Property(x => x.City)
                    .HasMaxLength(100)
                    .IsRequired();

                b.Property(x => x.State)
                    .HasMaxLength(100)
                    .IsRequired();

                b.Property(x => x.Country)
                    .HasMaxLength(100)
                    .IsRequired();

                b.Property(x => x.PinCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                b.HasOne<Patient>()
                    .WithMany()
                    .HasForeignKey(x => x.PatientId)
                    .OnDelete(DeleteBehavior.Restrict);

                b.HasIndex(x => x.PatientId)
                    .IsUnique()
                    .HasFilter("[IsPrimary] = 1 AND [IsDeleted] = 0")
                    .HasDatabaseName("UQ_PatientAddress_OnePrimary");

                b.HasQueryFilter(x => !x.IsDeleted);
            });


            // =========================================================
            // PATIENT EMERGENCY CONTACT
            // =========================================================

            modelBuilder.Entity<PatientEmergencyContact>(b =>
            {
                b.ToTable("PatientEmergencyContact");

                b.HasKey(x => x.Id);

                b.Property(x => x.ContactName)
                    .HasMaxLength(150)
                    .IsRequired();

                b.Property(x => x.Relationship)
                    .HasConversion<string>()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                b.Property(x => x.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsRequired();

                b.Property(x => x.AlternatePhone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                b.Property(x => x.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                b.Property(x => x.Address)
                    .HasMaxLength(500);

                b.HasOne<Patient>()
                    .WithMany()
                    .HasForeignKey(x => x.PatientId)
                    .OnDelete(DeleteBehavior.Restrict);

                b.HasIndex(x => x.PatientId)
                    .IsUnique()
                    .HasFilter("[IsPrimary] = 1 AND [IsDeleted] = 0")
                    .HasDatabaseName("UQ_PatientEmergencyContact_OnePrimary");

                b.HasQueryFilter(x => !x.IsDeleted);
            });


            // =========================================================
            // PATIENT MEDICAL HISTORY
            // =========================================================

            modelBuilder.Entity<PatientMedicalHistory>(b =>
            {
                b.ToTable("PatientMedicalHistory");

                b.HasKey(x => x.Id);

                b.Property(x => x.Category)
                    .HasConversion<string>()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                b.Property(x => x.Title)
                    .HasMaxLength(200)
                    .IsRequired();

                b.Property(x => x.Description)
                    .HasMaxLength(1000);

                b.Property(x => x.RelatedPerson)
                    .HasMaxLength(100);

                b.Property(x => x.HistoryStatus)
                    .HasConversion<string>()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property(x => x.TreatedAtFacility)
                    .HasMaxLength(200);

                b.HasOne<Patient>()
                    .WithMany()
                    .HasForeignKey(x => x.PatientId)
                    .OnDelete(DeleteBehavior.Restrict);

                b.HasIndex(x => new
                {
                    x.PatientId,
                    x.Category
                });

                b.HasQueryFilter(x => !x.IsDeleted);
            });


            // =========================================================
            // PATIENT ALLERGY
            // =========================================================

            modelBuilder.Entity<PatientAllergy>(b =>
            {
                b.ToTable("PatientAllergy");

                b.HasKey(x => x.Id);

                b.Property(x => x.AllergyType)
                    .HasConversion<string>()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property(x => x.Allergen)
                    .HasMaxLength(200)
                    .IsRequired();

                b.Property(x => x.ReactionDescription)
                    .HasMaxLength(500);

                b.Property(x => x.Severity)
                    .HasConversion<string>()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.Property(x => x.AllergyStatus)
                    .HasConversion<string>()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                b.HasOne<Patient>()
                    .WithMany()
                    .HasForeignKey(x => x.PatientId)
                    .OnDelete(DeleteBehavior.Restrict);

                b.HasIndex(x => new
                {
                    x.PatientId,
                    x.AllergyStatus,
                    x.Severity
                });

                b.HasQueryFilter(x => !x.IsDeleted);
            });


            // =========================================================
            // PATIENT DOCUMENT
            // =========================================================

            modelBuilder.Entity<PatientDocument>(b =>
            {
                b.ToTable("PatientDocument");

                b.HasKey(x => x.Id);

                b.Property(x => x.DocumentType)
                    .HasConversion<string>()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                b.Property(x => x.DocumentTitle)
                    .HasMaxLength(200)
                    .IsRequired();

                b.Property(x => x.FileUrl)
                    .HasMaxLength(500)
                    .IsRequired();

                b.Property(x => x.FileName)
                    .HasMaxLength(255)
                    .IsRequired();

                b.Property(x => x.MimeType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                b.HasOne<Patient>()
                    .WithMany()
                    .HasForeignKey(x => x.PatientId)
                    .OnDelete(DeleteBehavior.Restrict);

                b.HasIndex(x => new
                {
                    x.PatientId,
                    x.DocumentType
                });

                b.HasQueryFilter(x => !x.IsDeleted);
            });
        }
    }
}