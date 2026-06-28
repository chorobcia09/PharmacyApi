using Microsoft.AspNetCore.Mvc;
using Pharmacy.Database;

namespace Pharmacy.Controllers;

[ApiController]
[Route("[controller]")]
public class MedicationController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var medications = MedicationData.Medications;
        return Ok(medications);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var medication = MedicationData.Medications.FirstOrDefault(m => m.Id == id);

        if (medication == null)
        {
            return NotFound(new { Message = $"Lek o identyfikatorze {id} nie został znaleziony." });
        }

        return Ok(medication);
    }
}
