using CulturaWeb.Api.ViewModels;
using AutoMapper;
using CulturaWeb.Domain.Entity;

namespace CulturaWeb.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public MapperConfiguration Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<LivroViewModel, Livro>().ReverseMap();
                cfg.CreateMap<GeneroViewModel, Genero>().ReverseMap();
                cfg.CreateMap<EditoraViewModel, Editora>().ReverseMap();
                cfg.CreateMap<EnderecoViewModel, Endereco>().ReverseMap();
                cfg.CreateMap<CidadeViewModel, Cidade>().ReverseMap();
                cfg.CreateMap<EstadoViewModel, Estado>().ReverseMap();

            });

            return config;
        }
    }
}
