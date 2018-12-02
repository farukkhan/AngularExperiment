using AngularAspNetCore.Entities;
using AngularAspNetCore.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAspNetCore.MappingProfiles
{
    public class WeatherForCastProfile : Profile
    {
        public WeatherForCastProfile()
        {
            CreateMap<WeatherForeCast, WeatherForecastForClient>().ForMember(dest => dest.TemperatureC, opt => opt.MapFrom(src=> $"{src.TemperatureC}C"))
                .ForMember(dest => dest.TemperatureF, opt => opt.MapFrom(src => $"{src.TemperatureF}F"));
        }
    }
}
