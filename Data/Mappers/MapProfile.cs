using AutoMapper;
using Data.DTOs.CarDTO;
using Data.DTOs.CategoryDTO;
using Data.DTOs.CustomerDTO;
using Data.DTOs.ExtraDTO;
using Data.DTOs.TransmissionDTO;
using Data.DTOs.UserDTO;
using Data.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mappers
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryGetDTO>();
            CreateMap<Extra, ExtraGetDTO>();
            CreateMap<Transmission, TransmissionGetDTO>();
            CreateMap<User, UserGetDTO>();

            CreateMap<Customer, CustomerGetDTO>()
                .ForMember(dest => dest.CarName, src => src.MapFrom(x => x.Car.Name));

            CreateMap<Car, CarGetDTO>()
                .ForMember(dest => dest.Category, src => src.MapFrom(x => x.Category.Name))
                .ForMember(dest => dest.Transmission, src => src.MapFrom(x => x.Transmission.Type));
                
        }
    }
}
