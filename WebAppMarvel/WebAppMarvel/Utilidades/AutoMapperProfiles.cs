using AutoMapper;
using WebAppMarvel.DTOS;
using WebAppMarvel.Entidades;

namespace WebAppMarvel.Utilidades
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<MarvelApiResponse, List<SerieDTO>>()
               .ConvertUsing(src => src.Data.Results.Select(result => new SerieDTO
               {
                   Nombre = result.Name.ToString(),
                   Series = result.series.Items.Select(item => item.Name).ToList()
               }).ToList());

            CreateMap<MarvelApiResponse, SerieDTO>()
                 .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Data.Results.FirstOrDefault().Name.ToString()))
                 .ForMember(dest => dest.Series, opt => opt.MapFrom(src => src.Data.Results.FirstOrDefault().series.Items.Select(item => item.Name).ToList()));
        }
    }
}