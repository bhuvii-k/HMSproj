using HMS.Domain.Enums;

namespace HMS.Domain.Entities.Patient
{
    public class PatientDocument
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        public DocumentType DocumentType { get; set; }

        public string DocumentTitle { get; set; } = null!;

        // Blob storage URL
        public string FileUrl { get; set; } = null!;

        public string FileName { get; set; } = null!;

        public int? FileSizeKB { get; set; }

        public string? MimeType { get; set; }

        // Users.Id
        public int? UploadedByUserId { get; set; }

        public bool UploadedBySelf { get; set; }

        public bool IsVerified { get; set; }

        // Users.Id
        public int? VerifiedByUserId { get; set; }

        public DateTime? VerifiedAt { get; set; }

        public DateOnly? ExpiryDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int? CreatedBy { get; set; }

        public DateTime? ModifiedAt { get; set; }
        public int? ModifiedBy { get; set; }

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; }
    }
}