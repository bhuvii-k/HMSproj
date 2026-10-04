using HMS.Domain.Enums;

namespace HMS.Domain.Entities.Patient
{
    public class PatientMedicalHistory
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        public MedicalHistoryCategory Category { get; set; }

        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public string? RelatedPerson { get; set; }

        public DateOnly? EventDate { get; set; }

        public HistoryStatus? HistoryStatus { get; set; }

        public string? TreatedAtFacility { get; set; }

        public int? RecordedByDoctorId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int? CreatedBy { get; set; }

        public DateTime? ModifiedAt { get; set; }
        public int? ModifiedBy { get; set; }

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; }
    }
}