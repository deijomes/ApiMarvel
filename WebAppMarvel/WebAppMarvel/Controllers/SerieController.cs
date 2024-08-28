using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using WebAppMarvel.DTOS;
using WebAppMarvel.Entidades;
using WebAppMarvel.Servicios;

namespace WebAppMarvel.Controllers
{
    [Route("api/marvel")]
    [ApiController]
    public class SerieController : ControllerBase
    {
        private readonly IPersonajeSerie personajeSerie;
        private readonly IMapper mapper;

        public SerieController(IPersonajeSerie personajeSerie, IMapper mapper)
        {
            this.personajeSerie = personajeSerie;
            this.mapper = mapper;
        }

        [HttpGet("serie")]

        public async Task<ActionResult<List<SerieDTO>>> getserie()
        {
            var serie = await personajeSerie.GetPersonajesAsync();
            var serieDto = mapper.Map< List<SerieDTO>>(serie);
            return Ok(serieDto);
        }

    }
}
