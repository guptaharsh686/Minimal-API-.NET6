using AutoMapper;
using MinimalApi.Dtos;
using MinimalApi.Models;

namespace MinimalApi.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //source->target

            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}
