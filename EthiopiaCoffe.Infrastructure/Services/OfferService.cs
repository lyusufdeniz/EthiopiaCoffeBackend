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
    public class OfferService(IOfferRepository _offerRepository,IMapper _mapper,IUnitOfWork _unitOfWork) : IOfferService
    {
        public async Task<ResponseDTO<OfferDTO>> GetById(Guid id)
        {
            var entity = await _offerRepository.GetByIdAsync(id);
            if (entity is null)
            {
                ResponseDTO<NoContent>.Fail($"Offer Not Found", HttpStatusCode.NotFound);
            }
            var mapped = _mapper.Map<OfferDTO>(entity);
            return ResponseDTO<OfferDTO>.Succes(mapped, HttpStatusCode.OK);
        }
        public async Task<ResponseDTO<Guid>> AddAsync(OfferAddDTO entity)
        {
            var id = await _offerRepository.AddAsync(_mapper.Map<Offer>(entity));
            await _unitOfWork.CommitAsync();
            return ResponseDTO<Guid>.Succes(id, HttpStatusCode.Created);
        }

        public async Task<ResponseDTO<List<OfferDTO>>> AllAsync()
        {
            var mapped = _mapper.Map<List<OfferDTO>>(await _offerRepository.All());
            return ResponseDTO<List<OfferDTO>>.Succes(mapped, HttpStatusCode.OK);
        }


        public async Task<ResponseDTO<NoContent>> DeleteAsync(OfferDTO entity)
        {
            if (_offerRepository.GetByIdAsync(entity.Id) is null)
            {
                ResponseDTO<NoContent>.Fail($"Offer Not Found", HttpStatusCode.NotFound);
            }

            await _offerRepository.Delete(_mapper.Map<Offer>(entity));
            await _unitOfWork.CommitAsync();
            return ResponseDTO<NoContent>.Succes(HttpStatusCode.NoContent);
        }

        public async Task<ResponseDTO<NoContent>> DeleteAsync(Guid id)
        {
            var entity = _offerRepository.GetByIdAsync(id);
            if (entity is null)
            {
                ResponseDTO<NoContent>.Fail($"Offer Not Found", HttpStatusCode.NotFound);
            }

            await _offerRepository.Delete(_mapper.Map<Offer>(entity));
            await _unitOfWork.CommitAsync();
            return ResponseDTO<NoContent>.Succes(HttpStatusCode.NoContent);
        }


        public async Task<ResponseDTO<NoContent>> UpdateAsync(OfferUpdateDTO entity)
        {
            var mapped = _mapper.Map<Offer>(entity);
            await _offerRepository.Update(mapped);
            await _unitOfWork.CommitAsync();
            return ResponseDTO<NoContent>.Succes(HttpStatusCode.NoContent);
        }

        public async Task<ResponseDTO<List<OfferWithCategoryDTO>>> OffersWithCategory()
        {
            var mapped = _mapper.Map<List<OfferWithCategoryDTO>>(await _offerRepository.OffersWithCategory());
            return ResponseDTO<List<OfferWithCategoryDTO>>.Succes(mapped, HttpStatusCode.OK);
        }
    }
}
