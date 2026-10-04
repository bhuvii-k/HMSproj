using HMS.Application.Dto.PatientDtos;
using HMS.Application.Interface.IRepo;
using HMS.Application.Interface.IServices;
using HMS.Domain.Entities.Patient;

namespace HMS.Application.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepo;

        public PatientService(IPatientRepository patientRepo)
        {
            _patientRepo = patientRepo;
        }

        public async Task<List<PatientResponseDto>> GetAllPatientService()
        {
            var patients = await _patientRepo.GetAllAsync();

            List<PatientResponseDto> patientResponse = new();

            foreach (var patient in patients)
            {
                patientResponse.Add(MapToResponseDto(patient));
            }

            return patientResponse;
        }

        public async Task<PatientResponseDto?> GetPatientByIdService(int id)
        {
            var patient = await _patientRepo.GetByIdAsync(id);

            if (patient == null)
            {
                return null;
            }

            return MapToResponseDto(patient);
        }

        public static PatientResponseDto MapToResponseDto(Patient patient)
        {
            return new PatientResponseDto
            {
                Id = patient.Id,

                FirstName = patient.FirstName,
                MiddleName = patient.MiddleName,
                LastName = patient.LastName,

                Gender = patient.Gender,
                DateOfBirth = patient.DateOfBirth,

                BloodGroup = patient.BloodGroup,
                MaritalStatus = patient.MaritalStatus,

                Phone = patient.Phone,
                AlternatePhone = patient.AlternatePhone,
                Email = patient.Email,

                PhotoUrl = patient.PhotoUrl,

                Nationality = patient.Nationality,
                PreferredLanguage = patient.PreferredLanguage,
                Occupation = patient.Occupation,

                GovtIdType = patient.GovtIdType,

                RegistrationSource = patient.RegistrationSource,

                IsVerified = patient.IsVerified,

                Status = patient.Status,

                CreatedAt = patient.CreatedAt
            };
        }

    }
}