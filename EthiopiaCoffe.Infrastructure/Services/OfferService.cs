using AutoMapper;
using EthiopiaCoffe.Domain.Concrete.Entities;
using EthiopiaCoffe.Repository.DTOs;
using EthiopiaCoffe.Repository.DTOs.Offer;
using EthiopiaCoffe.Repository.Repositories;
using EthiopiaCoffe.Repository.Services;
using EthiopiaCoffe.Repository.UnitOfWorks;
using System.Net;

namespace EthiopiaCoffe.Infrastructure.Services
{
    public class OfferService : GenericService<Offer, OfferDTO>, IOfferService
    {
        IOfferRepository _offerRepository;
        public OfferService(IMapper mapper, IGenericRepository<Offer> genericRepository, IUnitOfWork unitOfWork, IOfferRepository repository) : base(mapper, genericRepository, unitOfWork)
        {
            _offerRepository = repository;
        }

        public async Task<ResponseDTO<Guid>> AddAsync(OfferAddDTO entity)
        {
            var id = await _offerRepository.AddAsync(_mapper.Map<Offer>(entity));
            await _unitOfWork.CommitAsync();
            return ResponseDTO<Guid>.Succes(id, HttpStatusCode.Created);
        }

        public ResponseDTO<List<OfferWithCategoryDTO>> OffersWithCategory()
        {
           var mapped=_mapper.Map<List<OfferWithCategoryDTO>>(_offerRepository.OffersWithCategory());
            return ResponseDTO<List<OfferWithCategoryDTO>>.Succes(mapped);
        }

        public ResponseDTO<NoContent> Update(OfferUpdateDTO entity)
        {
            _offerRepository.Update(_mapper.Map<Offer>(entity));
            _unitOfWork.Commit();
            return ResponseDTO<NoContent>.Succes(HttpStatusCode.NoContent);
        }
    }
}
