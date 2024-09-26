using AutoMapper;
using Habesha.Services.ProductAPI.Models;
using Habesha.Services.ProductAPI.Models.Dto;

namespace Habesha.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
