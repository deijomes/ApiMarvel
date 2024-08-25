using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppMarvel.Servicios;

namespace WebAppMarvel.Controllers
{
    [Route("api/marvel")]
    [ApiController]
    public class PersonajesController : ControllerBase
    {
        private readonly IPersonajeSerie personajeSerie;

        public PersonajesController(IPersonajeSerie personajeSerie)
        {
            this.personajeSerie = personajeSerie;
        }

        [HttpGet("characterId")]
        public async Task<IActionResult> get(int id)
        {
            var personaje = await personajeSerie.GetPersonajeIdAsync(id);
            return Ok(personaje);
        }

    }
}
