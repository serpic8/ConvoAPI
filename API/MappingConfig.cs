using API.Models;
using API.Models.Dto;
using AutoMapper;

namespace API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Clase1, Clase1Dto>();
            CreateMap<Clase1Dto, Clase1>();

            CreateMap<Clase1, Clase1CreateDto>().ReverseMap();
            CreateMap<Clase1, Clase1UpdateDto>().ReverseMap();

            CreateMap<Clase2, Clase2Dto>();
            CreateMap<Clase2Dto, Clase2>();

            CreateMap<Clase2, Clase2CreateDto>().ReverseMap();
            CreateMap<Clase2, Clase2UpdateDto>().ReverseMap();

            CreateMap<Clase3, Clase3Dto>();
            CreateMap<Clase3Dto, Clase3>();

            CreateMap<Clase3, Clase3CreateDto>().ReverseMap();
            CreateMap<Clase3, Clase3UpdateDto>().ReverseMap();

            CreateMap<Clase4, Clase4Dto>();
            CreateMap<Clase4Dto, Clase4>();

            CreateMap<Clase4, Clase4CreateDto>().ReverseMap();
            CreateMap<Clase4, Clase4UpdateDto>().ReverseMap();
        }

    }
}
