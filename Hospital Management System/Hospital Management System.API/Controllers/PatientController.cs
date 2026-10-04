using HMS.Application.Interface.IServices;
using Microsoft.AspNetCore.Mvc;

namespace HMS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        #region 
        // GET: api/Patient
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var patients = await _patientService.GetAllPatientService();

            return Ok(patients);
        }

        // GET: api/Patient/1
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var patient = await _patientService.GetPatientByIdService(id);

            if (patient == null)
            {
                return NotFound(new
                {
                    message = $"Patient with ID {id} not found."
                });
            }

            return Ok(patient);
        }

        #endregion
    }
}