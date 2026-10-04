using HMS.Application.Interface.IRepo;
using HMS.Domain.Entities.Patient;
using HMS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Infrastructure.Repositories
{
    public class PatientRepository : IPatientRepository
    {

        private readonly ApplicationDbContext _context;
        public PatientRepository(ApplicationDbContext context) {

            _context = context;
        }
        public async Task<List<Patient>> GetAllAsync()
        {
            var patients= await _context.Patients.AsNoTracking().ToListAsync();
            return patients;
        }

        public async Task<Patient?> GetByIdAsync(int id)
        {
            var patients = await _context.Patients.AsNoTracking().FirstOrDefaultAsync(x=>x.Id==id);
            return patients;
        }
    }
}
