using HMS.Domain.Enums;

namespace HMS.Domain.Entities.Patient
{
    public class Patient
    {
        public int Id { get; set; }

        // FK -> Authentication/User table
       // public int? UserId { get; set; }

        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;

        public Gender Gender { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public BloodGroup? BloodGroup { get; set; }

        public MaritalStatus? MaritalStatus { get; set; }

        public string Phone { get; set; } = null!;
        public string? AlternatePhone { get; set; }
        public string? Email { get; set; }

        public string? PhotoUrl { get; set; }

        public string? Nationality { get; set; }
        public string? PreferredLanguage { get; set; }
        public string? Occupation { get; set; }

        public string? GovtIdType { get; set; }
        public string? GovtIdNumber { get; set; }

        public RegistrationSource RegistrationSource { get; set; }
            = RegistrationSource.Receptionist;

        public bool IsVerified { get; set; }

        public PatientStatus Status { get; set; }
            = PatientStatus.Active;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int? CreatedBy { get; set; }

        public DateTime? ModifiedAt { get; set; }
        public int? ModifiedBy { get; set; }

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; }
    }
}