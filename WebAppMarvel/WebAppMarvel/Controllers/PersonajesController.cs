using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAppMarvel.DTOS;
using WebAppMarvel.Entidades;
using WebAppMarvel.Servicios;

namespace WebAppMarvel.Controllers
{
    [Route("api/marvel")]
    [ApiController]
    public class PersonajesController : ControllerBase
    {
        private readonly IPersonajeSerie personajeSerie;
        private readonly IMapper mapper;

        public PersonajesController(IPersonajeSerie personajeSerie, IMapper mapper)
        {
            this.personajeSerie = personajeSerie;
            this.mapper = mapper;
        }

        [HttpGet("characterId")]
        public async Task<IActionResult> get(int id)
        {
            var personaje = await personajeSerie.GetPersonajeIdAsync(id);
            return Ok(personaje);
        }

        [HttpGet("characterName")]
        public async Task<ActionResult<List<PersonajeDTO>>> getpersoje()
        {
            var perosonaje = await personajeSerie.GetPersonajesAsync();
            var persoDto = mapper.Map<List<PersonajeDTO>>(perosonaje);
            return Ok(persoDto);
        }

    }

}

