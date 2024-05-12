using EthiopiaCoffe.Repository.DTOs;
using EthiopiaCoffe.Repository.DTOs.Offer;

namespace EthiopiaCoffe.Repository.Services
{
    public interface IOfferService
    {
        Task<ResponseDTO<OfferDTO>> GetById(Guid id);
        Task<ResponseDTO<List<OfferDTO>>> AllAsync();
        Task<ResponseDTO<Guid>> AddAsync(OfferAddDTO entity);
        Task<ResponseDTO<NoContent>> UpdateAsync(OfferUpdateDTO entity);
        Task<ResponseDTO<NoContent>> DeleteAsync(OfferDTO entity);
        Task<ResponseDTO<NoContent>> DeleteAsync(Guid id);
        Task<ResponseDTO<List<OfferWithCategoryDTO>>> OffersWithCategory();
    }
}
