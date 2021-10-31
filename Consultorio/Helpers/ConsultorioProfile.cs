using AutoMapper;
using Consultorio.Models.Dtos;
using Consultorio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Helpers
{
    public class ConsultorioProfile : Profile
    {
        public ConsultorioProfile()
        {
            CreateMap<Paciente, PacienteDetalhesDto>().ReverseMap();
            CreateMap<ConsultaDto, Consulta>()
                .ForMember(dest => dest.Profissional, opt => opt.Ignore())
                .ForMember(dest => dest.Especialidade, opt => opt.Ignore());

            CreateMap<Consulta, ConsultaDto>()
                .ForMember(dest => dest.Especialidade, opt => opt.MapFrom(src => src.Especialidade.Nome))
                .ForMember(dest => dest.Profissional, opt => opt.MapFrom(src => src.Profissional.Nome));

            CreateMap<PacienteAdicionarDto, Paciente>();
            CreateMap<PacienteAtualizarDto, Paciente>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
