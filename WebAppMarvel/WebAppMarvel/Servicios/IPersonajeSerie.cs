using System.Threading;
using WebAppMarvel.Entidades;

namespace WebAppMarvel.Servicios
{
    public interface IPersonajeSerie
    {
        Task<MarvelApiResponse> GetPersonajesAsync();

        Task<MarvelApiResponse> GetPersonajeIdAsync(int id);
        Task<MarvelApiResponse> GetPersonajeIdAsync(string id);
    }
}
