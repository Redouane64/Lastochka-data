using System;

using AutoMapper;
using AutoMapper.EquivalencyExpression;

namespace Lastochka.Data
{
    public class MapperProfile : Profile
    {

        public static IMapper Singleton => new MapperConfiguration(config => {
            config.AddCollectionMappers();
            config.AddProfile<MapperProfile>();
        }).CreateMapper();

        public MapperProfile()
        {
            CreateMap<Xml.Category, Data.Category>()
                .ForMember(dest => dest.ParentId, options => options.MapFrom(s => s.ParentId == 0 ? (int?)null : s.ParentId))
                .ReverseMap();

            CreateMap<Xml.Offer, Data.Offer>()
                .ForMember(dest => dest.LastModified, options => options.MapFrom(s => DateTime.UtcNow))
                .ForMember(dest => dest.Price, options => options.MapFrom(s => s.Oldprice == 0m ? s.Price : s.Oldprice))
                .ForMember(dest => dest.Discount, options => options.MapFrom(s => CalculateDiscount(s.Price, s.Oldprice)));
        }

        private int? CalculateDiscount(decimal price, decimal oldprice)
        {
            if(oldprice == 0)
            {
                return null;
            }

            return (int?)Math.Floor(((oldprice - price) / oldprice) * 100);
        }
    }

}
