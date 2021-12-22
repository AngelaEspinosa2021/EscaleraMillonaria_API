using AutoMapper;
using EscaleraMillonaria_API.Models;
using EscaleraMillonaria_API.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CategoryDto, Category>();
                config.CreateMap<Category, CategoryDto>();
            });

            return mappingConfig;
        }
    }
}
