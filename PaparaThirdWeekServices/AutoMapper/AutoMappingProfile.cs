using AutoMapper;
using PaparaThirdWeek.Domain.Entities;
using PaparaThirdWeek.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaThirdWeek.Services.AutoMapper
{
   
        public class AutoMappingProfile : Profile 
        { 
            public AutoMappingProfile()
            {
                CreateMap<Company, CompanyDto>().ReverseMap(); 
            }

        }
    
}
