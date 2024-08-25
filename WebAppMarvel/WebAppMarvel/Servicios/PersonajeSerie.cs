using Microsoft.AspNetCore.Http.HttpResults;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using WebAppMarvel.Entidades;

namespace WebAppMarvel.Servicios
{
    public class PersonajeSerie : IPersonajeSerie
    {
        private readonly IConfiguration configuration;
        private readonly HttpClient httpClient;
        private readonly string _url;
        private readonly string _crede;

        public PersonajeSerie( IConfiguration configuration, HttpClient httpClient)
        {
            this.configuration = configuration;
            this.httpClient = httpClient;
            _url = configuration["MyApi:Url"];
            _crede = configuration["credencial:token"];
        }

        public async Task<MarvelApiResponse> GetPersonajeIdAsync(int id)
        {
            string endpoint = $"characters/{id}";
            var response = await httpClient.GetAsync($"{_url}{endpoint}{_crede}");
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<MarvelApiResponse>(responseContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public async Task<MarvelApiResponse> GetPersonajesAsync()
        {
            string endpoint = "characters";
            var response = await httpClient.GetAsync($"{ _url}{endpoint}{ _crede}");
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<MarvelApiResponse>(responseContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

           
           
        }
    }
}
