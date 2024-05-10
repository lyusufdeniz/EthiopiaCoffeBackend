using EthiopiaCoffe.Domain.Concrete.Entities;
using EthiopiaCoffe.Repository.DTOs.Category;
using EthiopiaCoffe.Repository.DTOs;
using EthiopiaCoffe.Repository.DTOs.Offer;

namespace EthiopiaCoffe.Repository.Services
{
    public interface IOfferService:IGenericService<Offer,OfferDTO>
    {
        Task<ResponseDTO<Guid>> AddAsync(OfferAddDTO entity);
        ResponseDTO<NoContent> Update(OfferUpdateDTO entity);
        ResponseDTO<List<OfferWithCategoryDTO>> OffersWithCategory();
    }
}
