namespace WebAppMarvel.Entidades
{
    public class PersonajeSerie
    {
        public int SerieId { get; set; }
        public int PersonajeId { get; set; }
        public Series Serie { get; set; }
        public Personaje Personaje { get; set; }
    }
}
