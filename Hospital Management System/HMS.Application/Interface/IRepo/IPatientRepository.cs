using HMS.Domain.Entities.Patient;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Application.Interface.IRepo
{
    public interface IPatientRepository
    {
        Task<List<Patient>> GetAllAsync();
        Task<Patient?> GetByIdAsync(int id);
    }
}
