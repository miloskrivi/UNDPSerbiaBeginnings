using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using UNDPSerbia.Models;
using UNDPSerbia.Dtos;

namespace UNDPSerbia.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Employee, EmployeeDto>();
            Mapper.CreateMap<EmployeeDto, Employee>();
        }
    }
}