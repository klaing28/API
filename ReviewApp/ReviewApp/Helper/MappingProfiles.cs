using AutoMapper;
using ReviewApp.Model;
using ReviewApp.DTO;


namespace ReviewApp.Helper
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();

        }
    }
}
