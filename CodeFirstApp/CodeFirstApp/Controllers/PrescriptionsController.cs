using Microsoft.AspNetCore.Mvc;
using CodeFirstApp.Models;
using CodeFirstApp.Services;

namespace CodeFirstApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrescriptionsController : ControllerBase
    {
        private readonly PrescriptionService _service;

        public PrescriptionsController(PrescriptionService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PatientResponse>> GetPatientData(int id)
        {
            return await _service.GetPatientData(id);
        }

        [HttpPost]
        public async Task<ActionResult> AddPrescription(PrescriptionRequest request)
        {
            await _service.AddPrescription(request);
            return Ok();
        }
    }
}
