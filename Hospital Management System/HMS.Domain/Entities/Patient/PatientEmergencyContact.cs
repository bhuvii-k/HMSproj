using HMS.Domain.Enums;

namespace HMS.Domain.Entities.Patient
{
    public class PatientEmergencyContact
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        public string ContactName { get; set; } = null!;

        public EmergencyRelationship Relationship { get; set; }

        public string Phone { get; set; } = null!;
        public string? AlternatePhone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

        public bool IsPrimary { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int? CreatedBy { get; set; }

        public DateTime? ModifiedAt { get; set; }
        public int? ModifiedBy { get; set; }

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; }
    }
}