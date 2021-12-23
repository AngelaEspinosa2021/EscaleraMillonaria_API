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
                config.CreateMap<QuestionDto, Question>();
                config.CreateMap<Question, QuestionDto>();
                config.CreateMap<Award, AwardDto>();
                config.CreateMap<AwardDto, Award>();
            });

            return mappingConfig;
        }

    }
}
