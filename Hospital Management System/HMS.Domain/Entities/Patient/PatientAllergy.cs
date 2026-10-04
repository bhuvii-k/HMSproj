using HMS.Domain.Enums;

namespace HMS.Domain.Entities.Patient
{
    public class PatientAllergy
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        public AllergyType AllergyType { get; set; }

        public string Allergen { get; set; } = null!;

        public string? ReactionDescription { get; set; }

        public AllergySeverity Severity { get; set; }

        public DateOnly? OnsetDate { get; set; }

        public AllergyStatus AllergyStatus { get; set; }
            = AllergyStatus.Active;

        public int? RecordedByDoctorId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int? CreatedBy { get; set; }

        public DateTime? ModifiedAt { get; set; }
        public int? ModifiedBy { get; set; }

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; }
    }
}