using HMS.Application.Dto.PatientDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Application.Interface.IServices
{
    public interface IPatientService
    {
        public Task<List<PatientResponseDto>> GetAllPatientService();
        public Task<PatientResponseDto?> GetPatientByIdService(int id);
    }
}
