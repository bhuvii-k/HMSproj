using HMS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Application.Dto.PatientDtos
{
    public class PatientResponseDto
    {
        public int Id { get; set; }

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

        public RegistrationSource RegistrationSource { get; set; }

        public bool IsVerified { get; set; }

        public PatientStatus Status { get; set; }

        public DateTime CreatedAt { get; set; }


    }
}
