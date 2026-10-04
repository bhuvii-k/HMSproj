using HMS.Domain.Enums;

namespace HMS.Domain.Entities.Patient
{
    public class PatientAddress
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        public AddressType AddressType { get; set; }
            = AddressType.Current;

        public string AddressLine1 { get; set; } = null!;
        public string? AddressLine2 { get; set; }

        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string? PinCode { get; set; }

        public bool IsPrimary { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int? CreatedBy { get; set; }

        public DateTime? ModifiedAt { get; set; }
        public int? ModifiedBy { get; set; }

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; }
    }
}