using AutoMapper;
using Habesha.Services.CouponAPI.Models;
using Habesha.Services.CouponAPI.Models.Dto;

namespace Habesha.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
