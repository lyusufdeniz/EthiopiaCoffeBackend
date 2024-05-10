using AutoMapper;
using EthiopiaCoffe.Domain.Concrete.Entities;
using EthiopiaCoffe.Repository.DTOs.Offer;

namespace EthiopiaCoffe.Infrastructure.Mapping
{
    public class OfferObjectMap:Profile
    {
        public OfferObjectMap()
        {
            CreateMap<Offer, OfferDTO>().ReverseMap();
            CreateMap<Offer, OfferAddDTO>().ReverseMap();
            CreateMap<Offer, OfferUpdateDTO>().ReverseMap();
            CreateMap<Offer, OfferWithCategoryDTO>().ReverseMap();
        }
    }
}
