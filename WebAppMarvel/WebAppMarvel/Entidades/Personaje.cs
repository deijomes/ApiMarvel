namespace WebAppMarvel.Entidades
{
    public class MarvelApiResponse
    {
        public int Code { get; set; }
        public string Status { get; set; }
        public string Copyright { get; set; }
        public string AttributionText { get; set; }
        public string AttributionHTML { get; set; }
        public string Etag { get; set; }
        public Data Data { get; set; }
    }

    public class Data
    {
        public int Offset { get; set; }
        public int Limit { get; set; }
        public int Total { get; set; }
        public int Count { get; set; }
        public List<Personaje> Results { get; set; }
    }

    public class Personaje
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public thumbnail Thumbnail { get; set; }
        public Series series { get; set; }

    }

    public class thumbnail
    {
        public string path { get; set; }
        public string extension { get; set; }
    }
}

    

