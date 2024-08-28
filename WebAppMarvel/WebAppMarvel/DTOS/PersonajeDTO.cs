using WebAppMarvel.Entidades;

namespace WebAppMarvel.DTOS
{
    public class PersonajeDTO
    {
        public string Nombre { get; set; }
        public string Description { get; set; }
        public thumbnail Thumbnail { get; set; }
    }
}
